using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arabam {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {

            pictureBox1.Image = Image.FromFile(@"C:\Users\Abdülkerem\Desktop\Servis_araba_iç.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e) {
            Ana_Sayfa form2 = new Ana_Sayfa();
        }
    }
}
