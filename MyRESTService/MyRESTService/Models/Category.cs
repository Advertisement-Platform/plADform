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
    [Table("Catagory")]
    [DataContract]
    public class Catagory : ModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Catagory"/> class.
        /// </summary>
        public Catagory()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Catagory" /> class.
        /// </summary>
        /// <param name="catagoryName">Name of the catagory.</param>
        public Catagory(string catagoryName)
        {
            CatagoryName = catagoryName;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value> The name. </value>
        [DataMember]
        public string CatagoryName { get; set; }
    }
}
