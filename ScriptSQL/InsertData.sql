insert into DONVI (MADV, TENDV) values('VPK', 'Văn phòng khoa');
insert into DONVI (MADV, TENDV) values('BMHTTT', 'Bộ môn HTTT');
insert into DONVI (MADV, TENDV) values('BMCNPM', 'Bộ môn CNPM');
insert into DONVI (MADV, TENDV) values('BMKHMT', 'Bộ môn KHMT');
insert into DONVI (MADV, TENDV) values('BMCNTT', 'Bộ môn CNTT');
insert into DONVI (MADV, TENDV) values('BMTGMT', 'Bộ môn TGMT');
insert into DONVI (MADV, TENDV) values('BMMMTVVT', 'Bộ môn MMT và Viễn thông');
 
-- Nhập liệu Nhân viên cơ bản
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0001', 'Lưu Trung Hiếu', 'Nam', to_date('21-01-1972', 'DD/MM/YYYY'), 500000, '0123456789', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0002', 'Trần Ngọc Quế', 'Nữ', to_date('20-01-1975', 'DD/MM/YYYY'), 500000, '0123456788', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0003', 'Phạm Đình Nhân', 'Nam', to_date('20-09-1973', 'DD/MM/YYYY'), 500000, '0123456787', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0004', 'Thi Thanh Chương', 'Nam', to_date('05-02-1977', 'DD/MM/YYYY'), 500000, '0123456786', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0005', 'Trần Trung Hải', 'Nam', to_date('28-05-1989', 'DD/MM/YYYY'), 500000, '0123456785', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0006', 'Lưu Minh Tiến', 'Nam', to_date('26-07-1989', 'DD/MM/YYYY'), 500000, '0123456784', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0007', 'Hồ Xuân Ước', 'Nam', to_date('06-10-1999', 'DD/MM/YYYY'), 500000, '0123456783', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0008', 'Nguyễn Cảnh Thọ', 'Nam', to_date('14-01-1990', 'DD/MM/YYYY'), 500000, '0123456782', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0009', 'Vũ Văn Hoàng', 'Nam', to_date('14-02-1981', 'DD/MM/YYYY'), 500000, '0123456781', 'Nhân viên cơ bản', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('NVCB0010', 'Nguyễn Giao Ban', 'Nữ', to_date('18-03-1980', 'DD/MM/YYYY'), 500000, '0123456780', 'Nhân viên cơ bản', 'VPK');
    

-- Nhập liệu Giảng viên
-- BMHTTT
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000001', 'Vương Trường An', 'Nam', to_date('02-06-1973', 'DD/MM/YYYY'), 500000, '0123456779', 'Giảng viên', 'BMHTTT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000002', 'Đỗ Văn Khánh', 'Nam', to_date('21-11-1980', 'DD/MM/YYYY'), 500000, '0123456778', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000003', 'Nguyễn Trọng Khôi', 'Nam', to_date('30-01-1970', 'DD/MM/YYYY'), 500000, '0123456777', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000004', 'Lê Thị Thảo Minh', 'Nữ', to_date('13-03-1989', 'DD/MM/YYYY'), 500000, '0123456776', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000005', 'Nguyễn Văn Tuệ', 'Nam', to_date('26-10-1996', 'DD/MM/YYYY'), 500000, '0123456775', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000006', 'Trịnh Thị Ngọc Huế', 'Nữ', to_date('10-12-1989', 'DD/MM/YYYY'), 500000, '0123456774', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000007', 'Hoàng Anh Sơn', 'Nam', to_date('08-03-1974', 'DD/MM/YYYY'), 500000, '0123456773', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000008', 'Lê Trường Trung', 'Nam', to_date('18-02-1987', 'DD/MM/YYYY'), 500000, '0123456772', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000009', 'Nguyễn Thị Kim Thoa', 'Nữ', to_date('19-08-1971', 'DD/MM/YYYY'), 500000, '0123456771', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000010', 'Trần Thị Thanh Viết', 'Nữ', to_date('20-06-1984', 'DD/MM/YYYY'), 500000, '0123456770', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000011', 'Phan Thành Nam', 'Nam', to_date('06-10-1985', 'DD/MM/YYYY'), 500000, '0123456769', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000012', 'Trần Hải Thành', 'Nam', to_date('24-07-1985', 'DD/MM/YYYY'), 500000, '0123456768', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000013', 'Phan Ngọc Thảo', 'Nữ', to_date('11-11-1998', 'DD/MM/YYYY'), 500000, '0123456767', 'Giảng viên', 'BMHTTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000014', 'Vũ Văn Hoàng', 'Nam', to_date('31-12-1988', 'DD/MM/YYYY'), 500000, '0123456766', 'Giảng viên', 'BMHTTT');


