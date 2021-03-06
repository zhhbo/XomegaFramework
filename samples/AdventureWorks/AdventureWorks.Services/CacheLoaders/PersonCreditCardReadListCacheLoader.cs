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
    public partial class PersonCreditCardReadListCacheLoader : LookupCacheLoader 
    {
        public PersonCreditCardReadListCacheLoader()
            : base(LookupCache.Global, false, "person credit card")
        {
        }

        protected virtual IEnumerable<PersonCreditCard_ReadListOutput> ReadList()
        {
            IPersonCreditCardService svcPersonCreditCard = DI.Resolve<IPersonCreditCardService>();
            object nullParamReadList = null; // TODO: make sure input parameters are defined as data object properties
            IEnumerable<PersonCreditCard_ReadListOutput> outReadList = svcPersonCreditCard.ReadList((int)nullParamReadList);
            if (svcPersonCreditCard is IDisposable) ((IDisposable)svcPersonCreditCard).Dispose();
            return outReadList;
        }

        protected override void LoadCache(string tableType, CacheUpdater updateCache)
        {
            Dictionary<string, Dictionary<string, Header>> data = new Dictionary<string, Dictionary<string, Header>>();
            foreach (PersonCreditCard_ReadListOutput row in ReadList())
            {
                string type = "person credit card";
                Dictionary<string, Header> tbl;
                if (!data.TryGetValue(type, out tbl)) data[type] = tbl = new Dictionary<string, Header>();

                string id = "" + row.CreditCardId;
                Header h;
                if (!tbl.TryGetValue(id, out h))
                {
                    tbl[id] = h = new Header(type, id, row.CreditCardName);
                }
                h.AddToAttribute("person name", row.PersonName);
                h.AddToAttribute("card type", row.CardType);
                h.AddToAttribute("card number", row.CardNumber);
                h.AddToAttribute("exp month", row.ExpMonth);
                h.AddToAttribute("exp year", row.ExpYear);
            }
            // if no data is returned we still need to update cache to get the notify listener removed
            if (data.Count == 0) updateCache(new LookupTable(tableType, new List<Header>(), true));
            foreach (string type in data.Keys)
                updateCache(new LookupTable(type, data[type].Values, true));
        }
    }

}