CREATE DATABASE QLNS
GO
USE QLNS
GO
-- Cột TrPhong phải có cùng kiểu dữ liệu với cột MaNV trong bảng NHANVIEN
CREATE TABLE dbo.PHONGBAN(
	MaPB char(10) PRIMARY KEY,
	TenPB char(10) NULL,
	TrPhong char(4) NULL,
	NgNhanChuc date NULL,
	DiaDiem char(50) NULL
)

Create Table HOPDONG(
	MaHD char(10) primary key,
	ThoiHan int,
	ViTri char(30),
	MoTa char(100) NULL,
	)

Insert into HOPDONG Values ('HD01', 2, 'IT Helpdesk', 'IT Helpdesk Descriptions...')
Insert into HOPDONG Values ('HD02', 2, 'Thuc tap', 'Intern Descriptions...')
Insert into HOPDONG Values ('HD03', 2, 'Quan ly su kien', 'Event Handler Descriptions...')
Insert into HOPDONG Values ('HD04', 2, 'Quan ly kho', 'Store Manager Descriptions...')
Insert into HOPDONG Values ('HD05', 2, 'Ke toan', 'Accountant Descriptions...')
Insert into HOPDONG Values ('HD06', 2, 'Truyen thong', 'Marketing Descriptions...')
Insert into HOPDONG Values ('HD07', 2, 'Quan tri nhan su', 'HR Descriptions...')
Insert into HOPDONG Values ('HD08', 2, 'Quan tri mang', 'Network Supervisor Descriptions...')
Insert into HOPDONG Values ('HD09', 2, 'Phu trach ngoai giao', 'Communicado Descriptions...')
Insert into HOPDONG Values ('HD10', 2, 'Phat trien san pham', 'Software Developer Descriptions...')
Insert into HOPDONG Values ('HD11', 2, 'Bao ve', 'Security Descriptions...')
Insert into HOPDONG Values ('HD12', 2, 'Luat su', 'Attorney Descriptions...')

GO
-- Tạo cấu trúc bảng Nhân viên
-- Cột MaNQL là khóa ngoại tham chiếu đến cột MaNV cũng trong bảng này. Nhưng ta chưa tạo khóa ngoại lúc này để dễ nhập data
-- Khi nhập dữ liệu xong sẽ khai báo thêm khóa ngoại
-- Cột MaNQL phải có cùng kiểu dữ liệu với cột MaNV
-- Cột Phong phải có cùng kiểu dữ liệu với cột MaPB trong bảng PHONGBAN
CREATE TABLE dbo.NHANVIEN(
	MaNV char(10) PRIMARY KEY,
	MaHD char(10) references HOPDONG(MaHD),
	HotenNV nvarchar(50) NULL,
	NgSinh date NULL,
	Dchi nvarchar(50) NULL,
	Phai nvarchar(5) NULL,
	MaNQL char(10) NULL,
	Phong char(10),
	Hinh nvarchar(300) NULL
)

Go
-- Nhập giá trị vào bảng Nhân viên, nhập theo đúng thứ tự các thuộc tính trong bảng
-- Chú ý Nhập giá trị trong cột MaNQL phải là các giá trị có trong cột MaNV
Insert into NHANVIEN Values ('NV01', 'HD01', 'Nguyen Ngọc Hoang', '1972-08-13', '111 Vo Van Ngan', 'Nam',  'NV02', 'PB01', NULL)
Insert into NHANVIEN Values ('NV02', 'HD03', 'Nguyen Quang Ngoc', '1975-08-23', '111 Nguyen Van Troi', 'Nam',  'NV15', 'PB02' , NULL)
Insert into NHANVIEN Values ('NV03', 'HD02', 'Le Thi Ngọc', '1980-08-13', '111 Duong 3/2', 'Nu',  'NV15', 'PB01', NULL)
Insert into NHANVIEN Values ('NV04', 'HD06', 'Le Ngọc Hoang', '1982-08-18', '111 Le Van Duyet', 'Nam', 'NV03', 'PB02', NULL)
Insert into NHANVIEN Values ('NV05', 'HD11', 'Nguyen Thi Ngọc', '1992-08-13', '108 Vo Van Ngan', 'Nu',  'NV06', 'PB02', NULL)
Insert into NHANVIEN Values ('NV06', 'HD09', 'Truong Anh Kiet', '1960-12-13', '11 Hai Ba Trung', 'Nam', 'NV15', 'PB03', NULL)
Insert into NHANVIEN Values ('NV07', 'HD02', 'Le Phung Hieu', '1972-08-13', '11 Hau Giang', 'Nam','NV15', 'PB02', NULL)
Insert into NHANVIEN Values ('NV08', 'HD02', 'Nguyen Bao Hung', '1978-08-23', '10 Tran Hung Dao', 'Nam',  'NV15', 'PB03', NULL)
Insert into NHANVIEN Values ('NV09', 'HD08', 'Nguyen Bao Hoang', '1972-08-13', '111 Tran Hung Dao', 'Nam',  'NV15', 'PB04', NULL)
Insert into NHANVIEN Values ('NV10', 'HD07', 'Le Hoang Ngọc', '1972-08-13', '11 Lac Long Quan', 'Nam',  'NV15', 'PB04', NULL)
Insert into NHANVIEN Values ('NV11', 'HD04', 'Nguyen Bao Ngọc', '1972-08-13', '111 Minh Phung', 'Nu',  'NV15', 'PB04', NULL)
Insert into NHANVIEN Values ('NV12', 'HD05', 'Nguyen Ngọc A', '1982-08-13', '11 Nguyen Duy Trinh', 'Nam',  'NV11', 'PB02', NULL)
Insert into NHANVIEN Values ('NV13', 'HD10', 'Le Quang Hoang', '1979-08-23', '10 Ly Chinh Thang', 'Nam',  'NV15', 'PB01', NULL)
Insert into NHANVIEN Values ('NV14', 'HD12', 'Nguyen Quang Hoang', '1972-08-13', '11 Le Van Thinh', 'Nam',  'NV13', 'PB02', NULL)
Insert into NHANVIEN Values ('NV15', 'HD01', 'Dang Tan Dung', '1960-08-13', '23 Vo Van Ngan', 'Nam',  NULL, 'PB02', NULL)

