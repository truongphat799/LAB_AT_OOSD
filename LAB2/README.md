# XÂY DỰNG HỆ THỐNG THƯ VIỆN TRỰC TUYẾN

## 1. Giới thiệu

Đề tài xây dựng hệ thống thư viện trực tuyến phục vụ giảng viên, sinh viên và cán bộ trong trường. Hệ thống hỗ trợ tìm kiếm, tra cứu tài liệu, đọc và tải tài liệu điện tử, đăng ký mượn sách, quản lý việc mượn - trả sách và các nghiệp vụ quản lý thư viện.

Hệ thống được phân tích và thiết kế theo phương pháp hướng đối tượng, kết hợp mô hình hóa bằng UML và xây dựng cơ sở dữ liệu trên SQL Server.

---

## 2. Mục tiêu của bài Lab

Bài Lab nhằm thực hiện các công việc:

- Khảo sát và phân tích nghiệp vụ của hệ thống thư viện.
- Xác định các tác nhân và yêu cầu chức năng.
- Xây dựng Use Case Diagram.
- Xây dựng Activity Diagram.
- Xây dựng Sequence Diagram.
- Xác định các lớp và mối quan hệ giữa các lớp.
- Thiết kế giao diện mẫu cho hệ thống.
- Thiết kế cơ sở dữ liệu SQL Server.
- Tạo các bảng, khóa chính, khóa ngoại và ràng buộc dữ liệu.
- Thêm dữ liệu mẫu để kiểm tra cơ sở dữ liệu.

---

# 3. Chức năng của hệ thống

Hệ thống gồm hai nhóm người dùng chính:

### 3.1. Độc giả

Độc giả có thể:

- Đăng ký tài khoản.
- Đăng nhập hệ thống.
- Tìm kiếm tài liệu.
- Xem thông tin tài liệu.
- Đọc tài liệu điện tử.
- Tải tài liệu điện tử.
- Nhập mã thẻ thư viện khi tải tài liệu.
- Đăng ký mượn sách.
- Xem các sách đang mượn.
- Xem tình trạng mượn sách.
- Gửi yêu cầu đặt mua tài liệu điện tử.

### 3.2. Thủ thư

Thủ thư có thể:

- Đăng nhập hệ thống quản lý.
- Quản lý độc giả.
- Quản lý thẻ độc giả.
- Quản lý sách.
- Quản lý thể loại.
- Quản lý nhà xuất bản.
- Quản lý tài liệu điện tử.
- Quản lý phiếu mượn.
- Quản lý trả sách.
- Theo dõi sách đang được mượn.
- Theo dõi sách quá hạn.
- Lập phiếu phạt.
- Xử lý yêu cầu đặt mua tài liệu.
- Xem báo cáo và thống kê.

### 3.3. Hệ thống

Hệ thống thực hiện:

- Kiểm tra thông tin đăng nhập.
- Kiểm tra thông tin độc giả.
- Kiểm tra tình trạng thẻ.
- Kiểm tra số lượng sách còn lại.
- Kiểm tra điều kiện mượn sách.
- Lưu lịch sử đọc và tải tài liệu điện tử.
- Theo dõi thời hạn trả sách.
- Gửi email nhắc trả sách trước hạn.

---

# 4. Phân tích yêu cầu

## 4.1. Các tác nhân

Các tác nhân chính của hệ thống:

| STT | Tác nhân | Mô tả |
|-----|----------|-------|
| 1 | Độc giả | Sinh viên, giảng viên và cán bộ sử dụng thư viện |
| 2 | Thủ thư | Quản lý sách, độc giả và các nghiệp vụ thư viện |
| 3 | Hệ thống | Xử lý tự động các nghiệp vụ và kiểm tra dữ liệu |

---

# 5. Danh sách Use Case

| Mã | Use Case | Mô tả |
|----|----------|-------|
| UC01 | Đăng ký tài khoản | Độc giả tạo tài khoản sử dụng hệ thống |
| UC02 | Đăng nhập | Người dùng đăng nhập vào hệ thống |
| UC03 | Tìm kiếm tài liệu | Tìm kiếm sách và tài liệu |
| UC04 | Xem thông tin tài liệu | Xem thông tin chi tiết của tài liệu |
| UC05 | Đọc tài liệu điện tử | Đọc tài liệu trực tuyến |
| UC06 | Tải tài liệu điện tử | Tải tài liệu về máy |
| UC07 | Đăng ký mượn sách | Độc giả đăng ký mượn sách giấy |
| UC08 | Đặt mua tài liệu | Gửi yêu cầu thư viện mua tài liệu |
| UC09 | Quản lý mượn sách | Thủ thư quản lý phiếu mượn |
| UC10 | Quản lý trả sách | Thủ thư xử lý việc trả sách |
| UC11 | Xem sách đang mượn | Xem danh sách sách đang được mượn |
| UC12 | Xem sách quá hạn | Kiểm tra các sách quá hạn |
| UC13 | Quản lý tài liệu | Thêm, sửa, xóa và cập nhật tài liệu |
| UC14 | Xử lý yêu cầu đặt mua | Thủ thư duyệt hoặc từ chối yêu cầu |
| UC15 | Báo cáo thống kê | Thống kê tình hình thư viện |
| UC16 | Gửi email nhắc trả | Hệ thống gửi email nhắc độc giả |

---

# 6. Mô hình hóa UML

Trong bài Lab đã thực hiện các sơ đồ UML phục vụ phân tích và thiết kế hệ thống.

## 6.1. Use Case Diagram

Use Case Diagram mô tả các chức năng chính của hệ thống và mối quan hệ giữa tác nhân với các chức năng.

Các tác nhân chính:

- Độc giả
- Thủ thư

Các nhóm chức năng:

- Quản lý tài khoản.
- Tra cứu tài liệu.
- Đọc và tải tài liệu điện tử.
- Mượn và trả sách.
- Quản lý tài liệu.
- Xử lý yêu cầu đặt mua.
- Báo cáo thống kê.

---

## 6.2. Activity Diagram

Đã thiết kế các Activity Diagram cho các nghiệp vụ chính:

1. Đăng ký tài khoản.
2. Đăng nhập.
3. Tìm kiếm và xem thông tin tài liệu.
4. Đọc và tải tài liệu điện tử.
5. Đăng ký mượn sách.
6. Trả sách.
7. Đặt mua tài liệu.
8. Quản lý tài liệu.
9. Xem sách đang mượn.
10. Xem sách quá hạn.
11. Báo cáo và thống kê.
12. Gửi email nhắc trả sách.

Các Activity Diagram được thiết kế theo mô hình Swimlane gồm:

```text
ĐỘC GIẢ | THỦ THƯ | HỆ THỐNG

