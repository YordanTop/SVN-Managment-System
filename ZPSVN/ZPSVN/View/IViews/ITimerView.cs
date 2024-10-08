﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPSVN.Presentation.EventArguments;

namespace ZPSVN.View.IViews
{
    public interface ITimerView
    {
        int TextTimerToMinutes { get; }
        TextBox TimerTextBox { get; set; }

        event EventHandler<TimerEventArgs> SetTimer;
        event KeyPressEventHandler CheckKeyCharacter;
    }
}
