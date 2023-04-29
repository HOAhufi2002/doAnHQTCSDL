use master
go
sp_addlogin 'hoanv','1'
go
sp_addlogin 'mannv','2005'
go
sp_addlogin 'hac','1'
go
--TẠO USER
use qlcf_tthqt
go
sp_adduser'hoanv','hoanv'
go
sp_adduser'mannv','mannv'
go
sp_adduser 'hac','hac'
--HỦY USER 
go
sp_dropuser 'hoanv'
--CẤP QUYỀN USER RIÊNG LẺ
-- NHÂN VIÊN
-- xem bảng nhân viên 
grant execute on hienthinhanvien to hoanv
grant execute on danhmucsp to hoanv
grant execute on cbboxgt to hoanv
grant execute on cbboxcv to hoanv

-- xem bảng loại
grant execute on  cbboxloai to hoanv 
go
grant select on loai to hoanv
-- xem bảng sản phẩm
grant select on nhanvien to hoanv
--  thu hồi xem ds hóa đơn (doanh thu)
revoke execute on DS_HOADON to hoanv
revoke execute on TIMKIEM_NGAY to hoanv
--  dịch vụ xem chi tiết hóa đơn
go
grant execute on DS_CTHD to hoanv
-- dịch vụ hiện thỉ cbb sản phẩm
grant execute on DS_SP to hoanv
--  dịch vụ nhân viên được thêm cthd
grant execute on THEM_CTHD to hoanv
-- dịch vụ nhân viên được lưu dữ liệu xuống csdl 
grant execute on DS_ALL_CTHD to hoanv
-- dịch vụ nhân viên được cập nhật tổng tiền
grant execute on CAPNHAT_TONGTIEN to hoanv
-- nhân viên load cbb tên nv 
grant execute on TT_NHANVIEN to hoanv
-- nhân viên load cbb bàn
grant execute on  DS_BAN to hoanv
-- nhân viên được thêm hóa đơn
grant execute on  THEM_HD to hoanv
-- hiển thị tổng sp 
grant execute on tongsp to hoanv
-----------------------------------------------------
--TẠO NHÓM QUYỀN NHÂN VIÊN
go
sp_addrole 'NhanVien'
--xem bảng nhân viên 
grant execute on hienthinhanvien to NhanVien
go
grant execute on danhmucsp to NhanVien
go
grant execute on cbboxgt to NhanVien
go
grant execute on cbboxcv to NhanVien
go
-- xem bảng loại
grant execute on  cbboxloai to NhanVien 
go
grant select on loai to NhanVien
go
-- xem bảng sản phẩm
grant select on nhanvien to NhanVien
go
--  dịch vụ xem chi tiết hóa đơn
go
grant execute on DS_CTHD to NhanVien
-- dịch vụ hiện thỉ cbb sản phẩm
grant execute on DS_SP to NhanVien
--  dịch vụ nhân viên được thêm cthd
grant execute on THEM_CTHD to NhanVien
-- dịch vụ nhân viên được lưu dữ liệu xuống csdl 
grant execute on DS_ALL_CTHD to NhanVien
-- dịch vụ nhân viên được cập nhật tổng tiền
grant execute on CAPNHAT_TONGTIEN to NhanVien
-- nhân viên load cbb tên nv 
grant execute on TT_NHANVIEN to NhanVien
-- nhân viên load cbb bàn
grant execute on  DS_BAN to NhanVien
-- nhân viên được thêm hóa đơn
grant execute on  THEM_HD to NhanVien
-- hiển thị tổng sp 
grant execute on tongsp to NhanVien
--  thu hồi xem ds hóa đơn (doanh thu)
revoke execute on DS_HOADON to NhanVien
revoke execute on TIMKIEM_NGAY to NhanVien
----------------------------------------------
--THÊM NHÂN VIÊN mannv VÀO NHÓM QUYỀN
go
sp_addrolemember 'NhanVien','mannv'
--XÓA NHÂN VIÊN mannv KHỎI NHÓM QUYỀN
go
sp_droprolemember 'NhanVien','mannv'
