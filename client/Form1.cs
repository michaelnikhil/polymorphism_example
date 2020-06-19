using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maDLL;

namespace client {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Fruit pomme = new Pomme();
            listBox1.Items.Add("la pomme se mange " + pomme.SeMange());
            listBox1.Items.Add("la pomme se nourrit " + pomme.SeNourrit());
            listBox1.Items.Add("la pomme se reproduit " + pomme.SeReproduit());
            listBox1.Items.Add("presence de pepins : " + pomme.PresenceDePepins());



        }
    }
}
