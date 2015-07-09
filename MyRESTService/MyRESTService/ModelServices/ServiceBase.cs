using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRESTService.Models;

namespace MyRESTService.ModelServices
{
    public class ServiceBase
    {
        public ServiceBase()
        {
                DatabaseContext = new MainDbContext();
        }

        private MainDbContext _databaseContext;
        protected MainDbContext DatabaseContext
        {
            get { return _databaseContext ?? new MainDbContext(); }
            set { _databaseContext = value; }
        }
    }
}
