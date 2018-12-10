using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BindingEnums
{
    public class InputParameter
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public bool Required { get; set; }
        public object Value { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Object> InputParameterList { get; set; } = new ObservableCollection<Object>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            InputParameter bitlocker_drive = new InputParameter();
            bitlocker_drive.Name = "BitLocker Enabled";
            bitlocker_drive.Type = typeof(String);
            InputParameterList.Add(bitlocker_drive);

            InputParameter bitlocker_status = new InputParameter();
            bitlocker_status.Name = "Status";
            bitlocker_status.Type = typeof(Status);
            InputParameterList.Add(bitlocker_status);

            InputParameter bitlocker_foo = new InputParameter();
            bitlocker_foo.Name = "Foo";
            bitlocker_foo.Type = typeof(Foo);
            InputParameterList.Add(bitlocker_foo);
        }
    }
}
 