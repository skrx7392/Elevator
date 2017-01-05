using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class Floor : IFloor
    {
        public int FloorValue { get; private set; }
        public List<IFloorButton> Buttons = new List<IFloorButton>();
        public IDoor Door { get; private set; }

        public Floor(int floor)
        {
            FloorValue = floor;
            Buttons.Add(new FloorButton(true));
            Buttons.Add(new FloorButton(false));
            Door = new FloorDoor(floor);
        }

        public void ProcessRequest(bool isDirectionUp)
        {
            Buttons.FirstOrDefault(p => p.IsDirectionUp == isDirectionUp).TurnLightOn();
        }
    }
}
