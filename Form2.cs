using Arabam.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arabam {
    public partial class Ana_Sayfa : Form {
        public Ana_Sayfa() {

            InitializeComponent();

        }

        private void Ana_Sayfa_FormClosed(object sender, FormClosedEventArgs e) {

            /*if (e.CloseReason == CloseReason.UserClosing) {
                YüklemeEkranı YüklemeEkranı = new YüklemeEkranı();
                this.Close();
                YüklemeEkranı.Show();
                MessageBox.Show("Çarpıya Tıklandı");
            }*/
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e) {
            MouseEventArgs mouseEventArgs = e as MouseEventArgs;
            int x = mouseEventArgs.X;
            int y = mouseEventArgs.Y;

            if (mouseEventArgs != null) {
                //MessageBox.Show($"Resmin ({x}, {y}) koordinatlarına tıklandı!");
            }
            if (x < 420 && x > 250 && y < 330 && y > 220) {
                MessageBox.Show("Kapıya Tıkladınız");
                //Yeni form açılacak
            }
        }

        private void Ana_Sayfa_SizeChanged(object sender, System.EventArgs e) {
            int buttonWidth = 150;
            int buttonHeight = 50;
            int margin = 20;

            int button1X = this.ClientSize.Width - buttonWidth - margin;
            int button1Y = this.ClientSize.Height - buttonHeight - 900;
            if (button1Y < margin) {
                button1Y = margin;
            }

            if (button1X < margin) {
                button1X = margin;
            }
            int button2X = this.ClientSize.Width - buttonWidth - 1700;
            if (button2X < margin) {
                button2X = margin;
            }
            int button2Y = button1Y;
            İçeribtn.SetBounds(button1X, button1Y, buttonWidth, buttonHeight);
            Dndrbtn.SetBounds(button2X, button2Y, buttonWidth, buttonHeight);

        }

        private string[] ImagePaths = {
                @"C:\Users\Abdülkerem\Desktop\Servis_araba.jpg",
                @"C:\Users\Abdülkerem\Desktop\Servis_araba_düz.jpg",
                @"C:\Users\Abdülkerem\Desktop\Servis_araba_duzsag.jpg",
                @"C:\Users\Abdülkerem\Desktop\Servis_araba_arka.jpg"
            };
        private int CurrentImage = 0;
        private void button2_Click(object sender, System.EventArgs e) {

            CurrentImage++;

            if (CurrentImage >= ImagePaths.Length) {
                CurrentImage = 0;
            }

            pictureBox1.Image = Image.FromFile(ImagePaths[CurrentImage]);



        }

        private void İçeribtn_Click(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }

    
}




