-- CHÍNH SÁCH 1--
create or replace view uv_NhanVienCoBan_NHANSU
as 
    select * 
    from NHANSU 
    where MANV = sys_context('userenv', 'session_user')
    with check option;

create or replace view uv_NhanVienCoBan_SINHVIEN
as
    select *
    from SINHVIEN
    with check option;
    
create or replace view uv_NhanVienCoBan_DONVI
as
    select *
    from DONVI
    with check option;
    
create or replace view uv_NhanVienCoBan_HOCPHAN
as
    select *
    from HOCPHAN
    with check option;
    
create or replace view uv_NhanVienCoBan_KHMO
as
    select MAHP as "MA HOC PHAN", HK as "HOC KY", NAM, MACT as "MA CHUONG TRINH"
    from KHMO
    with check option;
    
grant select, update(DT) on uv_NhanVienCoBan_NHANSU to rl_NhanVienCoBan;
grant select on uv_NhanVienCoBan_SINHVIEN to rl_NhanVienCoBan;
grant select on uv_NhanVienCoBan_DONVI to rl_NhanVienCoBan;
grant select on uv_NhanVienCoBan_HOCPHAN to rl_NhanVienCoBan;
grant select on uv_NhanVienCoBan_KHMO to rl_NhanVienCoBan;



-- CHÍNH SÁCH 2--
grant rl_NhanVienCoBan to rl_GiangVien;

create or replace view uv_GiangVien_PHANCONG
as
    select MAGV, MAHP, HK, NAM, MACT
    from PHANCONG
    where MAGV = sys_context('userenv', 'session_user');
    
create or replace view uv_GiangVien_DANGKY
as
    select DK.*
    from DANGKY DK, PHANCONG PC
    where PC.MAGV = DK.MAGV 
    and PC.MAHP = DK.MAHP
    and DK.HK = PC.HK
    and DK.NAM = PC.NAM
    and DK.MACT = PC.MACT
    and PC.MAGV = sys_context('userenv', 'session_user')
    with check option;
    
create or replace trigger utrig_GiangVien_DANGKY
instead of insert or update on uv_GiangVien_DANGKY
for each row
begin
    if (updating) then
        update DANGKY 
        set DIEMTH = NVL(:new.DIEMTH, :old.DIEMTH),
            DIEMQT = NVL(:new.DIEMQT, :old.DIEMQT),
            DIEMCK = NVL(:new.DIEMCK, :old.DIEMCK),
            DIEMTK = NVL(:new.DIEMTK, :old.DIEMTK)
        where MASV = :old.MASV and MAGV = :old.MAGV and MACT = :old.MACT and NAM = :old.NAM and HK = :old.HK and MAHP = :old.MAHP;
    end if;    
end;
/

grant select on uv_GiangVien_PHANCONG to rl_GiangVien;
grant select, update(DIEMTH, DIEMQT, DIEMCK, DIEMTK) on uv_GiangVien_DANGKY to rl_GiangVien;

-- CHÍNH SÁCH 3--
create or replace trigger utrig_GiaoVu_KHMO
instead of insert or update on uv_NhanVienCoBan_KHMO
for each row 
begin
    if (inserting) then
        insert into KHMO values (:new."MA HOC PHAN", :new."HOC KY", :new.NAM, :new."MA CHUONG TRINH");
    elsif (updating) then
        update KHMO set 
        MAHP = :new."MA HOC PHAN",
        HK = :new."HOC KY",
        NAM = :new.NAM,
        MACT = :new."MA CHUONG TRINH"
        where MAHP = :old."MA HOC PHAN"
        and HK = :old."HOC KY"
        and NAM = :old.NAM
        and MACT = :old."MA CHUONG TRINH";
    end if;
end;
/

grant rl_NhanVienCoBan to rl_GiaoVu;
grant insert, update on uv_NhanVienCoBan_SINHVIEN to rl_GiaoVu;
grant insert, update on uv_NhanVienCoBan_DONVI to rl_GiaoVu;
grant insert, update on uv_NhanVienCoBan_HOCPHAN to rl_GiaoVu;
grant insert, update on uv_NhanVienCoBan_KHMO to rl_GiaoVu;

create or replace view uv_GiaoVu_PHANCONG
as
    select *
    from PHANCONG
    with check option;
    
create or replace trigger utrig_GiaoVu_PHANCONG
instead of update on uv_GiaoVu_PHANCONG
for each row
declare
    v_count number;