Go
-- Nhập giá trị vào bảng PHONGBAN, nhập theo đúng thứ tự các thuộc tính trong bảng
-- Kiểu dữ liệu Date nhập theo dạng: 'YYYY-MM-DD' (Year-Month-Day)
-- Chú ý nhập giá trị cột TrPhong là các giá trị có trong cột MaNV của bảng NHANVIEN
Insert into PHONGBAN Values ('PB01', 'Nghien cuu', 'NV02', '2013-12-12', 'Tang tret - Khu A');
Insert into PHONGBAN Values ('PB02', 'To chuc', 'NV03', '2013-11-21', 'Tang 8 - Khu A');
Insert into PHONGBAN Values ('PB03', 'Vat tu', 'NV06', '2013-1-25', 'Tang 5 - Khu A2');
Insert into PHONGBAN Values ('PB04', 'Dao tao', 'NV15', '2013-2-19', 'Tang ham - Khu trung tam');
Insert into PHONGBAN Values ('PB05', 'Kinh doanh', 'NV15', '2013-08-18', 'Tang 6 - Khu C');
Insert into PHONGBAN Values ('PB06', 'Doi ngoai', 'NV15', '2013-10-17', 'Tang tret - Khu B');
Insert into PHONGBAN Values ('PB07', 'Xay dung', 'NV15', '2013-02-20', 'Tang tret - Khu X');
Insert into PHONGBAN Values ('PB08', 'QL Du an', 'NV11', '2013-12-12', 'Tang 3 - Khu Y');
Insert into PHONGBAN Values ('PB09', 'Ke toan', 'NV13', '2013-12-12', 'Tang 1 - Khu Z');
Insert into PHONGBAN Values ('PB10', 'BGD', 'NV15', '2010-11-29', 'Trung tam bat giac - Khu 0');
Go
-- Thêm hai khóa ngoại cho bảng NhanVien
Alter table NHANVIEN WITH CHECK ADD FOREIGN KEY(MaNQL) REFERENCES NHANVIEN(MaNV)
Go
ALTER TABLE NHANVIEN  WITH CHECK ADD FOREIGN KEY(Phong) REFERENCES PHONGBAN(MaPB)

Go
CREATE TABLE DANGNHAP(
	MaNV char(10) references NHANVIEN(MaNV),
	TenDN char(50) primary key,
	MatKhau char(50) NULL,
)

Go
Insert into DANGNHAP Values ('NV06', 'Admin1', '1234')
Insert into DANGNHAP Values ('NV10', 'Admin2', '12345')


Go
-- Tạo cấu trúc bảng Dự án
-- Cột Phong là khóa ngoại tham chiếu đến cột MaPB bên bảng PhongBan
Create Table DUAN(
	MaDA char(4) primary key,
	TenDA nvarchar(50),
	DiaDiem nvarchar(50),
	Phong char(10) references PHONGBAN(MaPB)
	)
