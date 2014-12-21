using Mitra.AssistenciaSocial.UI.WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mitra.AssistenciaSocial.UI.WPF.ViewModel
{
    public class ManterEntidadeSocialViewModel : ViewModelBase
    {
        public ManterEntidadeSocialViewModel()
        {
            Model = new EntidadeSocial();
        }

        private EntidadeSocial Model;

        public ICommand SubMitCommand
        {
            get
            {
                return new RelayCommand(param => this.Salvar(param));
            }
        }

        private string _id;
        public string Id
        {
            get {
                return _id;
            }
            set
            {
                if (_id != value && !string.IsNullOrEmpty(value))
                {
                    _id = value;
                    RaisePropertyChanged(Id);
                }
            }
        }
        private string _nome;
        public string Nome
        {
            get {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        private string _endereco;
        public string Endereco
        {
            get {
                return _endereco;
            }
            set
            {
                _endereco = value;
            }
        }
        private string _telefone;
        public string Telefone
        {
            get {
                return _telefone;
            }
            set
            {
                _telefone = value;
            }
        }
        private string _cnpj;
        public string CNPJ
        {
            get {
                return _cnpj;
            }
            set
            {
                _cnpj = value;
            }
        }

        private void Salvar(object parameter)
        {
            this.ErrorMessage = "Erro ao salvar a Entidade Social!";
        }
    }
}
