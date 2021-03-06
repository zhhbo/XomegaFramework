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
    public partial class SalesOrderPaymentObject : DataObject
    {
        #region Constants

        public const string CreditCard = "CreditCard";
        public const string CurrencyRate = "CurrencyRate";
        public const string DueDate = "DueDate";
        public const string Freight = "Freight";
        public const string ShipMethodId = "ShipMethodId";
        public const string SubTotal = "SubTotal";
        public const string TaxAmt = "TaxAmt";
        public const string TotalDue = "TotalDue";

        #endregion

        #region Properties

        public TextProperty CurrencyRateProperty { get; private set; }
        public DateProperty DueDateProperty { get; private set; }
        public MoneyProperty FreightProperty { get; private set; }
        public EnumIntProperty ShipMethodIdProperty { get; private set; }
        public MoneyProperty SubTotalProperty { get; private set; }
        public MoneyProperty TaxAmtProperty { get; private set; }
        public MoneyProperty TotalDueProperty { get; private set; }

        #endregion

        #region Child Objects

        public CreditCardPaymentObjectCustomized CreditCardObject { get { return (CreditCardPaymentObjectCustomized)GetChildObject(CreditCard); } }

        #endregion

        #region Construction

        protected override void Initialize()
        {
            CurrencyRateProperty = new TextProperty(this, CurrencyRate);
            CurrencyRateProperty.Editable = false;
            DueDateProperty = new DateProperty(this, DueDate);
            DueDateProperty.Required = true;
            FreightProperty = new MoneyProperty(this, Freight);
            FreightProperty.Required = true;
            FreightProperty.Editable = false;
            ShipMethodIdProperty = new EnumIntProperty(this, ShipMethodId);
            ShipMethodIdProperty.Required = true;
            ShipMethodIdProperty.Size = 10;
            ShipMethodIdProperty.EnumType = "ship method";
            SubTotalProperty = new MoneyProperty(this, SubTotal);
            SubTotalProperty.Required = true;
            SubTotalProperty.Editable = false;
            TaxAmtProperty = new MoneyProperty(this, TaxAmt);
            TaxAmtProperty.Required = true;
            TaxAmtProperty.Editable = false;
            TotalDueProperty = new MoneyProperty(this, TotalDue);
            TotalDueProperty.Required = true;
            TotalDueProperty.Editable = false;
            DataObject objCreditCard = new CreditCardPaymentObjectCustomized();
            AddChildObject(CreditCard, objCreditCard);
        }

        #endregion
    }

}