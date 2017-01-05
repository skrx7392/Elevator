using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class DoorCloseButton : IButton
    {
        public Enums.State Indicator { get; private set; }
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
