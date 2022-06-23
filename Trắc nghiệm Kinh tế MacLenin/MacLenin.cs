using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trắc_nghiệm_Kinh_tế_MacLenin
{
  public partial class MacLenin : Form
  {
    private int numCauHoi = 0;
    private static Random randomCauHoi = new Random();
    private string DapAn = "Z";
    private string DapAnDaChon = "Z";
    //---Chương 1--- 1->11
    //---Chương 2--- 11->51
    //---Chương 3--- 51->130
    //---Chương 4--- 131->156
    //---Chương 5--- 156->271
    //---Chương 6--- 271->301
    private int CauBatDau, CauKetThuc;
    public MacLenin()
    {
      InitializeComponent();
    }

    private void MacLenin_Load(object sender, EventArgs e)
    {
      CauBatDau = Convert.ToInt32(textBox_BatDau.Text);
      CauKetThuc = Convert.ToInt32(textBox_KetThuc.Text) + 1;
      numCauHoi = randomCauHoi.Next(CauBatDau, CauKetThuc);
      CauHoi();
      radioButtonA.Checked = false;
      radioButtonB.Checked = false;
      radioButtonC.Checked = false;
      radioButtonD.Checked = false;
    }

    private void button_XacNhan_Click(object sender, EventArgs e)
    {
      if(radioButtonA. Checked)
      {
        DapAnDaChon = "A";
      }
      else if (radioButtonB. Checked)
      {
        DapAnDaChon = "B";
      }
      else if (radioButtonC. Checked)
      {
        DapAnDaChon = "C";
      }
      else if (radioButtonD.Checked)
      {
        DapAnDaChon = "D";
      }
      if (DapAnDaChon == DapAn)
      {
        label_DapAn.Text = "Đáp án đúng";
        label_DapAn.ForeColor = Color.LightGreen;
      }
      else
      {
        label_DapAn.Text = "Sai, đáp án đúng là: " + DapAn;
        label_DapAn.ForeColor = Color.Red;
      }
    }
    private void button_CauTiep_Click(object sender, EventArgs e)
    {
      CauBatDau = Convert.ToInt32(textBox_BatDau.Text);
      CauKetThuc = Convert.ToInt32(textBox_KetThuc.Text) + 1;
      numCauHoi = randomCauHoi.Next(CauBatDau, CauKetThuc);
      CauHoi();
      label_DapAn.Text = "";
      radioButtonA.Checked = false;
      radioButtonB.Checked = false;
      radioButtonC.Checked = false;
      radioButtonD.Checked = false;
    }
    private void CauHoi()
    {
      //---Chương 1---
      if (numCauHoi == 1)
      {
        label_De.Text = "Thuật ngữ 'kinh tế - chính trị' được sử dụng lần đầu tiên vào năm nào?";
        radioButtonA.Text = "A. " + "1610";
        radioButtonB.Text = "B. " + "1612";
        radioButtonC.Text = "C. " + "1615";
        radioButtonD.Text = "D. " + "1618";
        DapAn = "C";
      }
      else if (numCauHoi == 2)
      {
        label_De.Text = "Ai là người đầu tiên đưa ra khái niệm 'kinh tế - chính trị'?";
        radioButtonA.Text = "A. " + "Antoine Montchretiên";
        radioButtonB.Text = "B. " + "Francois Quesney";
        radioButtonC.Text = "C. " + "Tomas Mun";
        radioButtonD.Text = "D. " + "William Petty";
        DapAn = "A";
      }
      else if (numCauHoi == 3)
      {
        label_De.Text = "Ai là người được C.Mác coi là sáng lập ra kinh tế chính trị tư sản cổ điển?";
        radioButtonA.Text = "A. " + "A.Smith";
        radioButtonB.Text = "B. " + "D.Ricardo";
        radioButtonC.Text = "C. " + "W.Petty";
        radioButtonD.Text = "D. " + "R.T.Mathus";
        DapAn = "C";
      }
      else if (numCauHoi == 4)
      {
        label_De.Text = "Kinh tế- chính trị Mác - Lênin đã kế thừa và phát triển trực tiếp những thành tựu của:";
        radioButtonA.Text = "A. " + "Chủ nghĩa trọng thương";
        radioButtonB.Text = "B. " + "Chủ nghĩa trọng nông";
        radioButtonC.Text = "C. " + "Kinh tế chính trị cổ điển Anh";
        radioButtonD.Text = "D. " + "Kinh tế- chính trị tầm thường";
        DapAn = "C";
      }
      else if (numCauHoi == 5)
      {
        label_De.Text = "Học thuyết kinh tế nào của C. Mác được coi là hòn đá tảng?";
        radioButtonA.Text = "A. " + "Học thuyết giá trị lao động";
        radioButtonB.Text = "B. " + "Học thuyết giá trị thặng dư";
        radioButtonC.Text = "C. " + "Học thuyết tích luỹ tư sản";
        radioButtonD.Text = "D. " + "Học thuyết tái sản xuất tư bản xã hội";
        DapAn = "B";
      }
      else if (numCauHoi == 6)
      {
        label_De.Text = "Đối tượng nghiên cứu của kinh tế- chính trị Mác-Lênin là:";
        radioButtonA.Text = "A. " + "Sản xuất của cải vật chất";
        radioButtonB.Text = "B. " + "Quan hệ xã hội giữa người với người";
        radioButtonC.Text = "C. " + "Quan hệ sản xuất trong mối quan hệ tác động qua lại với lực lượng sản xuất và kiến trúc thượng tầng.";
        radioButtonD.Text = "D. " + "Quá trình sản xuất, phân phối, trao đổi, tiêu dùng.";
        DapAn = "C";
      }
      else if (numCauHoi == 7)
      {
        label_De.Text = "Chọn phương án đúng về quy luật kinh tế và chính sách kinh tế:";
        radioButtonA.Text = "A. " + "Quy luật kinh tế là cơ sở của chính sách kinh tế";
        radioButtonB.Text = "B. " + "Chính sách kinh tế là hoạt động chủ quan của nhà nước trên cơ sở nhận thức và vận dụng các quy luật khách quan";
        radioButtonC.Text = "C. " + "Quy luật kinh tế và chính sách kinh tế đều phụ thuộc vào các điều kiện khách quan";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 8)
      {
        label_De.Text = "Để nghiên cứu kinh tế - chính trị Mác - Lênin có thể sử dụng nhiều phương pháp, phương pháp nào quan trọng nhất?";
        radioButtonA.Text = "A. " + "Trừu tượng hoá khoa học";
        radioButtonB.Text = "B. " + "Phân tích và tổng hợp";
        radioButtonC.Text = "C. " + "Mô hình hoá";
        radioButtonD.Text = "D. " + "Điều tra thống kê";
        DapAn = "A";
      }
      else if (numCauHoi == 9)
      {
        label_De.Text = "Trừu tượng hoá khoa học là:";
        radioButtonA.Text = "A. " + "Gạt bỏ những bộ phận phức tạp của đối tượng nghiên cứu";
        radioButtonB.Text = "B. " + "Gạt bỏ các hiện tượng ngẫu nhiên, bề ngoài, chỉ giữ lại những mối liên hệ phổ biến mang tính bản chất";
        radioButtonC.Text = "C. " + "Quá trình đi từ cụ thể đến trừu tượng và ngược lại";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 10)
      {
        label_De.Text = "Chức năng nhận thức của kinh tế - chính trị là nhằm:";
        radioButtonA.Text = "A. " + "Phát hiện bản chất của các hiện tượng và quá trình kinh tế";
        radioButtonB.Text = "B. " + "Sự tác động giữa quan hệ sản xuất với lực lượng sản xuất và kiến trúc thượng tầng";
        radioButtonC.Text = "C. " + "Tìm ra các quy luật kinh tế";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 11)
      {
        label_De.Text = "Chức năng phương pháp luận của kinh tế- chính trị Mác- Lênin thể hiện ở:";
        radioButtonA.Text = "A. " + "Trang bị phương pháp để xem xét thế giới nói chung";
        radioButtonB.Text = "B. " + "Là nền tảng lý luận cho các khoa học kinh tế ngành";
        radioButtonC.Text = "C. " + "Là cơ sở lý luận cho các khoa học nằm giáp ranh giữa các tri thức các ngành khác nhau";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 12)
      {
        label_De.Text = "Chức năng tư tưởng của kinh tế- chính trị Mác – Lê nin thể hiện ở:";
        radioButtonA.Text = "A. " + "Góp phần xây dựng thế giới quan cách mạng của giai cấp công nhân";
        radioButtonB.Text = "B. " + "Tạo niềm tin vào thắng lợi trong cuộc đấu tranh xoá bỏ áp bức bóc lột";
        radioButtonC.Text = "C. " + "Là vũ khí tư tưởng của giai cấp công nhân và nhân dân lao động trong công cuộc xây dựng CNXH";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      //---Chương 2---
      else if (numCauHoi == 13)
      {
        label_De.Text = "Khi nghiên cứu phương thức sản xuất TBCN, C.Mác bắt đầu từ:";
        radioButtonA.Text = "A. " + "Sản xuất của cải vật chất";
        radioButtonB.Text = "B. " + "Lưu thông hàng hoá";
        radioButtonC.Text = "C. " + "Sản xuất giá trị thặng dư";
        radioButtonD.Text = "D. " + "Sản xuất hàng hoá giản đơn và hàng hoá";
        DapAn = "D";
      }
      else if (numCauHoi == 14)
      {
        label_De.Text = "Quá trình sản xuất là sự kết hợp của các yếu tố:";
        radioButtonA.Text = "A. " + "Sức lao động với công cụ lao động";
        radioButtonB.Text = "B. " + "Lao động với tư liệu lao động";
        radioButtonC.Text = "C. " + "Sức lao động với đối tượng lao động và tư liệu lao động";
        radioButtonD.Text = "D. " + "Lao động với đối tượng lao động và tư liệu lao động";
        DapAn = "C";
      }
      else if (numCauHoi == 15)
      {
        label_De.Text = "Các chế độ xã hội nào có tồn tại sản xuất hàng hóa?";
        radioButtonA.Text = "A. " + "Cộng sản nguyên thuỷ- phong kiến- chiếm hữu nô lệ- tư bản – chủ nghĩa cộng sản";
        radioButtonB.Text = "B. " + "Cộng sản nguyên thuỷ- chiếm hữu nô lệ- phong kiến- tư bản- chủ nghĩa cộng sản";
        radioButtonC.Text = "C. " + "Chiếm hữu nô lệ - phong kiến - tư bản - chủ nghĩa cộng sản";
        radioButtonD.Text = "D. " + "Chiếm hữu nô lệ - phong kiến - tư bản – chủ nghĩa xã hội";
        DapAn = "D";
      }
      else if (numCauHoi == 16)
      {
        label_De.Text = "Sản xuất hàng hoá xuất hiện dựa trên:";
        radioButtonA.Text = "A. " + "Phân công lao động cá biệt và chế độ tư hữu về tư liệu sản xuất";
        radioButtonB.Text = "B. " + "Phân công lao động chung và chế độ sở hữu khác nhau về TLSX";
        radioButtonC.Text = "C. " + "Phân công lao động và sự tách biệt về kinh tế giữa những người sản xuất";
        radioButtonD.Text = "D. " + "Phân công lao động xã hội và chế độ tư hữu hoặc những hình thức sở hữu khác nhau về TLSX";
        DapAn = "D";
      }
      else if (numCauHoi == 17)
      {
        label_De.Text = "Hàng hoá là:";
        radioButtonA.Text = "A. " + "Sản phẩm của lao động để thoả mãn nhu cầu của con người";
        radioButtonB.Text = "B. " + "Sản phẩm của lao động có thể thoả mãn nhu cầu nào đó của con người thông qua mua bán";
        radioButtonC.Text = "C. " + "Sản phẩm ở trên thị trường";
        radioButtonD.Text = "D. " + "Sản phẩm được sản xuất ra để đem bán";
        DapAn = "B";
      }
      else if (numCauHoi == 18)
      {
        label_De.Text = "Giá trị của hàng hoá được quyết định bởi:";
        radioButtonA.Text = "A. " + "Sự khan hiếm của hàng hoá";
        radioButtonB.Text = "B. " + "Sự hao phí sức lao động của con người";
        radioButtonC.Text = "C. " + "Lao động trừu tượng của người sản xuất kết tinh trong hàng hoá";
        radioButtonD.Text = "D. " + "Công dụng của hàng hoá";
        DapAn = "C";
      }
      else if (numCauHoi == 19)
      {
        label_De.Text = "Quy luật giá trị có tác dụng:";
        radioButtonA.Text = "A. " + "Điều tiết sản xuất và lưu thông hàng hoá";
        radioButtonB.Text = "B. " + "Cải tiến kỹ thuật, tăng năng suất lao động và phân hoá những người sản xuất";
        radioButtonC.Text = "C. " + "Điều tiết sản xuất, phân hoá giàu nghèo";
        radioButtonD.Text = "D. " + "Cả a và b";
        DapAn = "D";
      }
      else if (numCauHoi == 20)
      {
        label_De.Text = "Sản xuất hàng hoá tồn tại:";
        radioButtonA.Text = "A. " + "Trong mọi xã hội";
        radioButtonB.Text = "B. " + "Trong chế độ nô lệ, phong kiến, TBCN";
        radioButtonC.Text = "C. " + "Trong các xã hội, có phân công lao động xã hội và sự tách biệt về kinh tế giữa những người sản xuất";
        radioButtonD.Text = "D. " + "Chỉ có trong CNTB";
        DapAn = "C";
      }
      else if (numCauHoi == 21)
      {
        label_De.Text = "Giá cả hàng hoá là:";
        radioButtonA.Text = "A. " + "Giá trị của hàng hoá";
        radioButtonB.Text = "B. " + "Quan hệ về lượng giữa hàng và tiền";
        radioButtonC.Text = "C. " + "Tổng của chi phí sản xuất và lợi nhuận";
        radioButtonD.Text = "D. " + "Biểu hiện bằng tiền của giá trị hàng hoá";
        DapAn = "D";
      }
      else if (numCauHoi == 22)
      {
        label_De.Text = "Quy luật giá trị là:";
        radioButtonA.Text = "A. " + "Quy luật riêng của CNTB";
        radioButtonB.Text = "B. " + "Quy luật cơ bản của sản xuất và trao đổi hàng hoá";
        radioButtonC.Text = "C. " + "Quy luật kinh tế chung của mọi xã hội";
        radioButtonD.Text = "D. " + "Quy luật kinh tế của thời kỳ quá độ lên CNXH";
        DapAn = "B";
      }
      else if (numCauHoi == 23)
      {
        label_De.Text = "Yếu tố quyết định đến giá cả hàng hoá là:";
        radioButtonA.Text = "A. " + "Giá trị của hàng hoá";
        radioButtonB.Text = "B. " + "Quan hệ cung cầu về hàng hoá";
        radioButtonC.Text = "C. " + "Giá trị sử dụng của hàng hoá";
        radioButtonD.Text = "D. " + "Mốt thời trang của hàng hoá";
        DapAn = "A";
      }
      else if (numCauHoi == 24)
      {
        label_De.Text = "Lao động trừu tượng là:";
        radioButtonA.Text = "A. " + "Là phạm trù riêng của CNTB";
        radioButtonB.Text = "B. " + "Là phạm trù của mọi nền kinh tế hàng hoá";
        radioButtonC.Text = "C. " + "Là phạm trù riêng của kinh tế thị trường";
        radioButtonD.Text = "D. " + "Là phạm trù chung của mọi nền kinh tế";
        DapAn = "B";
      }
      else if (numCauHoi == 25)
      {
        label_De.Text = "Lao động cụ thể là:";
        radioButtonA.Text = "A. " + "Là phạm trù lịch sử";
        radioButtonB.Text = "B. " + "Lao động tạo ra giá trị của hàng hoá";
        radioButtonC.Text = "C. " + "Tạo ra giá trị sử dụng của hàng hoá";
        radioButtonD.Text = "D. " + "Biểu hiện tính chất xã hội của người sản xuất hàng hoá";
        DapAn = "C";
      }
      else if (numCauHoi == 26)
      {
        label_De.Text = "Lượng giá trị xã hội của hàng hoá được quyết định bởi:";
        radioButtonA.Text = "A. " + "Hao phí vật tư kỹ thuật";
        radioButtonB.Text = "B. " + "Hao phí lao động cần thiết của người sản xuất hàng hoá";
        radioButtonC.Text = "C. " + "Hao phí lao động sống của người sản xuất hàng hoá";
        radioButtonD.Text = "D. " + "Thời gian lao động xã hội cần thiết";
        DapAn = "D";
      }
      else if (numCauHoi == 27)
      {
        label_De.Text = "Lượng giá trị của đơn vị hàng hoá thay đổi:";
        radioButtonA.Text = "A. " + "Tỷ lệ thuận với năng suất lao động";
        radioButtonB.Text = "B. " + "Tỷ lệ nghịch với cường độ lao động";
        radioButtonC.Text = "C. " + "Tỷ lệ nghịch với năng suất lao động, không phụ thuộc vào cường độ lao động";
        radioButtonD.Text = "D. " + "A và B";
        DapAn = "C";
      }
      else if (numCauHoi == 28)
      {
        label_De.Text = "Chọn ý đúng về tăng năng suất lao động: Khi tăng năng suất lao động thì:";
        radioButtonA.Text = "A. " + "Số lượng hàng hoá làm ra trong 1 đơn vị thời gian tăng";
        radioButtonB.Text = "B. " + "Tổng giá trị của hàng hoá không thay đổi";
        radioButtonC.Text = "C. " + "Giá trị 1 đơn vị hàng hoá giảm xuống";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 29)
      {
        label_De.Text = "Khi đồng thời tăng năng suất lao động và cường độ lao động lên 2 lần thì ý nào dưới đây là đúng?";
        radioButtonA.Text = "A. " + "Tổng số hàng hoá tăng lên 4 lần, tổng số giá trị hàng hoá tăng lên 4 lần";
        radioButtonB.Text = "B. " + "Tổng số giá trị hàng hoá tăng 2 lần, tổng số hàng hoá tăng 2 lần";
        radioButtonC.Text = "C. " + "Giá trị 1 hàng hoá giảm 2 lần, tổng số giá trị hàng hoá tăng 2 lần";
        radioButtonD.Text = "D. " + "Tổng số hàng hoá tăng lên 2 lần, giá trị 1 hàng hoá giảm 2 lần";
        DapAn = "C";
      }
      else if (numCauHoi == 30)
      {
        label_De.Text = "Giá trị sử dụng là gì?";
        radioButtonA.Text = "A. " + "Là công dụng của vật có thể thoả mãn nhu cầu nào đó của con người";
        radioButtonB.Text = "B. " + "Là tính hữu ích của vật";
        radioButtonC.Text = "C. " + "Là thuộc tính tự nhiên của vật";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 31)
      {
        label_De.Text = "Yếu tố nào được xác định là thực thể của giá trị hàng hoá?";
        radioButtonA.Text = "A. " + "Lao động cụ thể";
        radioButtonB.Text = "B. " + "Lao động trừu tượng";
        radioButtonC.Text = "C. " + "Lao động giản đơn";
        radioButtonD.Text = "D. " + "Lao động phức tạp";
        DapAn = "B";
      }
      else if (numCauHoi == 32)
      {
        label_De.Text = "Giá trị hàng hoá được tạo ra từ đâu?";
        radioButtonA.Text = "A. " + "Từ sản xuất";
        radioButtonB.Text = "B. " + "Từ phân phối";
        radioButtonC.Text = "C. " + "Từ trao đổi";
        radioButtonD.Text = "D. " + "Cả sản xuất, phân phối và trao đổi";
        DapAn = "A";
      }
      else if (numCauHoi == 33)
      {
        label_De.Text = "Tính chất hai mặt của lao động sản xuất hàng hoá là:";
        radioButtonA.Text = "A. " + "Lao động tư nhân và lao động xã hội";
        radioButtonB.Text = "B. " + "Lao động giản đơn và lao động phức tạp";
        radioButtonC.Text = "C. " + "Lao động cụ thể và lao động trừu tượng";
        radioButtonD.Text = "D. " + "Lao động quá khứ và lao động sống";
        DapAn = "C";
      }
      else if (numCauHoi == 34)
      {
        label_De.Text = "Ai là người phát hiện ra tính chất hai mặt của lao động sản xuất hàng hoá?";
        radioButtonA.Text = "A. " + "A.Smith";
        radioButtonB.Text = "B. " + "D.Ricardo";
        radioButtonC.Text = "C. " + "C.Mác";
        radioButtonD.Text = "D. " + "Ph. Ăng ghen";
        DapAn = "C";
      }
      else if (numCauHoi == 35)
      {
        label_De.Text = "Lao động cụ thể là:";
        radioButtonA.Text = "A. " + "Là những việc làm cụ thể";
        radioButtonB.Text = "B. " + "Là lao động có mục đích cụ thể";
        radioButtonC.Text = "C. " + "Là lao động ở các ngành nghề cụ thể";
        radioButtonD.Text = "D. " + "Là lao động ngành nghề, có mục đích riêng, đối tượng riêng, công cụ lao động riêng và kết quả riêng";
        DapAn = "D";
      }
      else if (numCauHoi == 36)
      {
        label_De.Text = "Lao động trừu tượng là gì?";
        radioButtonA.Text = "A. " + "Là lao động không cụ thể";
        radioButtonB.Text = "B. " + "Là lao động phức tạp";
        radioButtonC.Text = "C. " + "Là lao động có trình độ cao, mất nhiều công đào tạo";
        radioButtonD.Text = "D. " + "Là sự hao phí sức lao động của người sản xuất hàng hoá nói chung không tính đến những hình thức cụ thể.";
        DapAn = "D";
      }
      else if (numCauHoi == 37)
      {
        label_De.Text = "Lao động trừu tượng là nguồn gốc:";
        radioButtonA.Text = "A. " + "Của tính hữu ích của hàng hoá";
        radioButtonB.Text = "B. " + "Của giá trị hàng hoá";
        radioButtonC.Text = "C. " + "Của giá trị sử dụng";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "B";
      }
      else if (numCauHoi == 38)
      {
        label_De.Text = "Thế nào là lao động giản đơn?";
        radioButtonA.Text = "A. " + "Là lao động làm công việc đơn giản";
        radioButtonB.Text = "B. " + "Là lao động làm ra các hàng hoá chất lượng không cao";
        radioButtonC.Text = "C. " + "Là lao động chỉ làm một công đoạn của quá trình tạo ra hàng hoá";
        radioButtonD.Text = "D. " + "Là lao động không cần trải qua đào tạo cũng có thể làm được";
        DapAn = "D";
      }
      else if (numCauHoi == 39)
      {
        label_De.Text = "Thế nào là lao động phức tạp?";
        radioButtonA.Text = "A. " + "Là lao động tạo ra các sản phẩm chất lượng cao, tinh vi";
        radioButtonB.Text = "B. " + "Là lao động có nhiều thao tác phức tạp";
        radioButtonC.Text = "C. " + "Là lao động phải trải qua đào tạo, huấn luyện mới làm được";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "C";
      }
      else if (numCauHoi == 40)
      {
        label_De.Text = "Ý nào sau đây là ý không đúng về lao động phức tạp?";
        radioButtonA.Text = "A. " + "Trong cùng một thời gian lao động, lao động phức tạp tạo ra nhiều giá trị hơn lao động giản đơn";
        radioButtonB.Text = "B. " + "Lao động phức tạp là lao động giản đơn nhân bội lên";
        radioButtonC.Text = "C. " + "Lao động phức tạp là lao động trí tuệ của người lao động có trình độ cao";
        radioButtonD.Text = "D. " + "Lao động phức tạp là lao động trải qua đào tạo, huấn luyện";
        DapAn = "C";
      }
      else if (numCauHoi == 41)
      {
        label_De.Text = "Chọn phương án đúng trong các phương án sau đây:";
        radioButtonA.Text = "A. " + "Lao động cụ thể được thực hiện trước lao động trừu tượng";
        radioButtonB.Text = "B. " + "Lao động cụ thể tạo ra tính hữu ích của sản phẩm";
        radioButtonC.Text = "C. " + "Lao động trừu tượng chỉ có ở người có trình độ cao, còn người có trình độ thấp chỉ có lao động cụ thể";
        radioButtonD.Text = "D. " + "Cả a, b, c đều đúng";
        DapAn = "B";
      }
      else if (numCauHoi == 42)
      {
        label_De.Text = "Công thức tính giá trị hàng hoá là: c + v + m. Ý nào là không đúng trong các ý sau?";
        radioButtonA.Text = "A. " + "Lao động cụ thể bảo toàn và chuyển giá trị TLSX (c) sang sản phẩm";
        radioButtonB.Text = "B. " + "Lao động trừu tượng tạo ra giá trị mới (v+m)";
        radioButtonC.Text = "C. " + "Lao động trừu tượng tạo nên toàn bộ giá trị (c + v + m)";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "C";
      }
      else if (numCauHoi == 43)
      {
        label_De.Text = "Tiền tệ là:";
        radioButtonA.Text = "A. " + "Thước đo giá trị của hàng hoá";
        radioButtonB.Text = "B. " + "Phương tiện để lưu thông hàng hoá và để thanh toán";
        radioButtonC.Text = "C. " + "Là hàng hoá đặc biệt đóng vai trò là vật ngang giá chung";
        radioButtonD.Text = "D. " + "Là vàng, bạc";
        DapAn = "C";
      }
      else if (numCauHoi == 44)
      {
        label_De.Text = "Bản chất tiền tệ là gì? Chọn các ý đúng:";
        radioButtonA.Text = "A. " + "Là hàng hoá đặc biệt, làm vật ngang giá cho các hàng hoá khác";
        radioButtonB.Text = "B. " + "Thể hiện lao động xã hội kết tinh trong hàng hoá";
        radioButtonC.Text = "C. " + "Phản ánh quan hệ kinh tế giữa những người sản xuất hàng hoá với nhau";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "A";
      }
      else if (numCauHoi == 45)
      {
        label_De.Text = "Trong các chức năng của tiền, chức năng nào là quan trọng nhất?";
        radioButtonA.Text = "A. " + "Thước đo giá trị";
        radioButtonB.Text = "B. " + "Phương tiện lưu thông";
        radioButtonC.Text = "C. " + "Phương tiện thanh toán";
        radioButtonD.Text = "D. " + "Phương tiện cất trữ và tiền tệ thế giới";
        DapAn = "A";
      }
      else if (numCauHoi == 46)
      {
        label_De.Text = "Nguồn gốc của tiền là:";
        radioButtonA.Text = "A. " + "Do mua bán, trao đổi quốc tế";
        radioButtonB.Text = "B. " + "Do nhà nước phát hành";
        radioButtonC.Text = "C. " + "Do nhu cầu mua bán	";
        radioButtonD.Text = "D. " + "Do nhu cầu của sản xuất và trao đổi hàng hóa";
        DapAn = "D";
      }
      else if (numCauHoi == 47)
      {
        label_De.Text = "Theo quy luật lưu thông tiền tệ, lượng tiền cần thiết trong lưu thông tỷ lệ thuận với yếu tố nào dưới đây";
        radioButtonA.Text = "A. " + "Giá trị hàng hóa lưu thông trên thị trường";
        radioButtonB.Text = "B. " + "Tốc độ lưu thông của tiền";
        radioButtonC.Text = "C. " + "Số tiền mua bán chịu";
        radioButtonD.Text = "D. " + "Các phương án trên đều đúng";
        DapAn = "A";
      }
      else if (numCauHoi == 48)
      {
        label_De.Text = "Sự tác động của cung và cầu làm cho:";
        radioButtonA.Text = "A. " + "Giá cả < hơn giá trị";
        radioButtonB.Text = "B. " + "Giá cả > hơn giá trị";
        radioButtonC.Text = "C. " + "Giá cả vận động xoay quanh giá trị";
        radioButtonD.Text = "D. " + "Giá cả = giá trị";
        DapAn = "C";
      }
      else if (numCauHoi == 49)
      {
        label_De.Text = "Cung - cầu là quy luật kinh tế. Thế nào là cầu?";
        radioButtonA.Text = "A. " + "Là nhu cầu của thị trường về hàng hoá";
        radioButtonB.Text = "B. " + "Là nhu cầu của người mua hàng hoá";
        radioButtonC.Text = "C. " + "Là sự mong muốn, sở thích của người tiêu dùng";
        radioButtonD.Text = "D. " + "Nhu cầu của xã hội về hàng hoá được biểu hiện trên thị trường ở một mức giá nhất định";
        DapAn = "D";
      }
      else if (numCauHoi == 50)
      {
        label_De.Text = "Thế nào là cung hàng hoá?";
        radioButtonA.Text = "A. " + "Là số lượng hàng hoá xã hội sản xuất ra";
        radioButtonB.Text = "B. " + "Là toàn bộ số hàng hoá đem bán trên thị trường";
        radioButtonC.Text = "C. " + "Toàn bộ hàng hoá đem bán trên thị trường và có thể đưa nhanh đến thị trường ở một mức giá nhất định";
        radioButtonD.Text = "D. " + "Là toàn bộ khả năng cung cấp hàng hoá cho thị trường";
        DapAn = "C";
      }
      //---Chương 3---
      else if (numCauHoi == 51)
      {
        label_De.Text = "Tái sản xuất là:";
        radioButtonA.Text = "A. " + "Là quá trình sản xuất";
        radioButtonB.Text = "B. " + "Là quá trình sản xuất được lặp đi lặp lại và phục hồi không ngừng.";
        radioButtonC.Text = "C. " + "Là sự khôi phục lại sản xuất";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "B";
      }
      else if (numCauHoi == 52)
      {
        label_De.Text = "Loại tái sản xuất nào làm tăng sản phẩm chủ yếu do tăng năng suất lao động và hiệu quả sử dụng các nguồn lực?";
        radioButtonA.Text = "A. " + "Tái sản xuất giản đơn";
        radioButtonB.Text = "B. " + "Tái sản xuất mở rộng";
        radioButtonC.Text = "C. " + "Tái sản xuất mở rộng theo chiều rộng";
        radioButtonD.Text = "D. " + "Tái sản xuất mở rộng theo chiều sâu";
        DapAn = "D";
      }
      else if (numCauHoi == 53)
      {
        label_De.Text = "Chọn ý sai về tái sản xuất giản đơn và tái sản xuất mở rộng?";
        radioButtonA.Text = "A. " + "Tái sản xuất giản đơn là đặc trưng của nền sản xuất nhỏ";
        radioButtonB.Text = "B. " + "Tái sản xuất giản đơn là việc tổ chức sản xuất đơn giản, không phức tạp";
        radioButtonC.Text = "C. " + "Tái sản xuất mở rộng là đặc trưng của nền sản xuất lớn";
        radioButtonD.Text = "D. " + "Sản phẩm thặng dư là nguồn gốc của tái sản xuất mở rộng";
        DapAn = "B";
      }
      else if (numCauHoi == 54)
      {
        label_De.Text = "Chọn ý sai về tái sản xuất mở rộng theo chiều rộng và tái sản xuất mở rộng theo chiều sâu?";
        radioButtonA.Text = "A. " + "Đều làm cho sản phẩm tăng lên";
        radioButtonB.Text = "B. " + "Cả hai hình thức tái sản xuất đều dựa trên cơ sở tăng năng suất lao động và hiệu quả sử dụng các yếu tố đầu vào";
        radioButtonC.Text = "C. " + "Tái sản xuất mở rộng theo chiều sâu sử dụng tài nguyên hiệu quả hơn và gây ra ô nhiễm ít hơn tái sản xuất mở rộng theo chiều rộng.";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 55)
      {
        label_De.Text = "Chọn các ý đúng về lao động và sức lao động:";
        radioButtonA.Text = "A. " + "Sức lao động chỉ là khả năng, còn lao động là sức lao động đã được tiêu dùng";
        radioButtonB.Text = "B. " + "Sức lao động là hàng hoá, còn lao động không là hàng hoá";
        radioButtonC.Text = "C. " + "Sức lao động có giá trị, còn lao động không có giá trị";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 56)
      {
        label_De.Text = "Sức lao động trở thành hàng hoá một cách phổ biến từ khi nào?";
        radioButtonA.Text = "A. " + "Từ khi có sản xuất hàng hoá";
        radioButtonB.Text = "B. " + "Từ xã hội chiếm hữu nô lệ";
        radioButtonC.Text = "C. " + "Từ khi có kinh tế thị trường";
        radioButtonD.Text = "D. " + "Từ khi có CNTB";
        DapAn = "D";
      }
      else if (numCauHoi == 57)
      {
        label_De.Text = "Điều kiện tất yếu để sức lao động trở thành hàng hoá là:";
        radioButtonA.Text = "A. " + "Người lao động tự nguyện đi làm thuê";
        radioButtonB.Text = "B. " + "Người lao động được tự do thân thể";
        radioButtonC.Text = "C. " + "Người lao động hoàn toàn không có TLSX và của cải gì";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 58)
      {
        label_De.Text = "Tư bản bất biến (c) là:";
        radioButtonA.Text = "A. " + "Giá trị của nó chuyển dần vào sản phẩm qua khấu hao";
        radioButtonB.Text = "B. " + "Giá trị của nó lớn lên trong quá trình sản xuất";
        radioButtonC.Text = "C. " + "Giá trị của nó không thay đổi về lượng và được chuyển nguyên vẹn sang sản phẩm";
        radioButtonD.Text = "D. " + "Giá trị của nó không thay đổi và được chuyển ngay sang sản phẩm sau một chu kỳ sản xuất";
        DapAn = "C";
      }
      else if (numCauHoi == 59)
      {
        label_De.Text = "Tư bản là:";
        radioButtonA.Text = "A. " + "Khối lượng tiền tệ lớn, nhờ đó có nhiều lợi nhuận";
        radioButtonB.Text = "B. " + "Máy móc, thiết bị, nhà xưởng và công nhân làm thuê";
        radioButtonC.Text = "C. " + "Toàn bộ tiền và của cải vật chất";
        radioButtonD.Text = "D. " + "Giá trị mang lại giá trị thặng dư bằng cách bóc lột lao động làm thuê";
        DapAn = "D";
      }
      else if (numCauHoi == 60)
      {
        label_De.Text = "Tư bản bất biến (c) và tư bản khả biến (v) thuộc phạm trù tư bản nào?";
        radioButtonA.Text = "A. " + "Tư bản tiền tệ";
        radioButtonB.Text = "B. " + "Tư bản sản xuất";
        radioButtonC.Text = "C. " + "Tư bản hàng hoá";
        radioButtonD.Text = "D. " + "Tư bản lưu thông";
        DapAn = "B";
      }
      else if (numCauHoi == 61)
      {
        label_De.Text = "Tư bản cố định là:";
        radioButtonA.Text = "A. " + "Các TLSX chủ yếu như nhà xưởng, máy móc…";
        radioButtonB.Text = "B. " + "Tư bản cố định là tư bản bất biến";
        radioButtonC.Text = "C. " + "Giá trị của nó chuyển dần sang sản phẩm";
        radioButtonD.Text = "D. " + "Cả a, c";
        DapAn = "D";
      }
      else if (numCauHoi == 62)
      {
        label_De.Text = "Tư bản khả biến là:";
        radioButtonA.Text = "A. " + "Tư bản luôn luôn biến đổi";
        radioButtonB.Text = "B. " + "Sức lao động của công nhân làm thuê";
        radioButtonC.Text = "C. " + "Là nguồn gốc của giá trị thặng dư";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 63)
      {
        label_De.Text = "Chọn các ý không đúng về các cặp phạm trù tư bản:";
        radioButtonA.Text = "A. " + "Chia tư bản thành tư bản bất biến và tư bản khả biến để tìm nguồn gốc giá trị thặng dư";
        radioButtonB.Text = "B. " + "Chia tư bản thành tư bản cố định và tư bản lưu động để biết phương thức chuyển giá trị của chúng sang sản phẩm";
        radioButtonC.Text = "C. " + "Tư bản cố định cũng là tư bản bất biến, tư bản lưu động cũng là tư bản khả biến";
        radioButtonD.Text = "D. " + "Cả a, b đều đúng";
        DapAn = "C";
      }
      else if (numCauHoi == 64)
      {
        label_De.Text = "Giá trị hàng hoá sức lao động gồm:";
        radioButtonA.Text = "A. " + "Giá trị các tư liệu tiêu dùng để tái sản xuất sức lao động của công nhân và nuôi gia đình anh ta";
        radioButtonB.Text = "B. " + "Chi phí để thoả mãn nhu cầu văn hoá, tinh thần";
        radioButtonC.Text = "C. " + "Chi phí đào tạo người lao động";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 65)
      {
        label_De.Text = "Chọn các ý đúng trong các nhận định dưới đây:";
        radioButtonA.Text = "A. " + "Người bán và người mua sức lao động đều bình đẳng về mặt pháp lý";
        radioButtonB.Text = "B. " + "Sức lao động được mua và bán theo quy luật giá trị";
        radioButtonC.Text = "C. " + "Thị trường sức lao động được hình thành và phát triển từ phương thức sản xuất TBCN";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 66)
      {
        label_De.Text = "Chọn các ý đúng trong các nhận định sau:";
        radioButtonA.Text = "A. " + "Tiền tệ là sản vật cuối cùng của lưu thông hàng hoá và là hình thức biểu hiện đầu tiên của tư bản";
        radioButtonB.Text = "B. " + "Tư bản được biểu hiện ở tiền, nhưng bản thân tiền không phải là tư bản";
        radioButtonC.Text = "C. " + "Mọi tư bản mới đều nhất thiết phải mang hình thái tiền tệ";
        radioButtonD.Text = "D. " + "Cả a, b, c đều đúng";
        DapAn = "D";
      }
      else if (numCauHoi == 67)
      {
        label_De.Text = "Mục đích trực tiếp của nền sản xuất TBCN là:";
        radioButtonA.Text = "A. " + "Sản xuất ra ngày càng nhiều của cải vật chất";
        radioButtonB.Text = "B. " + "Mở rộng phạm vi thống trị của QHSX TBCN";
        radioButtonC.Text = "C. " + "Tạo ra ngày càng nhiều giá trị thặng dư";
        radioButtonD.Text = "D. " + "Làm cho lao động ngày càng lệ thuộc vào tư bản";
        DapAn = "C";
      }
      else if (numCauHoi == 68)
      {
        label_De.Text = "Các cách diễn tả giá trị hàng hoá dưới đây, cách nào đúng?";
        radioButtonA.Text = "A. " + "Giá trị hàng hoá = c + v + m";
        radioButtonB.Text = "B. " + "Giá trị hàng hoá = giá trị cũ + giá trị mới";
        radioButtonC.Text = "C. " + "Giá trị hàng hoá = k + p";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 69)
      {
        label_De.Text = "Chọn cách diễn tả sai dưới đây:";
        radioButtonA.Text = "A. " + "Giá trị mới của sản phẩm = v + m";
        radioButtonB.Text = "B. " + "Giá trị của sản phẩm mới = v + m";
        radioButtonC.Text = "C. " + "Giá trị của TLSX = c";
        radioButtonD.Text = "D. " + "Giá trị của sức lao động = v";
        DapAn = "B";
      }
      else if (numCauHoi == 70)
      {
        label_De.Text = "Khi nào tiền tệ biến thành tư bản?";
        radioButtonA.Text = "A. " + "Có lượng tiền tệ đủ lớn";
        radioButtonB.Text = "B. " + "Dùng tiền đầu tư vào sản xuất kinh doanh";
        radioButtonC.Text = "C. " + "Sức lao động trở thành hàng hoá";
        radioButtonD.Text = "D. " + "Dùng tiền để buôn bán mua rẻ, bán đắt";
        DapAn = "C";
      }
      else if (numCauHoi == 71)
      {
        label_De.Text = "Tư bản bất biến (c) và tư bản khả biến (v) có vai trò thế nào trong quá trình sản xuất giá trị thặng dư? Chọn các ý không đúng dưới đây:";
        radioButtonA.Text = "A. " + "Tư bản bất biến (c) là điều kiện để sản xuất giá trị thặng dư";
        radioButtonB.Text = "B. " + "Tư bản khả biến là nguồn gốc của giá trị thặng dư";
        radioButtonC.Text = "C. " + "Cả c và v có vai trò ngang nhau trong quá trình tạo ra giá trị thặng dư";
        radioButtonD.Text = "D. " + "Cả a và b";
        DapAn = "C";
      }
      else if (numCauHoi == 72)
      {
        label_De.Text = "Cho biết ý nghĩa của việc phát hiện ra tính chất hai mặt của lao động sản xuất hàng hoá của C.Mác. Chọn các ý đúng dưới đây:";
        radioButtonA.Text = "A. " + "Chia tư bản thành tư bản bất biến và khả biến";
        radioButtonB.Text = "B. " + "Giải thích quá trình chuyển giá trị cũ sang sản phẩm và tạo ra giá trị mới của sản phẩm";
        radioButtonC.Text = "C. " + "Hình thành công thức giá trị hàng hoá = c + v + m";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 73)
      {
        label_De.Text = "Tỷ suất giá trị thặng dư (m') phản ánh điều gì? Chọn ý đúng:";
        radioButtonA.Text = "A. " + "Trình độ bóc lột của tư bản đối với công nhân làm thuê";
        radioButtonB.Text = "B. " + "Hiệu quả của tư bản";
        radioButtonC.Text = "C. " + "Chỉ cho nhà tư bản biết nơi đầu tư có lợi";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "A";
      }
      else if (numCauHoi == 74)
      {
        label_De.Text = "Phương pháp sản xuất giá trị thặng dư tuyệt đối và phương pháp sản xuất giá trị thặng dư tương đối có điểm nào giống nhau?";
        radioButtonA.Text = "A. " + "Đều làm cho công nhân tốn sức lao động nhiều hơn";
        radioButtonB.Text = "B. " + "Đều làm tăng tỷ suất giá trị thặng dư";
        radioButtonC.Text = "C. " + "Đều làm giảm giá trị sức lao động của công nhân";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "B";
      }
      else if (numCauHoi == 75)
      {
        label_De.Text = "Phương pháp sản xuất giá trị thặng dư tuyệt đối là:";
        radioButtonA.Text = "A. " + "Kéo dài thời gian của ngày lao động, còn thời gian lao động cần thiết không thay đổi";
        radioButtonB.Text = "B. " + "Tiết kiệm chi phí sản xuất";
        radioButtonC.Text = "C. " + "Sử dụng kỹ thuật tiên tiến, cải tiến tổ chức quản lý";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "A";
      }
      else if (numCauHoi == 76)
      {
        label_De.Text = "Khi xem xét phương pháp sản xuất giá trị thặng dư tuyệt đối, những ý nào dưới đây không đúng?";
        radioButtonA.Text = "A. " + "Giá trị sức lao động không đổi";
        radioButtonB.Text = "B. " + "Thời gian lao động cần thiết thay đổi";
        radioButtonC.Text = "C. " + "Ngày lao động thay đổi";
        radioButtonD.Text = "D. " + "Thời gian lao động thặng dư thay đổi";
        DapAn = "B";
      }
      else if (numCauHoi == 77)
      {
        label_De.Text = "Phương pháp sản xuất giá trị thặng dư tuyệt đối có những hạn chế. Chọn ý đúng trong các nhận xét dưới đây:";
        radioButtonA.Text = "A. " + "Gặp phải sự phản kháng quyết liệt của công nhân";
        radioButtonB.Text = "B. " + "Năng suất lao động không thay đổi";
        radioButtonC.Text = "C. " + "Không thoả mãn khát vọng giá trị thặng dư của nhà tư bản";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 78)
      {
        label_De.Text = "Những nhận xét dưới đây về phương pháp sản xuất giá trị thặng dư tuyệt đối, nhận xét nào là không đúng?";
        radioButtonA.Text = "A. " + "Chủ yếu áp dụng ở giai đoạn đầu của CNTB khi kỹ thuật còn thủ công lạc hậu";
        radioButtonB.Text = "B. " + "Giá trị sức lao động không thay đổi";
        radioButtonC.Text = "C. " + "Ngày lao động không thay đổi";
        radioButtonD.Text = "D. " + "Thời gian lao động thặng dư thay đổi";
        DapAn = "C";
      }
      else if (numCauHoi == 79)
      {
        label_De.Text = "Những ý kiến dưới đây về phương pháp sản xuất giá trị thặng dư tương đối, ý kiến nào đúng?";
        radioButtonA.Text = "A. " + "Ngày lao động không đổi";
        radioButtonB.Text = "B. " + "Thời gian lao động cần thiết và giá trị sức lao động thay đổi";
        radioButtonC.Text = "C. " + "Hạ thấp giá trị sức lao động";
        radioButtonD.Text = "D. " + "Cả a, b, c đều đúng";
        DapAn = "D";
      }
      else if (numCauHoi == 80)
      {
        label_De.Text = "Nhận xét về giá trị thặng dư tương đối và giá trị thặng dư siêu ngạch, ý nào dưới đây là đúng?";
        radioButtonA.Text = "A. " + "Đều dựa trên cơ sở tăng NSLĐ";
        radioButtonB.Text = "B. " + "Giá trị thặng dư tương đối dựa trên cơ sở tăng NSLĐ xã hội còn giá trị thặng dư siêu ngạch dựa trên cơ sở tăng NSLĐ cá biệt";
        radioButtonC.Text = "C. " + "Giá trị thặng dư siêu ngạch có thể chuyển hoá thành giá trị thặng dư tương đối";
        radioButtonD.Text = "D. " + "Cả a, b, c đều đúng";
        DapAn = "D";
      }
      else if (numCauHoi == 81)
      {
        label_De.Text = "Chọn các ý kiến đúng khi nhận xét giá trị thặng dư tương đối và giá trị thặng dư siêu ngạch:";
        radioButtonA.Text = "A. " + "Giá trị thặng dư tương đối do toàn bộ giai cấp tư sản thu được";
        radioButtonB.Text = "B. " + "Giá trị thặng dư siêu ngạch chỉ một số nhà tư bản đi đầu trong ứng dụng tiến bộ kỹ thuật, giảm giá trị cá biệt";
        radioButtonC.Text = "C. " + "Giá trị thặng dư tương đối phản ánh trực tiếp quan hệ giai cấp tư sản và giai cấp công nhân, còn giá trị thặng dư siêu ngạch là động lực trực tiếp của các nhà tư bản";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 82)
      {
        label_De.Text = "Vai trò của máy móc trong quá trình tạo ra giá trị thặng dư, chọn ý đúng:";
        radioButtonA.Text = "A. " + "Máy móc là nguồn gốc của giá trị thặng dư";
        radioButtonB.Text = "B. " + "Máy móc là tiền đề vật chất cho việc tạo ra giá trị thặng dư";
        radioButtonC.Text = "C. " + "Máy móc và sức lao động đều tạo ra giá trị thặng dư";
        radioButtonD.Text = "D. " + "Máy móc là yếu tố quyết định để tạo ra giá trị thặng dư";
        DapAn = "B";
      }
      else if (numCauHoi == 83)
      {
        label_De.Text = "Không có";
        radioButtonA.Text = "A. " + "Không có";
        radioButtonB.Text = "B. " + "Không có";
        radioButtonC.Text = "C. " + "Không có";
        radioButtonD.Text = "D. " + "Không có";
        DapAn = "Không có câu này trong tài liệu";
      }
      else if (numCauHoi == 84)
      {
        label_De.Text = "Tiền công TBCN là:";
        radioButtonA.Text = "A. " + "Giá trị của lao động";
        radioButtonB.Text = "B. " + "Sự trả công cho lao động";
        radioButtonC.Text = "C. " + "Giá trị sức lao động";
        radioButtonD.Text = "D. " + "Giá cả của sức lao động";
        DapAn = "D";
      }
      else if (numCauHoi == 85)
      {
        label_De.Text = "Nếu nhà tư bản trả công theo đúng giá trị sức lao động thì có còn bóc lột giá trị thặng dư không?";
        radioButtonA.Text = "A. " + "Không";
        radioButtonB.Text = "B. " + "Có";
        radioButtonC.Text = "C. " + "Bị lỗ vốn";
        radioButtonD.Text = "D. " + "Hoà vốn";
        DapAn = "B";
      }
      else if (numCauHoi == 86)
      {
        label_De.Text = "Giá trị thặng dư là gì?";
        radioButtonA.Text = "A. " + "Lợi nhuận thu được của người sản xuất kinh doanh";
        radioButtonB.Text = "B. " + "Giá trị của tư bản tự tăng lên";
        radioButtonC.Text = "C. " + "Phần giá trị mới dôi ra ngoài giá trị sức lao động do người công nhân làm thuê tạo ra";
        radioButtonD.Text = "D. " + "Hiệu số giữa giá trị hàng hoá với chi phí sản xuất TBCN";
        DapAn = "C";
      }
      else if (numCauHoi == 87)
      {
        label_De.Text = "Chọn các ý không đúng về lợi nhuận và giá trị thặng dư";
        radioButtonA.Text = "A. " + "Bản chất của lợi nhuận là giá trị thặng dư";
        radioButtonB.Text = "B. " + "Lợi nhuận và giá trị thặng dư luôn luôn bằng nhau";
        radioButtonC.Text = "C. " + "Giá trị thặng dư được hình thành từ sản xuất còn lợi nhuận hình thành trên thị trường";
        radioButtonD.Text = "D. " + "Cả a và c";
        DapAn = "B";
      }
      else if (numCauHoi == 88)
      {
        label_De.Text = "Chọn các ý đúng về tỷ suất lợi nhuận và tỷ suất giá trị thặng dư";
        radioButtonA.Text = "A. " + "p' < m'";
        radioButtonB.Text = "B. " + "m' nói lên thực chất mức độ bóc lột";
        radioButtonC.Text = "C. " + "p' chỉ ra nơi đầu tư có lợi cho nhà tư bản";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 89)
      {
        label_De.Text = "Ngày lao động là 8h, tỷ suất giá trị thặng dư m' = 100%, nhà tư bản tăng ngày lao động lên 1h và giá trị sức lao động giảm đi 25%. Vậy tỷ suất giá trị thặng dư mới là bao nhiêu?";
        radioButtonA.Text = "A. " + "150%";
        radioButtonB.Text = "B. " + "200%";
        radioButtonC.Text = "C. " + "250%";
        radioButtonD.Text = "D. " + "300%";
        DapAn = "B";
      }
      else if (numCauHoi == 90)
      {
        label_De.Text = "Tiền công thực tế là gì?";
        radioButtonA.Text = "A. " + "Là tổng số tiền nhận được thực tế trong 1 tháng";
        radioButtonB.Text = "B. " + "Là số tiền trong sổ lương + tiền thưởng + các nguồn thu nhập khác";
        radioButtonC.Text = "C. " + "Là số lượng hàng hoá và dịch vụ mua được bằng tiền công danh nghĩa";
        radioButtonD.Text = "D. " + "Là giá cả của sức lao động";
        DapAn = "C";
      }
      else if (numCauHoi == 91)
      {
        label_De.Text = "Những ý kiến nào dưới đây là sai?";
        radioButtonA.Text = "A. " + "Tích luỹ tư bản là biến một phần giá trị thặng dư thành tư bản";
        radioButtonB.Text = "B. " + "Nguồn gốc của tích luỹ tư bản là giá trị thặng dư";
        radioButtonC.Text = "C. " + "Động cơ của tích lỹ tư bản cũng là giá trị thặng dư";
        radioButtonD.Text = "D. " + "Tích luỹ cơ bản là sự tiết kiệm tư bản";
        DapAn = "D";
      }
      else if (numCauHoi == 92)
      {
        label_De.Text = "Tích tụ tư bản là:";
        radioButtonA.Text = "A. " + "Là tăng quy mô tư bản cá biệt bằng cách tư bản hoá giá trị thặng dư";
        radioButtonB.Text = "B. " + "Là kết quả trực tiếp của tích luỹ tư bản";
        radioButtonC.Text = "C. " + "Làm cho tư bản xã hội tăng";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 93)
      {
        label_De.Text = "Thời gian chu chuyển của tư bản gồm thời gian sản xuất và thời gian lưu thông. Thời gian sản xuất không gồm thời gian nào?";
        radioButtonA.Text = "A. " + "Thời gian lao động";
        radioButtonB.Text = "B. " + "Thời gian tiêu thụ hàng hoá";
        radioButtonC.Text = "C. " + "Thời gian dự trữ sản xuất";
        radioButtonD.Text = "D. " + "Thời gian gián đoạn lao động";
        DapAn = "B";
      }
      else if (numCauHoi == 94)
      {
        label_De.Text = "Các yếu tố dưới đây, yếu tố nào không thuộc tư bản bất biến?";
        radioButtonA.Text = "A. " + "Máy móc, thiết bị, nhà xưởng";
        radioButtonB.Text = "B. " + "Kết cấu hạ tầng sản xuất";
        radioButtonC.Text = "C. " + "Tiền lương, tiền thưởng";
        radioButtonD.Text = "D. " + "Điện, nước, nguyên liệu";
        DapAn = "C";
      }
      else if (numCauHoi == 95)
      {
        label_De.Text = "Những yếu tố dưới đây, yếu tố nào không thuộc tư bản cố định?";
        radioButtonA.Text = "A. " + "Nguyên vật liệu, điện, nước dùng cho sản xuất";
        radioButtonB.Text = "B. " + "Các phương tiện vận tải";
        radioButtonC.Text = "C. " + "Máy móc, nhà xưởng";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "A";
      }
      else if (numCauHoi == 96)
      {
        label_De.Text = "Các yếu tố dưới đây, yếu tố nào thuộc tư bản lưu động?";
        radioButtonA.Text = "A. " + "Đất đai làm mặt bằng sản xuất";
        radioButtonB.Text = "B. " + "Máy móc, nhà xưởng";
        radioButtonC.Text = "C. " + "Tiền lương";
        radioButtonD.Text = "D. " + "Cả a và b";
        DapAn = "C";
      }
      else if (numCauHoi == 97)
      {
        label_De.Text = "Dựa vào căn cứ nào để chia tư bản ra thành tư bản cố định và tư bản lưu động?";
        radioButtonA.Text = "A. " + "Tốc độ chu chuyển chung của tư bản";
        radioButtonB.Text = "B. " + "Phương thức chuyển giá trị của các bộ phận tư bản sang sản phẩm";
        radioButtonC.Text = "C. " + "Vai trò các bộ phận tư bản trong quá trình sản xuất giá trị thặng dư";
        radioButtonD.Text = "D. " + "Sự thay đổi về lượng trong quá trình sản";
        DapAn = "B";
      }
      else if (numCauHoi == 98)
      {
        label_De.Text = "Hãy nhận dạng những dấu hiệu nào không thuộc phạm trù hao mòn hữu hình?";
        radioButtonA.Text = "A. " + "Giảm khả năng sử dụng";
        radioButtonB.Text = "B. " + "Do sử dụng";
        radioButtonC.Text = "C. " + "Tác động của tự nhiên";
        radioButtonD.Text = "D. " + "Khấu hao nhanh";
        DapAn = "C";
      }
      else if (numCauHoi == 99)
      {
        label_De.Text = "Hình thức nào không phải biểu hiện giá trị thặng dư?";
        radioButtonA.Text = "A. " + "Lợi nhuận";
        radioButtonB.Text = "B. " + "Lợi tức";
        radioButtonC.Text = "C. " + "Địa tô";
        radioButtonD.Text = "D. " + "Tiền lương";
        DapAn = "D";
      }
      else if (numCauHoi == 100)
      {
        label_De.Text = "Lợi nhuận có nguồn gốc từ:";
        radioButtonA.Text = "A. " + "Lao động phức tạp";
        radioButtonB.Text = "B. " + "Lao động quá khứ";
        radioButtonC.Text = "C. " + "Lao động cụ thể";
        radioButtonD.Text = "D. " + "Lao động không được trả công";
        DapAn = "D";
      }
      else if (numCauHoi == 101)
      {
        label_De.Text = "Khi hàng hoá bán đúng giá trị thì:";
        radioButtonA.Text = "A. " + "p = m";
        radioButtonB.Text = "B. " + "p < m";
        radioButtonC.Text = "C. " + "p >m";
        radioButtonD.Text = "D. " + "p = 0";
        DapAn = "A";
      }
      else if (numCauHoi == 102)
      {
        label_De.Text = "Tỷ suất lợi nhuận phản ánh:";
        radioButtonA.Text = "A. " + "Trình độ bóc lột của tư bản";
        radioButtonB.Text = "B. " + "Nghệ thuật quản lý của tư bản";
        radioButtonC.Text = "C. " + "Hiệu quả của tư bản đầu tư";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "C";
      }
      else if (numCauHoi == 103)
      {
        label_De.Text = "Quy luật giá cả sản xuất là biểu hiện hoạt động của:";
        radioButtonA.Text = "A. " + "Quy luật giá trị";
        radioButtonB.Text = "B. " + "Quy luật giá trị thặng dư";
        radioButtonC.Text = "C. " + "Quy luật cạnh tranh";
        radioButtonD.Text = "D. " + "Quy luật cung - cầu";
        DapAn = "A";
      }
      else if (numCauHoi == 104)
      {
        label_De.Text = "Lợi nhuận thương nghiệp có được là do bán hàng hoá với mức giá:";
        radioButtonA.Text = "A. " + "Cao hơn giá trị";
        radioButtonB.Text = "B. " + "Bằng giá trị";
        radioButtonC.Text = "C. " + "Bằng chi phí sản xuất TBCN";
        radioButtonD.Text = "D. " + "Thấp hơn giá trị";
        DapAn = "B";
      }
      else if (numCauHoi == 105)
      {
        label_De.Text = "Lợi tức là một phần của:";
        radioButtonA.Text = "A. " + "Lợi nhuận";
        radioButtonB.Text = "B. " + "Lợi nhuận siêu ngạch";
        radioButtonC.Text = "C. " + "Lợi nhuận bình quân";
        radioButtonD.Text = "D. " + "Lợi nhuận ngân hàng";
        DapAn = "C";
      }
      else if (numCauHoi == 106)
      {
        label_De.Text = "Trong các nhân tố ảnh hưởng đến tỷ suất lợi nhuận, nhân tố nào ảnh hưởng thuận chiều?";
        radioButtonA.Text = "A. " + "Cấu tạo hữu cơ của tư bản";
        radioButtonB.Text = "B. " + "Tốc độ chu chuyển của tư bản";
        radioButtonC.Text = "C. " + "Tư bản bất biến";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "B";
      }
      else if (numCauHoi == 107)
      {
        label_De.Text = "Nhân tố nào dưới đây có ảnh hưởng ngược chiều với tỷ suất lợi nhuận";
        radioButtonA.Text = "A. " + "Tỷ suất giá trị thặng dư";
        radioButtonB.Text = "B. " + "Tốc độ chu chuyển của tư bản";
        radioButtonC.Text = "C. " + "Cấu tạo hữu cơ của tư bản";
        radioButtonD.Text = "D. " + "Cả a và b";
        DapAn = "C";
      }
      else if (numCauHoi == 108)
      {
        label_De.Text = "Địa tô TBCN là phần còn lại sau khi khấu trừ:";
        radioButtonA.Text = "A. " + "Lợi nhuận";
        radioButtonB.Text = "B. " + "Lợi nhuận siêu ngạch";
        radioButtonC.Text = "C. " + "Lợi nhuận độc quyền";
        radioButtonD.Text = "D. " + "Lợi nhuận bình quân";
        DapAn = "D";
      }
      else if (numCauHoi == 109)
      {
        label_De.Text = "Trong CNTB, giá cả nông phẩm được xác định theo giá cả của nông phẩm ở loại đất nào?";
        radioButtonA.Text = "A. " + "Đất tốt";
        radioButtonB.Text = "B. " + "Đất trung bình";
        radioButtonC.Text = "C. " + "Đất xấu";
        radioButtonD.Text = "D. " + "Mức trung bình của các loại đất xấu";
        DapAn = "C";
      }
      else if (numCauHoi == 110)
      {
        label_De.Text = "Địa tô chênh lệch I thu được trên:";
        radioButtonA.Text = "A. " + "Ruộng đất có độ màu mỡ trung bình";
        radioButtonB.Text = "B. " + "Ruộng đất tốt";
        radioButtonC.Text = "C. " + "Ruộng đất ở vị trí thuận lợi";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 111)
      {
        label_De.Text = "Địa tô chênh lệch II thu được trên:";
        radioButtonA.Text = "A. " + "Ruộng đất đã thâm canh";
        radioButtonB.Text = "B. " + "Ruộng đất có độ màu mỡ trung bình";
        radioButtonC.Text = "C. " + "Ruộng đất có độ màu mỡ tốt";
        radioButtonD.Text = "D. " + "Ở ruộng đất có vị trí thuận lợi";
        DapAn = "A";
      }
      else if (numCauHoi == 112)
      {
        label_De.Text = "Nguyên nhân có địa tô chênh lệch II là do:";
        radioButtonA.Text = "A. " + "Do độ màu mỡ tự nhiên của đất";
        radioButtonB.Text = "B. " + "Do vị trí thuận lợi của đất";
        radioButtonC.Text = "C. " + "Do đầu tư thêm mà có";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "C";
      }
      else if (numCauHoi == 113)
      {
        label_De.Text = "Loại ruộng đất nào chỉ có địa tô tuyệt đối?";
        radioButtonA.Text = "A. " + "Ruộng tốt";
        radioButtonB.Text = "B. " + "Ruộng trung bình";
        radioButtonC.Text = "C. " + "Ruộng có vị trí thuận lợi";
        radioButtonD.Text = "D. " + "Ruộng xấu";
        DapAn = "D";
      }
      else if (numCauHoi == 114)
      {
        label_De.Text = "Trong CNTB giá cả đất đai ngày càng tăng lên vì:";
        radioButtonA.Text = "A. " + "Tỷ suất lợi tức có xu hướng giảm";
        radioButtonB.Text = "B. " + "Đất đai ngày càng khan hiếm";
        radioButtonC.Text = "C. " + "Địa tô ngày càng tăng";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 115)
      {
        label_De.Text = "Chọn các ý đúng trong các ý dưới đây:";
        radioButtonA.Text = "A. " + "Tư bản cho vay là tư bản tiềm thế";
        radioButtonB.Text = "B. " + "Tư bản ngân hàng là tư bản tiềm thế";
        radioButtonC.Text = "C. " + "Tư bản ngân hàng là tư bản hoạt động";
        radioButtonD.Text = "D. " + "Cả a và c";
        DapAn = "D";
      }
      else if (numCauHoi == 116)
      {
        label_De.Text = "Chọn các ý đúng trong các ý dưới đây:";
        radioButtonA.Text = "A. " + "Địa tô chênh lệch gắn với độc quyền tư hữu ruộng đất";
        radioButtonB.Text = "B. " + "Địa tô chênh lệch gắn với độc quyền kinh doanh trong nông nghiệp";
        radioButtonC.Text = "C. " + "Địa tô tuyệt đối gắn với độc quyền kinh doanh trong nông nghiệp";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "B";
      }
      else if (numCauHoi == 117)
      {
        label_De.Text = "Tuần hoàn của tư bản công nghiệp là sự thống nhất của các hình thái tuần hoàn";
        radioButtonA.Text = "A. " + "Tư bản tiền tệ và tư bản sản xuất";
        radioButtonB.Text = "B. " + "Tư bản sản xuất và tư bản hàng hóa";
        radioButtonC.Text = "C. " + "Tư bản tiền tệ, tư bản sản xuất và tư bản hàng hóa";
        radioButtonD.Text = "D. " + "Cả 3 câu trên đều sai";
        DapAn = "C";
      }
      else if (numCauHoi == 118)
      {
        label_De.Text = "Tỷ suất lợi nhuận bình quân hình thành";
        radioButtonA.Text = "A. " + "Do cạnh tranh nội bộ ngành";
        radioButtonB.Text = "B. " + "Do cạnh tranh giữa các ngành sản xuất";
        radioButtonC.Text = "C. " + "Do cơ chế thị trường mà có";
        radioButtonD.Text = "D. " + "Do tác động của quy luật kinh tế";
        DapAn = "B";
      }
      else if (numCauHoi == 119)
      {
        label_De.Text = "Phương pháp sản xuất giá trị thặng dư tương đối";
        radioButtonA.Text = "A. " + "Sử dụng kỹ thuật tiên tiến, cải tiến tổ chức quản lý, rút ngắn thời gian lao động tất yếu";
        radioButtonB.Text = "B. " + "Kéo dài thời gian lao động tất yếu";
        radioButtonC.Text = "C. " + "Tiết kiệm chi phí sản xuất";
        radioButtonD.Text = "D. " + "Kéo dài thời gian của ngày lao động, còn thời gian lao động tất yếu không thay đổi";
        DapAn = "A";
      }
      else if (numCauHoi == 120)
      {
        label_De.Text = "Trong 8 giờ người lao động sản xuất được 15 sản phẩm có tổng giá trị là 60 đô-la. Nếu cường độ lao động tăng lên 1,5 lần thì giá trị tổng sản phẩm (GTTSP) làm ra trong ngày và giá trị của một sản phẩm (GT1SP) lần lượt là:";
        radioButtonA.Text = "A. " + "GTTSP trong ngày là 90 đô-la; GT1SP giảm đi 1,5 lần";
        radioButtonB.Text = "B. " + "GTTSP trong ngày là 90 đô-la; GT1SP không thay đổi";
        radioButtonC.Text = "C. " + "GTTSP trong ngày không đổi; GT1SP tăng lên 1,5 lần";
        radioButtonD.Text = "D. " + "Cả 3 câu trên đều sai";
        DapAn = "B";
      }
      else if (numCauHoi == 121)
      {
        label_De.Text = "Nguồn gốc của địa tô TBCN là gì?";
        radioButtonA.Text = "A. " + "Do độ màu mỡ của đất đem lại";
        radioButtonB.Text = "B. " + "Do độc quyền tư hữu ruộng đất";
        radioButtonC.Text = "C. " + "Là một phần giá trị thặng dư do lao động tạo ra";
        radioButtonD.Text = "D. " + "Là số tiền người thuê đất trả cho chủ sở hữu đất";
        DapAn = "C";
      }
      else if (numCauHoi == 122)
      {
        label_De.Text = "Nguồn gốc của lợi nhuận thương nghiệp là:";
        radioButtonA.Text = "A. " + "Là kết quả của hoạt động buôn bán";
        radioButtonB.Text = "B. " + "Là một phần giá trị thặng dư do công nhân làm thuê tạo ra";
        radioButtonC.Text = "C. " + "Là khoản chênh lệch giữa giá mua và giá bán";
        radioButtonD.Text = "D. " + "Là kết quả của mua rẻ, bán đắt, trốn thuế";
        DapAn = "B";
      }
      else if (numCauHoi == 123)
      {
        label_De.Text = "Khối lượng giá trị thặng dư phản ánh gì?";
        radioButtonA.Text = "A. " + "Trình độ bóc lột của tư bản đối với lao động làm thuê";
        radioButtonB.Text = "B. " + "Phạm vi bóc lột của tư bản đối với lao động làm thuê";
        radioButtonC.Text = "C. " + "Quy mô bóc lột của tư bản đối với lao động làm thuê";
        radioButtonD.Text = "D. " + "Khả năng bóc lột của tư bản";
        DapAn = "C";
      }
      else if (numCauHoi == 124)
      {
        label_De.Text = "Điều kiện để có tái sản xuất mở rộng TBCN là:";
        radioButtonA.Text = "A. " + "Phải đổi mới máy móc, thiết bị";
        radioButtonB.Text = "B. " + "Phải tăng quy mô tư bản khả biến";
        radioButtonC.Text = "C. " + "Phải có tích luỹ tư bản";
        radioButtonD.Text = "D. " + "Phải cải tiến tổ chức, quản lý";
        DapAn = "C";
      }
      else if (numCauHoi == 125)
      {
        label_De.Text = "Nguồn gốc của địa tô TBCN là:";
        radioButtonA.Text = "A. " + "Là tiền cho thuê đất";
        radioButtonB.Text = "B. " + "Do giá trị sử dụng của đất (độ màu mỡ, vị trí) mang lại";
        radioButtonC.Text = "C. " + "Là một phần của lợi nhuận bình quân";
        radioButtonD.Text = "D. " + "Là một phần giá trị thặng dư do công nhân tạo ra";
        DapAn = "D";
      }
      else if (numCauHoi == 126)
      {
        label_De.Text = "Địa tô tuyệt đối là:";
        radioButtonA.Text = "A. " + "Địa tô có trên đất xấu nhất";
        radioButtonB.Text = "B. " + "Địa tô có trên đất ở vị trí xa đường giao thông, thị trường";
        radioButtonC.Text = "C. " + "Địa tô trên đất có điều kiện sản xuất khó khăn nhất";
        radioButtonD.Text = "D. " + "Địa tô có trên tất cả các loại đất cho thuê";
        DapAn = "D";
      }
      else if (numCauHoi == 127)
      {
        label_De.Text = "Địa tô chênh lệch I và chênh lệch II khác nhau ở:";
        radioButtonA.Text = "A. " + "Địa tô chênh lệch I có trên ruộng đất tốt và trung bình về màu mỡ";
        radioButtonB.Text = "B. " + "Địa tô chênh lệch II có trên ruộng đất có vị trí thuận lợi";
        radioButtonC.Text = "C. " + "Địa tô chênh lệch I do độ màu mỡ tự nhiên của đất mang lại, địa tô chênh lệch II do độ màu mỡ nhân tạo đem lại";
        radioButtonD.Text = "D. " + "Địa tô chênh lệch II có thể chuyển thành địa tô chênh lệch I";
        DapAn = "C";
      }
      else if (numCauHoi == 128)
      {
        label_De.Text = "Trong các cách diễn đạt dưới đây, cách nào không đúng?";
        radioButtonA.Text = "A. " + "Trên ruộng đất tốt, sau khi đã thâm canh có địa tô: Tuyệt đối + chênh lệch I + chênh lệch II";
        radioButtonB.Text = "B. " + "Trên loại đất có vị trí thuận lợi có địa tô: tuyệt đối + chênh lệch I";
        radioButtonC.Text = "C. " + "Trên loại đất xấu nhưng ở vị trí thuận lợi có địa tô: tuyệt đối + chênh lệch I";
        radioButtonD.Text = "D. " + "Trên loại đất xấu không có địa tô tuyệt đối";
        DapAn = "D";
      }
      else if (numCauHoi == 129)
      {
        label_De.Text = "Ngân hàng thương mại cổ phần là ngân hàng mà:";
        radioButtonA.Text = "A. " + "Vốn của nó do các tư nhân đóng góp";
        radioButtonB.Text = "B. " + "Vốn của nó do các cổ đông đóng góp";
        radioButtonC.Text = "C. " + "Là ngân hàng tư nhân được thành lập theo nguyên tắc công ty cổ phần";
        radioButtonD.Text = "D. " + "Là ngân hàng có niêm yết cổ phiếu ở sở giao dịch chứng khoán";
        DapAn = "C";
      }
      else if (numCauHoi == 130)
      {
        label_De.Text = "Bản chất tiền công TBCN là giá cả sức lao động. Đó là loại tiền công gì?";
        radioButtonA.Text = "A. " + "Tiền công theo thời gian";
        radioButtonB.Text = "B. " + "Tiền công theo sản phẩm";
        radioButtonC.Text = "C. " + "Tiền công danh nghĩa";
        radioButtonD.Text = "D. " + "Tiền công thực tế";
        DapAn = "C";
      }
      //---Chương 4
      else if (numCauHoi == 131)
      {
        label_De.Text = "Ý kiến nào là đúng nhất về cạnh tranh trong các ý sau:";
        radioButtonA.Text = "A. " + "Là cuộc đấu tranh giữa những người sản xuất";
        radioButtonB.Text = "B. " + "Là cuộc đấu tranh giữa những người sản xuất với người tiêu dùng";
        radioButtonC.Text = "C. " + "Là cuộc đấu tranh giữa các chủ thể hành vi kinh tế";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "C";
      }
      else if (numCauHoi == 132)
      {
        label_De.Text = "Mục đích của cạnh tranh là gì? Chọn câu trả lời đúng nhất trong câu trả lời sau:";
        radioButtonA.Text = "A. " + "Nhằm thu lợi nhuận nhiều nhất";
        radioButtonB.Text = "B. " + "Nhằm mua, bán hàng hoá với giá cả có lợi nhất";
        radioButtonC.Text = "C. " + "Giành các điều kiện sản xuất thuận lợi nhất";
        radioButtonD.Text = "D. " + "Giành lợi ích tối đa cho mình";
        DapAn = "D";
      }
      else if (numCauHoi == 133)
      {
        label_De.Text = "Phương thức sản xuất TBCN có những giai đoạn nào?";
        radioButtonA.Text = "A. " + "CNTB tự do cạnh tranh và CNTB độc quyền";
        radioButtonB.Text = "B. " + "CNTB hiện đại và CNTB độc quyền";
        radioButtonC.Text = "C. " + "CNTB hiện đại và CNTB tự do cạnh tranh";
        radioButtonD.Text = "D. " + "CNTB ngày nay và CNTB độc quyền";
        DapAn = "A";
      }
      else if (numCauHoi == 134)
      {
        label_De.Text = "CNTB độc quyền xuất hiện vào thời kỳ lịch sử nào?";
        radioButtonA.Text = "A. " + "Cuối thế kỷ 17 đầu thế kỷ 18";
        radioButtonB.Text = "B. " + "Cuối thế kỷ 18 đầu thế kỷ 19";
        radioButtonC.Text = "C. " + "Cuối thế kỷ 19 đầu thế kỷ 20";
        radioButtonD.Text = "D. " + "Từ sau chiến tranh thế giới thứ 2";
        DapAn = "C";
      }
      else if (numCauHoi == 135)
      {
        label_De.Text = "CNTB độc quyền là:";
        radioButtonA.Text = "A. " + "Một PTSX mới";
        radioButtonB.Text = "B. " + "Một hình thái kinh tế- xã hội";
        radioButtonC.Text = "C. " + "Một giai đoạn phát triển của PTSX-TBCN";
        radioButtonD.Text = "D. " + "Một nấc thang phát triển của LLSX";
        DapAn = "C";
      }
      else if (numCauHoi == 136)
      {
        label_De.Text = "Nguyên nhân ra đời của CNTB độc quyền là:";
        radioButtonA.Text = "A. " + "Do cuộc đấu tranh của giai cấp công nhân và nhân dân lao động";
        radioButtonB.Text = "B. " + "Do sự can thiệp của nhà nước tư sản";
        radioButtonC.Text = "C. " + "Do sự tập trung sản xuất dưới tác động của cách mạng- khoa học - công nghệ";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "C";
      }
      else if (numCauHoi == 137)
      {
        label_De.Text = "Kết luận sau đây là của ai? 'Tự do cạnh tranh đẻ ra tập trung sản xuất và sự tập trung sản xuất này khi phát triển đến mức độ nhất định, lại dẫn tới độc quyền'";
        radioButtonA.Text = "A. " + "C.Mác";
        radioButtonB.Text = "B. " + "Ph. Ăng ghen";
        radioButtonC.Text = "C. " + "Lênin";
        radioButtonD.Text = "D. " + "Cả C.Mác và Ph. Ăng ghen";
        DapAn = "C";
      }
      else if (numCauHoi == 138)
      {
        label_De.Text = "Ý kiến nào sau đây là sai?";
        radioButtonA.Text = "A. " + "Xuất khẩu tư bản là xuất khẩu giá trị sử dụng ra nước ngoài";
        radioButtonB.Text = "B. " + "Xuất khẩu tư bản là đưa vốn, công nghệ, kinh nghiệm quản lý ra nước ngoài";
        radioButtonC.Text = "C. " + "Xuất khẩu tư bản là ăn bám bình phương";
        radioButtonD.Text = "D. " + "Xuất khẩu tư bản là giúp đỡ các nước nghèo phát triển";
        DapAn = "B";
      }
      else if (numCauHoi == 139)
      {
        label_De.Text = "Sự ra đời của tư bản tài chính là kết quả của sự phát triển:";
        radioButtonA.Text = "A. " + "Độc quyền ngân hàng";
        radioButtonB.Text = "B. " + "Sự phát triển của thị trường tài chính";
        radioButtonC.Text = "C. " + "Độc quyền công nghiệp";
        radioButtonD.Text = "D. " + "Quá trình xâm nhập liên kết độc quyền ngân hàng với độc quyền công nghiệp";
        DapAn = "D";
      }
      else if (numCauHoi == 140)
      {
        label_De.Text = "Chế độ tham dự của tư bản tài chính được thiết lập do:";
        radioButtonA.Text = "A. " + "Quyết định của nhà nước";
        radioButtonB.Text = "B. " + "Yêu cầu tổ chức của các ngân hàng";
        radioButtonC.Text = "C. " + "Yêu cầu của các tổ chức độc quyền công nghiệp";
        radioButtonD.Text = "D. " + "Số cổ phiếu khống chế nắm công ty mẹ, con, cháu.";
        DapAn = "D";
      }
      else if (numCauHoi == 141)
      {
        label_De.Text = "Xuất khẩu hàng hoá là đặc điểm của:";
        radioButtonA.Text = "A. " + "Sản xuất hàng hoá giản đơn";
        radioButtonB.Text = "B. " + "Của CNTB";
        radioButtonC.Text = "C. " + "Của CNTB tự do cạnh tranh";
        radioButtonD.Text = "D. " + "Của CNTB độc quyền";
        DapAn = "C";
      }
      else if (numCauHoi == 142)
      {
        label_De.Text = "Xuất khẩu hàng hoá là:";
        radioButtonA.Text = "A. " + "Đưa hàng hoá ra nước ngoài";
        radioButtonB.Text = "B. " + "Đưa hàng hoá ra bán ở nước ngoài để thực hiện giá trị";
        radioButtonC.Text = "C. " + "Xuất khẩu giá trị ra nước ngoài";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "B";
      }
      else if (numCauHoi == 143)
      {
        label_De.Text = "Xuất khẩu tư bản là:";
        radioButtonA.Text = "A. " + "Đầu tư trực tiếp ra nước ngoài";
        radioButtonB.Text = "B. " + "Cho nước ngoài vay";
        radioButtonC.Text = "C. " + "Mang hàng hoá ra bán ở nước ngoài để thực hiện giá trị";
        radioButtonD.Text = "D. " + "Cả a và b";
        DapAn = "D";
      }
      else if (numCauHoi == 144)
      {
        label_De.Text = "Xuất khẩu tư bản là đặc điểm của:";
        radioButtonA.Text = "A. " + "Các nước giàu có";
        radioButtonB.Text = "B. " + "Của CNTB";
        radioButtonC.Text = "C. " + "Của CNTB độc quyền";
        radioButtonD.Text = "D. " + "Của CNTB tự do cạnh tranh";
        DapAn = "C";
      }
      else if (numCauHoi == 145)
      {
        label_De.Text = "Mục đích của xuất khẩu tư bản là:";
        radioButtonA.Text = "A. " + "Để giải quyết nguồn tư bản 'thừa' trong nước";
        radioButtonB.Text = "B. " + "Chiếm đoạt giá trị thặng dư và các nguồn lợi khác ở nước nhập khẩu tư bản";
        radioButtonC.Text = "C. " + "Thực hiện giá trị và chiếm các nguồn lợi khác của nước nhập khẩu tư bản";
        radioButtonD.Text = "D. " + "Giúp đỡ các nước nhập khẩu tư bản phát triển";
        DapAn = "B";
      }
      else if (numCauHoi == 146)
      {
        label_De.Text = "Về kinh tế, xuất khẩu tư bản nhà nước nhằm mục đích:";
        radioButtonA.Text = "A. " + "Thu nhiều lợi nhuận";
        radioButtonB.Text = "B. " + "Tạo điều kiện cho các nước nhập khẩu tư bản phát triển";
        radioButtonC.Text = "C. " + "Khống chế kinh tế các nước nhập khẩu tư bản";
        radioButtonD.Text = "D. " + "Tạo môi trường thuận lợi cho xuất khẩu tư bản tư nhân";
        DapAn = "D";
      }
      else if (numCauHoi == 147)
      {
        label_De.Text = "Vì sao trong CNTB độc quyền cạnh tranh không bị thủ tiêu?";
        radioButtonA.Text = "A. " + "Vì các tổ chức độc quyền cạnh tranh với nhau";
        radioButtonB.Text = "B. " + "Vì tổ chức độc quyền cạnh tranh với các công ty ngoài độc quyền";
        radioButtonC.Text = "C. " + "Vì các xí nghiệp trong nội bộ tổ chức độc quyền cạnh tranh với nhau";
        radioButtonD.Text = "D. " + "Vì cạnh tranh là quy luật khách quan của kinh tế hàng hoá";
        DapAn = "D";
      }
      else if (numCauHoi == 148)
      {
        label_De.Text = "Các cuộc xâm chiếm thuộc địa của các nước đế quốc diễn ra mạnh mẽ vào thời kỳ nào?";
        radioButtonA.Text = "A. " + "Thế kỷ XVII";
        radioButtonB.Text = "B. " + "Thế kỷ XVIII";
        radioButtonC.Text = "C. " + "Cuối thế kỷ XVIII - đầu thế kỷ XIX";
        radioButtonD.Text = "D. " + "Cuối thế kỷ XIX - đầu thế kỷ XX";
        DapAn = "D";
      }
      else if (numCauHoi == 149)
      {
        label_De.Text = "Trong giai đoạn CNTB độc quyền:";
        radioButtonA.Text = "A. " + "Quy luật giá trị không còn hoạt động";
        radioButtonB.Text = "B. " + "Quy luật giá trị vẫn hoạt động";
        radioButtonC.Text = "C. " + "Quy luật giá trị lúc hoạt động, lúc không hoạt động";
        radioButtonD.Text = "D. " + "Quy luật giá trị hoạt động kém hiệu quả";
        DapAn = "B";
      }
      else if (numCauHoi == 150)
      {
        label_De.Text = "Trong giai đoạn CNTB độc quyền quy luật giá trị có biểu hiện mới, thành:";
        radioButtonA.Text = "A. " + "Quy luật giá cả sản xuất";
        radioButtonB.Text = "B. " + "Quy luật giá cả độc quyền";
        radioButtonC.Text = "C. " + "Quy luật lợi nhuận độc quyền";
        radioButtonD.Text = "D. " + "Quy luật lợi nhuận bình quân";
        DapAn = "B";
      }
      else if (numCauHoi == 151)
      {
        label_De.Text = "Conglomeret là:";
        radioButtonA.Text = "A. " + "Tổ chức độc quyền đa ngành có hàng trăm doanh nghiệp";
        radioButtonB.Text = "B. " + "Kết hợp vài ba chục hãng vừa và nhỏ không có sự liên quan nào về sản xuất và dịch vụ cho sản xuất";
        radioButtonC.Text = "C. " + "Tổ chức độc quyền gồm hàng trăm doanh nghiệp có quan hệ chặt chẽ nhau về sản xuất và dịch vụ";
        radioButtonD.Text = "D. " + "Kết hợp nhiều doanh nghiệp vừa và nhỏ có quan hệ chặt chẽ về sản xuất và dịch vụ";
        DapAn = "B";
      }
      else if (numCauHoi == 152)
      {
        label_De.Text = "Chủ nghĩa tư bản tạo ra những vấn đề gì trong lịch sử?";
        radioButtonA.Text = "A. " + "Tạo ra những nhân tố mới thúc đẩy phát triển kinh tế.";
        radioButtonB.Text = "B. " + "Gây ra những hậu quả nặng nề cho nhân loại.";
        radioButtonC.Text = "C. " + "Tạo tiền đề vật chất đầy đủ và tiền đề xã hội chín muồi cho sự ra đời của xã hội mới.";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 153)
      {
        label_De.Text = "Biểu hiện về mặt xã hội của mâu thuẫn giữa tính chất xã hội hoá của lực lượng sản xuất với quan hệ chiếm hữu tư nhân tư bản chủ nghĩa về tư liệu sản xuất trong xã hội tư bản là gì?";
        radioButtonA.Text = "A. " + "Mâu thuẫn giữa giai cấp công nhân và giai cấp tư sản";
        radioButtonB.Text = "B. " + "Mâu thuẫn giữa các nhà tư bản với nha";
        radioButtonC.Text = "C. " + "Mâu thuẫn giữa giai cấp tư sản với giai cấp nông dân";
        radioButtonD.Text = "D. " + "Mâu thuẫn giữa các nhà tư bản độc quyền";
        DapAn = "A";
      }
      else if (numCauHoi == 154)
      {
        label_De.Text = "CNTB độc quyền nhà nước là:";
        radioButtonA.Text = "A. " + "Một quan hệ kinh tế, chính trị, xã hội";
        radioButtonB.Text = "B. " + "Một chính sách trong giai đoạn độc quyền";
        radioButtonC.Text = "C. " + "Một kiểu tổ chức kinh tế – xã hội";
        radioButtonD.Text = "D. " + "Một cơ chế điều tiết của nhà nước tư sản";
        DapAn = "A";
      }
      else if (numCauHoi == 155)
      {
        label_De.Text = "Cơ chế kinh tế của CNTB độc quyền nhà nước gồm:";
        radioButtonA.Text = "A. " + "Cơ chế thị trường và độc quyền tư nhân";
        radioButtonB.Text = "B. " + "Độc quyền tư nhân và sự điều tiết của nhà nước";
        radioButtonC.Text = "C. " + "Cơ chế thị trường, độc quyền tư nhân và sự can thiệp của nhà nước";
        radioButtonD.Text = "D. " + "Cơ chế thị trường và sự điều tiết của nhà nước";
        DapAn = "C";
      }
      else if (numCauHoi == 156)
      {
        label_De.Text = "Bản chất kinh tế của chủ nghĩa đế quốc là:";
        radioButtonA.Text = "A. " + "Sự thống trị các dân tộc thuộc địa về kinh tế";
        radioButtonB.Text = "B. " + "Sự thống trị của các tổ chức độc quyền";
        radioButtonC.Text = "C. " + "Là xâm lược, hiếu chiến, phản động toàn diện";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "B";
      }
      //---Chương 5---
      else if (numCauHoi == 157)
      {
        label_De.Text = "Nhận định sau đây là đúng hay sai? 'Kinh tế thị trường do CNTB sinh ra và là sản phẩm riêng có của CNTB'";
        radioButtonA.Text = "A. " + "Đúng";
        radioButtonB.Text = "B. " + "Sai";
        radioButtonC.Text = "C. " + "Không đủ cơ sở để xác định";
        radioButtonD.Text = "D. " + "Ý kiến khác";
        DapAn = "B";
      }
      else if (numCauHoi == 158)
      {
        label_De.Text = "Kinh tế thị trường trải qua mấy giai đoạn?";
        radioButtonA.Text = "A. " + "2";
        radioButtonB.Text = "B. " + "3";
        radioButtonC.Text = "C. " + "4";
        radioButtonD.Text = "D. " + "5";
        DapAn = "B";
      }
      else if (numCauHoi == 159)
      {
        label_De.Text = "Mô hình kinh tế thị trường của Việt Nam là:";
        radioButtonA.Text = "A. " + "Mô hình kinh tế thị trường tự do mới";
        radioButtonB.Text = "B. " + "Kinh tế thị trường xã hội";
        radioButtonC.Text = "C. " + "Kinh tế thị trường xã hội chủ nghĩa";
        radioButtonD.Text = "D. " + "Cả a, b và c đều sai";
        DapAn = "D";
      }
      else if (numCauHoi == 160)
      {
        label_De.Text = "Mô hình kinh tế thị trường định hướng xã hội chủ nghĩa ở Việt Nam được xác định là mô hình kinh tế tổng quát của thời kỳ quá độ lên chủ nghĩa xã hội ở nước ta từ Đại hội đại biểu toàn quốc lần thứ mấy của Đảng?";
        radioButtonA.Text = "A. " + "Đại hội VI";
        radioButtonB.Text = "B. " + "Đại hội VII";
        radioButtonC.Text = "C. " + "Đại hội IX";
        radioButtonD.Text = "D. " + "Đại hội X";
        DapAn = "C";
      }
      else if (numCauHoi == 161)
      {
        label_De.Text = "Đại hội nào của Đảng đã xác định: “Nền kinh tế thị trường định hướng xã hội chủ nghĩa ở nước ta là nền kinh tế hàng hóa nhiều thành phần, vận hành theo cơ chế thị trường, có sự quản lý của nhà nước, dưới sự lãnh đạo của Đảng Cộng sản”?";
        radioButtonA.Text = "A. " + "Đại hội VIII";
        radioButtonB.Text = "B. " + "Đại hội IX";
        radioButtonC.Text = "C. " + "Đại hội X";
        radioButtonD.Text = "D. " + "Đại hội XI";
        DapAn = "D";
      }
      else if (numCauHoi == 162)
      {
        label_De.Text = "Phát triển kinh tế thị trường định hướng xã hội chủ nghĩa ở Việt Nam là tất yếu khách quan vì:";
        radioButtonA.Text = "A. " + "Phù hợp với quy luật phát triển khách quan";
        radioButtonB.Text = "B. " + "Do tính ưu việt của kinh tế thị trường trong thúc đẩy phát triển";
        radioButtonC.Text = "C. " + "Do đó là mô hình phù hợp với nguyện vọng của nhân dân";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 163)
      {
        label_De.Text = "Hiện nay ở Việt Nam có mấy thành phần kinh tế cơ bản?";
        radioButtonA.Text = "A. " + "Có 3 thành phần";
        radioButtonB.Text = "B. " + "Có 4 thành phần";
        radioButtonC.Text = "C. " + "Có 5 thành phần";
        radioButtonD.Text = "D. " + "Có 6 thành phần";
        DapAn = "C";
      }
      else if (numCauHoi == 164)
      {
        label_De.Text = "Nền kinh tế nước ta thực sự chuyển sang kinh tế thị trường năm nào?";
        radioButtonA.Text = "A. " + "Năm 1980: khi bắt đầu có sự đổi mới trong đường lối chính sách kinh tế của Đảng và Nhà nước";
        radioButtonB.Text = "B. " + "Năm 1982: Đại hội Đảng V";
        radioButtonC.Text = "C. " + "Năm 1986: Đại hội Đảng VI";
        radioButtonD.Text = "D. " + "Năm 1991: Đại hội Đảng VII";
        DapAn = "C";
      }
      else if (numCauHoi == 165)
      {
        label_De.Text = "Đại hội nào của Đảng ta được coi là Đại hội của sự đổi mới?";
        radioButtonA.Text = "A. " + "Đại hội V (1982)";
        radioButtonB.Text = "B. " + "Đại hội VI (1986)";
        radioButtonC.Text = "C. " + "Đại hội VII (1991)";
        radioButtonD.Text = "D. " + "Đại hội VIII (1996)";
        DapAn = "B";
      }
      else if (numCauHoi == 166)
      {
        label_De.Text = "Ý kiến nào sau đây là đúng?";
        radioButtonA.Text = "A. " + "Kinh tế thị trường là một kiểu tổ chức kinh tế-xã hội";
        radioButtonB.Text = "B. " + "Kinh tế thị trường chỉ có ở CNTB";
        radioButtonC.Text = "C. " + "Kinh tế thị trường có ở tất cả các chế độ xã hội";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "A";
      }
      else if (numCauHoi == 167)
      {
        label_De.Text = "Không có";
        radioButtonA.Text = "A. " + "Không có";
        radioButtonB.Text = "B. " + "Không có";
        radioButtonC.Text = "C. " + "Không có";
        radioButtonD.Text = "D. " + "Không có";
        DapAn = "Không có câu này trong tài liệu";
      }
      else if (numCauHoi == 168)
      {
        label_De.Text = "Chọn ý không đúng về việc xác lập sở hữu công cộng tư liệu sản xuất:";
        radioButtonA.Text = "A. " + "Là quá trình lâu dài, từ thấp đến cao và luôn luôn phù hợp với trình độ của lực lượng sản xuất";
        radioButtonB.Text = "B. " + "Cần tiến hành nhanh thông qua quốc hữu hoá";
        radioButtonC.Text = "C. " + "Làm cho sở hữu công cộng có năng suất, chất lượng và hiệu quả cao hơn so với sở hữu tư nhân";
        radioButtonD.Text = "D. " + "Cả a và c";
        DapAn = "B";
      }
      else if (numCauHoi == 169)
      {
        label_De.Text = "Nguyên nhân tồn tại nhiều thành phần kinh tế trong thời kỳ quá độ ở nước ta là do:";
        radioButtonA.Text = "A. " + "Do trình độ lực lượng sản xuất còn nhiều thang bậc khác nhau, còn nhiều quan hệ sở hữu về tư liệu sản xuất";
        radioButtonB.Text = "B. " + "Do xã hội cũ để lại";
        radioButtonC.Text = "C. " + "Do quá trình cải tạo và xây dựng quan hệ sản xuất mới";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 170)
      {
        label_De.Text = "Thành phần kinh tế là khu vực kinh tế, kiểu quan hệ kinh tế dựa trên:";
        radioButtonA.Text = "A. " + "Một hình thức sở hữu nhất định về tư liệu sản xuất";
        radioButtonB.Text = "B. " + "Một quan hệ sản xuất nhất định";
        radioButtonC.Text = "C. " + "Một trình độ nhất định của lực lượng sản xuất";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 171)
      {
        label_De.Text = "Tư tưởng về quá độ lên CNXH bỏ qua TBCN do ai nêu ra?";
        radioButtonA.Text = "A. " + "C.Mác";
        radioButtonB.Text = "B. " + "Ph.Ăng ghen";
        radioButtonC.Text = "C. " + "V.I.Lênin";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "C";
      }
      else if (numCauHoi == 172)
      {
        label_De.Text = "‘Phân tích cho đến cùng thì năng suất lao động là cái quan trọng nhất, căn bản nhất cho sự thắng lợi của chế độ xã hội mới’. Câu nói này của ai?";
        radioButtonA.Text = "A. " + "V.I.Lênin";
        radioButtonB.Text = "B. " + "Ph.Ăng ghen";
        radioButtonC.Text = "C. " + "C.Mác";
        radioButtonD.Text = "D. " + "J.Stalin";
        DapAn = "A";
      }
      else if (numCauHoi == 173)
      {
        label_De.Text = "Tư tưởng quá độ bỏ qua chế độ TBCN lên CNXH lần đầu tiên thể hiện trong văn kiện nào của Đảng Cộng sản Việt Nam?";
        radioButtonA.Text = "A. " + "Năm 1930 trong cương lĩnh do đồng chí Trần Phú soạn thảo";
        radioButtonB.Text = "B. " + "Năm 1951 trong văn kiện Đại hội II";
        radioButtonC.Text = "C. " + "Năm 1960 trong văn kiện Đại hội III";
        radioButtonD.Text = "D. " + "Năm 1976 trong văn kiện Đại hội IV";
        DapAn = "A";
      }
      else if (numCauHoi == 174)
      {
        label_De.Text = "Thời kỳ quá độ lên CNXH ở nước ta bắt đầu từ khi nào?";
        radioButtonA.Text = "A. " + "Sau Cách mạng tháng 8 - 1945";
        radioButtonB.Text = "B. " + "Sau khi miền Bắc được giải phóng (1954)";
        radioButtonC.Text = "C. " + "Sau đại thắng mùa xuân 1975";
        radioButtonD.Text = "D. " + "Cả a, b và c đều sai";
        DapAn = "C";
      }
      else if (numCauHoi == 175)
      {
        label_De.Text = "Tiến lên CNXH bỏ qua chế độ TBCN là bỏ qua:";
        radioButtonA.Text = "A. " + "Bỏ qua tất cả cái gì có trong CNTB";
        radioButtonB.Text = "B. " + "Bỏ qua sự thống trị của QHSX TBCN";
        radioButtonC.Text = "C. " + "Bỏ qua sự thống trị của kiến trúc thượng tầng TBCN";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 176)
      {
        label_De.Text = "Tiến lên CNXH bỏ qua chế độ TBCN, nhưng không thể bỏ qua:";
        radioButtonA.Text = "A. " + "Những thành tựu văn minh mà nhân loại đạt được trong CNTB, đặc biệt là khoa học công nghệ";
        radioButtonB.Text = "B. " + "Những thành tựu của kinh tế thị trường";
        radioButtonC.Text = "C. " + "Những tính quy luật của sự phát triển LLSX";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "C";
      }
      else if (numCauHoi == 177)
      {
        label_De.Text = "Nội dung nhiệm vụ phát triển lực lượng sản xuất gồm có:";
        radioButtonA.Text = "A. " + "Xây dựng cơ sở vật chất - kỹ thuật cho CNXH";
        radioButtonB.Text = "B. " + "Tiến hành công nghiệp hóa, hiện đại hóa đất nước";
        radioButtonC.Text = "C. " + "Xây dựng con người, đào tạo lực lượng lao động mới";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 178)
      {
        label_De.Text = "Phạm trù chiếm hữu là:";
        radioButtonA.Text = "A. " + "Hành vi chưa xuất hiện trong xã hội nguyên thuỷ";
        radioButtonB.Text = "B. " + "Biểu hiện quan hệ giữa người với tự nhiên trong quá trinh sản xuất ra của cải vật chất";
        radioButtonC.Text = "C. " + "Là quan hệ giữa người với người trong việc chiếm hữu của cải";
        radioButtonD.Text = "D. " + "Là phạm trù lịch sử";
        DapAn = "B";
      }
      else if (numCauHoi == 179)
      {
        label_De.Text = "Phạm trù sở hữu:";
        radioButtonA.Text = "A. " + "Là điều kiện trước tiên của hoạt động sản xuất vật chất";
        radioButtonB.Text = "B. " + "Là biểu hiện quan hệ giữa người với tự nhiên trong quá trình sản xuất";
        radioButtonC.Text = "C. " + "Là hình thức xã hội của chiếm hữu trong một xã hội nhất định";
        radioButtonD.Text = "D. " + "Là phạm trù vĩnh viễn";
        DapAn = "C";
      }
      else if (numCauHoi == 180)
      {
        label_De.Text = "Chọn mệnh đề đúng dưới đây:";
        radioButtonA.Text = "A. " + "Khái niệm sở hữu đồng nghĩa với khái niệm chiếm hữu";
        radioButtonB.Text = "B. " + "Người sở hữu có thể là người chiếm hữu";
        radioButtonC.Text = "C. " + "Người sở hữu đương nhiên là người chiếm hữu";
        radioButtonD.Text = "D. " + "Người chiếm hữu đương nhiên là người sở hữu";
        DapAn = "B";
      }
      else if (numCauHoi == 181)
      {
        label_De.Text = "Sở hữu tồn tại thế nào?";
        radioButtonA.Text = "A. " + "Tồn tại độc lập";
        radioButtonB.Text = "B. " + "Tồn tại thông qua các thành phần kinh tế";
        radioButtonC.Text = "C. " + "Tồn tại thông qua các hình thức tổ chức sản xuất kinh doanh";
        radioButtonD.Text = "D. " + "Cả b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 182)
      {
        label_De.Text = "Thế nào là quan hệ sở hữu:";
        radioButtonA.Text = "A. " + "Là quan hệ giữa người với người, giữa các giai cấp về đối tượng sở hữu";
        radioButtonB.Text = "B. " + "Là quan hệ giữa chủ thể sở hữu với đối tượng sở hữu";
        radioButtonC.Text = "C. " + "Là quan hệ giữa các chủ thể sở hữu với nhau";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "A";
      }
      else if (numCauHoi == 183)
      {
        label_De.Text = "Thế nào là chế độ sở hữu:";
        radioButtonA.Text = "A. " + "Là quan hệ giữa người với tự nhiên trong quá trình sản xuất của cải vật chất";
        radioButtonB.Text = "B. " + "Là hình thức xã hội của chiếm hữu trong một xã hội";
        radioButtonC.Text = "C. " + "Là quan hệ giữa người với người trong việc chiếm hữu tư liệu sản xuất";
        radioButtonD.Text = "D. " + "Là phạm trù sở hữu được thể chế hoá thành quyền sở hữu được thực hiện thông qua một cơ chế nhất định";
        DapAn = "D";
      }
      else if (numCauHoi == 184)
      {
        label_De.Text = "Chọn mệnh đề đúng dưới đây:";
        radioButtonA.Text = "A. " + "Trong mỗi phương thức sản xuất có 1 loại hình sở hữu tư liệu sản xuất đặc trưng";
        radioButtonB.Text = "B. " + "Mỗi phương thức sản xuất có 1 hình thức sở hữu tư liệu sản xuất";
        radioButtonC.Text = "C. " + "Mỗi phương thức sản xuất có nhiều hình thức sở hữu tư liệu sản xuất";
        radioButtonD.Text = "D. " + "Cả a và c";
        DapAn = "";
      }
      else if (numCauHoi == 185)
      {
        label_De.Text = "Chọn phương án đúng:";
        radioButtonA.Text = "A. " + "Sự thay đổi của các hình thức sở hữu là quá trình lịch sử tự nhiên";
        radioButtonB.Text = "B. " + "Sự biến đổi các hình thức sở hữu do con người quy định";
        radioButtonC.Text = "C. " + "Các hình thức sở hữu TLSX do nhà nước đặt ra";
        radioButtonD.Text = "D. " + "Cả a, b, c đều đúng";
        DapAn = "A";
      }
      else if (numCauHoi == 186)
      {
        label_De.Text = "Sở hữu xét về mặt pháp lý là:";
        radioButtonA.Text = "A. " + "Quy định về quyền kế thừa, thế chấp đối tượng sở hữu";
        radioButtonB.Text = "B. " + "Quy định về quyền chuyển nhượng, cho thuê đối tượng sở hữu";
        radioButtonC.Text = "C. " + "Thể chế hoá về mặt pháp luật quan hệ giữa người với người về đối tượng sở hữu";
        radioButtonD.Text = "D. " + "Mang lại thu nhập cho chủ sở hữu";
        DapAn = "";
      }
      else if (numCauHoi == 187)
      {
        label_De.Text = "Trong thời kỳ quá độ ở nước ta, sở hữu nhà nước giữ vai trò gì?";
        radioButtonA.Text = "A. " + "Thống trị trong cơ cấu sở hữu ở nước ta";
        radioButtonB.Text = "B. " + "Chủ đạo trong cơ cấu sở hữu ở nước ta";
        radioButtonC.Text = "C. " + "Nền tảng trong cơ cấu sở hữu ở nước ta";
        radioButtonD.Text = "D. " + "Quan trọng trong cơ cấu sở hữu ở nước ta";
        DapAn = "B";
      }
      else if (numCauHoi == 188)
      {
        label_De.Text = "Trong thời kỳ quá độ ở nước ta, sở hữu nhà nước được thiết lập:";
        radioButtonA.Text = "A. " + "Đối với lĩnh vực kết cấu hạ tầng, tài nguyên, các tài sản quốc gia";
        radioButtonB.Text = "B. " + "ở các lĩnh vực then chốt của nền kinh tế";
        radioButtonC.Text = "C. " + "ở các lĩnh vực cung ứng hàng hoá, dịch vụ thông thường";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 189)
      {
        label_De.Text = "Trong thời kỳ quá độ ở nước ta sở hữu tư nhân:";
        radioButtonA.Text = "A. " + "Bị xoá bỏ";
        radioButtonB.Text = "B. " + "Tồn tại đan xen với các hình thức sở hữu khác";
        radioButtonC.Text = "C. " + "Bị hạn chế";
        radioButtonD.Text = "D. " + "Là hình thức sở hữu thống trị";
        DapAn = "B";
      }
      else if (numCauHoi == 190)
      {
        label_De.Text = "Sở hữu tư nhân ở nước ta gồm có:";
        radioButtonA.Text = "A. " + "Sở hữu cá thể";
        radioButtonB.Text = "B. " + "Sở hữu tiểu chủ";
        radioButtonC.Text = "C. " + "Sở hữu tư bản tư nhân";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 191)
      {
        label_De.Text = "Cơ cấu kinh tế nhiều thành phần có vai trò gì?";
        radioButtonA.Text = "A. " + "Cho phép khai thác, sử dụng có hiệu quả các yếu tố sản xuất các nguồn lực và tiềm năng của nền kinh tế";
        radioButtonB.Text = "B. " + "Thúc đẩy kinh tế hàng hoá phát triển, khoa học, công nghệ phát triển nhanh";
        radioButtonC.Text = "C. " + "Làm cho năng suất lao động tăng, kinh tế tăng trưởng nhanh và hiệu quả";
        radioButtonD.Text = "D. " + "Cả a, b và c";
        DapAn = "D";
      }
      else if (numCauHoi == 192)
      {
        label_De.Text = "Chọn các ý đúng về sở hữu và thành phần kinh tế:";
        radioButtonA.Text = "A. " + "Một hình thức sở hữu hình thành 1 thành phần kinh tế";
        radioButtonB.Text = "B. " + "Một hình thức sở hữu có thể hình thành nhiều thành phần kinh tế";
        radioButtonC.Text = "C. " + "Một thành phần kinh tế chỉ tồn tại thông qua 1 hình thức tổ chức sản xuất kinh doanh";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "B";
      }
      else if (numCauHoi == 193)
      {
        label_De.Text = "Chọn các ý đúng về sở hữu và thành phần kinh tế:";
        radioButtonA.Text = "A. " + "Một hình thức sở hữu hình thành 1 thành phần kinh tế";
        radioButtonB.Text = "B. " + "Một hình thức sở hữu có thể hình thành nhiều thành phần kinh tế";
        radioButtonC.Text = "C. " + "Một thành phần kinh tế chỉ tồn tại thông qua 1 hình thức tổ chức sản xuất kinh doanh";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 194)
      {
        label_De.Text = "Thành phần kinh tế nhà nước bao gồm:";
        radioButtonA.Text = "A. " + "Các doanh nghiệp nhà nước, các tổ chức kinh tế của nhà nước";
        radioButtonB.Text = "B. " + "Các tài sản thuộc sở hữu toàn dân";
        radioButtonC.Text = "C. " + "Các quỹ dự trữ quốc gia, quỹ bảo hiểm nhà nước";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 195)
      {
        label_De.Text = "Phạm trù kinh tế nhà nước:";
        radioButtonA.Text = "A. " + "Rộng hơn phạm trù doanh nghiệp nhà nước";
        radioButtonB.Text = "B. " + "Trùng với phạm trù kinh tế quốc doanh";
        radioButtonC.Text = "C. " + "Hẹp hơn phạm trù doanh nghiệp nhà nước";
        radioButtonD.Text = "D. " + "Trùng với phạm trù doanh nghiệp nhà nước";
        DapAn = "A";
      }
      else if (numCauHoi == 196)
      {
        label_De.Text = "Trong thành phần kinh tế nhà nước thực hiện nguyên tắc phân phối nào?";
        radioButtonA.Text = "A. " + "Theo lao động";
        radioButtonB.Text = "B. " + "Theo hiệu quá sản xuất kinh doanh";
        radioButtonC.Text = "C. " + "Ngoài thù lao lao động thông qua các quỹ phúc lợi xã hội và tập thể";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 197)
      {
        label_De.Text = "Kinh tế nhà nước giữ vai trò chủ đạo. Biểu hiện nào dưới đây không đúng về vai trò chủ đạo:";
        radioButtonA.Text = "A. " + "Chiếm tỷ trọng lớn";
        radioButtonB.Text = "B. " + "Nắm các ngành then chốt, các lĩnh vực quan trọng";
        radioButtonC.Text = "C. " + "Là nhân tố chính thúc đẩy tăng trưởng kinh tế nhanh và bền vững, có tác dụng chi phối các thành phần kinh tế khác";
        radioButtonD.Text = "D. " + "Đi đầu trong ứng dụng tiến bộ khoa học công nghệ, là công cụ để định hướng và điều tiết kinh tế vĩ mô";
        DapAn = "A";
      }
      else if (numCauHoi == 198)
      {
        label_De.Text = "Thành phần kinh tế tập thể bao gồm các hình thức tổ chức sản xuất kinh doanh nào?";
        radioButtonA.Text = "A. " + "Các hợp tác xã cổ phần, hợp tác xã dịch vụ đầu vào đầu ra";
        radioButtonB.Text = "B. " + "Kinh tế trang trại";
        radioButtonC.Text = "C. " + "Tổ, nhóm hợp tác xã và hợp tác xã";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 199)
      {
        label_De.Text = "Các hợp tác xã kiểu mới được xây dựng và hoạt động theo nguyên tắc:";
        radioButtonA.Text = "A. " + "Tự nguyện, cùng có lợi";
        radioButtonB.Text = "B. " + "Bình đẳng, quản lý dân chủ";
        radioButtonC.Text = "C. " + "Có sự lãnh đạo của Đảng và quản lý của nhà nước";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 200)
      {
        label_De.Text = "Trong kinh tế tập thể thực hiện nguyên tắc phân phối nào?";
        radioButtonA.Text = "A. " + "Theo lao động";
        radioButtonB.Text = "B. " + "Vốn đóng góp";
        radioButtonC.Text = "C. " + "Mức độ tham gia dịch vụ";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "D";
      }
      else if (numCauHoi == 201)
      {
        label_De.Text = "Kinh tế tiểu chủ có đặc điểm:";
        radioButtonA.Text = "A. " + "Chưa sử dụng lao động làm thuê";
        radioButtonB.Text = "B. " + "Có sử dụng lao động làm thuê nhưng rất nhỏ";
        radioButtonC.Text = "C. " + "Chỉ dựa vào lao động bản thân và gia đình";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "B";
      }
      else if (numCauHoi == 202)
      {
        label_De.Text = "Hình thức tổ chức sản xuất kinh doanh điển hình của kinh tế cá thể tiểu chủ là:";
        radioButtonA.Text = "A. " + "Kinh tế hộ gia đình";
        radioButtonB.Text = "B. " + "Kinh tế trang trại";
        radioButtonC.Text = "C. " + "Công ty trách nhiệm 1 thành viên";
        radioButtonD.Text = "D. " + "Cả a, b, c";
        DapAn = "A";
      }
      else if (numCauHoi == 203)
      {
        label_De.Text = "Điểm giống nhau cơ bản của kinh tế cá thể và tiểu chủ là:";
        radioButtonA.Text = "A. " + "Sử dụng lao động bản thân và gia đình";
        radioButtonB.Text = "B. " + "Chưa sử dụng lao động làm thuê";
        radioButtonC.Text = "C. " + "Dựa trên cơ sở tư hữu nhỏ về tư liệu sản xuất";
        radioButtonD.Text = "D. " + "Có sử dụng một số lao động làm thuê";
        DapAn = "C";
      }
      else if (numCauHoi == 204)
      {
        label_De.Text = "Điểm khác nhau cơ bản giữa kinh tế cá thể và kinh tế tiểu chủ là ở:";
        radioButtonA.Text = "A. " + "Kinh tế cá thể chỉ sử dụng lao động bản thân và gia đình";
        radioButtonB.Text = "B. " + "Kinh tế tiểu chủ có sử dụng lao động làm thuê nhưng không đáng kể";
        radioButtonC.Text = "C. " + "Kinh tế cá thể có thể trở thành kinh tế tiểu chủ";
        radioButtonD.Text = "D. " + "Kinh tế tiểu chủ có thể trở thành kinh tế cá thể";
        DapAn = "A";
      }
      else if (numCauHoi == 205)
      {
        label_De.Text = "Thành phần kinh tế tư bản tư nhân dựa trên:";
        radioButtonA.Text = "A. " + "Sở hữu tư nhân về tư liệu sản xuất";
        radioButtonB.Text = "B. " + "Chế độ tư hữu nhỏ về tư liệu sản xuất";
        radioButtonC.Text = "C. " + "Chế độ tư hữu lớn về tư liệu sản xuất";
        radioButtonD.Text = "D. " + "Sử dụng lao động làm thuê";
        DapAn = "C";
      }
      else if (numCauHoi == 206)
      {
        label_De.Text = "Thành phần kinh tế tư bản nhà nước gồm:";
        radioButtonA.Text = "A. " + "Hình thức liên doanh giữa nhà nước với tư bản tư nhân trong nước";
        radioButtonB.Text = "B. " + "Hình thức liên doanh giữa nhà nước với tư bản tư nhân nước ngoài";
        radioButtonC.Text = "C. " + "Xí nghiệp 100% vốn nước ngoài";
        radioButtonD.Text = "D. " + "Cả a và b";
        DapAn = "D";
      }
      else if (numCauHoi == 207)
      {
        label_De.Text = "Sử dụng thành phần kinh tế tư bản nhà nước có lợi gì? ";
        radioButtonA.Text = "A. " + "Huy động và sử dụng được nguồn vốn lớn có hiệu quả ";
        radioButtonB.Text = "B. " + "Học tập được kinh nghiệm quản lý tiên tiến";
        radioButtonC.Text = "C. " + "Tiếp nhận được kỹ thuật công nghệ hiện đại ";
        radioButtonD.Text = "D. " + "Cả a, b, c ";
        DapAn = "D";
      }
      else if (numCauHoi == 208)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 209)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 210)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 211)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 212)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 213)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 214)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 215)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 216)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 217)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 218)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 219)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 220)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 221)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 222)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 223)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 224)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 225)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 226)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 227)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 228)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 229)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 230)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 231)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 232)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 233)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 234)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 235)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 236)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 237)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 238)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 239)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 240)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 241)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 242)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 243)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 244)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 245)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 246)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 247)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 248)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 249)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 250)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 251)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 252)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 253)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 254)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 255)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 256)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 257)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 258)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 259)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 260)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 261)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 262)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 263)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 264)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 265)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 266)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 267)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 268)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 269)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 270)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 271)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 272)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 273)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 274)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 275)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 276)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 277)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 278)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 279)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 280)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 281)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 282)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 283)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 284)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 285)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 286)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 287)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 288)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 289)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 290)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 291)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 292)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 293)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 294)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 295)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 296)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 297)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 298)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 299)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }
      else if (numCauHoi == 300)
      {
        label_De.Text = "";
        radioButtonA.Text = "A. " + "";
        radioButtonB.Text = "B. " + "";
        radioButtonC.Text = "C. " + "";
        radioButtonD.Text = "D. " + "";
        DapAn = "";
      }

      //else if (numCauHoi == )
      //{
      //  label_De.Text = "";
      //  radioButtonA.Text = "A. " + "";
      //  radioButtonB.Text = "B. " + "";
      //  radioButtonC.Text = "C. " + "";
      //  radioButtonD.Text = "D. " + "";
      //  DapAn = "";
      //}
    }
  }
}
