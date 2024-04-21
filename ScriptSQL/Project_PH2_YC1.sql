--CS1--
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
    select *
    from KHMO
    with check option;
    
grant select, update(DT) on uv_NhanVienCoBan_NHANSU to NhanVienCoBan;
grant select on uv_NhanVienCoBan_SINHVIEN to NhanVienCoBan;
grant select on uv_NhanVienCoBan_DONVI to NhanVienCoBan;
grant select on uv_NhanVienCoBan_HOCPHAN to NhanVienCoBan;
grant select on uv_NhanVienCoBan_KHMO to NhanVienCoBan;

--CS2--
--grant select, update(DT) on uv_NhanVienCoBan_NHANSU to GiangVien;
--grant select on uv_NhanVienCoBan_SINHVIEN to GiangVien;
--grant select on uv_NhanVienCoBan_DONVI to GiangVien;
--grant select on uv_NhanVienCoBan_HOCPHAN to GiangVien;
--grant select on uv_NhanVienCoBan_KHMO to GiangVien;

grant NhanVienCoBan to GiangVien;

create or replace view uv_GiangVien_PHANCONG
as
    select *
    from PHANCONG
    where MAGV = sys_context('userenv', 'session_user');
    
create or replace view uv_GiangVien_DANGKY
as
    select DK.*
    from DANGKY DK, PHANCONG PC
    where PC.MAGV = DK.MAGV 
    and PC.MAHP = DK.MAHP
    and PC.MAGV = sys_context('userenv', 'session_user')
    with check option;
    
create or replace trigger utrig_GiangVien_DANGKY
instead of update on uv_GiangVien_DANGKY
for each row
begin
    update DANGKY 
    set DIEMTH = NVL(:new.DIEMTH, :old.DIEMTH),
        DIEMQT = NVL(:new.DIEMQT, :old.DIEMQT),
        DIEMCK = NVL(:new.DIEMCK, :old.DIEMCK),
        DIEMTK = NVL(:new.DIEMTK, :old.DIEMTK)
    where MASV = :old.MASV and MAGV = :old.MAGV;
end;
/

grant select on uv_GiangVien_PHANCONG to GiangVien;
grant select, update(DIEMTH, DIEMQT, DIEMCK, DIEMTK) on uv_GiangVien_DANGKY to GiangVien;

--CS3--
--grant select, update(DT) on uv_NhanVienCoBan_NHANSU to GiaoVu;
--grant select, insert, update on uv_NhanVienCoBan_SINHVIEN to GiaoVu;
--grant select, insert, update on uv_NhanVienCoBan_DONVI to GiaoVu;
--grant select, insert, update on uv_NhanVienCoBan_HOCPHAN to GiaoVu;
--grant select, insert, update on uv_NhanVienCoBan_KHMO to GiaoVu;

grant NhanVienCoBan to GiaoVu;
grant insert, update on uv_NhanVienCoBan_SINHVIEN to GiaoVu;
grant insert, update on uv_NhanVienCoBan_DONVI to GiaoVu;
grant insert, update on uv_NhanVienCoBan_HOCPHAN to GiaoVu;
grant insert, update on uv_NhanVienCoBan_KHMO to GiaoVu;

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
begin
    if (:new.HK = 1) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 0), 'MM');
    elsif (:new.HK = 2) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 4), 'MM');
    elsif (:new.HK = 3) then
        v_start_date := trunc(add_months(trunc(sysdate, 'YYYY'), 8), 'MM');
    end if;
    
    if (trunc(sysdate) between v_start_date and v_start_date + interval '14' day) then
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

grant select, update on uv_GiaoVu_PHANCONG to GiaoVu;
grant insert, delete on uv_GiaoVu_DANGKY to GiaoVu;

--CS4--
--grant select, update(DT) on uv_NhanVienCoBan_NHANSU to TruongDonVi;
--grant select on uv_NhanVienCoBan_SINHVIEN to TruongDonVi;
--grant select on uv_NhanVienCoBan_DONVI to TruongDonVi;
--grant select on uv_NhanVienCoBan_HOCPHAN to TruongDonVi;
--grant select on uv_NhanVienCoBan_KHMO to TruongDonVi;
--grant select on uv_GiangVien_PHANCONG to TruongDonVi;
--grant select, update(DIEMTH, DIEMQT, DIEMCK, DIEMTK) on uv_GiangVien_DANGKY to TruongDonVi;

