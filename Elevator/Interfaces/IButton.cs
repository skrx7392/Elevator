using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Interfaces
{
    /// <summary>
    /// Defines the Button Interface
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// Indicates whether the Button is Active
        /// </summary>
        Enums.State Indicator { get; }
        
        /// <summary>
        /// Turns on the light on the selected button
        /// </summary>
        void TurnLightOn();

        /// <summary>
        /// Turns off the light on the selected Button
        /// </summary>
        void TurnLightOff();
    }
}
