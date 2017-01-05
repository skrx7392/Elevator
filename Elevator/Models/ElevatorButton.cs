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
        public Enums.State Indicator { get; private set; }
        public int FloorValue { get; private set; }
        public ElevatorButton(int floorValue, bool indicator)
        {
            FloorValue = floorValue;
            Indicator = indicator == true ? Enums.State.Active : Enums.State.Inactive;
        }
        public void TurnLightOn()
        {
            Indicator = Enums.State.Active;
        }
        public void TurnLightOff()
        {
            Indicator = Enums.State.Inactive;
        }
    }
}
