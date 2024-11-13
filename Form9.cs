using System;
using System.Windows.Forms;

namespace prj_HeartspingAdventure
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            // 버튼 + 마우스 테두리 변경 코드 ①
            // 버튼 기본 스타일 설정
            btn_save.FlatStyle = FlatStyle.Flat; // 저장
            btn_Exit.FlatStyle = FlatStyle.Flat; // 종료
            btn_Main.FlatStyle = FlatStyle.Flat; // 메인

            // 마우스가 버튼 위에 있을 때 테두리 없애기
            btn_save.MouseEnter += new EventHandler(Button_MouseEnter_S); // 저장
            btn_save.MouseLeave += new EventHandler(Button_MouseLeave_S);

            btn_Exit.MouseEnter += new EventHandler(Button_MouseEnter_E); // 종료
            btn_Exit.MouseLeave += new EventHandler(Button_MouseLeave_E);

            btn_Main.MouseEnter += new EventHandler(Button_MouseEnter_M); // 메인
            btn_Main.MouseLeave += new EventHandler(Button_MouseLeave_M);
        }

        // 버튼 + 마우스 테두리 변경 코드 ②
        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_S(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_save.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_save.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_S(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_save.FlatStyle = FlatStyle.Flat;
        }

        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_E(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Exit.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Exit.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_E(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Exit.FlatStyle = FlatStyle.Flat;
        }

        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_M(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Main.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Main.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_M(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Main.FlatStyle = FlatStyle.Flat;
        }

        private void btn_save_Click(object sender, EventArgs e) // 저장
        {
            this.Close();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e) //종료
        {
            Application.Exit();
        }

        private void btn_Main_Click(object sender, EventArgs e) // 메인화면 불러오기
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Update();
        }
    }
}