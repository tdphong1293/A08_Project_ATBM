create or replace procedure sp_CreateUserNV
authid current_user
as
    cursor cur is (
        select MANV
        from NHANSU
        where MANV not in (select username from all_users)
    );
    strsql varchar2(1000);
    usr varchar2(100);
begin
    open cur;
    loop
        fetch cur into usr;
        exit when cur%notfound;
        
        strsql := 'create user ' || usr || ' identified by ' || usr;
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

create or replace procedure sp_CreateUserSV
authid current_user
as
    cursor cur is (
        select MASV
        from SINHVIEN
        where MASV not in (select username from all_users)
    );
    strsql varchar2(1000);
    usr varchar2(100);
begin
    open cur;
    loop
        fetch cur into usr;
        exit when cur%notfound;
        
        strsql := 'create user ' || usr || ' identified by ' || usr;
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

create or replace procedure sp_AddRoleNV
    (strrole varchar2, loainv nvarchar2)
authid current_user
as
    cursor cur is (
        select MANV
        from NHANSU
        where MANV in (select username from all_users) and VAITRO = N'''' || to_nchar(loainv) || ''''
    );
    strsql varchar2(1000);
    usr varchar2(100);
begin
    open cur;
    loop
        fetch cur into usr;
        exit when cur%notfound;
        dbms_output.put_line(usr);
        strsql := 'grant '|| strrole || ' to ' || usr;
        dbms_output.put_line(strsql);
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

create or replace procedure sp_AddRoleSV
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
        
        strsql := 'grant SinhVien to ' || usr;
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

exec sp_CreateUserNV;
exec sp_createUserSV;
exec sp_AddRoleNV('NhanVienCoBan', N'Nhân viên cơ bản');
exec sp_AddRoleNV('GiangVien', N'Giảng viên');
exec sp_AddRoleNV('GiaoVu', N'Giáo vụ');
exec sp_AddRoleNV('TruongDonVi', N'Trưởng đơn vị');
exec sp_AddRoleNV('TruongKhoa', N'Trưởng khoa');
exec sp_AddRoleSV;