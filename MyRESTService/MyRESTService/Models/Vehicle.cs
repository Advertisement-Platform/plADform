using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyRESTService.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Vehicle")]
    [DataContract]
    public class Vehicle : Catagory
    {
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value> The make. </value>
        [DataMember]
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value> The model. </value>
        [DataMember]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value> The year. </value>
        [DataMember]
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value> The price. </value>
        [DataMember]
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value> The color. </value>
        [DataMember]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the type of the vehicle.
        /// </summary>
        /// <value> The type of the vehicle. </value>
        [DataMember]
        public string VehicleType { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value> The description. </value>
        [DataMember]
        public string Description { get; set; }
    }
}
