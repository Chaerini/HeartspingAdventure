using System;
using System.Windows.Forms;

namespace prj_HeartspingAdventure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 버튼 + 마우스 테두리 변경 코드 ①
            // 버튼 기본 스타일 설정
            btn_load.FlatStyle = FlatStyle.Flat; // 불러오기
            btn_Newgame.FlatStyle = FlatStyle.Flat; // 시작
            btn_Exit.FlatStyle = FlatStyle.Flat; // 종료

            // 마우스가 버튼 위에 있을 때 테두리 없애기
            btn_load.MouseEnter += new EventHandler(Button_MouseEnter_L); // 불러오기
            btn_load.MouseLeave += new EventHandler(Button_MouseLeave_L);

            btn_Newgame.MouseEnter += new EventHandler(Button_MouseEnter_N); // 시작
            btn_Newgame.MouseLeave += new EventHandler(Button_MouseLeave_N);

            btn_Exit.MouseEnter += new EventHandler(Button_MouseEnter_E); // 종료
            btn_Exit.MouseLeave += new EventHandler(Button_MouseLeave_E);
        }

        // 버튼 + 마우스 테두리 변경 코드 ②
        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_L(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_load.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_load.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_L(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_load.FlatStyle = FlatStyle.Flat;
        }

        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_N(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Newgame.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Newgame.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_N(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Newgame.FlatStyle = FlatStyle.Flat;
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

        private void button3_Click(object sender, EventArgs e)  // 종료
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)  // 불러오기
        {
            Form2 loadSaveFIle = new Form2();
            loadSaveFIle.Show();
        }

        private void btn_Newgame_Click(object sender, EventArgs e)  // 새 게임
        {
            Status.FirstStatus();
            Form3 Newgame = new Form3();
            Newgame.Show();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
