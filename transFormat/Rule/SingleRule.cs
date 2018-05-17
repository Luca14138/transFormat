using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace transFormat
{
    public class SingleRule
    {
        public SingleRule()
        {
            this.Name = null;
            this.Numbers = new float[30];
        }
        /// <summary>
        /// Gets or sets the name of single line rule
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        ///<summary>
        ///Get or set the number of wanted field.
        /// </summary>
        /// <value>
        /// The number
        /// </value>
        public float[] Numbers { get; set; }
    }
}
