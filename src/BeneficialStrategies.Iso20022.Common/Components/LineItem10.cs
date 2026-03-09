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
/// Unit of information showing the related provision of products and/or services and monetary summations reported as a discrete line items.
/// </summary>
[IsoId("_SuJtLAEcEeCQm6a_G2yO_w_-1957014618")]
[DisplayName("Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItem10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The unique identification of this invoice line item.
    /// </summary>
    [IsoId("_SuJtLQEcEeCQm6a_G2yO_w_276499295")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Something that is produced and sold as the result of an industrial process.
    /// </summary>
    [IsoId("_SuTeIAEcEeCQm6a_G2yO_w_-1081676107")]
    [DisplayName("Trade Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPdct")]
    #endif
    [IsoXmlTag("TradPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeProduct1? TradeProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeProduct1? TradeProduct { get; init; } 
    #else
    public TradeProduct1? TradeProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Purchase order reference assigned by the buyer related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_SuTeIQEcEeCQm6a_G2yO_w_1418969012")]
    [DisplayName("Buyer Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrOrdrId")]
    #endif
    [IsoXmlTag("BuyrOrdrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification23? BuyerOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification23? BuyerOrderIdentification { get; init; } 
    #else
    public DocumentIdentification23? BuyerOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contract reference related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_SuTeIgEcEeCQm6a_G2yO_w_-2047566678")]
    [DisplayName("Contract Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctId")]
    #endif
    [IsoXmlTag("CtrctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? ContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? ContractIdentification { get; init; } 
    #else
    public DocumentIdentification22? ContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specific purchase account for recording debits and credits for accounting purposes.
    /// </summary>
    [IsoId("_SuTeIwEcEeCQm6a_G2yO_w_-1211043201")]
    [DisplayName("Purchase Accounting Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsAcctgAcct")]
    #endif
    [IsoXmlTag("PurchsAcctgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    #else
    public AccountingAccount1? PurchaseAccountingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_SuTeJAEcEeCQm6a_G2yO_w_-769209174")]
    [DisplayName("Net Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPric")]
    #endif
    [IsoXmlTag("NetPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? NetPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? NetPrice { get; init; } 
    #else
    public CurrencyAndAmount? NetPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity and conversion factor on which the net price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_SuTeJQEcEeCQm6a_G2yO_w_-899649920")]
    [DisplayName("Net Price Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPricQty")]
    #endif
    [IsoXmlTag("NetPricQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity4? NetPriceQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4? NetPriceQuantity { get; init; } 
    #else
    public Quantity4? NetPriceQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Allowance or charge applied to the net price.
    /// </summary>
    [IsoId("_SuTeJgEcEeCQm6a_G2yO_w_328165622")]
    [DisplayName("Net Price Allowance Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPricAllwncChrg")]
    #endif
    [IsoXmlTag("NetPricAllwncChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemAllowanceCharge1? NetPriceAllowanceCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemAllowanceCharge1? NetPriceAllowanceCharge { get; init; } 
    #else
    public LineItemAllowanceCharge1? NetPriceAllowanceCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Net weight of the product.
    /// </summary>
    [IsoId("_SuTeJwEcEeCQm6a_G2yO_w_917729180")]
    [DisplayName("Net Weight")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetWght")]
    #endif
    [IsoXmlTag("NetWght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? NetWeight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? NetWeight { get; init; } 
    #else
    public Quantity3? NetWeight { get; set; } 
    #endif
    
    /// <summary>
    /// Gross price of the product and/or service.
    /// </summary>
    [IsoId("_SuTeKAEcEeCQm6a_G2yO_w_415525348")]
    [DisplayName("Gross Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssPric")]
    #endif
    [IsoXmlTag("GrssPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? GrossPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? GrossPrice { get; init; } 
    #else
    public CurrencyAndAmount? GrossPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity and conversion factor on which the gross price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_SuTeKQEcEeCQm6a_G2yO_w_-26631818")]
    [DisplayName("Gross Price Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssPricQty")]
    #endif
    [IsoXmlTag("GrssPricQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity4? GrossPriceQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4? GrossPriceQuantity { get; init; } 
    #else
    public Quantity4? GrossPriceQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Gross weight of the product.
    /// </summary>
    [IsoId("_SuTeKgEcEeCQm6a_G2yO_w_-502407978")]
    [DisplayName("Gross Weight")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssWght")]
    #endif
    [IsoXmlTag("GrssWght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? GrossWeight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? GrossWeight { get; init; } 
    #else
    public Quantity3? GrossWeight { get; set; } 
    #endif
    
    /// <summary>
    /// Logistics service charge for this line item.
    /// </summary>
    [IsoId("_SuTeKwEcEeCQm6a_G2yO_w_-1074285510")]
    [DisplayName("Logistics Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LogstcsChrg")]
    #endif
    [IsoXmlTag("LogstcsChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesDetails2? LogisticsCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesDetails2? LogisticsCharge { get; init; } 
    #else
    public ChargesDetails2? LogisticsCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_SuTeLAEcEeCQm6a_G2yO_w_-1718452272")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemTax1? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemTax1? Tax { get; init; } 
    #else
    public LineItemTax1? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Allowance or charge specified for this line item.
    /// </summary>
    [IsoId("_SuTeLQEcEeCQm6a_G2yO_w_-1288890455")]
    [DisplayName("Allowance Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwncChrg")]
    #endif
    [IsoXmlTag("AllwncChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemAllowanceCharge1? AllowanceCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemAllowanceCharge1? AllowanceCharge { get; init; } 
    #else
    public LineItemAllowanceCharge1? AllowanceCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
    /// </summary>
    [IsoId("_SuTeLgEcEeCQm6a_G2yO_w_1555627299")]
    [DisplayName("Financial Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinAdjstmnt")]
    #endif
    [IsoXmlTag("FinAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment4? FinancialAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment4? FinancialAdjustment { get; init; } 
    #else
    public Adjustment4? FinancialAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity billed for this line item.
    /// </summary>
    [IsoId("_SuTeLwEcEeCQm6a_G2yO_w_-72954526")]
    [DisplayName("Billed Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlldQty")]
    #endif
    [IsoXmlTag("BlldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? BilledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? BilledQuantity { get; init; } 
    #else
    public Quantity3? BilledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of product packages delivered.
    /// </summary>
    [IsoId("_SuTeMAEcEeCQm6a_G2yO_w_1141764402")]
    [DisplayName("Package Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgQty")]
    #endif
    [IsoXmlTag("PackgQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? PackageQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PackageQuantity { get; init; } 
    #else
    public System.UInt64? PackageQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units per package in this line item for a supply chain trade delivery.
    /// </summary>
    [IsoId("_SuTeMQEcEeCQm6a_G2yO_w_1057688708")]
    [DisplayName("Per Package Unit Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PerPackgUnitQty")]
    #endif
    [IsoXmlTag("PerPackgUnitQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? PerPackageUnitQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? PerPackageUnitQuantity { get; init; } 
    #else
    public Quantity3? PerPackageUnitQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Physical packaging of the product.
    /// </summary>
    [IsoId("_SucoEAEcEeCQm6a_G2yO_w_-531731082")]
    [DisplayName("Packaging")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Packgng")]
    #endif
    [IsoXmlTag("Packgng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Packaging1? Packaging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Packaging1? Packaging { get; init; } 
    #else
    public Packaging1? Packaging { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity that is free of charge for this line item.
    /// </summary>
    [IsoId("_SucoEQEcEeCQm6a_G2yO_w_695882671")]
    [DisplayName("Charge Free Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgFreeQty")]
    #endif
    [IsoXmlTag("ChrgFreeQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? ChargeFreeQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? ChargeFreeQuantity { get; init; } 
    #else
    public Quantity3? ChargeFreeQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity value on which the quantity measurement started for a line item. For instance the start amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_SucoEgEcEeCQm6a_G2yO_w_1824445894")]
    [DisplayName("Measure Quantity Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MeasrQtyStart")]
    #endif
    [IsoXmlTag("MeasrQtyStart")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? MeasureQuantityStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? MeasureQuantityStart { get; init; } 
    #else
    public Quantity3? MeasureQuantityStart { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity value on which the quantity measurement ended for a line item. For instance the end amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_SucoEwEcEeCQm6a_G2yO_w_-1570728431")]
    [DisplayName("Measure Quantity End")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MeasrQtyEnd")]
    #endif
    [IsoXmlTag("MeasrQtyEnd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? MeasureQuantityEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? MeasureQuantityEnd { get; init; } 
    #else
    public Quantity3? MeasureQuantityEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the clock time measure started for a line item.
    /// </summary>
    [IsoId("_SucoFAEcEeCQm6a_G2yO_w_-1177982434")]
    [DisplayName("Measure Date Time Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MeasrDtTmStart")]
    #endif
    [IsoXmlTag("MeasrDtTmStart")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MeasureDateTimeStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MeasureDateTimeStart { get; init; } 
    #else
    public System.DateTime? MeasureDateTimeStart { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the clock time measure ended for a line item.
    /// </summary>
    [IsoId("_SucoFQEcEeCQm6a_G2yO_w_-1092370631")]
    [DisplayName("Measure Date Time End")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MeasrDtTmEnd")]
    #endif
    [IsoXmlTag("MeasrDtTmEnd")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MeasureDateTimeEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MeasureDateTimeEnd { get; init; } 
    #else
    public System.DateTime? MeasureDateTimeEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_SucoFgEcEeCQm6a_G2yO_w_392335545")]
    [DisplayName("Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipTo")]
    #endif
    [IsoXmlTag("ShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? ShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? ShipTo { get; init; } 
    #else
    public TradeParty1? ShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_SucoFwEcEeCQm6a_G2yO_w_-1792779697")]
    [DisplayName("Incoterms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incotrms")]
    #endif
    [IsoXmlTag("Incotrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms3? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms3? Incoterms { get; init; } 
    #else
    public Incoterms3? Incoterms { get; set; } 
    #endif
    
    /// <summary>
    /// Actual delivery date/time of the products and/or services for this line item.
    /// </summary>
    [IsoId("_SucoGAEcEeCQm6a_G2yO_w_-1420879465")]
    [DisplayName("Delivery Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDtTm")]
    #endif
    [IsoXmlTag("DlvryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DeliveryDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DeliveryDateTime { get; init; } 
    #else
    public System.DateTime? DeliveryDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery note related to the delivery of the products and/or services for this line item.
    /// </summary>
    [IsoId("_SucoGQEcEeCQm6a_G2yO_w_1419263589")]
    [DisplayName("Delivery Note Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryNoteId")]
    #endif
    [IsoXmlTag("DlvryNoteId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? DeliveryNoteIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? DeliveryNoteIdentification { get; init; } 
    #else
    public DocumentIdentification22? DeliveryNoteIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary totals for this line item.
    /// </summary>
    [IsoId("_SucoGgEcEeCQm6a_G2yO_w_525193840")]
    [DisplayName("Monetary Summation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntrySummtn")]
    #endif
    [IsoXmlTag("MntrySummtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemMonetarySummation1? MonetarySummation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemMonetarySummation1? MonetarySummation { get; init; } 
    #else
    public LineItemMonetarySummation1? MonetarySummation { get; set; } 
    #endif
    
    /// <summary>
    /// Note included in this line item.
    /// </summary>
    [IsoId("_SucoGwEcEeCQm6a_G2yO_w_402346471")]
    [DisplayName("Included Note")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InclNote")]
    #endif
    [IsoXmlTag("InclNote")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation1? IncludedNote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation1? IncludedNote { get; init; } 
    #else
    public AdditionalInformation1? IncludedNote { get; set; } 
    #endif
    
    
    #nullable disable
    
}
