using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkiApp
{
    public partial class MakeSelectionsForm : Form
    {
        public string SelectedItems => String.Join(",", listBox1.Items.Cast<String>());
        public MakeSelectionsForm()
        {
            InitializeComponent();

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                comboBox1.Items.Add(letter.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ((ComboBox)sender).SelectedItem;
            listBox1.Items.Add(item);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            List<object> itemsToDelete = [.. listBox1.SelectedItems];

            foreach (var item in itemsToDelete)
            {
                listBox1.Items.Remove(item);
            }
        }
    }
}
