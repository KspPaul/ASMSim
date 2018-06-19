using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMSim
{
    class CodeData
    {
        private int _accumulator;
        int currentP = 0;
        
        public void SetAcc(int x)
        {
            _accumulator = x;
        }

        public int GetAcc()
        {
            return _accumulator;
        }
        public int GetCurrentP()
        {
            return currentP;
        }
        public void SetCurrentP(int x)
        {
            currentP = x;
        }
    }
}
