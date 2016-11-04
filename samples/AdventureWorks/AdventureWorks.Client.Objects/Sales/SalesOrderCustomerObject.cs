//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Xomega Data Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using AdventureWorks.Client.Objects;
using AdventureWorks.Enumerations;
using AdventureWorks.Services;
using System;
using System.Data.Spatial;
using Xomega.Framework;
using Xomega.Framework.Properties;

namespace AdventureWorks.Client.Objects
{
    public partial class SalesOrderCustomerObject : DataObject
    {
        #region Constants

        public const string AccountNumber = "AccountNumber";
        public const string BillToAddressId = "BillToAddressId";
        public const string CustomerId = "CustomerId";
        public const string Lookup = "Lookup";
        public const string PersonId = "PersonId";
        public const string PersonName = "PersonName";
        public const string ShipToAddressId = "ShipToAddressId";
        public const string StoreId = "StoreId";
        public const string StoreName = "StoreName";
        public const string TerritoryId = "TerritoryId";

        #endregion

        #region Properties

        public TextProperty AccountNumberProperty { get; private set; }
        public IntegerKeyProperty BillToAddressIdProperty { get; private set; }
        public IntegerKeyProperty CustomerIdProperty { get; private set; }
        public IntegerKeyProperty PersonIdProperty { get; private set; }
        public TextProperty PersonNameProperty { get; private set; }
        public IntegerKeyProperty ShipToAddressIdProperty { get; private set; }
        public IntegerKeyProperty StoreIdProperty { get; private set; }
        public TextProperty StoreNameProperty { get; private set; }
        public EnumIntProperty TerritoryIdProperty { get; private set; }

        #endregion

        #region Child Objects

        public SalesCustomerLookupObject LookupObject { get { return (SalesCustomerLookupObject)GetChildObject(Lookup); } }

        #endregion

        #region Construction

        protected override void Initialize()
        {
            AccountNumberProperty = new TextProperty(this, AccountNumber);
            AccountNumberProperty.Required = true;
            AccountNumberProperty.Size = 10;
            AccountNumberProperty.Editable = false;
            BillToAddressIdProperty = new IntegerKeyProperty(this, BillToAddressId);
            CustomerIdProperty = new IntegerKeyProperty(this, CustomerId);
            CustomerIdProperty.Required = true;
            PersonIdProperty = new IntegerKeyProperty(this, PersonId);
            PersonIdProperty.Editable = false;
            PersonNameProperty = new TextProperty(this, PersonName);
            PersonNameProperty.Editable = false;
            ShipToAddressIdProperty = new IntegerKeyProperty(this, ShipToAddressId);
            StoreIdProperty = new IntegerKeyProperty(this, StoreId);
            StoreIdProperty.Editable = false;
            StoreNameProperty = new TextProperty(this, StoreName);
            StoreNameProperty.Editable = false;
            TerritoryIdProperty = new EnumIntProperty(this, TerritoryId);
            TerritoryIdProperty.Size = 10;
            TerritoryIdProperty.EnumType = "sales territory";
            TerritoryIdProperty.Editable = false;
            DataObject objLookup = new SalesCustomerLookupObject();
            AddChildObject(Lookup, objLookup);
        }

        #endregion
    }

}