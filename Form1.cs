using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Csempek_szama {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            // Ellenőrizzük, hogy a TextBox-okban érvényes adatok vannak-e
            if (double.TryParse(textBox1.Text, out double szelesseg) && double.TryParse(textBox2.Text, out double magassag)) {
                // A terület méretének kiszámítása négyzetméterben
                double terulet = szelesseg * magassag;

                // A csempeméret 20x20 cm, de a plusz 10%-ot is hozzáadjuk
                double csempemagassag = 0.2; // 20 cm méterben
                double cseppszlesseg = 0.2; // 20 cm méterben
                double illesztes = 1.1; // 100% + 10% illesztés

                // Szükséges csempék számának kiszámítása
                double szuksegesCsempek = (terulet * illesztes) / (csempemagassag * cseppszlesseg);

                // Eredmény megjelenítése a labelAnswer-ben
                labelAnswer.Text = $"Szükséges csempék száma: {Math.Ceiling(szuksegesCsempek)} darab";
            }
            else {
                // Hibaüzenet, ha érvénytelen adatok vannak
                MessageBox.Show("Érvénytelen adatok. Kérem, adjon meg érvényes számokat a TextBox-okban.");
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
