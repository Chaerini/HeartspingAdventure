using System;
using System.Windows.Forms;
using System.IO;

namespace prj_HeartspingAdventure
{
    public partial class Form8 : Form
    {
        // Windows Media Player 생성을 위한 참조
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;

        public Form8()
        {
            InitializeComponent();

            // 버튼 + 마우스 테두리 변경 코드 ①
            // 버튼 기본 스타일 설정
            button1.FlatStyle = FlatStyle.Flat; // 춤
            btn_rest.FlatStyle = FlatStyle.Flat; // 휴식
            btn_ballet.FlatStyle = FlatStyle.Flat; // 발레
            btn_snack.FlatStyle = FlatStyle.Flat; // 간식
            btn_HOME.FlatStyle = FlatStyle.Flat; // HOME

            // 마우스가 버튼 위에 있을 때 테두리 없애기
            button1.MouseEnter += new EventHandler(Button_MouseEnter_D); // 춤
            button1.MouseLeave += new EventHandler(Button_MouseLeave_D);

            btn_rest.MouseEnter += new EventHandler(Button_MouseEnter_R); // 휴식
            btn_rest.MouseLeave += new EventHandler(Button_MouseLeave_R);

            btn_ballet.MouseEnter += new EventHandler(Button_MouseEnter_B); // 발레
            btn_ballet.MouseLeave += new EventHandler(Button_MouseLeave_B);

            btn_snack.MouseEnter += new EventHandler(Button_MouseEnter_S); // 간식
            btn_snack.MouseLeave += new EventHandler(Button_MouseLeave_S);

            btn_HOME.MouseEnter += new EventHandler(Button_MouseEnter_H); // HOME
            btn_HOME.MouseLeave += new EventHandler(Button_MouseLeave_H);
        }

