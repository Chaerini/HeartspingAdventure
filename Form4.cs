using System;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib;
using System.Threading.Tasks;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prj_HeartspingAdventure
{
    public partial class Form4 : Form
    {

        float HP = Status.HP; // 현재 체력
        float MaxHP = Status.MaxHP; // 최대 체력
        int power_level = Status.power_level; // 전투력

        int elegance = Status.elegance; // 품위
        int stress = Status.stress; // 스트레스

        int level = Status.level; // 레벨
        float exp = Status.exp; // 경험치
        float Maxexp = Status.Maxexp; // 최대 경험치

        int card_num = Status.card_num; // 카드개수

        // 탐험
        Random random = new Random();
        Form6_1 form6_1 = new Form6_1();
        int cardIndex;
        bool isCard;

        // 이미지, 영상 경로
        string ImagePath = System.IO.Directory.GetCurrentDirectory();
        string path = @"\Image";


        public Form4()
        {
            InitializeComponent();

            // 버튼 + 마우스 테두리 변경 코드 ①
            // 버튼 기본 스타일 설정
            btn_Exploration.FlatStyle = FlatStyle.Flat; // 탐험
            btn_Battle.FlatStyle = FlatStyle.Flat; // 전투
            btn_Collection.FlatStyle = FlatStyle.Flat; // 컬렉션
            btn_Schedule.FlatStyle = FlatStyle.Flat; // 스케줄
            btn_Nextday.FlatStyle = FlatStyle.Flat; // 다음날

            // 마우스가 버튼 위에 있을 때 테두리 없애기
            btn_Exploration.MouseEnter += new EventHandler(Button_MouseEnter_E); // 탐험
            btn_Exploration.MouseLeave += new EventHandler(Button_MouseLeave_E);

            btn_Battle.MouseEnter += new EventHandler(Button_MouseEnter_B); // 전투
            btn_Battle.MouseLeave += new EventHandler(Button_MouseLeave_B);

            btn_Collection.MouseEnter += new EventHandler(Button_MouseEnter_C); // 컬렉션
            btn_Collection.MouseLeave += new EventHandler(Button_MouseLeave_C);

            btn_Schedule.MouseEnter += new EventHandler(Button_MouseEnter_S); // 스케줄
            btn_Schedule.MouseLeave += new EventHandler(Button_MouseLeave_S);

            btn_Nextday.MouseEnter += new EventHandler(Button_MouseEnter_N); // 다음날
            btn_Nextday.MouseLeave += new EventHandler(Button_MouseLeave_N);

            Status.levelUP(); // 레벨 변경에 따른 사진 변환 ①
            OnLevelChanged(Status.level); // 레벨 변경에 따른 사진 변환 ②
        }

        // 버튼 + 마우스 테두리 변경 코드 ②
        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_E(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Exploration.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Exploration.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_E(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Exploration.FlatStyle = FlatStyle.Flat;
        }

        private void Button_MouseEnter_B(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Battle.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Battle.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_B(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Battle.FlatStyle = FlatStyle.Flat;
        }

        private void Button_MouseEnter_C(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Collection.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Collection.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_C(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Collection.FlatStyle = FlatStyle.Flat;
        }

        private void Button_MouseEnter_S(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Schedule.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Schedule.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_S(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Schedule.FlatStyle = FlatStyle.Flat;
        }

        private void Button_MouseEnter_N(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_Nextday.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_Nextday.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_N(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_Nextday.FlatStyle = FlatStyle.Flat;
        }

        // 값이 변경될 때마다 호출
        private void OnLevelChanged(int newlevel)
        {
            UpdateImage(newlevel);
        }
        private void UpdateImage(int level)
        {
            string filename1 = Path.Combine(ImagePath + path, "hcp_Lv1.png");
            string filename2 = Path.Combine(ImagePath + path, "hcp_Lv2.png");
            string filename3 = Path.Combine(ImagePath + path, "hcp_Lv3.png");
            string filename4 = Path.Combine(ImagePath + path, "hcp_Lv4.png");
            string filename5 = Path.Combine(ImagePath + path, "hcp_Lv5.png");

            switch (level)
            {
                case 1:
                    pb_hcb_Lv1.Image = Image.FromFile(filename1);
                    break;
                case 2:
                    pb_hcb_Lv1.Image = Image.FromFile(filename2);
                    break;
                case 3:
                    pb_hcb_Lv1.Image = Image.FromFile(filename3);
                    break;
                case 4:
                    pb_hcb_Lv1.Image = Image.FromFile(filename4);
                    break;
                case 5:
                    pb_hcb_Lv1.Image = Image.FromFile(filename5);
                    break;
            }
        }

        // 프로그래스바 값 설정 메서드
        public void UpdatePrograssBar(int exp)
        {
            // ProgressBar의 최소값을 0으로 설정하고, 최대값을 최대 경험치로 설정합니다.
            prob_exp.Minimum = 0;
            prob_exp.Maximum = (int)Status.Maxexp;

            // 현재 경험치를 ProgressBar에 반영합니다. 
            // 최소값은 0이고, 최대값은 최대 경험치 범위를 넘지 않게 조정합니다.
            // prob_exp.Minimum = 0; : Pb의 최소값을 0으로 설정
            // prob_exp.Maximum = (int)Status.Maxexp; : 최대 경험치를 Pb의 최대값으로 설정
            // prob_exp.Value : 현재 경험치에 따라 Pb업뎃.
            // 경험치 최소 또는 최대 넘침 방지 위해 Math.Min & Math.Max로 값 제한
            prob_exp.Value = Math.Min(prob_exp.Maximum, Math.Max(prob_exp.Minimum, exp));

            // 경험치가 최대값에 도달 > 레벨 증가
            if (Status.exp >= Status.Maxexp)
            {
                Status.levelUP();
                //Status.exp -= Status.Maxexp; // 경험치를 초기화
                //Status.level += 1; // 레벨 상승
                //Status.Maxexp += 50; // 다음 레벨의 최대 경험치를 증가

                // 레벨 레이블 업뎃
                lb_Level.Text = Status.level.ToString();
                lb_HP.Text = Status.HP.ToString();
                lb_Power_Level.Text = Status.power_level.ToString();
                lb_Elegance.Text = Status.elegance.ToString();
                lb_Stress.Text = Status.stress.ToString();

                // 레벨 변경에 따른 이미지 업뎃
                UpdateImage(Status.level);

                // PrograssBar 업뎃
                UpdatePrograssBar((int)Status.exp);
            }
        }

        private void Form4_Load(object sender, EventArgs e) // Form4
        {
            // UI 업데이트
            UpdateStatusUI();

            // 경험치를 기준으로 ProgressBar를 업데이트
            UpdatePrograssBar((int)Status.exp);
        }

        private void UpdateStatusUI()
        {
            if (Status.HP < 0)
                Status.HP = 0;
            if (Status.power_level < 0)
                Status.power_level = 0;
            if (Status.elegance < 0)
                Status.elegance = 0;
            if (Status.stress < 0)
                Status.stress = 0;

            // 스탯 값들을 UI에 표시
            lb_HP.Text = Status.HP.ToString();
            lb_Power_Level.Text = Status.power_level.ToString();
            lb_Elegance.Text = Status.elegance.ToString();
            lb_Stress.Text = Status.stress.ToString();
            lb_Level.Text = Status.level.ToString();

        }

        // 경험치에 따른 ProgressBar 업데이트
        private void UpdateProgressBar(int expValue)
        {
            prob_exp.Value = expValue;
        }

        private void btn_Exploration_Click(object sender, EventArgs e) // 탐험 버튼
        {
            if (Status.card_num == 10)
            {
                MessageBox.Show("티니핑을 모두 모았다!");
                return;
            }
            Explore();
        }

        private void btn_Battle_Click(object sender, EventArgs e) // 전투 버튼
        {
            this.Close();
            Form6 form6 = new Form6();
            form6.Show();

        }

        private void btn_Collection_Click(object sender, EventArgs e) // 컬렉션 버튼
        {
            this.Close();
            Form7 form7 = new Form7();
            form7.Show();

        }

        private void btn_Schedule_Click(object sender, EventArgs e) // 스케줄 버튼
        {
            this.Close();
            Form8 form8 = new Form8();
            form8.Show();

        }

        private void btn_Nextday_Click(object sender, EventArgs e) // 다음날 버튼
        {
            Status.StatusInit();

            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
                Form9 form9 = new Form9();
                form9.Show();
            }
        }

        // 탐험
        private void Explore()
        {
            string exploreVideo = Path.Combine(ImagePath + path, "ExploreResult.mp4");

            do
            {
                cardIndex = random.Next(1, 11);
            } while (Status.card_flag[cardIndex - 1] == 1);

            isCard = random.Next(0, 2) == 1;

            Status.power_level += 10;
            Status.exp += 20; // 탐험 후 경험치 20 증가

            // 탐험 후 ProgressBar를 업데이트
            UpdatePrograssBar((int)Status.exp);

            if (form6_1.IsDisposed)
            {
                form6_1 = new Form6_1();
            }

            form6_1.startVideo(exploreVideo);

            form6_1.axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange1;

            form6_1.Show();
        }


        private void AxWindowsMediaPlayer1_PlayStateChange1(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == 8)
            {
                ExploreResult(isCard, cardIndex);

            }

        }

        private void AxWindowsMediaPlayer1_PlayStateChange2(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                // 영상이 종료되면 close
                form6_1.Close();
                // 새로운 메인 창을 띄우고 전에 있던 메인창 닫음
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }

        }

        private async void ExploreResult(bool isCard, int cardIndex)
        {
            string resultMessage = "";
            string cardVideoPath; ;
            if (isCard)
            {
                resultMessage = "티니핑을 잡았다!";
                cardVideoPath = Path.Combine(ImagePath + path, $"card{cardIndex}.mp4");
                Status.card_flag[cardIndex - 1] = 1;
                Status.card_num++;
                Status.exp += 10;


            }
            else
            {
                resultMessage = "티니핑을 놓쳤다!";
                cardVideoPath = Path.Combine(ImagePath + path, @"탐험실패.mp4");
            }
            MessageBox.Show(resultMessage);
            await Task.Delay(100);

            form6_1.startVideo(cardVideoPath);
            form6_1.axWindowsMediaPlayer1.PlayStateChange -= AxWindowsMediaPlayer1_PlayStateChange1;
            form6_1.axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Explore();

        }
    }
}