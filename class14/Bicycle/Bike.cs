using System;
using System.Collections.Generic;
using System.Text;

namespace Bicycle
{
    class Bike
    {
        private int _speed;

        public Bike(int speed)
        {
            _speed = speed;
        }

        public void Acccelerate(int additionalSpeed)
        {
            _speed += additionalSpeed;
        }

        public int GetSpeed()
        { return _speed; }
    }
}
