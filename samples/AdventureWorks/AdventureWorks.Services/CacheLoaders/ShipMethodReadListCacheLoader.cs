//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Lookup Cache Loaders" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Xomega.Framework;
using Xomega.Framework.Properties;
using Xomega.Framework.Lookup;

using AdventureWorks.Services;

namespace AdventureWorks.Services
{
    public partial class ShipMethodReadListCacheLoader : LookupCacheLoader 
    {
        public ShipMethodReadListCacheLoader()
            : base(LookupCache.Global, false, "ship method")
        {
        }

        protected virtual IEnumerable<ShipMethod_ReadListOutput> ReadList()
        {
            IShipMethodService svcShipMethod = DI.Resolve<IShipMethodService>();
            IEnumerable<ShipMethod_ReadListOutput> outReadList = svcShipMethod.ReadList();
            if (svcShipMethod is IDisposable) ((IDisposable)svcShipMethod).Dispose();
            return outReadList;
        }

        protected override void LoadCache(string tableType, CacheUpdater updateCache)
        {
            Dictionary<string, Dictionary<string, Header>> data = new Dictionary<string, Dictionary<string, Header>>();
            foreach (ShipMethod_ReadListOutput row in ReadList())
            {
                string type = "ship method";
                Dictionary<string, Header> tbl;
                if (!data.TryGetValue(type, out tbl)) data[type] = tbl = new Dictionary<string, Header>();

                string id = "" + row.ShipMethodId;
                Header h;
                if (!tbl.TryGetValue(id, out h))
                {
                    tbl[id] = h = new Header(type, id, row.Name);
                }
            }
            // if no data is returned we still need to update cache to get the notify listener removed
            if (data.Count == 0) updateCache(new LookupTable(tableType, new List<Header>(), true));
            foreach (string type in data.Keys)
                updateCache(new LookupTable(type, data[type].Values, true));
        }
    }

}