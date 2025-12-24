# 🎨 DỰ ÁN MÔ PHỎNG ỨNG DỤNG PAINT CỦA WINDOWS – IT008

## 👨‍🎓 Lời cảm ơn đến ThS. Võ Tuấn Kiệt

Lời đầu tiên, nhóm em xin gửi lời cảm ơn chân thành và sâu sắc nhất của nhóm chúng em đến thạc sĩ Võ Tuấn Kiệt đã đồng hành, hướng dẫn nhóm em trong suốt quá trình học tập ở trường.

Trong suốt quá trình trình học tập và trao đổi, nhờ có sự định hướng về tư duy lập trình và những góp ý quý báu của thầy về việc nên chọn những chủ đề nào để đề tài của nhóm em sẽ có nhiều ứng dụng, giúp cho việc nghiên cứu sau này của nhóm, nhóm em đã quyết định sẽ chọn "Paint" sẽ là chủ đề của nhóm mình và sẽ là "đứa con tinh thần" của toàn nhóm. Với chủ đề mình đã chọn, nhóm em không chỉ tìm tòi ra được cách tạo ra các công cụ vẽ hình đơn giản mà còn tìm hiểu thêm được nhiều kiến thức về quản lý bộ nhớ trong GDI+, cách tạo ra các con trỏ cho từng công cụ mình đã chọn, và đặc biệt là kỹ thuật tối ưu hóa thuật toán như Flood fill để tạo nên 1 công cụ mà nhóm em tâm đắc nhất: FillBucket

Dù đã có nhiều cố gắng để hoàn thiện đồ án một cách tốt nhất, nhưng do kiến thức còn hạn chế, chắc chắn sản phẩm không tránh khỏi những thiếu sót. Chúng em rất mong tiếp tục nhận được những ý kiến đóng góp của thầy để kiến thức của chúng em ngày càng hoàn thiện hơn.

Một lần nữa, nhóm em xin kính chúc thầy sẽ có thật nhiều sức khỏe, hạnh phúc và có thêm nhiều thành công nữa trong tương lai sắp tới của mình!

Trân trọng,
## 🧑‍🏫 Giới thiệu đồ án và sơ lược chức năng
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
