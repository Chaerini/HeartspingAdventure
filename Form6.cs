using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using System.IO;

namespace prj_HeartspingAdventure
{
    public partial class Form6 : Form
    {
        public static string videoPath = "";
        public static int bossChoice = -1;
        private bool bossAppeared = false;
        Form6_1 form6_1 = new Form6_1();

        string videoPT = System.IO.Directory.GetCurrentDirectory();
        string path = @"\Image";

        public Form6()
        {
            InitializeComponent();

            // 버튼 + 마우스 테두리 변경 코드 ①
            // 버튼 기본 스타일 설정
            button1.FlatStyle = FlatStyle.Flat; // 보스 1
            button2.FlatStyle = FlatStyle.Flat; // 보스 2
            button3.FlatStyle = FlatStyle.Flat; // 보스 3
            button4.FlatStyle = FlatStyle.Flat; // 보스 4
            btn_HOME.FlatStyle = FlatStyle.Flat; // HOME

            // 마우스가 버튼 위에 있을 때 테두리 없애기
            button1.MouseEnter += new EventHandler(Button_MouseEnter_1); // 보스 1
            button1.MouseLeave += new EventHandler(Button_MouseLeave_1);

            button2.MouseEnter += new EventHandler(Button_MouseEnter_2); // 보스 2
            button2.MouseLeave += new EventHandler(Button_MouseLeave_2);

            button3.MouseEnter += new EventHandler(Button_MouseEnter_3); // 보스 3
            button3.MouseLeave += new EventHandler(Button_MouseLeave_3);

            button4.MouseEnter += new EventHandler(Button_MouseEnter_4); // 보스 4
            button4.MouseLeave += new EventHandler(Button_MouseLeave_4);

            btn_HOME.MouseEnter += new EventHandler(Button_MouseEnter_H); // HOME
            btn_HOME.MouseLeave += new EventHandler(Button_MouseLeave_H);
        }

        // 버튼 + 마우스 테두리 변경 코드 ②
        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_1(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            button1.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            button1.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_1(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            button1.FlatStyle = FlatStyle.Flat;
        }

        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_2(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            button2.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            button2.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_2(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            button2.FlatStyle = FlatStyle.Flat;
        }

        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_3(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            button3.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            button3.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_3(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            button3.FlatStyle = FlatStyle.Flat;
        }

        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_4(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            button4.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            button4.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_4(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            button4.FlatStyle = FlatStyle.Flat;
        }

        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_H(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_HOME.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_HOME.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_H(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_HOME.FlatStyle = FlatStyle.Flat;
        }

        private void UpdateButtonStates()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            string btn_lock = Path.Combine(videoPT + path, "btn_lock.png");

            button1.Image = Image.FromFile(btn_lock);
            button2.Image = Image.FromFile(btn_lock);
            button3.Image = Image.FromFile(btn_lock);
            button4.Image = Image.FromFile(btn_lock);

            if (Status.elegance >= 10)
            {
                string btn1 = Path.Combine(videoPT + path, "btn1.png");
                button1.Enabled = true;
                button1.Image = Image.FromFile(btn1);
            }

            if (Status.elegance >= 20)
            {
                string btn2 = Path.Combine(videoPT + path, "btn2.png");
                button2.Enabled = true;
                button2.Image = Image.FromFile(btn2);
            }

            if (Status.elegance >= 30)
            {
                string btn3 = Path.Combine(videoPT + path, "btn3.png");
                button3.Enabled = true;
                button3.Image = Image.FromFile(btn3);
            }
            if (Status.elegance >= 40)
            {
                string btn4 = Path.Combine(videoPT + path, "btn4.png");
                button4.Enabled = true;
                button4.Image = Image.FromFile(btn4);
            }

        }

        private void StartBossFight(int bossNum, int villanPower, string videoFile)
        {
            videoPath = videoFile;
            bossChoice = bossNum;
            bossAppeared = false;
            bool victory = Status.power_level > villanPower;

            if (form6_1 != null && !form6_1.IsDisposed)
            {
                form6_1.Close();
            }
            form6_1 = new Form6_1();

            form6_1.startVideo(videoPath);

            form6_1.axWindowsMediaPlayer1.PlayStateChange += (object sender, _WMPOCXEvents_PlayStateChangeEvent e) =>
            {
                if (e.newState == 8)
                {
                    if (!bossAppeared)
                    {
                        bossAppeared = true;
                        if (victory)
                            FightResult(1, bossNum);
                        else
                            FightResult(0, bossNum);

                    }
                }
            };

            form6_1.Show();
        }

        private async void FightResult(int result, int bossNum)
        {
            string resultMessage = "";
            if (result == 1)
            {
                Status.exp += bossNum * 30;

                switch (Status.level)
                {
                    case 1:
                        Status.HP = Status.MaxHP;
                        break;
                    case 2:
                        Status.HP = Status.MaxHP;
                        break;
                    case 3:
                        Status.HP = Status.MaxHP;
                        break;
                    case 4:
                        Status.HP = Status.MaxHP;
                        break;
                    case 5:
                        Status.HP = Status.MaxHP;
                        break;
                }
                resultMessage = "악당핑을 물리쳤다!";
                string vp1 = Path.Combine(videoPT + path, $"{bossNum}.mp4");
                videoPath = vp1;
            }
            else
            {

                Status.HP = (int)(Status.HP * 0.5);
                Status.stress += 20;
                Status.exp += bossNum * 10;
                resultMessage = "악당핑에게 졌다!\n힘을 길러오자!";
                string vp2 = Path.Combine(videoPT + path, "lose.mp4");
                videoPath = vp2;
            }

            MessageBox.Show(resultMessage);
            await Task.Delay(100);
            form6_1.startVideo(videoPath);

            form6_1.axWindowsMediaPlayer1.PlayStateChange += (object sender, _WMPOCXEvents_PlayStateChangeEvent e) =>
            {
                if (e.newState == 8)
                {
                    // 수정
                    form6_1.Close();
                    this.Close();

                    Form4 form4 = new Form4();
                    form4.Show();
                }
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string boss1 = Path.Combine(videoPT + path, "등장 악동핑.mp4");
            StartBossFight(1, 50, boss1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string boss2 = Path.Combine(videoPT + path, "등장 앙마핑.mp4");
            StartBossFight(2, 100, boss2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string boss3 = Path.Combine(videoPT + path, "등장 다해핑.mp4");
            StartBossFight(3, 200, boss3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string boss4 = Path.Combine(videoPT + path, "등장 뿌뿌핑.mp4");
            StartBossFight(4, 400, boss4);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void btn_HOME_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}