-- BMCNPM
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000015', 'Đinh Thị Mỹ Quỳnh', 'Nữ', to_date('11-01-1975', 'DD/MM/YYYY'), 500000, '0123456765', 'Giảng viên', 'BMCNPM');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000016', 'Dương Đức Toàn', 'Nam', to_date('08-01-1988', 'DD/MM/YYYY'), 500000, '0123456764', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000017', 'Phạm Viết Minh', 'Nam', to_date('08-12-1989', 'DD/MM/YYYY'), 500000, '0123456763', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000018', 'Nguyễn Thị Phương Ngọc', to_date('Nữ', '17-12-1997', 'DD/MM/YYYY'), 500000, '0123456762', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000019', 'Nguyễn Hữu Thanh Phong', to_date('Nam', '17-11-1997', 'DD/MM/YYYY'), 500000, '0123456761', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000020', 'Trần Quang Toàn', 'Nam', to_date('05-11-1978', 'DD/MM/YYYY'), 500000, '0123456760', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000021', 'Lê Kim Tỵ', 'Nữ', to_date('22-01-1972', 'DD/MM/YYYY'), 500000, '0123456759', 'Giảng viên', 'BMCNPM');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000022', 'Trần Thị Thanh Viết', 'Nữ', to_date('19-01-1976', 'DD/MM/YYYY'), 500000, '0123456758', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000023', 'Trương Hoàng Phong', 'Nam', to_date('08-05-1995', 'DD/MM/YYYY'), 500000, '0123456757', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000024', 'Vũ Văn Cường', 'Nam', to_date('13-11-1982', 'DD/MM/YYYY'), 500000, '0123456756', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000025', 'Trần Đình Trung', 'Nam', to_date('24-11-1984', 'DD/MM/YYYY'), 500000, '0123456755', 'Giảng viên', 'BMCNPM');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000026', 'Dương Việt Hoàng', 'Nam', to_date('03-07-1984', 'DD/MM/YYYY'), 500000, '0123456754', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000027', 'Nguyễn Thị Hồng Trinh', 'Nữ', to_date('17-09-1972', 'DD/MM/YYYY'), 500000, '0123456753', 'Giảng viên', 'BMCNPM');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000028', 'Nguyễn Mạnh Thời', 'Nam', to_date('01-08-1981', 'DD/MM/YYYY'), 500000, '0123456752', 'Giảng viên', 'BMCNPM');


