using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Interfaces
{
    /// <summary>
    /// Defines the Interface for floor
    /// </summary>
    public interface IFloor
    {
        /// <summary>
        /// Identifies the Floor number
        /// </summary>
        int FloorValue { get; }

        /// <summary>
        /// Defines the Floor Door 
        /// </summary>
        IDoor Door { get; }

        /// <summary>
        /// Identifies the button clicked
        /// </summary>
        /// <param name="isDirectionUp">Gives whether the button clicked is for upward direction</param>
        void ProcessRequest(bool isDirectionUp);
    }
}
