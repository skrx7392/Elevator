using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Interfaces
{
    /// <summary>
    /// Interface for FloorButtons
    /// </summary>
    public interface IFloorButton : IButton
    {
        /// <summary>
        /// Defines whether the button is for going up or down
        /// </summary>
        bool IsDirectionUp { get; }
    }
}