begin
    select count(*) into v_count
    from HOCPHAN HP, DONVI DV
    where :old.MAHP = HP.MAHP
    and HP.MADV = DV.MADV
    and DV.TENDV = N'Văn phòng khoa';
    
    if (v_count > 0) then
        update PHANCONG 
        set MAGV = :new.MAGV,
            MAHP = :new.MAHP,
            HK = :new.HK,
            NAM = :new.NAM,
            MACT = :new.MACT
        where MAGV = :old.MAGV
        and MAHP = :old.MAHP
        and HK = :old.HK
        and NAM = :old.NAM
        and MACT = :old.MACT; 
    end if;
end;
/

create or replace view uv_GiaoVu_DANGKY
as
    select *
    from DANGKY
    with check option;
    
create or replace trigger utrig_GiaoVu_DANGKY
instead of insert or delete on uv_GiaoVu_DANGKY
for each row
declare 
    v_start_date date;
    v_end_date date;
begin
    if (:new.HK = 1) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 0), 'MM');
    elsif (:new.HK = 2) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 4), 'MM');
    elsif (:new.HK = 3) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 8), 'MM');
    end if;

    if (:old.HK = 1) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 0), 'MM');
    elsif (:old.HK = 2) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 4), 'MM');
    elsif (:old.HK = 3) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 8), 'MM');
    end if;

    v_end_date := v_start_date + interval '14' day;

    if (trunc(sysdate) between v_start_date and v_end_date) then
        if (inserting) then
            insert into DANGKY values (:new.MASV, :new.MAGV, :new.MAHP, :new.HK, :new.NAM, :new.MACT, :new.DIEMTH, :new.DIEMQT, :new.DIEMCK, :new.DIEMTK);
        elsif (deleting) then
            delete from DANGKY 
            where MASV = :old.MASV 
            and MAGV = :old.MAGV 
            and MAHP = :old.MAHP 
            and HK = :old.HK 
            and NAM = :old.NAM 
            and MACT = :old.MACT;
        end if;
    end if;
end;
/


grant select, update on uv_GiaoVu_PHANCONG to rl_GiaoVu;
grant select, insert, delete on uv_GiaoVu_DANGKY to rl_GiaoVu;


--CS4--

grant rl_GiangVien to rl_TruongDonVi;

create or replace view uv_TruongDonVi_NHANSU
as
    select ns.MANV 
    from NHANSU ns, DONVI dv
    where ns.MADV = dv.MADV 
    and DV.TRGDV = sys_context('userenv', 'session_user')
/

create or replace view uv_TruongDonVi_DONVI
as
    select DV.*, NS.HOTEN
    from DONVI DV, NHANSU NS
    where DV.TRGDV = NS.MANV
/

create or replace view uv_TruongDonVi_KHMO
as
    select KH.*
    from KHMO KH, HOCPHAN HP, DONVI DV
    where KH.MAHP = HP.MAHP
    and HP.MADV = DV.MADV 
    and DV.TRGDV = sys_context('userenv', 'session_user')
/

create or replace view uv_TruongDonVi_PHANCONG_2
as
    select PC.*
    from PHANCONG PC, NHANSU NS, DONVI DV
    where PC.MAGV = NS.MANV
    and NS.MADV = DV.MADV
    and DV.TRGDV = sys_context('userenv', 'session_user')
/

create or replace view uv_TruongDonVi_PHANCONG_1          
as
    select PC.*
    from PHANCONG PC, HOCPHAN HP, DONVI DV
    where PC.MAHP = HP.MAHP
    and HP.MADV = DV.MADV
    and DV.TRGDV = sys_context('userenv', 'session_user')
    with check option;
       
create or replace trigger utrig_TruongDonVi_PHANCONG
instead of insert or update or delete on uv_TruongDonVi_PHANCONG_1
for each row
declare
    v_count number;
begin
    select count(*) into v_count
    from HOCPHAN HP, DONVI DV
    where :new.MAHP = HP.MAHP
    and HP.MADV = DV.MADV
    and DV.TRGDV = sys_context('userenv', 'session_user');

    if (deleting) then
        delete from PHANCONG 
        where MAGV = :old.MAGV 
        and MAHP = :old.MAHP
        and HK = :old.HK
        and NAM = :old.NAM
        and MACT = :old.MACT;
    elsif (v_count > 0) then
        if (inserting) then
            insert into PHANCONG values (:new.MAGV, :new.MAHP, :new.HK, :new.NAM, :new.MACT);
        elsif (updating) then
            update PHANCONG 
            set MAGV = :new.MAGV,
                MAHP = :new.MAHP,
                HK = :new.HK,
                NAM = :new.NAM,
                MACT = :new.MACT
            where MAGV = :old.MAGV 
            and MAHP = :old.MAHP
            and HK = :old.HK
            and NAM = :old.NAM
            and MACT = :old.MACT;
        end if;
    end if;
