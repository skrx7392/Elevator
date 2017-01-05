using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Interfaces
{
    /// <summary>
    /// Defines the Door Interface
    /// </summary>
    public interface IDoor
    {
        /// <summary>
        /// Opens Doors
        /// </summary>
        void OpenDoors();

        /// <summary>
        /// Closes Doors
        /// </summary>
        void CloseDoors();
    }
}
