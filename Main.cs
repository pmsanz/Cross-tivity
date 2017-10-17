using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cross_Tivity
{
    public partial class Main : Form
    {

        private DateTimePicker timePicker;

        public Main()
        {
            InitializeComponent();
            InicializarTimmer();
        }

        private void InicializarTimmer()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(10, 10);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }
        

    }
}