end;
/

grant select on uv_TruongDonVi_NHANSU to rl_TruongDonVi;
grant select on uv_TruongDonVi_DONVI to rl_TruongDonVi;
grant select on uv_TruongDonVi_KHMO to rl_TruongDonVi;
grant select on uv_TruongDonVi_PHANCONG_2 to rl_TruongDonVi;
grant select, insert, update, delete on uv_TruongDonVi_PHANCONG_1 to rl_TruongDonVi;

--CS5--

grant rl_GiangVien to rl_TruongKhoa;

create or replace view uv_TruongKhoa_PHANCONG
as
    select *
    from PHANCONG
    with check option;
    
create or replace trigger utrig_TruongKhoa_PHANCONG
instead of insert or update or delete on uv_TruongKhoa_PHANCONG
for each row
declare
    v_count number;
begin
    select count(*)into v_count
    from HOCPHAN HP, DONVI DV
    where :new.MAHP = HP.MAHP
    and HP.MADV = DV.MADV
    and DV.TENDV = N'Văn phòng khoa';
    if (deleting) then
        delete from PHANCONG 
        where MAGV = :old.MAGV 
        and MAHP = :old.MAHP
        and HK = :old.HK
        and NAM = :old.NAM
        and MACT = :old.MACT;
    end if;
    if (v_count > 0) then
        if (inserting) then
            insert into PHANCONG values (:new.MAGV, :new.MAHP, :new.HK, :new.NAM, :new.MACT);
        elsif (updating) then
            update PHANCONG 
            set MAGV = :new.MAGV,
                MAHP = :new.MAHP,
                HK = :new.HK,
                NAM = :new.NAM,
                MACT = :new.MACT
            where MAGV = :old.MAGV 
            and MAHP = :old.MAHP
            and HK = :old.HK
            and NAM = :old.NAM
            and MACT = :old.MACT;
            end if;
    end if;
end;
/

create or replace view uv_TruongKhoa_NHANSU
as
    select * 
    from NHANSU
    with check option;

grant select, insert, update, delete on uv_TruongKhoa_PHANCONG to rl_TruongKhoa;
grant select, insert, update, delete on uv_TruongKhoa_NHANSU to rl_TruongKhoa;
grant select on uv_GiaoVu_DANGKY to rl_TruongKhoa;

--CS6--
create or replace function pc1_SinhVien_SINHVIEN
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    usr varchar2(10) := sys_context('userenv', 'session_user');
    cursor cur is (
        select granted_role
        from DBA_ROLE_PRIVS
        where grantee = usr
    );
    usrrole varchar2(100);
    type role_tab is table of varchar2(100);
    roles role_tab := role_tab();
