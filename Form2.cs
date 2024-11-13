using System;
using System.Windows.Forms;
using System.IO;

namespace prj_HeartspingAdventure
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void btn_file1_Click(object sender, EventArgs e)
        {
            LoadData loadData = new LoadData();
            string directory = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Save";
            string filePath = Path.Combine(directory + path, "File1_PingStatus.json");  // PingStatus 파일 경로

            // 파일 존재 여부 확인
            if (File.Exists(filePath))
            {
                // 파일이 있으면 데이터 로드
                loadData.Load("File1");

                Boss_Status boss = new Boss_Status();
                MessageBox.Show("데이터를 불러옵니다.");

                this.Close();
                Form4 form4 = new Form4();
                form4.Show();

            }
            else
            {
                // 파일이 없으면 메시지 출력
                MessageBox.Show("파일이 없습니다.");
            }

        }


        private void btn_file2_Click(object sender, EventArgs e)
        {
            LoadData loadData = new LoadData();
            string directory = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Save";  // 앞에 '\'를 빼고 Path.Combine으로 처리
            string filePath = Path.Combine(directory + path, "File2_PingStatus.json");  // PingStatus 파일 경로

            // 파일 존재 여부 확인
            if (File.Exists(filePath))
            {
                // 파일이 있으면 데이터 로드
                loadData.Load("File2");

                Boss_Status boss = new Boss_Status();
                MessageBox.Show("데이터를 불러옵니다.");

                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                // 파일이 없으면 메시지 출력
                MessageBox.Show("파일이 없습니다.");
            }

        }

        private void btn_file3_Click(object sender, EventArgs e)
        {
            LoadData loadData = new LoadData();
            string directory = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Save";
            string filePath = Path.Combine(directory + path, "File3_PingStatus.json");  // PingStatus 파일 경로

            // 파일 존재 여부 확인
            if (File.Exists(filePath))
            {
                // 파일이 있으면 데이터 로드
                loadData.Load("File3");

                Boss_Status boss = new Boss_Status();
                MessageBox.Show("데이터를 불러옵니다.");

                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                // 파일이 없으면 메시지 출력
                MessageBox.Show("파일이 없습니다.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData loadData = new LoadData();
            string directory = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Save";
            string filePath = Path.Combine(directory + path, "File4_PingStatus.json");  // PingStatus 파일 경로

            // 파일 존재 여부 확인
            if (File.Exists(filePath))
            {
                // 파일이 있으면 데이터 로드
                loadData.Load("File4");

                Boss_Status boss = new Boss_Status();
                MessageBox.Show("데이터를 불러옵니다.");

                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                // 파일이 없으면 메시지 출력
                MessageBox.Show("파일이 없습니다.");
            }

        }
        private void btn_HOME_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}