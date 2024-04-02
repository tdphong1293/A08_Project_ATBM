create table THONGBAO(
    NoiDung nvarchar2(4000)
);

begin
    sa_sysdba.create_policy(
        policy_name => 'thongbao_policy',
        column_name => 'thongbao_label'
    );
end;
/

exec sa_sysdba.enable_policy('thongbao_policy');

exec sa_components.create_level('thongbao_policy', 20, 'SV', 'Sinh Vien');
exec sa_components.create_level('thongbao_policy', 40, 'NV', 'Nhan Vien');
exec sa_components.create_level('thongbao_policy', 60, 'GVU', 'Giao Vu');
exec sa_components.create_level('thongbao_policy', 80, 'GV', 'Giang Vien');
exec sa_components.create_level('thongbao_policy', 100, 'TDV', 'Truong Don Vi');
exec sa_components.create_level('thongbao_policy', 120, 'TK', 'Truong Khoa');

exec sa_components.create_compartment('thongbao_policy', 100, 'HTTT', 'He Thong Thong Tin');
exec sa_components.create_compartment('thongbao_policy', 200, 'CNPM', 'Cong Nghe Phan Mem');
exec sa_components.create_compartment('thongbao_policy', 300, 'KHMT', 'Khoa Hoc May Tinh');
exec sa_components.create_compartment('thongbao_policy', 400, 'CNTT', 'Cong Nghe Thong Tin');
exec sa_components.create_compartment('thongbao_policy', 500, 'TGMT', 'Thi Giac May Tinh');
exec sa_components.create_compartment('thongbao_policy', 600, 'MMT', 'Mang May Tinh');

exec sa_components.create_group('thongbao_policy', 100, 'CS1', 'Co So 1');
exec sa_components.create_group('thongbao_policy', 200, 'CS2', 'Co So 2');
