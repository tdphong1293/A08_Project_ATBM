-- ============== STANDARD AUDIT ============== --
-- Kích Standard Audit cho nhân viên
create or replace procedure sp_Enable_Audit_UserNV
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

-- Kích hoạt Standard Audit cho sinh viên
create or replace procedure sp_Enable_Audit_UserSV
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

-- Tắt Standard Audit cho nhân viên
create or replace procedure sp_Disable_Audit_UserNV
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
        
        strsql := 'NOAUDIT ALL BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'NOAUDIT SELECT TABLE, UPDATE TABLE, INSERT TABLE, DELETE TABLE BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'NOAUDIT SESSION WHENEVER NOT SUCCESSFUL';
        execute immediate (strsql);

    end loop;
    close cur;
end;
/

-- Tắt Standard Audit cho sinh viên
create or replace procedure sp_Disable_Audit_UserSV
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
        
        strsql := 'NOAUDIT ALL BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'NOAUDIT SELECT TABLE, UPDATE TABLE, INSERT TABLE, DELETE TABLE BY ' || usr || ' BY ACCESS';
        execute immediate (strsql);

        strsql := 'NOAUDIT SESSION WHENEVER NOT SUCCESSFUL';
        execute immediate (strsql);

    end loop;
    close cur;
end;
/

exec sp_Enable_Audit_UserNV;
exec sp_Enable_Audit_UserSV;

exec sp_Disable_Audit_UserNV;
exec sp_Disable_Audit_UserSV;


SELECT *
FROM DBA_AUDIT_TRAIL where username = 'TRGDV0001' and OWNER = 'OLS_ADMIN' AND (ACTION_NAME IN ('SELECT', 'INSERT', 'UPDATE', 'DELETE'))
ORDER BY TIMESTAMP desc;




-- =============== FINE-GRAINED AUDIT ===============

-- 3a) Hành vi Cập nhật quan hệ ĐANGKY tại các trường liên quan đến điểm số
--     nhưng người đó không thuộc vai trò Giảng viên
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

    select granted_role into UserRole
    from dba_role_privs
    where grantee = sys_context('USERENV', 'SESSION_USER');

    if ( UserRole = 'RL_GIANGVIEN' ) then
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

-- 3b) Hành vi của người dùng này có thể đọc trên trường PHUCAP của người khác ở quan hệ NHANSU
begin
    dbms_fga.add_policy(
        object_schema   => 'OLS_ADMIN',
        object_name     => 'NHANSU',
        policy_name     => 'FGA_POLICY_PHUCAP',
        audit_condition => 'MANV <> sys_context(''USERENV'', ''SESSION_USER'')',
        audit_column    => 'PHUCAP',
        statement_types => 'SELECT'
    );
end;
/

begin
    dbms_fga.enable_policy(
        object_schema => 'OLS_ADMIN',
        object_name   => 'NHANSU',
        policy_name   => 'FGA_POLICY_PHUCAP',
        enable        => true
    );
end;
/


select * 
from DBA_FGA_AUDIT_TRAIL 
ORDER BY TIMESTAMP desc;



--SELECT * FROM AUDITABLE_SYSTEM_ACTIONS;

select USERNAME, OWNER, OBJ_NAME, ACTION, ACTION_NAME, TO_CHAR(EXTENDED_TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') from DBA_AUDIT_TRAIL;
-- ======== LỆNH XÓA LỊCH SỬ AUDIT ========
-- TRUNCATE table sys.Aud$;
-- TRUNCATE table sys.FGA_LOG$;
