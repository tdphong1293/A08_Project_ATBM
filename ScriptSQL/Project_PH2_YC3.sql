
-- ============== STANDARD AUDIT ============== --
-- Cài Standard Audit cho nhân viên
create or replace procedure sp_Create_Audit_UserNV
authid current_user
as
    cursor cur is (
        select MANV
        from NHANSU
        where MANV in (select username from all_users)
    );
    strsql varchar2(1000);
    usr varchar2(100);
begin
    open cur;
    loop
        fetch cur into usr;
        exit when cur%notfound;
        
        strsql := 'GRANT UNLIMITED TABLESPACE TO ' || usr;
        execute immediate (strsql);
        
        strsql := 'AUDIT ALL BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'AUDIT SELECT TABLE, UPDATE TABLE, INSERT TABLE, DELETE TABLE BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'AUDIT SESSION WHENEVER NOT SUCCESSFUL';
        execute immediate (strsql);

    end loop;
    close cur;
end;
/

-- Cài Standard Audit cho sinh viên
create or replace procedure sp_Create_Audit_UserSV
authid current_user
as
    cursor cur is (
        select MASV
        from SINHVIEN
        where MASV in (select username from all_users)
    );
    strsql varchar2(1000);
    usr varchar2(100);
begin
    open cur;
    loop
        fetch cur into usr;
        exit when cur%notfound;
        
        strsql := 'GRANT UNLIMITED TABLESPACE TO ' || usr;
        execute immediate (strsql);
        
        strsql := 'AUDIT ALL BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'AUDIT SELECT TABLE, UPDATE TABLE, INSERT TABLE, DELETE TABLE BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'AUDIT SESSION WHENEVER NOT SUCCESSFUL';
        execute immediate (strsql);

    end loop;
    close cur;
end;
/

exec sp_Create_Audit_UserNV;
exec sp_Create_Audit_UserSV;


SELECT *
FROM DBA_AUDIT_TRAIL
ORDER BY TIMESTAMP desc;


alter session set "_ORACLE_SCRIPT" = true;
alter session set "_optimizer_filter_pred_pullup" = false; 

create or replace function f_CheckRoleGiangVien 
return number 
as
    UserRole nvarchar2(30);
begin
    if (sys_context('USERENV', 'SESSION_USER') = 'OLS_ADMIN' ) then 
        return 0;
    end if;

    select granted_role
    from dba_role_privs
    where grantee = 'TRGDV0001';

    if ( UserRole = 'rl_GiangVien' ) then
        return 1; 
    else
        return 0;
    end if;
end;
/

begin
    dbms_fga.add_policy(
        object_schema   => 'OLS_ADMIN',
        object_name     => 'DANGKY',
        policy_name     => 'FGA_POLICY_DIEM',
        audit_condition => '(f_CheckRoleGiangVien = 0)',
        audit_column    => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK',
        statement_types => 'INSERT,UPDATE,DELETE'
    );
end;
/

begin
    dbms_fga.enable_policy(
        object_schema => 'OLS_ADMIN',
        object_name   => 'DANGKY',
        policy_name   => 'FGA_POLICY_DIEM',
        enable        => true
    );
end;
/

select * 
from DBA_FGA_AUDIT_TRAIL 
ORDER BY TIMESTAMP desc;



--SELECT * FROM AUDITABLE_SYSTEM_ACTIONS;


