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
using Shouyuan.IEC104;

namespace GuiZhou104
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        ASDU ASDU = new ASDU();
        Slave s = new Slave(2404, 1);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte i = 0;
            i = i.SetBit(8).SetBit(8).SetBit(8);
            s.startService();
            var m = new Message(ElementTypes.BCR, 1, 3);
            m.Address = 8088;
            
        }
    }
}
