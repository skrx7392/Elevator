using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class FloorButton : IFloorButton
    {
        public FloorButton(bool direction)
        {
            IsDirectionUp = direction;
        }
        public Enums.State Indicator { get; set; }
        public bool IsDirectionUp { get; private set; }
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
