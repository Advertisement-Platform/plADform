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
    [Table("Client")]
    [DataContract]
    public class Client : ModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        public Client()
        {
            
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value> The name. </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value> The address. </value>
        [DataMember]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the name of the package.
        /// </summary>
        /// <value> The name of the package. </value>
        [DataMember]
        public string PackageName { get; set; }

        /// <summary>
        /// Gets or sets the contact person.
        /// </summary>
        /// <value> The contact person. </value>
        [DataMember]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or sets the contact phone.
        /// </summary>
        /// <value> The contact phone. </value>
        [DataMember]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        /// <value> The contact email. </value>
        [DataMember]
        public string ContactEmail { get; set; }
    }
}
