﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CBW.WindowsPhone
{
    public partial class MemoEditControl : UserControl
    {
        public MemoEditControl(string defauttext)
        {
            InitializeComponent();
            this.MemoEdittxtBox.DataContext = defauttext;
        }
    }
}