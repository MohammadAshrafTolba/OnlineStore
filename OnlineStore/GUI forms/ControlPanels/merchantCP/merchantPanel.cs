﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class merchantPanel : Form
    {
        private String connString;
        private User currUser;

        public merchantPanel(User newUser, String connString)
        {
            InitializeComponent();
            currUser = newUser;
            this.connString = connString;
        }
    }
}