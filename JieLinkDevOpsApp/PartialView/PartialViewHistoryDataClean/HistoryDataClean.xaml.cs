﻿using PartialViewHistoryDataClean.ViewModels;
using PartialViewInterface;
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

namespace PartialViewHistoryDataClean
{
    /// <summary>
    /// HistoryDataClean.xaml 的交互逻辑
    /// </summary>
    public partial class HistoryDataClean : UserControl, IPartialView
    {
        HistoryDataCleanViewModel viewModel;

        public HistoryDataClean()
        {
            InitializeComponent();
            viewModel = new HistoryDataCleanViewModel();
            DataContext = viewModel;
        }

        public string MenuName
        {
            get { return "数据清理"; }
        }

        public string TagName
        {
            get { return "HistoryDataClean"; }
        }

        public MenuType MenuType
        {
            get { return MenuType.Center; }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.Load();
        }
    }
}