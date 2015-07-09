using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MyRESTService.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Person")]
    [DataContract]
    public class Person : ModelBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value> The name. </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value> The surname. </value>
        [DataMember]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the cell no.
        /// </summary>
        /// <value> The cell no. </value>
        [DataMember]
        [Required(ErrorMessage = "Cellphone number is required!")]
        public string CellNo { get; set; }

        /// <summary>
        /// Gets or sets the registration identifier.
        /// </summary>
        /// <value> The registration identifier. </value>
        [DataMember]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance can send notification.
        /// </summary>
        /// <value> <c>true</c> if this instance can send notification; otherwise, <c>false</c>. </value>
        [DataMember]
        public bool CanSendNotification { get; set; }
    }
}
