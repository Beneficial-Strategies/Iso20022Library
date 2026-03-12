// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unit of information showing the related provision of products and/or services and monetary summations reported as a discrete line items.
/// </summary>
[IsoId("_SuJtLAEcEeCQm6a_G2yO_w_-1957014618")]
[DisplayName("Line Item")]
public partial record LineItem10
{
    #nullable enable
    
    /// <summary>
    /// The unique identification of this invoice line item.
    /// </summary>
    [IsoId("_SuJtLQEcEeCQm6a_G2yO_w_276499295")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Something that is produced and sold as the result of an industrial process.
    /// </summary>
    [IsoId("_SuTeIAEcEeCQm6a_G2yO_w_-1081676107")]
    [DisplayName("Trade Product")]
    [IsoXmlTag("TradPdct")]
    public TradeProduct1? TradeProduct { get; init; } 
    
    /// <summary>
    /// Purchase order reference assigned by the buyer related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_SuTeIQEcEeCQm6a_G2yO_w_1418969012")]
    [DisplayName("Buyer Order Identification")]
    [IsoXmlTag("BuyrOrdrId")]
    public DocumentIdentification23? BuyerOrderIdentification { get; init; } 
    
    /// <summary>
    /// Contract reference related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_SuTeIgEcEeCQm6a_G2yO_w_-2047566678")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    public DocumentIdentification22? ContractIdentification { get; init; } 
    
    /// <summary>
    /// Specific purchase account for recording debits and credits for accounting purposes.
    /// </summary>
    [IsoId("_SuTeIwEcEeCQm6a_G2yO_w_-1211043201")]
    [DisplayName("Purchase Accounting Account")]
    [IsoXmlTag("PurchsAcctgAcct")]
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_SuTeJAEcEeCQm6a_G2yO_w_-769209174")]
    [DisplayName("Net Price")]
    [IsoXmlTag("NetPric")]
    public CurrencyAndAmount? NetPrice { get; init; } 
    
    /// <summary>
    /// Quantity and conversion factor on which the net price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_SuTeJQEcEeCQm6a_G2yO_w_-899649920")]
    [DisplayName("Net Price Quantity")]
    [IsoXmlTag("NetPricQty")]
    public Quantity4? NetPriceQuantity { get; init; } 
    
    /// <summary>
    /// Allowance or charge applied to the net price.
    /// </summary>
    [IsoId("_SuTeJgEcEeCQm6a_G2yO_w_328165622")]
    [DisplayName("Net Price Allowance Charge")]
    [IsoXmlTag("NetPricAllwncChrg")]
    public LineItemAllowanceCharge1? NetPriceAllowanceCharge { get; init; } 
    
    /// <summary>
    /// Net weight of the product.
    /// </summary>
    [IsoId("_SuTeJwEcEeCQm6a_G2yO_w_917729180")]
    [DisplayName("Net Weight")]
    [IsoXmlTag("NetWght")]
    public Quantity3? NetWeight { get; init; } 
    
    /// <summary>
    /// Gross price of the product and/or service.
    /// </summary>
    [IsoId("_SuTeKAEcEeCQm6a_G2yO_w_415525348")]
    [DisplayName("Gross Price")]
    [IsoXmlTag("GrssPric")]
    public CurrencyAndAmount? GrossPrice { get; init; } 
    
    /// <summary>
    /// Quantity and conversion factor on which the gross price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_SuTeKQEcEeCQm6a_G2yO_w_-26631818")]
    [DisplayName("Gross Price Quantity")]
    [IsoXmlTag("GrssPricQty")]
    public Quantity4? GrossPriceQuantity { get; init; } 
    
    /// <summary>
    /// Gross weight of the product.
    /// </summary>
    [IsoId("_SuTeKgEcEeCQm6a_G2yO_w_-502407978")]
    [DisplayName("Gross Weight")]
    [IsoXmlTag("GrssWght")]
    public Quantity3? GrossWeight { get; init; } 
    
    /// <summary>
    /// Logistics service charge for this line item.
    /// </summary>
    [IsoId("_SuTeKwEcEeCQm6a_G2yO_w_-1074285510")]
    [DisplayName("Logistics Charge")]
    [IsoXmlTag("LogstcsChrg")]
    public ChargesDetails2? LogisticsCharge { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_SuTeLAEcEeCQm6a_G2yO_w_-1718452272")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public LineItemTax1? Tax { get; init; } 
    
    /// <summary>
    /// Allowance or charge specified for this line item.
    /// </summary>
    [IsoId("_SuTeLQEcEeCQm6a_G2yO_w_-1288890455")]
    [DisplayName("Allowance Charge")]
    [IsoXmlTag("AllwncChrg")]
    public LineItemAllowanceCharge1? AllowanceCharge { get; init; } 
    
    /// <summary>
    /// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
    /// </summary>
    [IsoId("_SuTeLgEcEeCQm6a_G2yO_w_1555627299")]
    [DisplayName("Financial Adjustment")]
    [IsoXmlTag("FinAdjstmnt")]
    public Adjustment4? FinancialAdjustment { get; init; } 
    
    /// <summary>
    /// Quantity billed for this line item.
    /// </summary>
    [IsoId("_SuTeLwEcEeCQm6a_G2yO_w_-72954526")]
    [DisplayName("Billed Quantity")]
    [IsoXmlTag("BlldQty")]
    public Quantity3? BilledQuantity { get; init; } 
    
    /// <summary>
    /// Number of product packages delivered.
    /// </summary>
    [IsoId("_SuTeMAEcEeCQm6a_G2yO_w_1141764402")]
    [DisplayName("Package Quantity")]
    [IsoXmlTag("PackgQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PackageQuantity { get; init; } 
    
    /// <summary>
    /// Number of units per package in this line item for a supply chain trade delivery.
    /// </summary>
    [IsoId("_SuTeMQEcEeCQm6a_G2yO_w_1057688708")]
    [DisplayName("Per Package Unit Quantity")]
    [IsoXmlTag("PerPackgUnitQty")]
    public Quantity3? PerPackageUnitQuantity { get; init; } 
    
    /// <summary>
    /// Physical packaging of the product.
    /// </summary>
    [IsoId("_SucoEAEcEeCQm6a_G2yO_w_-531731082")]
    [DisplayName("Packaging")]
    [IsoXmlTag("Packgng")]
    public Packaging1? Packaging { get; init; } 
    
    /// <summary>
    /// Quantity that is free of charge for this line item.
    /// </summary>
    [IsoId("_SucoEQEcEeCQm6a_G2yO_w_695882671")]
    [DisplayName("Charge Free Quantity")]
    [IsoXmlTag("ChrgFreeQty")]
    public Quantity3? ChargeFreeQuantity { get; init; } 
    
    /// <summary>
    /// Quantity value on which the quantity measurement started for a line item. For instance the start amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_SucoEgEcEeCQm6a_G2yO_w_1824445894")]
    [DisplayName("Measure Quantity Start")]
    [IsoXmlTag("MeasrQtyStart")]
    public Quantity3? MeasureQuantityStart { get; init; } 
    
    /// <summary>
    /// Quantity value on which the quantity measurement ended for a line item. For instance the end amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_SucoEwEcEeCQm6a_G2yO_w_-1570728431")]
    [DisplayName("Measure Quantity End")]
    [IsoXmlTag("MeasrQtyEnd")]
    public Quantity3? MeasureQuantityEnd { get; init; } 
    
    /// <summary>
    /// Date/time on which the clock time measure started for a line item.
    /// </summary>
    [IsoId("_SucoFAEcEeCQm6a_G2yO_w_-1177982434")]
    [DisplayName("Measure Date Time Start")]
    [IsoXmlTag("MeasrDtTmStart")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MeasureDateTimeStart { get; init; } 
    
    /// <summary>
    /// Date/time on which the clock time measure ended for a line item.
    /// </summary>
    [IsoId("_SucoFQEcEeCQm6a_G2yO_w_-1092370631")]
    [DisplayName("Measure Date Time End")]
    [IsoXmlTag("MeasrDtTmEnd")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MeasureDateTimeEnd { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_SucoFgEcEeCQm6a_G2yO_w_392335545")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public TradeParty1? ShipTo { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_SucoFwEcEeCQm6a_G2yO_w_-1792779697")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms3? Incoterms { get; init; } 
    
    /// <summary>
    /// Actual delivery date/time of the products and/or services for this line item.
    /// </summary>
    [IsoId("_SucoGAEcEeCQm6a_G2yO_w_-1420879465")]
    [DisplayName("Delivery Date Time")]
    [IsoXmlTag("DlvryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeliveryDateTime { get; init; } 
    
    /// <summary>
    /// Delivery note related to the delivery of the products and/or services for this line item.
    /// </summary>
    [IsoId("_SucoGQEcEeCQm6a_G2yO_w_1419263589")]
    [DisplayName("Delivery Note Identification")]
    [IsoXmlTag("DlvryNoteId")]
    public DocumentIdentification22? DeliveryNoteIdentification { get; init; } 
    
    /// <summary>
    /// Monetary totals for this line item.
    /// </summary>
    [IsoId("_SucoGgEcEeCQm6a_G2yO_w_525193840")]
    [DisplayName("Monetary Summation")]
    [IsoXmlTag("MntrySummtn")]
    public LineItemMonetarySummation1? MonetarySummation { get; init; } 
    
    /// <summary>
    /// Note included in this line item.
    /// </summary>
    [IsoId("_SucoGwEcEeCQm6a_G2yO_w_402346471")]
    [DisplayName("Included Note")]
    [IsoXmlTag("InclNote")]
    public AdditionalInformation1? IncludedNote { get; init; } 
    
    
    #nullable disable
    
}
