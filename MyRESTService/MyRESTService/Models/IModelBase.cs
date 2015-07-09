using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRESTService.Models
{
    public interface IModelBase
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
