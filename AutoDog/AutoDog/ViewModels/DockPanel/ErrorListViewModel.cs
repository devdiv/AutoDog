﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AutoDog.ViewModels
{
    class ErrorListViewModel:ToolViewModel
    {
        public const string ToolContentId = "ErrorListTool";
        public ErrorListViewModel()
            : base("错误列表")
        {
            ContentId = ToolContentId;

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri("pack://application:,,/Images/DockPanel/ErrorList.png");
            bi.EndInit();
            IconSource = bi;
        }
    }
}