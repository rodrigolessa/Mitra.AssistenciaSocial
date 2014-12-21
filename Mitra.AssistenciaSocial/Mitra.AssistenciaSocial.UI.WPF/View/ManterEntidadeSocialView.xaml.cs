﻿using System;
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
using Mitra.AssistenciaSocial.UI.WPF.ViewModel;

namespace Mitra.AssistenciaSocial.UI.WPF.View
{
    /// <summary>
    /// Interaction logic for ManterEntidadeSocialView.xaml
    /// </summary>
    public partial class ManterEntidadeSocialView : Window
    {
        public ManterEntidadeSocialView()
        {
            InitializeComponent();
            this.DataContext = new ManterEntidadeSocialViewModel();
        }
    }
}