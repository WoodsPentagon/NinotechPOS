﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Interfaces
{
    interface ITab
    {
        Button EnterButton();
        Control FirstControl();

        Task InitializeAsync();

        void RefreshData();
        void Refresh_Callback(object sender, EventArgs e);
        void CancelLoading();
    }
}
