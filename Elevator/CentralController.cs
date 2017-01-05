using Elevator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevator.Models;

namespace Elevator
{
    public class CentralController
    {
        public List<IElevator> elevators = new List<IElevator>();
        public List<IFloor> Floors = new List<IFloor>();

        public static void Main(String[] args)
        {
            int totalElevators = int.Parse(Console.ReadLine());
            int totalFloors = int.Parse(Console.ReadLine());
            var controller = new CentralController();
            for (int i = 0; i < totalElevators; i++)
            {
                int minFloor = int.Parse(Console.ReadLine());
                int maxFloor = int.Parse(Console.ReadLine());
                int step = int.Parse(Console.ReadLine());
                controller.elevators.Add(new Elevator.Models.Elevator(minFloor, minFloor, maxFloor, step));
            }
            for (int i = 0; i < totalFloors; i++)
            {
                controller.Floors.Add(new Models.Floor(i));
            }
            while (true)
            {
                //Assuming 0 = elevator button and 1 = floor button
                int buttonType = int.Parse(Console.ReadLine());
                if(buttonType == 0)
                {
                    int destFloor = int.Parse(Console.ReadLine());
                    int elevatorNumber = int.Parse(Console.ReadLine());
                    controller.ProcessRequest(controller, elevatorNumber, destFloor);
                }
                else
                {
                    int currFloor = int.Parse(Console.ReadLine());
                    bool isDirectionUp = bool.Parse(Console.ReadLine());
                    controller.ProcessRequest(controller, currFloor, isDirectionUp);
                }
            }
        }

        /// <summary>
        /// Precces the request received from the elevator buttons
        /// </summary>
        /// <param name="controller">Passes the central controller</param>
        /// <param name="elevatorNumber">Gives the elevator number in which the button is clicked</param>
        /// <param name="destFloor">Gives the destination floor of the elevator</param>
        private void ProcessRequest(CentralController controller, int elevatorNumber, int destFloor)
        {
            controller.elevators[elevatorNumber].ProcessRequest(destFloor);
            OpenFloorDoor(controller, destFloor);
        }

        /// <summary>
        /// Processes the request received from the floor buttons
        /// </summary>
        /// <param name="controller">Passes the central controller</param>
        /// <param name="currFloor">Gives the current floor in which the button is clicked</param>
        /// <param name="isDirectionUp">Gives the direction of the destination floor</param>
        private void ProcessRequest(CentralController controller, int currFloor, bool isDirectionUp)
        {
            // Turns on the light on the clicked button
            controller.Floors[currFloor].ProcessRequest(isDirectionUp);
            //Identifies if any elevators are Idle on the requested floor
            var suitableElevators = controller.elevators.FindAll(p => p.OperationState == Enums.State.Active && p.State == Enums.ElevatorState.Standing && p.CurrentFloor == currFloor);
            if (suitableElevators.Count>0)
            {
                suitableElevators.First().ProcessRequest(currFloor);
                OpenFloorDoor(controller, currFloor);
            }
            else
            {
                var intendedDirection = isDirectionUp == true ? Enums.ElevatorState.MovingUp : Enums.ElevatorState.MovingDown;
                //Identifies the most suitable elevator to fulfill the request based on the closest elevator moving in the intended direction
                suitableElevators = controller.elevators.FindAll(p => p.OperationState == Enums.State.Active && p.State == intendedDirection);
                var desiredElevator = suitableElevators.FirstOrDefault();
                int distanceAway = currFloor - desiredElevator.CurrentFloor;
                foreach (var item in suitableElevators)
                {
                    desiredElevator = distanceAway > currFloor - item.CurrentFloor ? item : desiredElevator;
                }
                desiredElevator.ProcessRequest(currFloor);
                OpenFloorDoor(controller, currFloor);
            }
        }
        /// <summary>
        /// Opens the Floor Doors
        /// </summary>
        /// <param name="controller">Passes the central controller</param>
        /// <param name="floorValue">Gives the floor number in which the doors are to be opened</param>
        private void OpenFloorDoor(CentralController controller, int floorValue)
        {
            controller.Floors.Find(p => p.FloorValue == floorValue).Door.OpenDoors();
        }
    }
}
