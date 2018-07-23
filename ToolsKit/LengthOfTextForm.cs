using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsKit
{
    public partial class LengthOfTextForm : Form
    {
        public LengthOfTextForm()
        {
            InitializeComponent();
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            textLenghtLabel.Text = mainTextBox.Text.Length.ToString();
        }
    }
}
