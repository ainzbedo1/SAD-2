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
namespace wpfUserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UcWpf : UserControl
    {
       
        public Button btn;
        public TextBox txt;
       
        public UcWpf()
        {
            InitializeComponent();
            var list = new List<ComboBoxItem>
                {
                    new ComboBoxItem {DisplayText = "Header1", IsHeader = true},
                    new ComboBoxItem {DisplayText = "Item1", IsHeader = false},
                    new ComboBoxItem {DisplayText = "Item2", IsHeader = false},
                    new ComboBoxItem {DisplayText = "Item3", IsHeader = false},
                    new ComboBoxItem {DisplayText = "Header2", IsHeader = true},
                    new ComboBoxItem {DisplayText = "Item4", IsHeader = false},
                    new ComboBoxItem {DisplayText = "Item5", IsHeader = false},
                    new ComboBoxItem {DisplayText = "Item6", IsHeader = false},
                };

            DataContext = list;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        public class ComboBoxItem
        {
            public string DisplayText { get; set; }
            public bool IsHeader { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