Go
-- Nhập dữ liệu cho bảng DUAN
Insert into DUAN Values ('DA01', 'Cap thoat nuoc', 'Go Vap', 'PB01')
Insert into DUAN Values ('DA02', 'Ban chung cu', 'Thu Thiem', 'PB02')
Insert into DUAN Values ('DA03', 'Xay biet thu', 'Thu Duc', 'PB04')
Insert into DUAN Values ('DA04', 'Lien ket dao tao', 'Go Vap', 'PB03')
Insert into DUAN Values ('DA05', 'Cung cap vat tu', 'Quan 2', 'PB05')
Insert into DUAN Values ('DA06', 'Huan luyen', 'Go Vap', 'PB02')
Go
-- Tạo cấu trúc bảng PHANCONG
-- Cột MaNV tham chiếu đến cột MaNV trong bảng NhanVien nên chúng phải có cùng kiểu dữ liệu
-- Cột MaDA tham chiếu đến cột MaDA trong bảng DUAN nên chúng phải có cùng kiểu dữ liệu
Create Table PHANCONG(
	MaNV char(10) references NHANVIEN(MaNV),
	MaDA char(4) references DUAN(MaDA),
	ThoiGian int,
	Primary key (MaNV, MaDA)
	)
Go
-- Nhập dữ liệu
-- Giá trị trong cột MaNV phải có ở cột MaNV trong bảng NhanVien
-- Giá trị trong cột MaDA phải có ở cột MaDA trong bảng DuAN
Insert into PHANCONG Values ('NV01', 'DA01', 3)
Insert into PHANCONG Values ('NV01', 'DA02', 3)
Insert into PHANCONG Values ('NV02', 'DA01', 3)
Insert into PHANCONG Values ('NV02', 'DA03', 3)
Insert into PHANCONG Values ('NV03', 'DA04', 3)
Insert into PHANCONG Values ('NV04', 'DA03', 3)
Insert into PHANCONG Values ('NV09', 'DA04', 3)
Insert into PHANCONG Values ('NV01', 'DA05', 3)
Insert into PHANCONG Values ('NV05', 'DA05', 3)
Insert into PHANCONG Values ('NV07', 'DA06', 3)
Insert into PHANCONG Values ('NV08', 'DA06', 3)

Go

Create Table THOIVIEC(
	MaNVThoiViec char(10),
	MaHD char(10) references HOPDONG(MaHD),
	NgayThoiViec date NULL,
	LyDo nvarchar(200),
	Primary key (MaNVThoiViec, MaHD)
	)

Go
Create Table THANNHAN(
	MaNV char(10) references NHANVIEN(MaNV),
	HotenTN nvarchar(50) NULL,
	VaiTro nvarchar(20),
	SDT char(15) NULL,
	Primary key (MaNV)
	)

Go

Insert into THANNHAN Values('NV01', 'Nguyen Van A', 'cha', '0721821832')
Insert into THANNHAN Values('NV02', 'Nguyen Thi B', 'me', '0252134125')
Insert into THANNHAN Values('NV03', 'Nguyen Van Hong', 'me', '2353215525')
Insert into THANNHAN Values('NV04', 'Nguyen Doan Tuoc Linh', 'anh trai', '0213892134')
Insert into THANNHAN Values('NV08', 'Ho Quy Ly', 'em trai', '0285923942')
Insert into THANNHAN Values('NV11', 'Dang Thi Nhu Quynh', 'em gai', '9231523867')
Insert into THANNHAN Values('NV15', 'Doan Ly Van', 'ba', '0582182316')

Go
Create Table LUONG(
	MaNV char(10) references NHANVIEN(MaNV),
	LuongCung int,
	NgayNghi int NULL,
	Phucap int NULL,
	TongLuong int NULL,
	Primary key (MaNV)
	)
INSERT INTO LUONG (MaNV, LuongCung, NgayNghi, Phucap, TongLuong) 
VALUES 
('NV01', 6000000, 2, 1000000, NULL),
('NV02', 8000000, 0, 500000, NULL),
('NV03', 7000000, 1, 800000, NULL),
('NV04', 9000000, 3, 1200000, NULL),
('NV05', 6000000, 0, 500000, NULL),
('NV06', 10000000, 2, 1000000, NULL),
('NV07', 10000000, 1, 800000, NULL),
('NV08', 12000000, 0, 500000, NULL),
('NV09', 9000000, 1, 800000, NULL),
('NV10', 15000000, 2, 1000000, NULL),
('NV11', 15000000, 2, 1000000, NULL),
('NV12', 15000000, 2, 1000000, NULL),
('NV13', 15000000, 2, 1000000, NULL),
('NV14', 15000000, 2, 1000000, NULL),
('NV15', 15000000, 2, 1000000, NULL);
