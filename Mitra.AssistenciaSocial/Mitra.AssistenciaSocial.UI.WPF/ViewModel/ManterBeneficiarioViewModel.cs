using Mitra.AssistenciaSocial.UI.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mitra.AssistenciaSocial.UI.WPF.ViewModel
{
    public class ManterBeneficiarioViewModel : ViewModelBase
    {
        public ManterBeneficiarioViewModel()
        {
            Model = new Beneficiario();
        }

        private Beneficiario Model;

        public ICommand SubMitCommand
        {
            get
            {
                return new RelayCommand(param => this.Salvar(param));
            }
        }

        private void Salvar(object parameter)
        {
            this.ErrorMessage = "Erro ao salvar o Beneficiário!";
        }
    }
}
