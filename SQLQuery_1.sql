
IF EXISTS (SELECT * FROM sys.databases WHERE Name LIKE 'Example5')
DROP DATABASE Example5
GO 
CREATE DATABASE Example5
GO 
USE Example5
GO 

--Tạo bảng lớp học
CREATE TABLE LopHoc(
    MaLopHoc INT PRIMARY KEY IDENTITY,
    TenLopHoc VARCHAR(10)
)
GO
SELECT * FROM Lophoc
GO
INSERT INTO LopHoc(TenLopHoc) VALUES ('T2205E')
SELECT * FROM Lophoc
UPDATE LopHoc SET TenLopHoc = 'T2209A1' WHERE MaLopHoc = 1
DELETE FROM LopHoc WHERE MaLopHoc = 1
GO 
--SanPham(masp, tensp, gia, loai)

--Tạo bảng Sinh vien có khoá ngoại là cột MaLopHoc, nối với bảng LopHoc
CREATE TABLE SinhVien(
    MaSV int PRIMARY KEY,
    TenSV varchar(40),
    MaLopHoc int,
    CONSTRAINT fk FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc)
)
GO
INSERT INTO SinhVien(MaSV, TenSV, MaLopHoc) VALUES (5,'Minh', 1);
INSERT INTO SinhVien(MaSV, TenSV, MaLopHoc) VALUES (3,'Hoa', 2);
INSERT INTO SinhVien(MaSV, TenSV, MaLopHoc) VALUES (14,'Minh', 8), (16, 'Linh', 3);
SELECT * FROM SinhVien
SELECT * FROM Lophoc
GO
--Category(id, name) id la PK
--Product(id, name, price, cat_id) id la PK, cat_id la FK

create table category (id int primary key, name varchar(20))
create table Produce (id int, name varchar(40), cat_id int,
constraint fk2 foreign key (cat_id) references category(id))
insert into category(id, name) values (1, 'Ha noi')
insert into category(id, name) values (2, 'cty')
insert into produce(id, name, cat_id) values (2, 'May rua bat', 1)
insert into produce(id, name, cat_id) values (2, 'May lau nha', 2)
insert into produce(id, name, cat_id) values (5, 'May ru ngu', 1)
select * from category
select * from Produce

--Tao bang SanPham voi mot cot NULL, mot cot NOT NULL
DROP TABLE SanPham
GO
CREATE TABLE SanPham(
    MaSP int NOT NULL,
    TenSP varchar(40) NULL
)
GO
INSERT INTO SanPham(MaSP, TenSP) VALUES (1, 'Laptop')
GO
INSERT INTO SanPham(TenSP) VALUES ('Laptop2')
GO
INSERT INTO SanPham(MaSP) VALUES (2)
GO
SELECT * FROM SanPham

--Tạo bảng với thuộc tính default cho cột Price
CREATE TABLE StoreProduct(
    ProductID int NOT NULL,
    Name varchar(40) NOT NULL,
    Price money NOT NULL DEFAULT (100)
)
GO

--Thử kiểm tra xem giá trị default có dược sử dụng hay không
INSERT INTO StoreProduct(ProductID, Name) VALUES (111, 'Rivets')
GO
INSERT INTO StoreProduct VALUES (1, 'Mac', 101)
GO
SELECT * FROM StoreProduct
GO
--Tao bang ContactPhone voi thuoc tinh IDENTITY
CREATE TABLE ContactPhone(
    Person_ID int IDENTITY(500,10) NOT NULL,
    MobileNumber bigint NOT NULL
)
GO
INSERT INTO ContactPhone VALUES (984123123);
INSERT INTO ContactPhone VALUES (984123124);
GO
SELECT * FROM ContactPhone
GO
--Tạo cột nhận dạng duy nhất tổng thể
DROP TABLE CellularPhone
GO
CREATE TABLE CellularPhone(
    Person_ID uniqueidentifier DEFAULT NEWID() NOT NULL,
    PersonName varchar(60) NOT NULL
)

--Chèn một record vào
INSERT INTO CellularPhone(PersonName) VALUES('William Smith')
GO
SELECT * FROM CellularPhone
GO
--Kiểm tra giá trị của cột Person_ID tự động sinh
SELECT * FROM CellularPhone
GO

--Tao bang ContactPhone voi cot MobilePhone co thuoc tinh UNIQUE
CREATE TABLE ContactPhone2 (
    Person_ID int PRIMARY KEY,
    MobileNumber bigint UNIQUE,
    ServiceProvider varchar(30),
    LandlineNumber bigint UNIQUE
)

--Chèn 2 bản ghi có giá trị giống nhau ở cột MobilePhone và lanlieNumber dẻ quan sát lỗi
INSERT INTO ContactPhone2 values (101, 983345674, 'Hutch', NULL)
INSERT INTO ContactPhone2 values (102, 983345674, 'Alex', 98332211)
INSERT INTO ContactPhone2 values (102, 983345674, 'Alex', 98332211)
GO
SELECT * FROM ContactPhone2
GO
--tao bang PhoneExpenses có một CHECK ở cột Amount
DROP TABLE PhoneExpenses
GO
CREATE TABLE PhoneExpenses(
    Expense_ID int PRIMARY KEY,
    MobileNumber bigint FOREIGN KEY REFERENCES ContactPhone2 (MobileNumber),
    Amount bigint CHECK (Amount > 0)
)
GO
--Test...
INSERT INTO PhoneExpenses(Expense_ID, MobileNumber, Amount)
VALUES (1,983345674, 10)
GO
--Test PRIMARY KEY...
INSERT INTO PhoneExpenses(Expense_ID, MobileNumber, Amount)
VALUES (1,983345674, 10)
GO
--TEST FOREIGN KEY...
INSERT INTO PhoneExpenses(Expense_ID, MobileNumber, Amount)
VALUES (2,9999, 10)
GO
--TEST CHECK...
INSERT INTO PhoneExpenses(Expense_ID, MobileNumber, Amount)
VALUES(2,983345674, -2)
GO 
SELECT * FROM PhoneExpenses
GO
--CHỉnh sửa cột trong bảng
ALTER TABLE ContactPhone2
    ALTER COLUMN ServiceProvider varchar(45)
GO
SELECT * FROM ContactPhone2
GO

--Xoá cột trong bảng
ALTER TABLE ContactPhone2
    DROP COLUMN ServiceProvider
GO

--Thêm một ràng buộc vào bảng
ALTER TABLE StoreProduct
    ADD CONTRAINT CHECK_PICE CHECK (Price >= 10)
GO
SELECT * FROM StoreProduct
GO

--Xoá một ràng buộc
ALTER TABLE StoreProduct
    DROP CONTRAINT CHECK_PICE


CREATE TABLE student
(rollNumber INT,
name VARCHAR(30),
class VARCHAR(30),
section VARCHAR(1),
mobile VARCHAR(10),
PRIMARY KEY(rollNumber, mobile));

INSERT INTO student(rollNumber, name, class, section, mobile)
VALUES (1, 'AMAN', 'FOURTH', 'B', '9988774455');
INSERT INTO student(rollNumber, name, class, section, mobile)
VALUES (2, 'JOHN', 'FIRST', 'A', '9988112233');
INSERT INTO student(rollNumber, name, class, section, mobile)
VALUES (3, 'Viet', 'Truong', 'B', '9988777755');
INSERT INTO student(rollNumber, name, class, section, mobile)
VALUES (4, 'Viet', 'Cong', 'c', '9955663322');



