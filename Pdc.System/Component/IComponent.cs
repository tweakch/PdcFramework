﻿using System.Collections.Generic;

namespace Pdc.System.Component
{
    /// <summary>
    ///     Defines a standard way to interact with a component
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        ///     True if the component has SubComponents, otherwise False
        /// </summary>
        bool IsComposite { get; }

        /// <summary>
        ///     True if the component is an active component
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        ///     True if the component is a passive component
        /// </summary>
        bool IsPassive { get; }

        /// <summary>
        ///     Returns all Sub Components of this component
        /// </summary>
        IEnumerable<IComponent> SubComponents { get; }

        /// <summary>
        ///     The type of the component
        /// </summary>
        EComponentType ComponentTypeType { get; }
    }
}