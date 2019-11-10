using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace windows2mqtt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            //todo nlog, autofac, mqttnet
            await Task.Delay(2000);
            var mw = new MainWindow();
            mw.Show();

            await Task.Delay(5000);

            mw.Close();
            GC.Collect();


        }

    }
}
