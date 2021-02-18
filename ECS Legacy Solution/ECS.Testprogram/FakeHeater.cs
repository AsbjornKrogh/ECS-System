using System;
using System.Collections.Generic;
using System.Text;
using ECS;

namespace ECS.Testprogram
{
    class FakeHeater : IHeater
    {
        public bool turnedOn = false;
        public bool turnedOff = false;
        public void TurnOn()
        {
            turnedOn = true;
        }

        public void TurnOff()
        {
            turnedOff = true;
        }

        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }
    }
}