        // 버튼 + 마우스 테두리 변경 코드 ②
        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter_D(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            button1.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            button1.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_D(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void Button_MouseEnter_R(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_rest.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_rest.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_R(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_rest.FlatStyle = FlatStyle.Flat;
        }

        private void Button_MouseEnter_B(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_ballet.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_ballet.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_B(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_ballet.FlatStyle = FlatStyle.Flat;
        }

        private void Button_MouseEnter_S(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_snack.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_snack.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave_S(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_snack.FlatStyle = FlatStyle.Flat;
        }

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

        // 동영상 컨트롤 생성
        private void CreateMediaPlayer()
        {
            // 동영상 인스턴스 생성
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();

            // COM 컨트롤을 위한 초기화 필수
            ((System.ComponentModel.ISupportInitialize)(mediaPlayer)).BeginInit();

            // 크기 및 위치 설정
            mediaPlayer.Location = new System.Drawing.Point(-50, 0);
            mediaPlayer.Size = new System.Drawing.Size(1250, 710);

            // 이벤트 핸들러 추가
            mediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;
            this.Controls.Add(mediaPlayer);

            // 동영상을 가장 앞으로
            mediaPlayer.BringToFront();

            // 초기화 완료
            ((System.ComponentModel.ISupportInitialize)(mediaPlayer)).EndInit();
        }

        // PlayStateChange 이벤트 핸들러
        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // 동영상이 끝났을 때
            if (e.newState == 8)
            {
                this.Close();
                Form4 form4 = new Form4();
                form4.Show();

            }
        }

        private void ScheduleMax()
        {
            if (Status.level == 1)
            {
                Status.Max_dance_count = 3;
                Status.Max_rest_count = 1;
                Status.Max_snack_count = 2;
                Status.Max_ballet_count = 2;
            }
            else if (Status.level == 2)
            {
                Status.Max_dance_count = 4;
                Status.Max_rest_count = 2;
                Status.Max_snack_count = 3;
                Status.Max_ballet_count = 3;
            }
            else if (Status.level == 3)
            {
                Status.Max_dance_count = 5;
                Status.Max_rest_count = 3;
                Status.Max_snack_count = 4;
                Status.Max_ballet_count = 4;
            }
            else if (Status.level == 4)
            {
                Status.Max_dance_count = 6;
                Status.Max_rest_count = 4;
                Status.Max_snack_count = 5;
                Status.Max_ballet_count = 5;
            }
            else if (Status.level == 5)
            {
                Status.Max_dance_count = 7;
                Status.Max_rest_count = 5;
                Status.Max_snack_count = 6;
                Status.Max_ballet_count = 6;
            }
            else
            {
                MessageBox.Show("레벨 오류.");
                return;
            }
        }

        // 춤추기 버튼 눌렀을 때
        // 품위 소폭 증가, 스트레스 소폭 감소
        private void btn_dance_Click(object sender, EventArgs e)
        {
            // 최대 횟수를 초과했을 때
            if (Status.dance_count >= Status.Max_dance_count)
            {
                MessageBox.Show("실행 가능한 횟수를 초과했습니다.");
                return;
            }

            // 스텟 업데이트
            Status.dance_count++;
            Status.HP -= 20;
            Status.elegance += 10;
            Status.stress -= 10;

            // 동영상 재생
            CreateMediaPlayer();

            // 이미지, 영상 파일 경로
            string vPath = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Image";
            string fn = Path.Combine(vPath + path, "evt_dance.mp4");
            string videoPath = fn;

            mediaPlayer.URL = videoPath;
            mediaPlayer.Ctlcontrols.play();

        }

        // 휴식 버튼 눌렀을 때
        // 스트레스 대폭 감소
        private void btn_rest_Click(object sender, EventArgs e)
        {
            // 최대 횟수를 초과했을 때
            if (Status.rest_count >= Status.Max_rest_count)
            {
                MessageBox.Show("실행 가능한 횟수를 초과했습니다.");
                return;
            }

            // 스텟 업데이트
            Status.rest_count++;
            Status.HP -= 20;
            Status.elegance += 10;
            Status.stress -= 30;

            // 동영상 재생
            CreateMediaPlayer();

            // 이미지, 영상 파일 경로
            string vPath = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Image";
            string fn = Path.Combine(vPath + path, "evt_rest.mp4");
            string videoPath = fn;

            mediaPlayer.URL = videoPath;
            mediaPlayer.Ctlcontrols.play();
        }

        // 간식 타임 버튼 눌렀을 때
        // 품위 소폭 감소, 스트레스 대폭 감소
        private void btn_snack_Click(object sender, EventArgs e)
        {
            // 최대 횟수를 초과했을 때
            if (Status.snack_count >= Status.Max_snack_count)
            {
                MessageBox.Show("실행 가능한 횟수를 초과했습니다.");
                return;
            }

            // 스텟 업데이트
            Status.snack_count++;
            Status.HP -= 20;
            Status.elegance -= 5;
            Status.stress -= 20;

            // 동영상 재생
            CreateMediaPlayer();

            string vPath = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Image";
            string fn = Path.Combine(vPath + path, "evt_snack.mp4");
            string videoPath = fn;

            mediaPlayer.URL = videoPath;
            mediaPlayer.Ctlcontrols.play();
        }

        // 발레 버튼 눌렀을 때
        // 품위 대폭 증가, 스트레스 소폭 감소
        private void btn_ballet_Click(object sender, EventArgs e)
        {
            // 최대 횟수를 초과했을 때
            if (Status.ballet_count >= Status.Max_ballet_count)
            {
                MessageBox.Show("실행 가능한 횟수를 초과했습니다.");
                return;
            }

            // 스텟 업데이트
            Status.ballet_count++;
            Status.HP -= 20;
            Status.elegance += 15;
            Status.stress -= 10;

            // 동영상 재생
            CreateMediaPlayer();

            string vPath = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Image";
            string fn = Path.Combine(vPath + path, "evt_ballet.mp4");
            string videoPath = fn;

            mediaPlayer.URL = videoPath;
            mediaPlayer.Ctlcontrols.play();
        }

        // 폼 실행됐을 때
        private void Form8_Load(object sender, EventArgs e)
        {
            ScheduleMax();
            // 실행횟수 및 최대횟수 설정
            lb_danceNum.Text = Status.dance_count.ToString();
            lb_danceMax.Text = Status.Max_dance_count.ToString();

            lb_restNum.Text = Status.rest_count.ToString();
            lb_restMax.Text = Status.Max_rest_count.ToString();

            lb_snackNum.Text = Status.snack_count.ToString();
            lb_snackMax.Text = Status.Max_snack_count.ToString();

            lb_balletNum.Text = Status.ballet_count.ToString();
            lb_balletMax.Text = Status.Max_ballet_count.ToString();
        }

        private void btn_HOME_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
