using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class ElevatorButton : IElevatorButton
    {
        public Enums.State Indicator { get; private set; }
        public string Value { get; private set; }
        public ElevatorButton(string floorValue, bool indicator)
        {
            Value = floorValue;
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
