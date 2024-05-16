using System;
using System.Threading;
using System.Windows.Forms;

namespace Arabam {
    public partial class YüklemeEkranı : Form {

        Ana_Sayfa Ana_Sayfa = new Ana_Sayfa();
        public YüklemeEkranı() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
            circularProgressBar1.Value += 1;

            if (circularProgressBar1.Value >= 100) {
                timer1.Stop();
                circularProgressBar1.Text = "Yüklendi";

                this.Invoke((MethodInvoker)delegate {
                    Ana_Sayfa Ana_Sayfa = new Ana_Sayfa();
                    Ana_Sayfa.Show();
                    this.Hide();
                });
            }

        }

        private void YüklemeEkranı_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
