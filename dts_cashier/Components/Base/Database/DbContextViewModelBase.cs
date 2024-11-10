using dts_cashier.Cache;
using dts_cashier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtsDatabaseDataAccess;

using dts_cashier.Cache;

namespace dts_cashier.Components.Base.Database
{
    public class DbContextViewModelBase : BaseModel
    {
        protected readonly DtsDbContext DbContext;

        public DbContextViewModelBase()
        {
            if (DataCacheContext.UseLocalDB) DbContext = new DtsDbContext();
        }
    }
}