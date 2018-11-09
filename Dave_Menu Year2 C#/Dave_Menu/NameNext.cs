using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dave_Menu
{
    public partial class NameNext : Form
    {
        List<Child> childList = new List<Child>();
        public NameNext(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void NameNext_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
        }

        private void btnGenerateName_Click(object sender, EventArgs e)
        {
            //        char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            //        Random r = new Random();
            //        int nameLength = r.Next(3, 13);
            //        string RandomString = "";
            //        for (int i = 0; i < nameLength; i++)
            //        {
            //            RandomString += letters[r.Next(0, 25)].ToString();
            //        }
            //        MessageBox.Show(RandomString);

            Random r = new Random();
            int length = r.Next(1, 9);
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < length)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            txtNewName.Text = Name;
        }
    }
}
