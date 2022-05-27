﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
  public partial class Splash : Form
  {
    public Splash()
    {
      InitializeComponent();
    }

    int startpoint = 0;
    private void timer1_Tick(object sender, EventArgs e)
    {
      startpoint = startpoint+1;
      myProgressBar.Value = startpoint;
      if(myProgressBar.Value == 100)
      {
        myProgressBar.Value = 0;
        timer1.Stop();
        Login login = new Login();
        login.Show();
        this.Hide();
      }
    }

    private void Splash_Load(object sender, EventArgs e)
    {
      timer1.Start();
    }
  }
}