begin
    if (sys_context('userenv', 'session_user') = 'OLS_ADMIN') then
        return '';
    end if;    

    open cur;
    loop
        fetch cur into usrrole;
        exit when cur%notfound;
        
        roles.extend;
        roles(roles.count) := usrrole;
    end loop;
    close cur;
    
    if 'RL_SINHVIEN' member of roles then
        return 'MASV = ''' || usr || '''';
    else 
        return '';
    end if;    
end;
/

begin
    dbms_rls.add_policy(
        object_schema => 'OLS_ADMIN',
        object_name => 'SINHVIEN',
        policy_name => 'pc1',
        function_schema => 'OLS_ADMIN',
        policy_function => 'pc1_SinhVien_SINHVIEN',
        statement_types => 'select, update',
        update_check => true
    );
end;
/

grant select, update(DCHI, DT) on SINHVIEN to rl_SinhVien;

create or replace function pc2_SinhVien_KHMO
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    cursor cur1 is (
        select granted_role
        from DBA_ROLE_PRIVS
        where grantee = sys_context('userenv', 'session_user')
    );
    cursor cur2 is (
        select MACT
        from SINHVIEN
    );
    v_mact varchar2(10);
    type role_tab is table of varchar2(100);
    roles role_tab := role_tab();
begin
    if (sys_context('userenv', 'session_user') = 'OLS_ADMIN') then
        return '';
    end if; 

    for res in cur1 loop
        roles.extend;
        roles(roles.count) := res.granted_role;
    end loop;
    
    if 'RL_SINHVIEN' member of roles then
        open cur2;
        fetch cur2 into v_mact;
        close cur2;
        return 'MACT = ' || '''' || v_mact || '''';   
    else 
        return '';
    end if;   
end;
/

begin
    dbms_rls.add_policy(
        object_schema => 'OLS_ADMIN',
        object_name => 'KHMO',
        policy_name => 'pc2',
        function_schema => 'OLS_ADMIN',
        policy_function => 'pc2_SinhVien_KHMO',
        statement_types => 'select'
    );
end;
/

grant select on KHMO to rl_SinhVien;

create or replace function pc3_SinhVien_DANGKY
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    usr varchar2(10);
    v_hk number;
    v_start_date date;
    v_end_date date;
    v_end_date date;
    strsql varchar2(1000);
begin
    if (sys_context('userenv', 'session_user') = 'OLS_ADMIN') then
        return '';
    end if;

    usr := sys_context('userenv', 'session_user');

    if (extract(month from sysdate) between 1 and 4) then
        v_hk := 1;
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 0), 'MM');
    elsif (extract(month from sysdate) between 5 and 8) then
        v_hk := 2;
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 4), 'MM');
    else
        v_hk := 3;
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 8), 'MM');
    end if;
    
    v_end_date := v_start_date + interval '14' day;

    if usr like 'SV%' then
    strsql := 'MASV = ''' || usr || ''' and HK = ' || v_hk || ' 
    and NAM = ' || extract(year from sysdate) || ' 
    and DIEMTH is null 
    and DIEMQT is null 
    and DIEMCK is null 
    and DIEMTK is null
    and trunc(sysdate) between ''' || v_start_date || ''' and ''' || v_end_date || '''';
    elsif usr like 'GIAOVU%' then
    strsql := '';
    end if;
    return strsql;
end;
/

begin
    dbms_rls.add_policy(
        object_schema => 'OLS_ADMIN',
        object_name => 'DANGKY',
        policy_name => 'pc3',
        function_schema => 'OLS_ADMIN',
        policy_function => 'pc3_SinhVien_DANGKY',
        statement_types => 'insert, delete',
        update_check => true
    );
end;
/

grant insert, delete on DANGKY to rl_SinhVien;

create or replace function pc4_SinhVien_DANGKY
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    usr varchar2(10) := sys_context('userenv', 'session_user');
begin
    if (sys_context('userenv', 'session_user') = 'OLS_ADMIN') then
        return '';
    end if;

    if (usr like 'SV%') then
        return 'MASV = ''' || usr || '''';
    else 
        return '';
    end if;    
end;
/

begin
    dbms_rls.add_policy(
        object_schema => 'OLS_ADMIN',
        object_name => 'DANGKY',
        policy_name => 'pc4',
        function_schema => 'OLS_ADMIN',
        policy_function => 'pc4_SinhVien_DANGKY',
        statement_types => 'select, update',
        update_check => true
    );
end;
/

grant select on DANGKY to rl_SinhVien;

create or replace function pc5_SinhVien_HOCPHAN
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    cursor cur1 is (
        select granted_role
        from DBA_ROLE_PRIVS
        where grantee = sys_context('userenv', 'session_user')
    );
    cursor cur2 is (
        select MACT
        from SINHVIEN
    );
    v_mact varchar2(10);
    type role_tab is table of varchar2(100);
    roles role_tab := role_tab();
begin
    if (sys_context('userenv', 'session_user') = 'OLS_ADMIN') then
        return '';
    end if; 

    for res in cur1 loop
        roles.extend;
        roles(roles.count) := res.granted_role;
    end loop;
    
    if 'RL_SINHVIEN' member of roles then
        open cur2;
        fetch cur2 into v_mact;
        close cur2;
        return 'MAHP IN (SELECT MAHP FROM KHMO WHERE MACT = ''' || v_mact || ''')';   
    else 
        return '';
    end if;   
end;
/

begin
    dbms_rls.add_policy(
        object_schema => 'OLS_ADMIN',
        object_name => 'HOCPHAN',
        policy_name => 'pc5',
        function_schema => 'OLS_ADMIN',
        policy_function => 'pc5_SinhVien_HOCPHAN',
        statement_types => 'select',
        update_check => true
    );
end;
/

grant select on HOCPHAN to rl_SinhVien;