﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class UIControl
    {
        protected DialogBox owner;

        public UIControl(DialogBox owner)
        {
            this.owner = owner;
        }
    }
}
