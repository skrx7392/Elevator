using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Interfaces
{
    /// <summary>
    /// Defines the interface for buttons used in elevator
    /// </summary>
    public interface IElevatorButton : IButton
    {
        /// <summary>
        /// Defines the value of the button as string to allow both floor numbers and door  open/close buttons
        /// </summary>
        string Value { get; } 
    }
}
