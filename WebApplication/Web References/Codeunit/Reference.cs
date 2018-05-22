﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebApplication.Codeunit {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Functions_Binding", Namespace="urn:microsoft-dynamics-schemas/codeunit/Functions")]
    public partial class Functions : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SearchDetermineNoTypeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Functions() {
            this.Url = global::WebApplication.Properties.Settings.Default.WebApplication_Codeunit_Functions;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SearchDetermineNoTypeCompletedEventHandler SearchDetermineNoTypeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/Functions:SearchDetermineNoType", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/Functions", ResponseElementName="SearchDetermineNoType_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/Functions", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string SearchDetermineNoType(string sessionID, string searchNo, ref SearchResults searchResults) {
            object[] results = this.Invoke("SearchDetermineNoType", new object[] {
                        sessionID,
                        searchNo,
                        searchResults});
            searchResults = ((SearchResults)(results[1]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SearchDetermineNoTypeAsync(string sessionID, string searchNo, SearchResults searchResults) {
            this.SearchDetermineNoTypeAsync(sessionID, searchNo, searchResults, null);
        }
        
        /// <remarks/>
        public void SearchDetermineNoTypeAsync(string sessionID, string searchNo, SearchResults searchResults, object userState) {
            if ((this.SearchDetermineNoTypeOperationCompleted == null)) {
                this.SearchDetermineNoTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchDetermineNoTypeOperationCompleted);
            }
            this.InvokeAsync("SearchDetermineNoType", new object[] {
                        sessionID,
                        searchNo,
                        searchResults}, this.SearchDetermineNoTypeOperationCompleted, userState);
        }
        
        private void OnSearchDetermineNoTypeOperationCompleted(object arg) {
            if ((this.SearchDetermineNoTypeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchDetermineNoTypeCompleted(this, new SearchDetermineNoTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SearchResults {
        
        private SalesHeader[] salesHeaderField;
        
        private SalesLine[] salesLineField;
        
        private SalesShipmentHeader[] salesShipmentHeaderField;
        
        private SalesShipmentLine[] salesShipmentLineField;
        
        private PostedPackage[] postedPackageField;
        
        private PostedPackageLine[] postedPackageLineField;
        
        private SalesInvoiceHeader[] salesInvoiceHeaderField;
        
        private SalesInvoiceLine[] salesInvoiceLineField;
        
        private ReturnReceiptHeader[] returnReceiptHeaderField;
        
        private ReturnReceiptLine[] returnReceiptLineField;
        
        private PostedReceive[] postedReceiveField;
        
        private PostedReceiveLine[] postedReceiveLineField;
        
        private SalesCreditMemo[] salesCreditMemoField;
        
        private SalesCreditMemoLines[] salesCreditMemoLinesField;
        
        private TestAddress[] testAddressField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesHeader")]
        public SalesHeader[] SalesHeader {
            get {
                return this.salesHeaderField;
            }
            set {
                this.salesHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesLine")]
        public SalesLine[] SalesLine {
            get {
                return this.salesLineField;
            }
            set {
                this.salesLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesShipmentHeader")]
        public SalesShipmentHeader[] SalesShipmentHeader {
            get {
                return this.salesShipmentHeaderField;
            }
            set {
                this.salesShipmentHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesShipmentLine")]
        public SalesShipmentLine[] SalesShipmentLine {
            get {
                return this.salesShipmentLineField;
            }
            set {
                this.salesShipmentLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostedPackage")]
        public PostedPackage[] PostedPackage {
            get {
                return this.postedPackageField;
            }
            set {
                this.postedPackageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostedPackageLine")]
        public PostedPackageLine[] PostedPackageLine {
            get {
                return this.postedPackageLineField;
            }
            set {
                this.postedPackageLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesInvoiceHeader")]
        public SalesInvoiceHeader[] SalesInvoiceHeader {
            get {
                return this.salesInvoiceHeaderField;
            }
            set {
                this.salesInvoiceHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesInvoiceLine")]
        public SalesInvoiceLine[] SalesInvoiceLine {
            get {
                return this.salesInvoiceLineField;
            }
            set {
                this.salesInvoiceLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnReceiptHeader")]
        public ReturnReceiptHeader[] ReturnReceiptHeader {
            get {
                return this.returnReceiptHeaderField;
            }
            set {
                this.returnReceiptHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnReceiptLine")]
        public ReturnReceiptLine[] ReturnReceiptLine {
            get {
                return this.returnReceiptLineField;
            }
            set {
                this.returnReceiptLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostedReceive")]
        public PostedReceive[] PostedReceive {
            get {
                return this.postedReceiveField;
            }
            set {
                this.postedReceiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostedReceiveLine")]
        public PostedReceiveLine[] PostedReceiveLine {
            get {
                return this.postedReceiveLineField;
            }
            set {
                this.postedReceiveLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesCreditMemo")]
        public SalesCreditMemo[] SalesCreditMemo {
            get {
                return this.salesCreditMemoField;
            }
            set {
                this.salesCreditMemoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesCreditMemoLines")]
        public SalesCreditMemoLines[] SalesCreditMemoLines {
            get {
                return this.salesCreditMemoLinesField;
            }
            set {
                this.salesCreditMemoLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestAddress")]
        public TestAddress[] TestAddress {
            get {
                return this.testAddressField;
            }
            set {
                this.testAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesHeader {
        
        private string docTypeField;
        
        private string noField;
        
        private string extDocNoField;
        
        private string docDateField;
        
        /// <remarks/>
        public string DocType {
            get {
                return this.docTypeField;
            }
            set {
                this.docTypeField = value;
            }
        }
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string ExtDocNo {
            get {
                return this.extDocNoField;
            }
            set {
                this.extDocNoField = value;
            }
        }
        
        /// <remarks/>
        public string DocDate {
            get {
                return this.docDateField;
            }
            set {
                this.docDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class TestAddress {
        
        private string[] channelField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Channel")]
        public string[] Channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesCreditMemoLines {
        
        private string docNoField;
        
        private string typeField;
        
        private string itemNoField;
        
        private string qtyField;
        
        private string unitPriceField;
        
        /// <remarks/>
        public string DocNo {
            get {
                return this.docNoField;
            }
            set {
                this.docNoField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public string Qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
        
        /// <remarks/>
        public string UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesCreditMemo {
        
        private string noField;
        
        private string extDocNoField;
        
        private string postingDateField;
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string ExtDocNo {
            get {
                return this.extDocNoField;
            }
            set {
                this.extDocNoField = value;
            }
        }
        
        /// <remarks/>
        public string PostingDate {
            get {
                return this.postingDateField;
            }
            set {
                this.postingDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class PostedReceiveLine {
        
        private string recNoField;
        
        private string typeField;
        
        private string itemNoField;
        
        private string qtyField;
        
        private string serialNoField;
        
        /// <remarks/>
        public string RecNo {
            get {
                return this.recNoField;
            }
            set {
                this.recNoField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public string Qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
        
        /// <remarks/>
        public string SerialNo {
            get {
                return this.serialNoField;
            }
            set {
                this.serialNoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class PostedReceive {
        
        private string noField;
        
        private string extDocNoField;
        
        private string extTrackNoField;
        
        private string shippingAgentField;
        
        private string shippingServiceField;
        
        private string receiveDateField;
        
        private string postedSourceIDField;
        
        private string sourceIDField;
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string ExtDocNo {
            get {
                return this.extDocNoField;
            }
            set {
                this.extDocNoField = value;
            }
        }
        
        /// <remarks/>
        public string ExtTrackNo {
            get {
                return this.extTrackNoField;
            }
            set {
                this.extTrackNoField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingAgent {
            get {
                return this.shippingAgentField;
            }
            set {
                this.shippingAgentField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingService {
            get {
                return this.shippingServiceField;
            }
            set {
                this.shippingServiceField = value;
            }
        }
        
        /// <remarks/>
        public string ReceiveDate {
            get {
                return this.receiveDateField;
            }
            set {
                this.receiveDateField = value;
            }
        }
        
        /// <remarks/>
        public string PostedSourceID {
            get {
                return this.postedSourceIDField;
            }
            set {
                this.postedSourceIDField = value;
            }
        }
        
        /// <remarks/>
        public string SourceID {
            get {
                return this.sourceIDField;
            }
            set {
                this.sourceIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class ReturnReceiptLine {
        
        private string docNoField;
        
        private string typeField;
        
        private string itemNoField;
        
        private string qtyField;
        
        private string unitPriceField;
        
        /// <remarks/>
        public string DocNo {
            get {
                return this.docNoField;
            }
            set {
                this.docNoField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public string Qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
        
        /// <remarks/>
        public string UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class ReturnReceiptHeader {
        
        private string noField;
        
        private string extDocNoField;
        
        private string receiveDateField;
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string ExtDocNo {
            get {
                return this.extDocNoField;
            }
            set {
                this.extDocNoField = value;
            }
        }
        
        /// <remarks/>
        public string ReceiveDate {
            get {
                return this.receiveDateField;
            }
            set {
                this.receiveDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesInvoiceLine {
        
        private string docNoField;
        
        private string typeField;
        
        private string itemNoField;
        
        private string qtyField;
        
        private string unitPriceField;
        
        /// <remarks/>
        public string DocNo {
            get {
                return this.docNoField;
            }
            set {
                this.docNoField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public string Qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
        
        /// <remarks/>
        public string UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesInvoiceHeader {
        
        private string noField;
        
        private string extDocNoField;
        
        private string postingDateField;
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string ExtDocNo {
            get {
                return this.extDocNoField;
            }
            set {
                this.extDocNoField = value;
            }
        }
        
        /// <remarks/>
        public string PostingDate {
            get {
                return this.postingDateField;
            }
            set {
                this.postingDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class PostedPackageLine {
        
        private string packNoField;
        
        private string typeField;
        
        private string itemNoField;
        
        private string qtyField;
        
        private string priceField;
        
        private string serialNoField;
        
        /// <remarks/>
        public string PackNo {
            get {
                return this.packNoField;
            }
            set {
                this.packNoField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public string Qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
        
        /// <remarks/>
        public string Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string SerialNo {
            get {
                return this.serialNoField;
            }
            set {
                this.serialNoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class PostedPackage {
        
        private string packNoField;
        
        private string extTrackNoField;
        
        private string shippingAgentField;
        
        private string shippingServiceField;
        
        private string postingDateField;
        
        private string postedSourceIDField;
        
        private string sourceIDField;
        
        /// <remarks/>
        public string PackNo {
            get {
                return this.packNoField;
            }
            set {
                this.packNoField = value;
            }
        }
        
        /// <remarks/>
        public string ExtTrackNo {
            get {
                return this.extTrackNoField;
            }
            set {
                this.extTrackNoField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingAgent {
            get {
                return this.shippingAgentField;
            }
            set {
                this.shippingAgentField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingService {
            get {
                return this.shippingServiceField;
            }
            set {
                this.shippingServiceField = value;
            }
        }
        
        /// <remarks/>
        public string PostingDate {
            get {
                return this.postingDateField;
            }
            set {
                this.postingDateField = value;
            }
        }
        
        /// <remarks/>
        public string PostedSourceID {
            get {
                return this.postedSourceIDField;
            }
            set {
                this.postedSourceIDField = value;
            }
        }
        
        /// <remarks/>
        public string SourceID {
            get {
                return this.sourceIDField;
            }
            set {
                this.sourceIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesShipmentLine {
        
        private string docNoField;
        
        private string typeField;
        
        private string itemNoField;
        
        private string qtyField;
        
        private string unitPriceField;
        
        /// <remarks/>
        public string DocNo {
            get {
                return this.docNoField;
            }
            set {
                this.docNoField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public string Qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
        
        /// <remarks/>
        public string UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesShipmentHeader {
        
        private string noField;
        
        private string extDocNoField;
        
        private string shippingDateField;
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string ExtDocNo {
            get {
                return this.extDocNoField;
            }
            set {
                this.extDocNoField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingDate {
            get {
                return this.shippingDateField;
            }
            set {
                this.shippingDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/searchresults>")]
    public partial class SalesLine {
        
        private string docNoField;
        
        private string typeField;
        
        private string itemNoField;
        
        private string qtyField;
        
        private string unitPriceField;
        
        /// <remarks/>
        public string DocNo {
            get {
                return this.docNoField;
            }
            set {
                this.docNoField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNo {
            get {
                return this.itemNoField;
            }
            set {
                this.itemNoField = value;
            }
        }
        
        /// <remarks/>
        public string Qty {
            get {
                return this.qtyField;
            }
            set {
                this.qtyField = value;
            }
        }
        
        /// <remarks/>
        public string UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SearchDetermineNoTypeCompletedEventHandler(object sender, SearchDetermineNoTypeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchDetermineNoTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchDetermineNoTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public SearchResults searchResults {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SearchResults)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591