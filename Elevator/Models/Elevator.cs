using Elevator.Enums;
using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Models
{
    class Elevator : IElevator
    {
        public int CurrentFloor { get; private set; }
        public int MinFloor { get; private set; }
        public int MaxFloor { get; private set; }
        public int FloorStep { get; private set; }
        public ElevatorState State { get; set; }
        public int CurrentLoad { get; set; }
        public int MaxLoad { get; private set; }
        public State OperationState { get; set; }
        private IDoor Door { get; set; }
        
        public List<IButton> Buttons = new List<IButton>();
        public Elevator(int currentFloor, int minFloor, int maxFloor, int floorStep)
        {
            State = ElevatorState.Standing;
            OperationState = Enums.State.Active;
            Door = new ElevatorDoor();
            CurrentFloor = currentFloor;
            MinFloor = minFloor;
            MaxFloor = maxFloor;
            FloorStep = floorStep;
            AddButtons(minFloor, maxFloor, floorStep);
        }
        private void AddButtons(int min, int max, int step)
        {
            for (int i = min; i <= max; i += step)
            {
                Buttons.Add(new ElevatorButton(i, false));
            }
            Buttons.Add(new DoorOpenButton());
            Buttons.Add(new DoorCloseButton());
        }
        public void MoveUp()
        {
            State = ElevatorState.MovingUp;
            CurrentFloor += 1;
        }
        public void MoveDown()
        {
            State = ElevatorState.MovingDown;
            CurrentFloor -= 1;
        }
        public void OpenDoor()
        {
            Door.OpenDoors();
        }
        public void CloseDoor()
        {
            Door.CloseDoors();
        }
        public void ProcessRequest(int destFloor)
        {
            if(CurrentFloor==destFloor)
            {
                State = ElevatorState.Standing;
                OpenDoor();
            }
            else if(CurrentFloor<destFloor)
            {
                CheckLoadLimit();
                MoveUp();
            }
            else
            {
                CheckLoadLimit();
                MoveDown();
            }
        }
        private bool CheckLoadLimit()
        {
            // We will be getting CurrentLoad value from the sensor installed in the elevator
            while(CurrentLoad>=MaxLoad)
            {
                throw new Exception("Load Limit Exceeded");
            }
            return true;
        }
        public void MakeElevatorInactive()
        {
            OperationState = Enums.State.Inactive;
        }
        public void MakeElevatorActive()
        {
            OperationState = Enums.State.Active;
        }
    }
}
