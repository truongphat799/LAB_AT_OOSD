# LAB 3 – Phát triển phần mềm hướng đối tượng

## 1. Thông tin sinh viên

* **Họ và tên:** Trương Gia Phát
* **MSSV:** 
* **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
* **Tên bài Lab:** LAB 3
* **Ngôn ngữ:** C#
* **Loại ứng dụng:** Windows Forms
* **Cơ sở dữ liệu:** Microsoft SQL Server

---

## 2. Môi trường và phiên bản

* **Hệ điều hành:** Windows
* **IDE:** Visual Studio
* **.NET Framework:** 4.7.2
* **Ngôn ngữ lập trình:** C#
* **SQL Server:** Microsoft SQL Server
* **Cơ sở dữ liệu:** `QuanLyKhachSan`
* **SQL Server Instance:** `(localdb)\MSSQLLocalDB`

---

## 3. Nội dung đã thực hiện

Trong LAB 3, em đã xây dựng một phần của hệ thống **Quản lý khách sạn** bằng C# Windows Forms kết hợp với SQL Server.

Các nội dung đã thực hiện:

### 3.1. Kết nối cơ sở dữ liệu

* Xây dựng lớp `Db.cs` để quản lý kết nối SQL Server.
* Sử dụng `ConfigurationManager` để đọc chuỗi kết nối từ `App.config`.
* Xây dựng các phương thức:

  * `OpenConnection()` – mở kết nối cơ sở dữ liệu.
  * `Query()` – thực hiện truy vấn `SELECT`.
  * `Execute()` – thực hiện `INSERT`, `UPDATE`, `DELETE`.
  * `Scalar()` – lấy một giá trị từ cơ sở dữ liệu.

### 3.2. Xây dựng các Service

Đã xây dựng các Service phục vụ xử lý nghiệp vụ:

* `DanhMucService`

  * Quản lý khu vực.
  * Quản lý nhân viên.
  * Quản lý loại tiện nghi.
  * Quản lý dịch vụ.
  * Quản lý quy định đền bù.

* `DatPhongService`

  * Quản lý khách.
  * Quản lý phòng.
  * Quản lý phiếu đặt phòng.
  * Quản lý người lưu trú.
  * Thêm khách.
  * Tạo đặt phòng.
  * Nhận phòng.
  * Xử lý trường hợp khách không đến.

* `TraPhongService`

  * Lấy danh sách phiếu đang ở.
  * Lấy thông tin phòng.
  * Lấy tiện nghi của phòng.
  * Lấy quy định đền bù.
  * Lập phiếu đền bù.
  * Lập hóa đơn.
  * Thanh toán.
  * Trả phòng.

### 3.3. Xây dựng các lớp hỗ trợ

Đã xây dựng một số lớp hỗ trợ xử lý kết quả:

* `KetQuaXuLy.cs`
* `PhongDatItem.cs`
* `DenBuItem.cs`

Các lớp này giúp chuẩn hóa kết quả xử lý nghiệp vụ và truyền dữ liệu giữa Form và Service.

### 3.4. Xây dựng giao diện

Đã xây dựng Form quản lý danh mục:

* `FrmDanhMuc`
* Hiển thị dữ liệu từ cơ sở dữ liệu.
* Thêm khu vực.
* Thêm nhân viên.
* Thêm loại tiện nghi.
* Thêm dịch vụ.
* Thêm quy định đền bù.
* Hiển thị thông báo khi thao tác thành công hoặc thất bại.

---

## 4. Kết quả đạt được

Sau khi hoàn thành LAB 3:

* Kết nối được ứng dụng C# với SQL Server.
* Có thể truy vấn và hiển thị dữ liệu từ cơ sở dữ liệu.
* Có thể thực hiện các thao tác thêm dữ liệu thông qua Service.
* Các nghiệp vụ đặt phòng, nhận phòng, lập hóa đơn, thanh toán và trả phòng đã được xây dựng ở tầng Service.
* Giao diện `FrmDanhMuc` có thể sử dụng Service để tải dữ liệu và thực hiện thêm dữ liệu.
* Chương trình được tổ chức thành các nhóm:

  * `Data`
  * `Services`
  * `Forms`

Cấu trúc chính của project:

```text
QuanLyKhachSan/
│
├── Data/
│   └── Db.cs
│
├── Services/
│   ├── DatPhongService.cs
│   ├── DanhMucService.cs
│   ├── TraPhongService.cs
│   ├── KetQuaXuLy.cs
│   ├── PhongDatItem.cs
│   └── DenBuItem.cs
│
├── Forms/
│   └── FrmDanhMuc.cs
│
├── App.config
└── Program.cs
```

