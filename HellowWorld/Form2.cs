using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellowWorld
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Label lbl = new Label();
            lbl.Text = "Hello World";
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Arial", 14);
            lbl.Location = new System.Drawing.Point(50, 50);

            this.Controls.Add(lbl);
        }
    }
}

}
