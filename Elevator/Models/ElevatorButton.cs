using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class ElevatorButton : IButton
    {
        public bool Indicator { get; private set; }
        public int FloorValue { get; private set; }
        public ElevatorButton(int floorValue, bool indicator)
        {
            FloorValue = floorValue;
            Indicator = indicator;
        }
        public void TurnLightOn()
        {
            Indicator = true;
        }
        public void TurnLightOff()
        {
            Indicator = false;
        }
    }
}
