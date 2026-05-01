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
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace WpfCamera
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : System.Windows.Controls.UserControl
    {
        private readonly MediaCapture _mediaCapture = new MediaCapture();
        private readonly CaptureElement _captureElement;
        private StorageFolder _captureFolder;
        private bool _initialized = false;
        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
