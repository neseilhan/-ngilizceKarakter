using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İngilizceKarakter
{
    public partial class Form1 : Form
    {
        string sonuc = "";
        string cumle = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> harfDictionary = new Dictionary<string, string>
            {
                {"Ö","O"},
                {"Ç","C" },
                {"Ş","S" },
                {"Ğ","G" },
                {"Ü","U" },
                {"ö","o" },
                {"ç","c" },
                {"ş","s" },
                {"ğ","g" },
                {"ü","u" },
                {"İ","I" },
                {"ı","i" }

            };
            
            foreach (char harf in cumle)
            {
                if (harfDictionary.ContainsKey(harf.ToString()))
                    sonuc += harfDictionary[harf.ToString()];
                else
                    sonuc += harf.ToString();
            }
            listBox1.Items.Add(sonuc);
            //MessageBox.Show(sonuc);
        }

     

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            cumle = richTextBox1.Text.ToString();
        }


    }
}
