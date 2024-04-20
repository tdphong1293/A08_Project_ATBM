-- Tạo user nhân viên
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

-- Tạo user sinh viên
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

-- Thêm role tương ứng cho user nhân viên
create or replace procedure sp_AddRoleNV
    (strrole varchar2, loainv nvarchar2)
authid current_user
as
    cursor cur is (
        select MANV
        from NHANSU
        where MANV in (select username from all_users) and VAITRO = loainv
    );
    strsql varchar2(1000);
    usr varchar2(100);
begin
    open cur;
    loop
        fetch cur into usr;
        exit when cur%notfound;

        strsql := 'grant '|| strrole || ' to ' || usr;
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

-- Thêm role SinhVien cho user sinh viên
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
        
        strsql := 'grant rl_SinhVien to ' || usr;
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

--Xóa user nhân viên
create or replace procedure sp_dropNV
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
        
        strsql := 'drop user ' || usr;
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

-- Xóa user sinh viên
create or replace procedure sp_dropSV
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
        
        strsql := 'drop user ' || usr;
        execute immediate (strsql);
    end loop;
    close cur;
end;
/

-- Chạy procedure tạo user, thêm role user
exec sp_dropNV;
exec sp_dropSV;

exec sp_CreateUserNV;
exec sp_createUserSV;
exec sp_AddRoleNV('rl_NhanVienCoBan', N'Nhân viên cơ bản');
exec sp_AddRoleNV('rl_GiangVien', N'Giảng viên');
exec sp_AddRoleNV('rl_GiaoVu', N'Giáo vụ');
exec sp_AddRoleNV('rl_TruongDonVi', N'Trưởng đơn vị');
exec sp_AddRoleNV('rl_TruongKhoa', N'Trưởng khoa');
exec sp_AddRoleSV;

-- Insert nội dung và gán nhán dữ liệu của bảng thông báo
create or replace procedure Insert_ThongBao
    (v_noidung in varchar2, v_label in varchar2)
as
begin
    insert into THONGBAO values (v_noidung, char_to_label('thongbao_policy', v_label));
end;
/