---

## 5. Lỗi gặp phải

Trong quá trình thực hiện LAB 3, em gặp một số lỗi:

### Lỗi 1: Code bị sai định dạng sau khi sao chép

Một số câu lệnh C# bị xuống dòng không đúng vị trí, gây khó đọc và có thể phát sinh lỗi biên dịch.

### Lỗi 2: Thiếu lớp hỗ trợ

Một số Service sử dụng các lớp:

```text
KetQuaXuLy
PhongDatItem
DenBuItem
```

nhưng các lớp này chưa được tạo.

### Lỗi 3: Tên Control trên Form không đồng nhất

Trong `FrmDanhMuc`, phần xử lý nghiệp vụ sử dụng các Control như:

```text
dgvKhu
dgvNV
dgvLoaiTN
dgvDV
dgvQD
txtKhuMa
txtKhuTen
cboQDLoai
numDVGia
numQDTien
```

trong khi phần Designer ban đầu lại sử dụng tên mặc định như:

```text
dataGridView1
button1
button2
...
```

Điều này gây lỗi khi biên dịch hoặc khi chạy chương trình.

### Lỗi 4: Lỗi kết nối cơ sở dữ liệu

Ứng dụng phụ thuộc vào chuỗi kết nối trong `App.config`. Nếu tên database hoặc tên ConnectionString không chính xác thì chương trình không thể kết nối SQL Server.

---

## 6. Cách khắc phục

### Đối với lỗi code

Định dạng lại các file `.cs`, kiểm tra lại:

* `using`
* `namespace`
* dấu `{ }`
* tên class
* tên phương thức.

### Đối với lớp bị thiếu

Bổ sung các lớp:

```text
KetQuaXuLy.cs
PhongDatItem.cs
DenBuItem.cs
```

vào thư mục:

```text
Services/
```

### Đối với lỗi Control

Đặt tên các Control trong Windows Forms Designer trùng với tên được sử dụng trong code, ví dụ:

```text
dgvKhu
dgvNV
dgvLoaiTN
dgvDV
dgvQD
```

và:

```text
btnThemKhu
btnThemNV
btnThemLoaiTN
btnThemDV
btnThemQD
btnDong
```

### Đối với lỗi database

Kiểm tra file `App.config`:

```xml
<connectionStrings>
    <add name="QuanLyKhachSanDB"
         connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Đảm bảo SQL Server LocalDB có database:

```text
QuanLyKhachSan
```

---

## 7. Hướng dẫn giảng viên kiểm tra và chạy lại

### Bước 1: Mở project

Mở file Solution của project bằng:

```text
Visual Studio
```

Sau đó chọn project:

```text
QuanLyKhachSan
```

### Bước 2: Kiểm tra SQL Server

Mở SQL Server Management Studio hoặc công cụ quản lý SQL Server và kết nối:

```text
(localdb)\MSSQLLocalDB
```

Kiểm tra database:

```text
QuanLyKhachSan
```

đã tồn tại.

### Bước 3: Kiểm tra cấu hình

Mở:

```text
App.config
```

Kiểm tra ConnectionString có tên:

```text
QuanLyKhachSanDB
```

và database:

```text
QuanLyKhachSan
```

### Bước 4: Build project

Trong Visual Studio chọn:

```text
Build → Rebuild Solution
```

Đảm bảo project không còn lỗi biên dịch.

### Bước 5: Chạy chương trình

Nhấn:

```text
F5
```

hoặc:

```text
Debug → Start Debugging
```

### Bước 6: Kiểm tra chức năng

Có thể kiểm tra theo thứ tự:

1. Mở chương trình.
2. Kiểm tra kết nối cơ sở dữ liệu.
3. Mở chức năng quản lý danh mục.
4. Kiểm tra dữ liệu khu vực.
5. Kiểm tra dữ liệu nhân viên.
6. Kiểm tra loại tiện nghi.
7. Kiểm tra dịch vụ.
8. Kiểm tra quy định đền bù.
9. Thử thêm một dữ liệu mới.
10. Kiểm tra dữ liệu được cập nhật trên DataGridView.

---

## 8. Kết luận

LAB 3 đã hoàn thành các nội dung cơ bản về xây dựng ứng dụng quản lý khách sạn bằng **C# Windows Forms**, kết nối với **SQL Server** và tổ chức xử lý nghiệp vụ thông qua các lớp Service.

Các chức năng chính đã được xây dựng và có thể tiếp tục mở rộng trong các Lab tiếp theo.

