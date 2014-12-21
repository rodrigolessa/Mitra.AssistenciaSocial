using Mitra.AssistenciaSocial.UI.WPF.View;
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

namespace Mitra.AssistenciaSocial.UI.WPF
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

        private void CadastrarBeneficiarioOnClick(object sender, RoutedEventArgs e)
        {
            var view = new ManterBeneficiarioView();
            view.Show();
        }

        private void ListarBeneficiarioOnClick(object sender, RoutedEventArgs e)
        {
            var view = new ListarBeneficiarioView();
            view.Show();
        }

        private void CadastrarEntidadeSocialOnClick(object sender, RoutedEventArgs e)
        {
            var view = new ManterEntidadeSocialView();
            view.Show();
        }

        private void ListarEntidadeSocialOnClick(object sender, RoutedEventArgs e)
        {
            var view = new ListarEntidadeSocialView();
            view.Show();
        }

        private void CadastrarTipoDeAssistenciaOnClick(object sender, RoutedEventArgs e)
        {
            var view = new ManterTipoDeAssistenciaView();
            view.Show();
        }

        private void ListarTipoDeAssistenciaOnClick(object sender, RoutedEventArgs e)
        {
            var view = new ListarTipoDeAssistenciaView();
            view.Show();
        }
    }
}
