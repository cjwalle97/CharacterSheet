using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CharacterSheet
{
    public partial class Form1 : Form
    {
        Demon Nekomata = new Demon("Nekomata", 350, 150, 17, 17, 27, 27, 22);

        public void SaveBehaviour()
        {
            DataSerializer<Demon>.Serialize("Saved Demon", Nekomata);
        }

        public void LoadBehaviour()
        {
            DataSerializer<Demon>.Deserialize("Saved Demon");
        }

        public void QuitBehaviour()
        {

        }
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Nekomata.AccessName();
            textBox2.Text = Nekomata.AccessHealth().ToString();
            textBox3.Text = Nekomata.AccessMana().ToString();
            textBox4.Text = Nekomata.AccessStrength().ToString();
            textBox5.Text = Nekomata.AccessMagic().ToString();
            textBox6.Text = Nekomata.AccessDexterity().ToString();
            textBox7.Text = Nekomata.AccessAgility().ToString();
            textBox8.Text = Nekomata.AccessLuck().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton.SingletonState
            SaveBehaviour();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadBehaviour();
        }
    }
}