-- BMKHMT
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000029', 'Vương Trường Trương', 'Nam', to_date('09-01-1981', 'DD/MM/YYYY'), 500000, '0123456751', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000030', 'Lê Quang Vỹ', 'Nam', to_date('03-07-1985', 'DD/MM/YYYY'), 500000, '0123456750', 'Giảng viên', 'BMKHMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000031', 'Phan Ngọc Thảo', 'Nữ', to_date('17-09-1992', 'DD/MM/YYYY'), 500000, '0123456749', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000032', 'Hoàng Mai Loan', 'Nữ', to_date('29-04-1975', 'DD/MM/YYYY'), 500000, '0123456748', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000033', 'Đỗ Văn Khánh', 'Nam', to_date('11-12-1985', 'DD/MM/YYYY'), 500000, '0123456747', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000034', 'Huỳnh Anh Tấn', 'Nam', to_date('03-12-1980', 'DD/MM/YYYY'), 500000, '0123456746', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000035', 'Vương Trường Anh', 'Nam', to_date('01-05-1974', 'DD/MM/YYYY'), 500000, '0123456745', 'Giảng viên', 'BMKHMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000036', 'Phạm Hoàng Quân', 'Nam', to_date('20-12-1975', 'DD/MM/YYYY'), 500000, '0123456744', 'Giảng viên', 'BMKHMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000037', 'Phan Thị Ngọc Thảo', 'Nữ', to_date('17-08-1992', 'DD/MM/YYYY'), 500000, '0123456743', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000038', 'Hoàng Thị Mai Loan', 'Nữ', to_date('29-05-1975', 'DD/MM/YYYY'), 500000, '0123456742', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000039', 'Đỗ Nam Khánh', 'Nam', to_date('11-05-1985', 'DD/MM/YYYY'), 500000, '0123456741', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000040', 'Huỳnh Anh Tuấn', 'Nam', to_date('03-10-1980', 'DD/MM/YYYY'), 500000, '0123456740', 'Giảng viên', 'BMKHMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000041', 'Vương Quang Anh', 'Nam', to_date('01-07-1974', 'DD/MM/YYYY'), 500000, '0123456739', 'Giảng viên', 'BMKHMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000042', 'Phạm Minh Quân', 'Nam', to_date('20-08-1975', 'DD/MM/YYYY'), 500000, '0123456738', 'Giảng viên', 'BMKHMT');
    
    
-- BMCNTT
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000043', 'Nguyễn Trọng Thiên', 'Nam', to_date('03-12-1974', 'DD/MM/YYYY'), 500000, '0123456737', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000044', 'Thái Hoàng Nhân', 'Nam', to_date('24-11-1988', 'DD/MM/YYYY'), 500000, '0123456736', 'Giảng viên', 'BMCNTT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000045', 'Đặng Bảo Toàn', 'Nam', to_date('14-04-1983', 'DD/MM/YYYY'), 500000, '0123456735', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000046', 'Chung Mạnh Quỳnh', 'Nữ', to_date('18-12-1996', 'DD/MM/YYYY'), 500000, '0123456734', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000047', 'Phạm Hữu Tín', 'Nam', to_date('27-04-1977', 'DD/MM/YYYY'), 500000, '0123456733', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000048', 'Huỳnh Lê Song Tấn', 'Nam', to_date('29-01-1974', 'DD/MM/YYYY'), 500000, '0123456732', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000049', 'Đoàn Đại Dương', 'Nam', to_date('21-05-1979', 'DD/MM/YYYY'), 500000, '0123456731', 'Giảng viên', 'BMCNTT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000050', 'Nguyễn Trương Quốc Anh', 'Nam', to_date('13-02-1982', 'DD/MM/YYYY'), 500000, '0123456730', 'Giảng viên', 'BMCNTT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000051', 'Trương Bình Duy', 'Nam', to_date('24-11-1974', 'DD/MM/YYYY'), 500000, '0123456729', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000052', 'Đặng Dương Duy Anh', 'Nam', to_date('26-12-1997', 'DD/MM/YYYY'), 500000, '0123456728', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000053', 'Trương Bảo Tâm', 'Nữ', to_date('18-05-1996', 'DD/MM/YYYY'), 500000, '0123456727', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000054', 'Lê Phan Bảo Quyết', 'Nam', to_date('05-04-1990', 'DD/MM/YYYY'), 500000, '0123456726', 'Giảng viên', 'BMCNTT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000055', 'Trần Huỳnh Tiến Đạt', 'Nam', to_date('12-02-1974', 'DD/MM/YYYY'), 500000, '0123456725', 'Giảng viên', 'BMCNTT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000056', 'Trần Hải Thiên Ân', 'Nam', to_date('29-12-1974', 'DD/MM/YYYY'), 500000, '0123456724', 'Giảng viên', 'BMCNTT');
    

