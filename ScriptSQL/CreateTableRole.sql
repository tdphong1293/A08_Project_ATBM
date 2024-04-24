drop table DANGKY cascade constraints;
drop table PHANCONG cascade constraints;
drop table KHMO cascade constraints;
drop table HOCPHAN cascade constraints;
drop table SINHVIEN cascade constraints;
drop table NHANSU cascade constraints;
drop table DONVI cascade constraints;

drop role rl_NhanVienCoBan;
drop role rl_GiangVien;
drop role rl_GiaoVu;
drop role rl_TruongDonVi;
drop role rl_TruongKhoa;
drop role rl_SinhVien; 
--Tạo bảng--
create table NHANSU (
    MANV varchar2(9) primary key,
    HOTEN nvarchar2(100),
    PHAI nchar(3),
    NGSINH date,
    PHUCAP float,
    DT varchar2(10),
    VAITRO nvarchar2(100),
    MADV varchar2(9)
);

create table SINHVIEN (
    MASV varchar2(9) primary key,
    HOTEN nvarchar2(100),
    PHAI nchar(3),
    NGSINH date,
    DCHI nvarchar2(100),
    DT varchar2(10),
    MACT varchar2(5) check (MACT in ('CLC', 'CQ', 'CTTT', 'VP')),
    MANGANH varchar2(9), 
    SOTCTL int,
    DTBTL float
);

create table DONVI (
    MADV varchar2(9) primary key,
    TENDV nvarchar2(100),
    TRGDV varchar2(9)
);

create table HOCPHAN (
    MAHP varchar2(9) primary key,
    TENHP nvarchar2(100),
    SOTC int,
    STLT int,
    STTH int,
    SOSVTD int,
    MADV varchar2(9)
);

create table KHMO (
    MAHP varchar2(9),
    HK int check (HK > 0 and HK <= 3),
    NAM date,
    MACT varchar2(5) check (MACT in ('CLC', 'CQ', 'CTTT', 'VP')),
    constraint PK_KHMO primary key (MAHP, HK, NAM, MACT)
);

create table PHANCONG (
    MAGV varchar2(9),
    MAHP varchar2(9),
    HK int,
    NAM date,
    MACT varchar2(5),
    constraint PK_PHANCONG primary key (MAGV, MAHP, HK, NAM, MACT)
);

create table DANGKY (
    MASV varchar2(9),
    MAGV varchar2(9),
    MAHP varchar2(9),
    HK int,
    NAM date,
    MACT varchar2(5),
    DIEMTH float check (DIEMTH >= 0 and DIEMTH <= 10),
    DIEMQT float check (DIEMQT >= 0 and DIEMQT <= 10),
    DIEMCK float check (DIEMCK >= 0 and DIEMCK <= 10),
    DIEMTK float check (DIEMTK >= 0 and DIEMTK <= 10),
    constraint PK_DANGKY primary key (MASV, MAGV, MAHP, HK, NAM, MACT)
);

--Ràng buộc khóa ngoại--
alter table NHANSU add constraint 
    FK_NHANSU_DONVI foreign key (MADV) references DONVI(MADV);

alter table DONVI add constraint
    FK_DONVI_NHANSU foreign key (TRGDV) references NHANSU(MANV);
    
alter table HOCPHAN add constraint
    FK_HOCPHAN_DONVI foreign key (MADV) references DONVI(MADV);

alter table KHMO add constraint 
    FK_KHMO_HOCPHAN foreign key (MAHP) references HOCPHAN(MAHP);
    
alter table PHANCONG add constraint
    FK_PHANCONG_NHANSU foreign key (MAGV) references NHANSU(MANV);
alter table PHANCONG add constraint    
    FK_PHANCONG_KHMO foreign key (MAHP, HK, NAM, MACT) references KHMO(MAHP, HK, NAM, MACT);

alter table DANGKY add constraint
    FK_DANGKY_SINHVIEN foreign key (MASV) references  SINHVIEN(MASV);
alter table DANGKY add constraint
    FK_DANGKY_PHANCONG foreign key (MAGV, MAHP, HK, NAM, MACT) references PHANCONG(MAGV, MAHP, HK, NAM, MACT);

--Tạo vai trò--
create role rl_NhanVienCoBan;
create role rl_GiangVien;
create role rl_GiaoVu;
create role rl_TruongDonVi;
create role rl_TruongKhoa;
create role rl_SinhVien;