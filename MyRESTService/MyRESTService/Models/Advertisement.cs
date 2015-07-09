using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    [Table("Advertisement")]
    [DataContract]
    public class Advertisement //: ModelBase
    {

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value> The identifier. </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value> The created date. </value>
        [DataMember]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the expiry date.
        /// </summary>
        /// <value> The expiry date. </value>
        [DataMember]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value> The description. </value>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value> The title. </value>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        ///  <value> The picture. </value>
        [DataMember]
        public string Picture { get; set; }

        #region FK

        [DataMember]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [DataMember]
        public int CategoryId { get; set; }
        public Catagory Category { get; set; }

        #endregion
    }
}
