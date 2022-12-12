using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class FieldSizeForm : Form
    {
        public List<RadioButton> RadioButtons;
        public Label[,] LabelsField; 

        public FieldSizeForm()
        {
            InitializeComponent();
            RadioButtons = new List<RadioButton> 
            { 
                fieldSize4x4RadioButton, fieldSize5x5RadioButton, fieldSize6x6RadioButton, fieldSize7x7RadioButton,
            };
        }

        private void acceptSizeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
