using DAL.Generic;
using DAL.StoreProcedure;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace DAL
{
    public class PackagesShipmentDAL : GenericService<PackagesShipment>
    {
        private static DbWorker _DbWorker;

        public PackagesShipmentDAL(string connection) : base(connection)
        {
            _DbWorker = new DbWorker(connection);
        }
        public async Task<List<PackagesShipment>> GetTrackingList()
        {
            try
            {
                using (var _DbContext = new EntityDataContext(_connection))
                {
                    var detail = _DbContext.PackagesShipment.AsNoTracking().Where(x => x.Awbcode!=null&& x.CurrentStatus!= (int)PackagesShipmentStatus.Completed).ToListAsync();
                    if (detail != null)
                    {
                        return await detail;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("GetTrackingList - PackagesShipmentDAL: " + ex);
                return null;
            }
        }
        public async Task<long> UpdatePackagesShipmentStatus(long id,int status)
        {
            try
            {
                var model = await FindAsync(id);
                model.CurrentStatus = status;
                await UpdateAsync(model);
                return id;
            }
            catch (Exception ex)
            {
                LogHelper.InsertLogTelegram("UpdatePackagesShipmentStatus - PackagesShipmentDAL: " + ex);
                return 0;
            }
        }
    }
}
