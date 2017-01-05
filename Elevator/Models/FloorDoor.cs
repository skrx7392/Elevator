using Elevator.Enums;
using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class FloorDoor : IDoor
    {
        DoorState State = DoorState.Closed;
        public int FloorValue { get; private set; }
        public FloorDoor(int floor)
        {
            FloorValue = floor;
        }
        public void OpenDoors()
        {
            State = DoorState.Open;
        }
        public void CloseDoors()
        {
            State = DoorState.Closed;
        }
    }
}
