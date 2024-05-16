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

        }
    }
}
