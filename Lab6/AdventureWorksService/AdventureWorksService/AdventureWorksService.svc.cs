using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorksService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdventureWorksService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdventureWorksService.svc or AdventureWorksService.svc.cs at the Solution Explorer and start debugging.
    public class AdventureWorksService : IAdventureWorksService
    {
        private readonly AdventureWorksLTEntities ctx = new AdventureWorksLTEntities();

        public List<SalesOrderHeader> GetOrders()
        {
            return ctx.SalesOrderHeader.ToList();
        }

        public void UpdateOrder(SalesOrderHeader order)
        {
            ctx.SalesOrderHeader.Attach(order);
            ctx.Entry(order).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
