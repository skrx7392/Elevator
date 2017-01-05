using Elevator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Interfaces
{
    /// <summary>
    /// Defines the interface for Elevator
    /// </summary>
    public interface IElevator
    {
        /// <summary>
        /// Gives the current floor in which the elevator is in
        /// </summary>
        int CurrentFloor { get; }

        /// <summary>
        /// Gives the min floor that the elevator can access
        /// </summary>
        int MinFloor { get; }

        /// <summary>
        /// Gives the max floor that the elevator can access
        /// </summary>
        int MaxFloor { get; }

        /// <summary>
        /// Gives the no of floors the elevator skips between each stop;
        /// For example, some elevators stop only at odd numbered floors or even numbered floors if the step is 2
        /// </summary>
        int FloorStep { get; }

        /// <summary>
        /// Gives the current moving state of the elevator
        /// </summary>
        ElevatorState State { get; set; }

        /// <summary>
        /// Gives the current Operating Status of the elevator
        /// </summary>
        State OperationState { get; set; }

        /// <summary>
        /// Makes the elevator move up
        /// </summary>
        void MoveUp();

        /// <summary>
        /// Makes the elevator move down
        /// </summary>
        void MoveDown();

        /// <summary>
        /// Opens the elevator door
        /// </summary>
        void OpenDoor();

        /// <summary>
        /// Closes the elevator door
        /// </summary>
        void CloseDoor();

        /// <summary>
        /// Processes the request and decides on the direction the elevator should move
        /// </summary>
        /// <param name="destFloor">Destination floor of the elevator</param>
        void ProcessRequest(int destFloor);

        /// <summary>
        /// Makes the elevator Inactive
        /// </summary>
        void MakeElevatorInactive();

        /// <summary>
        /// Makes the elevator active
        /// </summary>
        void MakeElevatorActive();
    }
}
