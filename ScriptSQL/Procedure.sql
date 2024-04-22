drop procedure sp_dropNV;
drop procedure sp_dropSV;
drop procedure sp_CreateUserNV;
drop procedure sp_createUserSV;
drop procedure sp_AddRoleNV;
drop procedure sp_AddRoleSV;
drop procedure sp_SetLabelNV;
drop procedure sp_SetLabelSV;

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
        
        strsql := 'grant create session to ' || usr;
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
        
        strsql := 'grant create session to ' || usr;
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

-- Insert nội dung và gán nhán dữ liệu của bảng thông báo
create or replace procedure sp_Insert_ThongBao
    (v_noidung in nvarchar2, v_label in varchar2)
authid current_user    
as
begin
    insert into THONGBAO (NoiDung, thongbao_label) values (to_nchar(v_noidung), char_to_label('thongbao_policy', v_label));
    commit;
end;
/

-- Gán nhãn cho sinh viên
create or replace procedure sp_SetLabelSV
authid current_user
as
    cursor cur is (
        select MASV, MANGANH
        from SINHVIEN
        where MASV in (select username from all_users)
    );
    usr varchar2(100);
    nganh varchar2(100);
    v_label varchar2(1000);
begin
    open cur;
    loop
        fetch cur into usr, nganh;
        exit when cur%notfound;
        
        if (nganh = 'CNTT') then
            v_label := 'SV:CNTT';
        elsif (nganh = 'HTTT') then
            v_label := 'SV:HTTT';
        elsif (nganh = 'CNPM') then
            v_label := 'SV:CNPM';
        elsif (nganh = 'KHMT') then
            v_label := 'SV:KHMT';
        elsif (nganh = 'TGMT') then
            v_label := 'SV:TGMT';
        elsif (nganh = 'MMT') then
            v_label := 'SV:MMT';
        else
            v_label := 'SV';
        end if;
        
        begin
            sa_user_admin.set_user_labels('thongbao_policy', usr, v_label);
        end;
        
    end loop;
    close cur;
end;
/

-- Gán nhãn cho nhân viên
create or replace procedure sp_SetLabelNV
authid current_user
as
    cursor cur is (
        select MANV, MADV
        from NHANSU
        where MANV in (select username from all_users)
    );
    usr varchar2(100);
    donvi varchar2(100);
    v_label varchar2(1000);
begin
    open cur;
    loop
        fetch cur into usr, donvi;
        exit when cur%notfound;
        
        if (usr like 'NVCB%') then
            v_label := 'NV';
        elsif (usr like 'GV%') then
            v_label := 'GV';
        elsif (usr like 'GIAOVU%') then
            v_label := 'GVU';
        elsif (usr like 'TRGDV%') then
            v_label := 'TDV';
        elsif (usr like 'TRKHOA%') then
            v_label := 'TK';
        else
            v_label := 'NV';
        end if;
        
        if (donvi = 'BMCNTT') then
            v_label := v_label || ':CNTT';
        elsif (donvi = 'BMHTTT') then
            v_label := v_label || ':HTTT';
        elsif (donvi = 'BMCNPM') then
            v_label := v_label || ':CNPM';
        elsif (donvi = 'BMKHMT') then
            v_label := v_label || ':KHMT';
        elsif (donvi = 'BMTGMT') then
            v_label := v_label || ':TGMT';
        elsif (donvi = 'BMMMTVVT') then
            v_label := v_label || ':MMT';
        elsif (donvi = 'VPK') then
            v_label := v_label || ':CNTT,HTTT,CNPM,KHMT,TGMT,MMT';
        end if;
        
        begin
            sa_user_admin.set_user_labels('thongbao_policy', usr, v_label);
        end;
        
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

exec sp_SetLabelNV;
exec sp_SetLabelSV;