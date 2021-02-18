using System;
using System.Collections.Generic;
using System.Text;
using ECS;

namespace ECS.Testprogram
{
    class StubSensor : ITempSensor
    {
        public int temp { get; set; }
        public int GetTemp()
        {
            return temp;
        }

        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }
    }
}
