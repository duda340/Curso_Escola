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
using Rec_Escola.Views;

namespace Rec_Escola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btEscolaC_Click(object sender, RoutedEventArgs e)
        {
            EscolaForm win = new EscolaForm();
            win.ShowDialog();
        }

        private void btCursoC_Click(object sender, RoutedEventArgs e)
        {
            CursoForm win = new CursoForm();
            win.ShowDialog();
        }

        private void btEscolaL_Click(object sender, RoutedEventArgs e)
        {
            EscolaList wid = new EscolaList();
            wid.ShowDialog();
        }

        private void btEscolha4_Click(object sender, RoutedEventArgs e)
        {
            CursoList win = new CursoList();
            win.ShowDialog();
        }
    }
}
