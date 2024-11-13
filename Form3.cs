using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prj_HeartspingAdventure
{
    public partial class Form3 : Form
    {  
        private PictureBox pb_chat;
        private Label lb_chat;
        private PictureBox pb_crown;
        private Label lb_next;
        Form1 form1 = new Form1();

        public Form3()
        {
            InitializeComponent();
        }

        // 폼이 실행됐을 때
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string videoPath = System.IO.Directory.GetCurrentDirectory();
                string path = @"\Image";
                string filename1 = Path.Combine(videoPath + path, "Intro.mp4");
                
                video_intro.URL = videoPath + path + filename1;
                video_intro.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 대화창 생성 (1번)
        private void CreateChat()
        {
            // pb_chat 설정
            pb_chat = new PictureBox
            {
                Location = new System.Drawing.Point(109, 440),
                Size = new System.Drawing.Size(864, 138),
                Visible = false, // 처음에는 보이지 않도록 설정
            };
            // 이미지 설정
            string ImagePath = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Image";

            string filename1 = Path.Combine(ImagePath + path, "말풍선.png");
            pb_chat.Image = Image.FromFile(filename1);


            // 이미지 크기 조절
            pb_chat.SizeMode = PictureBoxSizeMode.StretchImage;

            // lb_chat 설정
            lb_chat = new Label
            {
                Location = new System.Drawing.Point(140, 469),
                Size = new System.Drawing.Size(790, 65),
                Visible = false, // 처음에는 보이지 않도록 설정
                Text = "지구로 떨어진 티니핑 중 하츄핑이 내 품에 들어왔다. \n남은 티니핑들을 찾아 힘을 합쳐 악당 핑을 물리치자!",
                AutoSize = false,
                Font = new Font("Cafe24 Ssukssuk ", 20),
                BackColor = System.Drawing.Color.White,
            };

            // pb_crown 설정
            pb_crown = new PictureBox
            {
                Location = new System.Drawing.Point(864, 534),
                Size = new System.Drawing.Size(20, 23),
                Visible = false, // 처음에는 보이지 않도록 설정
                BackColor = System.Drawing.Color.White,
            };
            // 이미지 설정
            string filename2 = Path.Combine(ImagePath + path, "왕관.png");
            pb_crown.Image = Image.FromFile(filename2);
            if (!File.Exists(filename2))
            {
                Directory.CreateDirectory(ImagePath + path);
            }

            // 이미지 크기 조절
            pb_crown.SizeMode = PictureBoxSizeMode.StretchImage;

            // lb_next 설정
            lb_next = new Label
            {
                Location = new System.Drawing.Point(883, 536),
                Size = new System.Drawing.Size(34, 20),
                Visible = false, // 처음에는 보이지 않도록 설정
                Text = "클릭",
                BackColor = System.Drawing.Color.White,
                Font = new Font("Cafe24 Ssukssuk ", 10),
            };

            // 이벤트 핸들러 추가
            pb_chat.Click += pb_chat_Click;
            lb_chat.Click += pb_chat_Click; // lb_chat 클릭 시에도 같은 핸들러 호출
            pb_crown.Click += pb_chat_Click;
            lb_next.Click += pb_chat_Click;

            // 폼에 컨트롤 추가
            Controls.Add(pb_chat);
            Controls.Add(lb_chat);
            Controls.Add(pb_crown);
            Controls.Add(lb_next);
        }

        // 동영상 끝났을 때 (2번)
        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // 동영상이 끝났을 때
            if (e.newState == 8)
            {
                CreateChat();
                pb_chat.Visible = true;
                lb_chat.Visible = true;
                pb_crown.Visible = true;
                lb_next.Visible = true;

                // 각 컨트롤을 가장 앞으로 가져오기
                pb_chat.BringToFront();
                lb_chat.BringToFront();
                pb_crown.BringToFront();
                lb_next.BringToFront();
            }
        }

        // 대화창 클릭 했을 때 (3번)
        private void pb_chat_Click(object sender, EventArgs e)
        {
            // start영상 종료
            this.Close();
            // 메인으로 이동
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
