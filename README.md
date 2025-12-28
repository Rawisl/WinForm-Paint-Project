# 🎨 DỰ ÁN MÔ PHỎNG ỨNG DỤNG PAINT CỦA WINDOWS – IT008

## 👨‍🎓 Lời cảm ơn đến ThS. Võ Tuấn Kiệt

Lời đầu tiên, nhóm em xin gửi lời cảm ơn chân thành và sâu sắc nhất của nhóm chúng em đến thạc sĩ Võ Tuấn Kiệt đã đồng hành, hướng dẫn nhóm em trong việc thực hiện đồ án ở môn học này.

Trong quá trình trình học tập và trao đổi, nhờ có sự định hướng về tư duy lập trình và những góp ý quý báu của thầy, nhóm em đã quyết định sẽ chọn "Paint" là chủ đề và sẽ là "đứa con tinh thần" của cả nhóm.

Với chủ đề mình đã chọn, nhóm em không chỉ học được cách tạo ra các công cụ vẽ hình đơn giản mà còn được tìm hiểu thêm được nhiều kiến thức về quản lý bộ nhớ trong GDI+, cách tạo ra các con trỏ cho từng công cụ mình đã chọn, và đặc biệt là tạo nên 1 công cụ mà nhóm em tâm đắc nhất: FillBucket.

Và sau cùng, nhóm em xin kính chúc thầy sẽ có thật nhiều sức khỏe và có thêm nhiều thành công nữa trong tương lai sắp tới của mình!

Trân trọng,
## 🧑‍🏫 Giới thiệu đồ án và sơ lược chức năng
- Đồ án này tập trung phát triển một phần mềm hỗ trợ vẽ kỹ thuật số 2D, mô phỏng lại phần mềm MS Paint truyền thống.
- Ứng dụng mô phỏng lại bộ công cụ vẽ truyền thống (như bút, tẩy, bảng màu) lên môi trường máy tính thông qua một giao diện thân thiện.
- Thông qua đồ án này, nhóm không chỉ tạo ra một sản phẩm có tính ứng dụng thực tế mà còn thể hiện khả năng tổ chức, quản lý dữ liệu và xử lý các tương tác đồ họa trong lập trình phần mềm.
## 📚 Ngôn ngữ sử dụng, công cụ tham khảo 
### Ngôn ngữ sử dụng
- Ngôn ngữ lập trình chính được sử dụng là C# (C-Sharp), kết hợp với nền tảng Windows Forms (WinForms) trên .NET Framework 4.8
- C# được sử dụng trong đồ án này vì:
  - là ngôn ngữ tiêu chuẩn được giảng dạy tại các trường đại học để làm quen với phát triển ứng dụng giao diện người dùng (GUI) trên Windows
  - C# cung cấp namespace System.Drawing, cho phép tương tác trực tiếp với các đối tượng đồ họa như Bitmap, Graphics, Pen, Brush. Điều này cực kỳ phù hợp để xây dựng các chức năng vẽ như bút chì, cọ vẽ, hình học
  - C# cho phép gọi các hàm từ thư viện hệ thống Windows (user32.dll) để tùy biến con trỏ chuột – một tính năng mà không phải ngôn ngữ nào cũng hỗ trợ dễ dàng (trong thư mục CursorManager.cs)
## Công cụ tham khảo
- Phần mềm Paint của Microsoft
- Phần mềm Word của Microsoft
- Phần mềm Adobe Photoshop
- Phần mềm Snipping Tool của Windows

## 👨‍👦‍👦Thành viên và thành phần phụ trách
### Trần Thị Hoài Ngọc - Team Leader & System Architect
### Lê Nguyễn Hữu Khang - UI/UX & Text Engine Developer
### Phạm Minh Đức - Graphics Logic & Algorithms Developer

## 📸 Screenshots
<img width="1371" height="765" alt="Paint 19_12_2025 11_18_31 SA" src="https://github.com/user-attachments/assets/e2a2f6c7-c2ab-499c-90d9-8e87421fad7e" />
