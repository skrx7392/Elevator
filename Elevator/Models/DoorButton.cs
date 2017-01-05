using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class DoorButton : IElevatorButton
    {
        public Enums.State Indicator { get; private set; }
        public string Value { get; private set; }
        public DoorButton(bool value)
        {
            Indicator = Enums.State.Inactive;
            Value = value.ToString();
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
