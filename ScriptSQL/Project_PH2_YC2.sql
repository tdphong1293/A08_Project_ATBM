drop table THONGBAO;

-- Tạo bảng THONGBAO
create table THONGBAO(
    NoiDung nvarchar2(2000),
    NgayTao date default trunc(sysdate)
);


grant select on THONGBAO to rl_SinhVien, rl_NhanVienCoBan, rl_GiangVien, rl_GiaoVu, rl_TruongDonVi, rl_TruongKhoa;

-- begin
--    sa_sysdba.drop_policy(
--        policy_name => 'thongbao_policy',
--        drop_column => TRUE
--    );
-- end;
-- /

-- Tạo chính sách OLS
begin
    sa_sysdba.create_policy(
        policy_name => 'thongbao_policy',
        column_name => 'thongbao_label'
    );
end;
/

-- Kích hoạt chính sách
exec sa_sysdba.enable_policy('thongbao_policy');

-- Cho phép user OLS_ADMIN quyền để quản lý chính sách OLS
begin
    sa_user_admin.set_user_privs(
        policy_name => 'thongbao_policy',
        user_name => 'OLS_ADMIN',
        privileges => 'FULL,PROFILE_ACCESS'
    );
end;
/

-- Tạo các thành phần của nhãn
exec sa_components.create_level('thongbao_policy', 20, 'SV', 'Sinh Vien');
exec sa_components.create_level('thongbao_policy', 40, 'NV', 'Nhan Vien');
exec sa_components.create_level('thongbao_policy', 60, 'GVU', 'Giao Vu');
exec sa_components.create_level('thongbao_policy', 80, 'GV', 'Giang Vien');
exec sa_components.create_level('thongbao_policy', 100, 'TDV', 'Truong Don Vi');
exec sa_components.create_level('thongbao_policy', 120, 'TK', 'Truong Khoa');

exec sa_components.create_compartment('thongbao_policy', 100, 'HTTT', 'He Thong Thong Tin');
exec sa_components.create_compartment('thongbao_policy', 200, 'CNPM', 'Cong Nghe Phan Mem');
exec sa_components.create_compartment('thongbao_policy', 300, 'KHMT', 'Khoa Hoc May Tinh');
exec sa_components.create_compartment('thongbao_policy', 400, 'CNTT', 'Cong Nghe Tri Thuc');
exec sa_components.create_compartment('thongbao_policy', 500, 'TGMT', 'Thi Giac May Tinh');
exec sa_components.create_compartment('thongbao_policy', 600, 'MMT', 'Mang May Tinh');

exec sa_components.create_group('thongbao_policy', 100, 'CS1', 'Co So 1');
exec sa_components.create_group('thongbao_policy', 200, 'CS2', 'Co So 2');

-- Kiểm tra các thành phần của nhãn
select * from dba_sa_levels;
select * from dba_sa_compartments;
select * from dba_sa_groups;

--Áp dụng chính sách OLS lên bảng THONGBAO
begin 
    sa_policy_admin.apply_table_policy(
        policy_name => 'thongbao_policy',
        schema_name => 'OLS_ADMIN',
        table_name => 'THONGBAO',
        table_options => 'READ_CONTROL'
    );
end;
/

--a) gán nhãn cho người dùng là Trưởng khoa có thể đọc được toàn bộ thông báo.
begin
    sa_user_admin.set_user_labels(
        policy_name => 'thongbao_policy',
        user_name => 'TRKHOA001',
        max_read_label => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
    );
end;
/

--b) user label: 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
begin
    sa_user_admin.set_user_labels(
        policy_name => 'thongbao_policy',
        user_name => 'TRGDV00001',
        max_read_label => 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
    );
end;
/

--c) user label: 'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
begin
    sa_user_admin.set_user_labels(
        policy_name => 'thongbao_policy',
        user_name => 'GIAOVU001',
        max_read_label => 'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
    );
end;
/

--d) data label t1: 'TDV'
exec sp_Insert_ThongBao(N'Thông báo đến các trưởng đơn vị', 'TDV');

--e) data label t2: 'SV:HTTT:CS1'
exec sp_Insert_ThongBao(N'Thông báo đến các sinh viên thuộc ngành HTTT ở cơ sở 1', 'SV:HTTT:CS1');

--f) data label t3: 'TDV:KHMT:CS1'
exec sp_Insert_ThongBao(N'Thông báo đến các trưởng đơn vị thuộc bộ môn KHMT ở cơ sở 1', 'TDV:KHMT:CS1');

--g) data label t4: 'TDV:KHMT'
exec sp_Insert_ThongBao(N'Thông báo đến các trưởng đơn vị thuộc bộ môn KHMT ở cơ sở 1 và 2', 'TDV:KHMT:CS1,CS2');

--h1) dữ liệu được phát tán đến mỗi giảng viên thuộc bộ môn HTTT ở cả 2 cơ sở, data label t5: 'GV:HTTT'
exec sp_Insert_ThongBao(N'Thông báo đến các giảng viên thuộc bộ môn HTTT ở cả 2 cơ sở', 'GV:HTTT');

--h2) dữ liệu được phát tán đến mỗi người trong trường không kể cơ sở, data label t6: 'SV'
exec sp_Insert_ThongBao(N'Thông báo đến mỗi người trong trường', 'SV');

--h3) dữ liệu được phát tán đến mỗi nhân viên trong của trường ở cơ sở 2, data label t7: 'NV::CS2'
exec sp_Insert_ThongBao(N'Thông báo đến mỗi nhân viên trong trưởng ở cơ sở 2', 'NV::CS2');