﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public abstract class BaseCommand
    {
        protected CommandType type;
        public abstract String StatusCheck();
    }
}
