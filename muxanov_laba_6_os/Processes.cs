using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muxanov_Kutin_laba6_OS
{
    public class Process
    {

        public int size;
        public int startIndex;
        public int id;
        public String state;
        public int typeOfMemory;


        public Process(int size, int id)
        {
            this.size = size;
            state = "Ready";
            this.id = id;
        }

        public void pauseProcess()
        {
            if (state.Equals("Running"))
                state = "Wait";
            else
            {
                state = "Running";
                OperationMemory.addProcess(id);
            }

        }

    }
}
