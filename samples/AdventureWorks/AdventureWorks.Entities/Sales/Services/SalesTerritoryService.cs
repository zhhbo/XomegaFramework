//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Service Implementations" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated
// unless they are placed between corresponding CUSTOM_CODE_START/CUSTOM_CODE_END lines.
//
// This file can be DELETED DURING REGENERATION IF NO LONGER NEEDED, e.g. if it gets renamed.
// To prevent this and preserve manual custom changes please remove the line above.
//---------------------------------------------------------------------------------------------

using AdventureWorks.Enumerations;
using AdventureWorks.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using Xomega.Framework;
using Xomega.Framework.Services;
// CUSTOM_CODE_START: add namespaces for custom code below
// CUSTOM_CODE_END

namespace AdventureWorks.Entities.Services
{
    public partial class SalesTerritoryService : ISalesTerritoryService
    {
        public SalesTerritoryService()
        {
        }

        public virtual IEnumerable<SalesTerritory_ReadListOutput> ReadList()
        {
            IEnumerable<SalesTerritory_ReadListOutput> res = null;
            using (AdventureWorksEntities ctx = new AdventureWorksEntities())
            {
                var src = from obj in ctx.SalesTerritory select obj;
                #region Source filter
                // CUSTOM_CODE_START: add custom filter criteria to the source query for ReadList operation below
                // src = src.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                var qry = from obj in src
                          select new SalesTerritory_ReadListOutput() {
                              TerritoryId = obj.TerritoryId,
                              Name = obj.Name,
                              CountryRegionCode = obj.CountryRegionCodeObject.CountryRegionCode,
                              Group = obj.Group,
                          };
                #region Result filter
                // CUSTOM_CODE_START: add custom filter criteria to the result query for ReadList operation below
                // qry = qry.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
                res = qry.ToList();
            }
            return res;
        }
    }
}