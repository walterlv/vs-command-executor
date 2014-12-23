using System.Windows;
using System.Windows.Controls;

namespace Walterlv.VisualStudio.CommandExecutor
{
    [ProvideToolboxControl("Command Executor", true)]
    public partial class CommandConfigToolbox : UserControl
    {
        public CommandConfigToolbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.button1_Click()", this.ToString()));
        }
    }
}
