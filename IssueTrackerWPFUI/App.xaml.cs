﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TrackerLibrary;

namespace IssueTrackerWPFUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
        }
    }
}
