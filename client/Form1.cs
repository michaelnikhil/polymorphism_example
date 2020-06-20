using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            AfficherMembres(pomme);
    

        }

        private void button2_Click(object sender, EventArgs e) {
            Legume haricots = new Haricots();
            AfficherMembres(haricots);

        }

        private void button3_Click(object sender, EventArgs e) {
            Legume poireaux = new Poireaux();
            AfficherMembres(poireaux);
        }

        private void button4_Click(object sender, EventArgs e) {
            Banane banane = new Banane();
            AfficherMembres(banane);

        }

        private void AfficherMembres(object obj) {

            listBox1.Items.Clear();
            MemberInfo[] properties = obj.GetType().GetMembers();

            foreach (MemberInfo prop in properties) {
                listBox1.Items.Add(prop.DeclaringType + "\t" + prop.MemberType + "\t" + prop.Name);

            }
        }
    }
}
