// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction
/// </summary>
[IsoId("_EZKYYSCCEey8XKHwKquEQw")]
[DisplayName("Invoice Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceLineItem2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Invoice date.
    /// </summary>
    [IsoId("_EeSwASCCEey8XKHwKquEQw")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Invoice order date.
    /// </summary>
    [IsoId("_EeSwAyCCEey8XKHwKquEQw")]
    [DisplayName("Order Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDt")]
    #endif
    [IsoXmlTag("OrdrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OrderDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OrderDate { get; init; } 
    #else
    public System.DateOnly? OrderDate { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the corporate contract number.
    /// </summary>
    [IsoId("_EeSwBSCCEey8XKHwKquEQw")]
    [DisplayName("Contract Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctNb")]
    #endif
    [IsoXmlTag("CtrctNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ContractNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContractNumber { get; init; } 
    #else
    public System.String? ContractNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Shipping date of the product or the date services rendered. 
    /// </summary>
    [IsoId("_EeSwByCCEey8XKHwKquEQw")]
    [DisplayName("Shipping Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgDt")]
    #endif
    [IsoXmlTag("ShppgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ShippingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ShippingDate { get; init; } 
    #else
    public System.DateOnly? ShippingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Rebilling indicator. 
    /// </summary>
    [IsoId("_EeSwCSCCEey8XKHwKquEQw")]
    [DisplayName("Rebilling Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RbllgInd")]
    #endif
    [IsoXmlTag("RbllgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RebillingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RebillingIndicator { get; init; } 
    #else
    public System.String? RebillingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the invoice line item represents a medical service.
    /// </summary>
    [IsoId("_EeSwCyCCEey8XKHwKquEQw")]
    [DisplayName("Medical Services Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdclSvcsInd")]
    #endif
    [IsoXmlTag("MdclSvcsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MedicalServicesIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MedicalServicesIndicator { get; init; } 
    #else
    public System.String? MedicalServicesIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the health industry number to which the medical services are being shipped (for example, Medical Services ship to Health Industry Number).
    /// </summary>
    [IsoId("_EeSwDSCCEey8XKHwKquEQw")]
    [DisplayName("Ship To Industry Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipToIndstryCd")]
    #endif
    [IsoXmlTag("ShipToIndstryCd")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? ShipToIndustryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShipToIndustryCode { get; init; } 
    #else
    public System.String? ShipToIndustryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_EeSwDyCCEey8XKHwKquEQw")]
    [DisplayName("Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCd")]
    #endif
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductCode { get; init; } 
    #else
    public System.String? ProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a code that identifies the product number qualifier of the product (for example, medical services).
    /// </summary>
    [IsoId("_EeSwESCCEey8XKHwKquEQw")]
    [DisplayName("Product Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctQlfr")]
    #endif
    [IsoXmlTag("PdctQlfr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProductQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductQualifier { get; init; } 
    #else
    public System.String? ProductQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// May contain further clarifying data, such as event name, etc.
    /// </summary>
    [IsoId("_EeSwEyCCEey8XKHwKquEQw")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the purchase is categorized
    /// as goods or services.
    /// </summary>
    [IsoId("_EeSwFSCCEey8XKHwKquEQw")]
    [DisplayName("Type Of Supply")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfSpply")]
    #endif
    [IsoXmlTag("TpOfSpply")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? TypeOfSupply { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TypeOfSupply { get; init; } 
    #else
    public System.String? TypeOfSupply { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_EeSwFyCCEey8XKHwKquEQw")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure1Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_EeSwGSCCEey8XKHwKquEQw")]
    [DisplayName("Other Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrUnitOfMeasr")]
    #endif
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherUnitOfMeasure { get; init; } 
    #else
    public System.String? OtherUnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the price for one unit of the product or service.
    /// </summary>
    [IsoId("_EeSwGyCCEey8XKHwKquEQw")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_EeSwHSCCEey8XKHwKquEQw")]
    [DisplayName("Product Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctQty")]
    #endif
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ProductQuantity { get; init; } 
    #else
    public System.UInt64? ProductQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Total line item amount, inclusive of adjustments and exclusive of taxes.
    /// </summary>
    [IsoId("_EeSwHyCCEey8XKHwKquEQw")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment12? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment12? Adjustment { get; init; } 
    #else
    public Adjustment12? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_EeSwISCCEey8XKHwKquEQw")]
    [DisplayName("Insurance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncInd")]
    #endif
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceIndicator { get; init; } 
    #else
    public System.String? InsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_EeSwIyCCEey8XKHwKquEQw")]
    [DisplayName("Insurance Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncAmt")]
    #endif
    [IsoXmlTag("InsrncAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_EeSwJSCCEey8XKHwKquEQw")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? Tax { get; init; } 
    #else
    public Tax39? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the value-added tax (VAT) invoice or tax receipt.
    /// </summary>
    [IsoId("_EeSwJyCCEey8XKHwKquEQw")]
    [DisplayName("Unique VAT Invoice Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqVATInvcRef")]
    #endif
    [IsoXmlTag("UnqVATInvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? UniqueVATInvoiceReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UniqueVATInvoiceReference { get; init; } 
    #else
    public System.String? UniqueVATInvoiceReference { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of line item, inclusive of any applicable adjustments and taxes.
    /// </summary>
    [IsoId("_EeSwKSCCEey8XKHwKquEQw")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_rdk5MTapEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbt")]
    #endif
    [IsoXmlTag("CdtDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebit3Code? CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebit3Code? CreditDebit { get; init; } 
    #else
    public CreditDebit3Code? CreditDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the line item carries a cost. 
    /// True : Line item does not have any cost associated to the customer.
    /// False : Line item has cost associated to the customer.
    /// </summary>
    [IsoId("_EeSwLSCCEey8XKHwKquEQw")]
    [DisplayName("Zero Cost To Customer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ZeroCostToCstmrInd")]
    #endif
    [IsoXmlTag("ZeroCostToCstmrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ZeroCostToCustomerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ZeroCostToCustomerIndicator { get; init; } 
    #else
    public System.String? ZeroCostToCustomerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional data.
    /// </summary>
    [IsoId("_EeSwLyCCEey8XKHwKquEQw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
