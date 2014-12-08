using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Mitra.AssistenciaSocial.UI.WPF.Model;

namespace Mitra.AssistenciaSocial.UI.WPF.ViewModel
{
    public class LogInViewModel : ViewModelBase
    {
        #region Propriedades

        private LogInModel Model;

        #endregion

        public LogInViewModel()
        {
            Model = new LogInModel();
        }

        private bool EnableDisable()
        {
            return true;
        }

        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                if (_UserName != value && !string.IsNullOrEmpty(value))
                {
                    _UserName = value;
                    RaisePropertyChanged(UserName);
                }
            }
        }

        private string _Password;
        public string Password
        {
            private get
            {
                return _Password;
            }
            set
            {
                if (_Password != value && !string.IsNullOrEmpty(value))
                {
                    _Password = value;
                    RaisePropertyChanged(Password);
                }
            }
        }

        //public ICommand SubMitCommand
        //{
        //    get
        //    {
        //        return new RelayCommand(param => this.GetApproval(param));
        //    }
        //}

        private void GetApproval(object Parameter)
        {
            if (this.Password != string.Empty && !string.IsNullOrEmpty(this.UserName))
            {
                bool approved = Model.GetApproval(this.UserName, this.Password);
                if (!approved)
                {
                    this.ErrorMessage = "Login ou Senha incorretos!";
                }
                else
                {
                    this.ErrorMessage = "Usuário logado!";
                }
            }
        }
    }
}
