using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//random komentaras :D
namespace TestApp
{

    
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            nameLabel.Text = nameField.Text;
        }
    }
}
