using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// 저장
namespace prj_HeartspingAdventure
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

            // 버튼 + 마우스 테두리 변경 코드 ①
            // 버튼 기본 스타일 설정
            btn_HOME.FlatStyle = FlatStyle.Flat; // HOME
            // 마우스가 버튼 위에 있을 때 테두리 없애기
            btn_HOME.MouseEnter += new EventHandler(Button_MouseEnter); // HOME
            btn_HOME.MouseLeave += new EventHandler(Button_MouseLeave);
        }

        // 버튼 + 마우스 테두리 변경 코드 ②
        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_HOME.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_HOME.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_HOME.FlatStyle = FlatStyle.Flat;
        }

        private void btn_file1_Click(object sender, EventArgs e) // 저장 1
        {
            // SaveData 객체 생성
            SaveData savedata = new SaveData();

            // PingStatus와 BossStatus 모두 저장
            savedata.Save("File1");

            MessageBox.Show("데이터를 저장합니다.");

            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btn_file2_Click(object sender, EventArgs e) // 저장 2
        {
            // SaveData 객체 생성
            SaveData savedata = new SaveData();

            // PingStatus와 BossStatus 모두 저장
            savedata.Save("File2");

            MessageBox.Show("데이터를 저장합니다.");

            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btn_file3_Click(object sender, EventArgs e) // 저장 3
        {
            // SaveData 객체 생성
            SaveData savedata = new SaveData();

            // PingStatus와 BossStatus 모두 저장
            savedata.Save("File3");

            MessageBox.Show("데이터를 저장합니다.");

            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e) // 저장 4
        {
            // SaveData 객체 생성
            SaveData savedata = new SaveData();

            // PingStatus와 BossStatus 모두 저장
            savedata.Save("File4");

            MessageBox.Show("데이터를 저장합니다.");

            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btn_HOME_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
