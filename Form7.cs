using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace prj_HeartspingAdventure
{
    public partial class Form7 : Form
    {
        // 이미지, 영상 파일 경로
        public static string ImgPath = System.IO.Directory.GetCurrentDirectory();
        public static string pt = @"\Image";
        public static string fn = Path.Combine(ImgPath + pt, "card_lock.png");

        private PictureBox[] pictureBoxes = new PictureBox[10];  // 10개의 PictureBox 배열
        private string[] imagePaths = new string[10];            // 각 카드에 대응하는 이미지 경로

        private string defaultImagePath = fn;  // 기본 이미지 경로

        public Form7()
        {
            InitializeComponent();

            // 버튼 + 마우스 테두리 변경 코드 ①
            // 버튼 기본 스타일 설정
            btn_home.FlatStyle = FlatStyle.Flat; // 탐험
            // 마우스가 버튼 위에 있을 때 테두리 없애기
            btn_home.MouseEnter += new EventHandler(Button_MouseEnter); // 탐험
            btn_home.MouseLeave += new EventHandler(Button_MouseLeave);

            // this.KeyPreview = true;  // 키보드 입력을 먼저 처리하도록 설정
            InitializePictureBoxes();  // PictureBox 배열 초기화
            LoadImagePaths();          // 이미지 경로 로드
            LoadDefaultImages();       // 기본 이미지 설정
        }

        // status 클래스
        public static int[] card_flag = new int[10];

        // 10개의 PictureBox를 배열로 초기화
        private void InitializePictureBoxes()
        {
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;
            pictureBoxes[9] = pictureBox10;
        }

        // 버튼 + 마우스 테두리 변경 코드 ②
        // 마우스가 버튼 위로 올려질 때
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // 버튼 테두리 팝업
            btn_home.FlatStyle = FlatStyle.Popup;
            // 테두리 크기를 0으로 설정
            btn_home.FlatAppearance.BorderSize = 0;
        }
        // 마우스가 버튼에서 벗어날 때
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // 기본 스타일로 복원
            btn_home.FlatStyle = FlatStyle.Flat;
        }

        // 이미지 경로를 로드하는 메서드 (정적 경로 예시)
        private void LoadImagePaths()
        {
            string cd1 = Path.Combine(ImgPath + pt, "card01.png");
            string cd2 = Path.Combine(ImgPath + pt, "card02.png");
            string cd3 = Path.Combine(ImgPath + pt, "card03.png");
            string cd4 = Path.Combine(ImgPath + pt, "card04.png");
            string cd5 = Path.Combine(ImgPath + pt, "card05.png");
            string cd6 = Path.Combine(ImgPath + pt, "card06.png");
            string cd7 = Path.Combine(ImgPath + pt, "card07.png");
            string cd8 = Path.Combine(ImgPath + pt, "card08.png");
            string cd9 = Path.Combine(ImgPath + pt, "card09.png");
            string cd10 = Path.Combine(ImgPath + pt, "card10.png");

            imagePaths[0] = cd1;
            imagePaths[1] = cd2;
            imagePaths[2] = cd3;
            imagePaths[3] = cd4;
            imagePaths[4] = cd5;
            imagePaths[5] = cd6;
            imagePaths[6] = cd7;
            imagePaths[7] = cd8;
            imagePaths[8] = cd9;
            imagePaths[9] = cd10;
        }


        // 각 PictureBox에 이미지를 설정하는 메서드
        private void SetImage(int cardIndex)
        {
            try
            {
                if (Status.card_flag[cardIndex] == 1 && !string.IsNullOrEmpty(imagePaths[cardIndex]))
                {
                    pictureBoxes[cardIndex].Image = Image.FromFile(imagePaths[cardIndex]);
                }
                else
                {
                    pictureBoxes[cardIndex].Image = Image.FromFile(defaultImagePath);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("이미지 파일을 찾을 수 없습니다: " + ex.Message);
                pictureBoxes[cardIndex].Image = null;
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("이미지를 로드하는 동안 메모리 오류가 발생했습니다: " + ex.Message);
                pictureBoxes[cardIndex].Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지를 설정하는 동안 오류가 발생했습니다: " + ex.Message);
            }
        }



        // 기본 이미지를 설정하는 메서드
        private void LoadDefaultImages()
        {
            for (int i = 0; i < imagePaths.Length; i++)
            {
                SetImage(i);  // 각 카드에 대해 이미지를 설정
            }
        }

        // 폼 실행 시, 일어나는 이벤트
        // 폼이 열릴 때 모든 PictureBox에 이미지를 설정
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Status.card_flag.Length; i++)
                {
                    SetImage(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("폼 로드 중 오류 발생: " + ex.Message);
            }
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                try
                {
                    Form9 nextForm = new Form9();
                    nextForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("새 폼을 여는 중 오류 발생: " + ex.Message);
                }
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("홈으로 돌아가는 중 오류 발생: " + ex.Message);
            }
        }
    }
}