grant GiangVien to TruongDonVi;

create or replace view uv_TruongDonVi_PHANCONG          
as
    select PC.*
    from PHANCONG PC, HOCPHAN HP, DONVI DV
    where PC.MAHP = HP.MAHP
    and HP.MADV = DV.MADV
    and DV.TRGDV = sys_context('userenv', 'session_user')
    with check option;
    
create or replace trigger utrig_TruongDonVi_PHANCONG
instead of insert or update or delete on uv_TruongDonVi_PHANCONG
for each row
declare
    v_count number;
begin
    select count(*) into v_count
    from HOCPHAN HP, DONVI DV
    where :new.MAHP = HP.MAHP
    and HP.MADV = DV.MADV
    and DV.TRGDV = sys_context('userenv', 'session_user');

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
        elsif (deleting) then
            delete from PHANCONG 
            where MAGV = :old.MAGV 
            and MAHP = :old.MAHP
            and HK = :old.HK
            and NAM = :old.NAM
            and MACT = :old.MACT;
        end if;
    end if;
end;
/

grant select, insert, update, delete on uv_TruongDonVi_PHANCONG to TruongDonVi;

--CS5--
--grant select, update(DT) on uv_NhanVienCoBan_NHANSU to TruongKhoa;
--grant select on uv_NhanVienCoBan_SINHVIEN to TruongKhoa;
--grant select on uv_NhanVienCoBan_DONVI to TruongKhoa;
--grant select on uv_NhanVienCoBan_HOCPHAN to TruongKhoa;
--grant select on uv_NhanVienCoBan_KHMO to TruongKhoa;
--grant select on uv_GiangVien_PHANCONG to TruongKhoa;
--grant select, update(DIEMTH, DIEMQT, DIEMCK, DIEMTK) on uv_GiangVien_DANGKY to TruongKhoa;

grant GiangVien to TruongKhoa;

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
    select count(*)
    into v_count
    from HOCPHAN HP, DONVI DV
    where :new.MAHP = HP.MAHP
    and HP.MADV = DV.MADV
    and DV.TENDV = N'Văn phòng khoa';

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
        elsif (deleting) then
            delete from PHANCONG 
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

grant select, insert, update, delete on uv_TruongKhoa_PHANCONG to TruongKhoa;
grant select, insert, update, delete on uv_TruongKhoa_NHANSU to TruongKhoa;
grant select on uv_GiaoVu_DANGKY to TruongKhoa;

--CS6--
create or replace function pc1_SinhVien_SINHVIEN
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    usr varchar2(10);
begin
    usr := sys_context('userenv', 'session_user');
    return 'MASV = ''' || usr || '''';
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

grant select, update(DCHI, DT) on SINHVIEN to SinhVien;

create or replace function pc2_SinhVien_KHMO
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    cursor cur is (
        select distinct KH.MAHP
        from KHMO KH, SINHVIEN SV
        where KH.MACT = SV.MACT
        and SV.MASV = sys_context('userenv', 'session_user')
    );
    v_mahp varchar2(10);
    strsql varchar2(1000);
begin
    open cur;
    loop
        fetch cur into v_mahp;
        exit when cur%notfound;
        
        if (strsql is not null) then
            strsql := strsql || ',';
        end if; 
        strsql := strsql || '''' || v_mahp || ''''; 
    end loop;
    close cur;
    return 'MAHP in (' || strsql || ')';
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

grant select on KHMO to SinhVien;

create or replace function pc3_SinhVien_DANGKY
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    usr varchar2(10);
    v_hk number;
    v_start_date date;
    strsql varchar2(1000);
begin
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
    
    strsql := 'MASV = ''' || usr || ''' and HK = ' || v_hk || ' 
        and NAM = extract(year from sysdate) 
        and DIEMTH is null 
        and DIEMQT is null 
        and DIEMCK is null 
        and DIEMTK is null
        and trunc(sysdate) between ''' || v_start_date || ''' and ''' || v_start_date + interval '14' day || '''';
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

grant insert, delete on DANGKY to SinhVien;

create or replace function pc4_SinhVien_DANGKY
    (p_schema varchar2, p_obj varchar2)
return varchar2
as
    usr varchar2(10);
begin
    usr := sys_context('userenv', 'session_user');
    return 'MASV = ''' || usr || '''';
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

grant select, update(MASV, MAGV, MAHP, HK, NAM, MACT) on DANGKY to SinhVien;