using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snippet_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if(snippet.Text == null || snippet_description.Text == null || snippet_name.Text == null || snippet_prefix.Text == null)
            {
                MessageBox.Show("You must write the data!");
            }

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "JSON files (*.json)|*.json|All Files (*.*)|*.*";
            saveFile.RestoreDirectory = true;

            if(saveFile.ShowDialog() == DialogResult.OK)
                generate(snippet_name.Text.ToString(), snippet_prefix.Text.ToString(), snippet_description.Text.ToString(), snippet.Text.ToString(), saveFile.FileName);
        }

        void generate(string name, string prefix, string description, string body, string path)
        {
            string toWrite = "{" + "\n\t"
                + "\"" + name + "\":{" + "\n\t\t"
                + "\"prefix\": " + "[\"" + prefix + "\"],\n\t\t"
                + "\"body\": [" + body + "]," + "\n\t\t" +
                "\"description\": " + "\"" + description + "\"" + "\n\t"
                + "}" + "\n}";

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(toWrite);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while writing the file, please try again later!");
            }
        }
    }
}