using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.AppDataFile;
using WpfApp1.Pages;
using WpfApp1.Properties;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectOdb.conObj = new salon_krasotyEntities1();
            FrameObj.frameMain = FrmMain;
            FrmMain.Navigate(new PageMain());
        }


        private void frmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
