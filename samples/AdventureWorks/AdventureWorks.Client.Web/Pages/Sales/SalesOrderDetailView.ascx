<%---------------------------------------------------------------------------------------------
 This file was AUTO-GENERATED by "ASP.NET Details Pages" Xomega.Net generator.

 Manual CHANGES to this file WILL BE LOST when the code is regenerated.
----------------------------------------------------------------------------------------------%>

<%@ Control Language="C#" Inherits="AdventureWorks.Client.Web.SalesOrderDetailView" %>

<%@ Import Namespace="AdventureWorks.Client.Objects" %>
<%@ Register src="~/Controls/Errors.ascx" tagname="Errors" tagprefix="uc" %>
<%@ Register src="~/Controls/Editors/DateTimeControl.ascx" tagname="DateTimeControl" tagprefix="uc" %>

<asp:Panel ID="pnlComposition" CssClass="view-composition" runat="server">
  <asp:UpdatePanel ID="upl_Main" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
      <asp:Panel ID="pnlSalesOrderDetailView" CssClass="view with-footer vw-sales-order-detail-view" runat="server">
        <div class="view-header">
          <asp:Label ID="lblSalesOrderDetailViewTitle" CssClass="view-title" Text="Detail" runat="server"></asp:Label>
        </div>
        <div class="view-body">
          <div class="content indented">
            <uc:Errors ID="errors" runat="server"></uc:Errors>
            <asp:Panel ID="pnl_Object" CssClass="indented" runat="server">
              <asp:Panel ID="pnlMain" CssClass="xw-obj" GroupingText="Detail" runat="server">
                <table class="xw-fieldset-layout">
                  <tr>
                    <td class="fieldColumn" style="width: 50%">
                      <div class="field">
                        <asp:Label ID="lblSalesOrderId" Text="Sales Order Id:" CssClass="label" runat="server"></asp:Label>
                        <asp:Label LabelID="lblSalesOrderId" ID="ctlSalesOrderId" Property="<%# SalesOrderDetailObject.SalesOrderId %>" runat="server"></asp:Label>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblCarrierTrackingNumber" Text="Carrier Tracking Number:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblCarrierTrackingNumber" ID="ctlCarrierTrackingNumber" Property="<%# SalesOrderDetailObject.CarrierTrackingNumber %>" runat="server"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblOrderQty" Text="Order Qty:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblOrderQty" ID="ctlOrderQty" Property="<%# SalesOrderDetailObject.OrderQty %>" runat="server" CssClass="integer"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblSpecialOfferId" Text="Special Offer Id:" CssClass="label" runat="server"></asp:Label>
                        <asp:DropDownList LabelID="lblSpecialOfferId" ID="ctlSpecialOfferId" Property="<%# SalesOrderDetailObject.SpecialOfferId %>" runat="server"></asp:DropDownList>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblProductId" Text="Product Id:" CssClass="label" runat="server"></asp:Label>
                        <asp:DropDownList LabelID="lblProductId" ID="ctlProductId" Property="<%# SalesOrderDetailObject.ProductId %>" runat="server"></asp:DropDownList>
                      </div>
                    </td>
                    <td class="fieldColumn" style="width: 50%">
                      <div class="field">
                        <asp:Label ID="lblUnitPrice" Text="Unit Price:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblUnitPrice" ID="ctlUnitPrice" Property="<%# SalesOrderDetailObject.UnitPrice %>" runat="server" CssClass="decimal"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblUnitPriceDiscount" Text="Unit Price Discount:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblUnitPriceDiscount" ID="ctlUnitPriceDiscount" Property="<%# SalesOrderDetailObject.UnitPriceDiscount %>" runat="server" CssClass="decimal"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblLineTotal" Text="Line Total:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblLineTotal" ID="ctlLineTotal" Property="<%# SalesOrderDetailObject.LineTotal %>" runat="server" CssClass="decimal"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblRowguid" Text="Rowguid:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblRowguid" ID="ctlRowguid" Property="<%# SalesOrderDetailObject.Rowguid %>" runat="server"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblModifiedDate" Text="Modified Date:" CssClass="label" runat="server"></asp:Label>
                        <uc:DateTimeControl LabelID="lblModifiedDate" ID="ctlModifiedDate" Property="<%# SalesOrderDetailObject.ModifiedDate %>" TextCssClass="datetime" runat="server"></uc:DateTimeControl>
                      </div>
                    </td>
                  </tr>
                </table>
              </asp:Panel>
            </asp:Panel>
          </div>
        </div>
        <div class="view-footer action-bar">
          <asp:Button ID="btnSave" Text="Save" OnClick="btnSave_Click" runat="server"></asp:Button>
          <asp:Button ID="btnDelete" Text="Delete" OnClick="btnDelete_Click" Enabled="false" OnClientClick="if (!confirm('Are you sure you want to delete this object?\nThis action cannot be undone.')) return false;" runat="server"></asp:Button>
          <asp:Button ID="btn_Close" Text="Close" OnClick="Close" runat="server"></asp:Button>
        </div>
      </asp:Panel>
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Panel>