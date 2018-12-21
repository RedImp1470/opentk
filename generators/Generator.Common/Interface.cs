using System.Collections.Generic;
using Generator.Common.Functions;

namespace Generator.Common
{
    /// <summary>
    /// Represents an AdvancedDLSupport interface.
    /// </summary>
    public class Interface
    {
        /// <summary>
        /// Gets or sets the name of this interface.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the functions contained within this interface.
        /// </summary>
        public List<Function> Functions { get; set; } = new List<Function>();

        /// <summary>
        /// Gets or sets a list of attributes to be applied to this interface.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
    }
}