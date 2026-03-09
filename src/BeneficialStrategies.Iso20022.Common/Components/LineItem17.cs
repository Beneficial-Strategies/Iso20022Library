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
[IsoId("__nQDseWlEeevU7McUP3D1w")]
[DisplayName("Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItem17
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
    [IsoId("__wBlMeWlEeevU7McUP3D1w")]
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
    [IsoId("__wBlM-WlEeevU7McUP3D1w")]
    [DisplayName("Trade Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPdct")]
    #endif
    [IsoXmlTag("TradPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeProduct3? TradeProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeProduct3? TradeProduct { get; init; } 
    #else
    public TradeProduct3? TradeProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Purchase order reference assigned by the buyer related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("__wBlNeWlEeevU7McUP3D1w")]
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
    [IsoId("__wBlN-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlOeWlEeevU7McUP3D1w")]
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
    [IsoId("__wBlO-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlPeWlEeevU7McUP3D1w")]
    [DisplayName("Net Price Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPricQty")]
    #endif
    [IsoXmlTag("NetPricQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? NetPriceQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? NetPriceQuantity { get; init; } 
    #else
    public Quantity16? NetPriceQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Allowance or charge applied to the net price.
    /// </summary>
    [IsoId("__wBlP-WlEeevU7McUP3D1w")]
    [DisplayName("Net Price Allowance Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPricAllwncChrg")]
    #endif
    [IsoXmlTag("NetPricAllwncChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemAllowanceCharge3? NetPriceAllowanceCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemAllowanceCharge3? NetPriceAllowanceCharge { get; init; } 
    #else
    public LineItemAllowanceCharge3? NetPriceAllowanceCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Net weight of the product.
    /// </summary>
    [IsoId("__wBlQeWlEeevU7McUP3D1w")]
    [DisplayName("Net Weight")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetWght")]
    #endif
    [IsoXmlTag("NetWght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? NetWeight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? NetWeight { get; init; } 
    #else
    public Quantity16? NetWeight { get; set; } 
    #endif
    
    /// <summary>
    /// Gross price of the product and/or service.
    /// </summary>
    [IsoId("__wBlQ-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlReWlEeevU7McUP3D1w")]
    [DisplayName("Gross Price Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssPricQty")]
    #endif
    [IsoXmlTag("GrssPricQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? GrossPriceQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? GrossPriceQuantity { get; init; } 
    #else
    public Quantity16? GrossPriceQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Gross weight of the product.
    /// </summary>
    [IsoId("__wBlR-WlEeevU7McUP3D1w")]
    [DisplayName("Gross Weight")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssWght")]
    #endif
    [IsoXmlTag("GrssWght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? GrossWeight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? GrossWeight { get; init; } 
    #else
    public Quantity16? GrossWeight { get; set; } 
    #endif
    
    /// <summary>
    /// Logistics service charge for this line item.
    /// </summary>
    [IsoId("__wBlSeWlEeevU7McUP3D1w")]
    [DisplayName("Logistics Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LogstcsChrg")]
    #endif
    [IsoXmlTag("LogstcsChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesDetails4? LogisticsCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesDetails4? LogisticsCharge { get; init; } 
    #else
    public ChargesDetails4? LogisticsCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("__wBlS-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlTeWlEeevU7McUP3D1w")]
    [DisplayName("Allowance Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwncChrg")]
    #endif
    [IsoXmlTag("AllwncChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemAllowanceCharge3? AllowanceCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemAllowanceCharge3? AllowanceCharge { get; init; } 
    #else
    public LineItemAllowanceCharge3? AllowanceCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
    /// </summary>
    [IsoId("__wBlT-WlEeevU7McUP3D1w")]
    [DisplayName("Financial Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinAdjstmnt")]
    #endif
    [IsoXmlTag("FinAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment6? FinancialAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment6? FinancialAdjustment { get; init; } 
    #else
    public Adjustment6? FinancialAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity billed for this line item.
    /// </summary>
    [IsoId("__wBlUeWlEeevU7McUP3D1w")]
    [DisplayName("Billed Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlldQty")]
    #endif
    [IsoXmlTag("BlldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? BilledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? BilledQuantity { get; init; } 
    #else
    public Quantity16? BilledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of product packages delivered.
    /// </summary>
    [IsoId("__wBlU-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlVeWlEeevU7McUP3D1w")]
    [DisplayName("Per Package Unit Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PerPackgUnitQty")]
    #endif
    [IsoXmlTag("PerPackgUnitQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? PerPackageUnitQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? PerPackageUnitQuantity { get; init; } 
    #else
    public Quantity16? PerPackageUnitQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Physical packaging of the product.
    /// </summary>
    [IsoId("__wBlV-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlWeWlEeevU7McUP3D1w")]
    [DisplayName("Charge Free Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgFreeQty")]
    #endif
    [IsoXmlTag("ChrgFreeQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? ChargeFreeQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? ChargeFreeQuantity { get; init; } 
    #else
    public Quantity16? ChargeFreeQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity value on which the quantity measurement started for a line item. For instance the start amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("__wBlW-WlEeevU7McUP3D1w")]
    [DisplayName("Measure Quantity Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MeasrQtyStart")]
    #endif
    [IsoXmlTag("MeasrQtyStart")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? MeasureQuantityStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? MeasureQuantityStart { get; init; } 
    #else
    public Quantity16? MeasureQuantityStart { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity value on which the quantity measurement ended for a line item. For instance the end amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("__wBlXeWlEeevU7McUP3D1w")]
    [DisplayName("Measure Quantity End")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MeasrQtyEnd")]
    #endif
    [IsoXmlTag("MeasrQtyEnd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? MeasureQuantityEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? MeasureQuantityEnd { get; init; } 
    #else
    public Quantity16? MeasureQuantityEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the clock time measure started for a line item.
    /// </summary>
    [IsoId("__wBlX-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlYeWlEeevU7McUP3D1w")]
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
    [IsoId("__wBlY-WlEeevU7McUP3D1w")]
    [DisplayName("Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipTo")]
    #endif
    [IsoXmlTag("ShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty4? ShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty4? ShipTo { get; init; } 
    #else
    public TradeParty4? ShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("__wBlZeWlEeevU7McUP3D1w")]
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
    [IsoId("__wBlZ-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlaeWlEeevU7McUP3D1w")]
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
    [IsoId("__wBla-WlEeevU7McUP3D1w")]
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
    [IsoId("__wBlbeWlEeevU7McUP3D1w")]
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
