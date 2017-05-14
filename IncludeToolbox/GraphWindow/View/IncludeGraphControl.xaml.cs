﻿using System.Windows;
using System.Windows.Controls;

namespace IncludeToolbox.GraphWindow
{
    public partial class IncludeGraphControl : UserControl
    {
        public IncludeGraphViewModel ViewModel { get; private set; }

        public IncludeGraphControl()
        {
            InitializeComponent();
            ViewModel = (IncludeGraphViewModel)DataContext;
        }

        private void Click_SaveGraph(object sender, RoutedEventArgs e)
        {
            // TODO: Progressbar and open prompt.
            ViewModel.SaveGraph();
        }
    }
}