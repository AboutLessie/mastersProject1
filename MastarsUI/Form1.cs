using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastarsUI
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            cancelBtn.Text = "Cofnij";
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                cancelBtn.Text = "Cofnij";
                listPanel[--index].BringToFront();
            }
            else if (index == 0)
            {
                cancelBtn.Text = "Zamknij";
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel[index].BringToFront();
        }
    }
}
