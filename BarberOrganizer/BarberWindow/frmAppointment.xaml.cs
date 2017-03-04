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
using System.Windows.Threading;

namespace BarbersWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class frmAppointment : Window
    {
        #region Variables

        DispatcherTimer currentTime = new DispatcherTimer();

        #endregion

        public frmAppointment()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.lblDateRight.Content = DateTime.Now.ToString("dddd, dd/MM/yyyy ") + "Hora: "+ DateTime.Now.ToString("HH:mm:ss");
            }, this.Dispatcher);

        }

       
        
    }
}
