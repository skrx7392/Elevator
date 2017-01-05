using Elevator.Enums;
using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class ElevatorDoor : IDoor
    {
        DoorState Door = DoorState.Closed;

        public void OpenDoors()
        {
            Door = DoorState.Open;
        }
        public void  CloseDoors()
        {
            Door = DoorState.Closed;
        }
    }
}
