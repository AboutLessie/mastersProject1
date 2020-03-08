using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotest.Logger
{
    public interface ILogMaker
    {
        void AddToLog(string text);
    }
}
