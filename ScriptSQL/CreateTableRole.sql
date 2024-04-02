drop table ĐANGKY delete cascade;
drop table PHANCONG delete cascade;
drop table KHMO delete cascade;
drop table HOCPHAN delete cascade;
drop table SINHVIEN delete cascade;
drop table NHANSU delete cascade;
drop table ĐONVI delete cascade;

--Tạo bảng--
create table NHANSU (
    MANV char(9) primary key,
    HOTEN nvarchar2(100),
    PHAI nchar(3),
    NGSINH date,
    PHUCAP float,
    DT char(10),
    VAITRO nvarchar2(100),
    MADV char(9)
);

create table SINHVIEN (
    MASV char(9) primary key,
    HOTEN nvarchar2(100),
    PHAI nchar(3),
    NGSINH date,
    DCHI nvarchar2(100),
    DT char(10),
    MACT char(5) check (MACT in ('CLC', 'CQ', 'CTTT', 'VP')),
    MANGANH char(9), 
    SOTCTL int,
    DTBTL float
);

create table DONVI (
    MADV char(9) primary key,
    TENDV nvarchar2(100),
    TRGDV char(9)
);

create table HOCPHAN (
    MAHP char(9) primary key,
    TENHP nvarchar2(100),
    SOTC int,
    STLT int,
    STTH int,
    SOSVTD int,
    MADV char(9)
);

create table KHMO (
    MAHP char(9),
    HK int check (HK > 0 and HK <= 3),
    NAM date,
    MACT char(5) check (MACT in ('CLC', 'CQ', 'CTTT', 'VP')),
    constraint PK_KHMO primary key (MAHP, HK, NAM, MACT)
);

create table PHANCONG (
    MAGV char(9),
    MAHP char(9),
    HK int,
    NAM date,
    MACT char(5),
    constraint PK_PHANCONG primary key (MAGV, MAHP, HK, NAM, MACT)
);

create table DANGKY (
    MASV char(9),
    MAGV char(9),
    MAHP char(9),
    HK int,
    NAM date,
    MACT char(5),
    DIEMTH float check (DIEMTH > 0 and DIEMTH <= 10),
    DIEMQT float check (DIEMQT > 0 and DIEMQT <= 10),
    DIEMCK float check (DIEMCK > 0 and DIEMCK <= 10),
    DIEMTK float check (DIEMTK > 0 and DIEMTK <= 10),
    constraint PK_DANGKY primary key (MASV, MAGV, MAHP, HK, NAM, MACT)
);

--Ràng buộc khóa ngoại--
alter table NHANSU add constraint 
    FK_NHANSU_DONVI foreign key (MADV) references to DONVI(MADV);

alter table DONVI add constraint
    FK_DONVI_NHANSU foreign key (TRGDV) references to NHANSU(MANV);
    
alter table HOCPHAN add constraint
    FK_HOCPHAN_DONVI foreign key (MADV) references to DONVI(MADV);

alter table KHMO add constraint 
    FK_KHMO_HOCPHAN foreign key (MAHP) references to HOCPHAN(MAHP);
    
alter table PHANCONG add constraint
    FK_PHANCONG_NHANSU foreign key (MAGV) references to NHANSU(MAGV);
alter table PHANCONG add constraint    
    FK_PHANCONG_KHMO foreign key (MAHP, HK, NAM, MACT) references to KHMO(MAHP, HK, NAM, MACT);

alter table DANGKY add constraint
    FK_DANGKY_SINHVIEN foreign key (MASV) references to SINHVIEN(MASV);
alter table DANGKY add constraint
    FK_DANGKY_PHANCONG foreign key (MAGV, MAHP, HK, NAM, MACT) references to PHANCONG(MAGV, MAHP, HK, NAM, MACT);

--Tạo vai trò--
create role NhanVienCoBan;
create role GiangVien;
create role GiaoVu;
create role TruongDonVi;
create role TruongKhoa;
create role SinhVien;