-- BMTGMT
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000057', 'Nguyễn Thị Kim Ánh', 'Nữ', to_date('19-06-1993', 'DD/MM/YYYY'), 500000, '0123456723', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000058', 'Trương Tấn Huy', 'Nam', to_date('01-03-1988', 'DD/MM/YYYY'), 500000, '0123456722', 'Giảng viên', 'BMTGMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000059', 'Lê Văn Hưởng', 'Nam', to_date('08-09-1992', 'DD/MM/YYYY'), 500000, '0123456721', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000060', 'Hoàng Anh Sơn', 'Nam', to_date('20-03-1983', 'DD/MM/YYYY'), 500000, '0123456720', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000061', 'Đinh Quốc Tuấn', 'Nam', to_date('05-06-1981', 'DD/MM/YYYY'), 500000, '0123456719', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000062', 'Nguyễn Giao Bản', 'Nam', to_date('03-12-1977', 'DD/MM/YYYY'), 500000, '0123456718', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000063', 'Nguyễn Tấn Diện', 'Nam', to_date('09-11-1985', 'DD/MM/YYYY'), 500000, '0123456717', 'Giảng viên', 'BMTGMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000064', 'Trần Thị Bích Ngọc', 'Nữ', to_date('19-12-1996', 'DD/MM/YYYY'), 500000, '0123456716', 'Giảng viên', 'BMTGMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000065', 'Trần Thị Soan', 'Nữ', to_date('17-09-1990', 'DD/MM/YYYY'), 500000, '0123456715', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000066', 'Trương Ngọc Tâm', 'Nữ', to_date('14-05-1982', 'DD/MM/YYYY'), 500000, '0123456714', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000067', 'Phan Thành Nam', 'Nam', to_date('29-09-1982', 'DD/MM/YYYY'), 500000, '0123456713', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000068', 'Nguyễn Trương Quốc Anh', 'Nam', to_date('26-03-1970', 'DD/MM/YYYY'), 500000, '0123456712', 'Giảng viên', 'BMTGMT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000069', 'Ngô Minh Thông', 'Nam', to_date('25-10-1991', 'DD/MM/YYYY'), 500000, '0123456711', 'Giảng viên', 'BMTGMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000070', 'Phạm Ngọc Thảo', 'Nữ', to_date('24-04-1986', 'DD/MM/YYYY'), 500000, '0123456710', 'Giảng viên', 'BMTGMT');
    

-- BMMMTVVT
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000071', 'Nguyễn Duy Thuận', 'Nam', to_date('07-06-1996', 'DD/MM/YYYY'), 500000, '0123456709', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000072', 'Phan Huỳnh Minh Duy', 'Nam', to_date('16-10-1970', 'DD/MM/YYYY'), 500000, '0123456708', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000073', 'Võ Thị Hoài Linh', 'Nữ', to_date('18-07-1973', 'DD/MM/YYYY'), 500000, '0123456707', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000074', 'Trịnh Quốc Huy', 'Nam', to_date('06-12-1971', 'DD/MM/YYYY'), 500000, '0123456706', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000075', 'Vũ Quốc Thể', 'Nam', to_date('19-09-1974', 'DD/MM/YYYY'), 500000, '0123456705', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000076', 'Đặng Anh Minh', 'Nam', to_date('24-05-1989', 'DD/MM/YYYY'), 500000, '0123456704', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000077', 'Đoàn Hương Quân', 'Nữ', to_date('19-03-1982', 'DD/MM/YYYY'), 500000, '0123456703', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000078', 'Đinh Thị Mỹ Quỳnh', 'Nữ', to_date('02-02-1990', 'DD/MM/YYYY'), 500000, '0123456702', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000079', 'Lê Hà Phương Anh', 'Nữ', to_date('03-11-1995', 'DD/MM/YYYY'), 500000, '0123456701', 'Giảng viên', 'BMMMTVVT');

insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GV000080', 'Nguyễn Vũ Hoài Dương', 'Nam', to_date('06-01-1996', 'DD/MM/YYYY'), 500000, '0123456700', 'Giảng viên', 'BMMMTVVT');
    
    
-- Nhập liệu Giáo vụ
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU01', 'Đinh Thị Mỹ Quỳnh', 'Nữ', to_date('21-04-1974', 'DD/MM/YYYY'), 500000, '0123456699', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU02', 'Nguyễn Thị Ngọc Giàu', 'Nữ', to_date('02-04-1992', 'DD/MM/YYYY'), 500000, '0123456698', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU03', 'Nguyễn Minh Khuê', 'Nữ', to_date('25-11-1990', 'DD/MM/YYYY'), 500000, '0123456697', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU04', 'Vũ Phúc Bảo', 'Nam', to_date('23-12-1990', 'DD/MM/YYYY'), 500000, '0123456696', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU05', 'Lê Thanh Chung', 'Nam', to_date('30-12-1978', 'DD/MM/YYYY'), 500000, '0123456695', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU06', 'Phạm Huỳnh Đăng Huy', 'Nam', to_date('23-11-1973', 'DD/MM/YYYY'), 500000, '0123456694', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU07', 'Nguyễn Trọng Thiên', 'Nam', to_date('14-09-1985', 'DD/MM/YYYY'), 500000, '0123456693', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU08', 'Hoàng Xuân Ngọc', 'Nữ', to_date('03-07-1992', 'DD/MM/YYYY'), 500000, '0123456692', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU09', 'Võ Nguyễn Hữu Nhân', 'Nam', to_date('16-06-1995', 'DD/MM/YYYY'), 500000, '0123456691', 'Giáo vụ', 'VPK');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('GIAOVU10', 'Phạm Duy Hạnh', 'Nam', to_date('26-11-1993', 'DD/MM/YYYY'), 500000, '0123456690', 'Giáo vụ', 'VPK');


-- Nhập liệu Trưởng Đơn vị
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('TRGDV001', 'Phạm Nguyễn Cương', 'Nam', to_date('01-02-1980', 'DD/MM/YYYY'), 500000, '0123456689', 'Trưởng đơn vị', 'BMHTTT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('TRGDV002', 'Nguyễn Văn Vũ', 'Nam', to_date('01-04-1970', 'DD/MM/YYYY'), 500000, '0123456688', 'Trưởng đơn vị', 'BMCNPM');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('TRGDV003', 'Lê Hoài Bắc', 'Nam', to_date('01-03-1950', 'DD/MM/YYYY'), 500000, '0123456687', 'Trưởng đơn vị', 'BMKHMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('TRGDV004', 'Hồng Trần Thoang', 'Nam', to_date('01-06-1990', 'DD/MM/YYYY'), 500000, '0123456686', 'Trưởng đơn vị', 'BMCNTT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('TRGDV005', 'Lý Quốc Ngọc', 'Nam', to_date('01-07-1970', 'DD/MM/YYYY'), 500000, '0123456685', 'Trưởng đơn vị', 'BMTGMT');
    
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('TRGDV006', 'Trần Trung Dũng', 'Nam', to_date('01-08-1990', 'DD/MM/YYYY'), 500000, '0123456684', 'Trưởng đơn vị', 'BMMMTVVT');
    
-- Nhập liệu Trưởng khoa
insert into NHANSU(MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
    values('TRKHOA01', 'Đinh Bá Tiến', 'Nam', to_date('01-09-1985', 'DD/MM/YYYY'), 500000, '0123456683', 'Trưởng khoa', 'BMKHMT');

-- Thêm trưởng đơn vị
UPDATE DONVI SET TRGDV = 'TRGDV001' WHERE MADV = 'BMHTTT';
UPDATE DONVI SET TRGDV = 'TRGDV002' WHERE MADV = 'BMCNPM';
UPDATE DONVI SET TRGDV = 'TRGDV003' WHERE MADV = 'BMKHMT';
UPDATE DONVI SET TRGDV = 'TRGDV004' WHERE MADV = 'BMCNTT';
UPDATE DONVI SET TRGDV = 'TRGDV005' WHERE MADV = 'BMTGMT';
UPDATE DONVI SET TRGDV = 'TRGDV006' WHERE MADV = 'BMMMTVVT';