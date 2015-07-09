using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyRESTService.Models
{
    [DataContract]
    public class ModelBase: IModelBase
    {
        [DataMember]
        public virtual int Id { get; set; }

        [DataMember]
        public virtual DateTime CreatedDate { get; set; }
    }
}
