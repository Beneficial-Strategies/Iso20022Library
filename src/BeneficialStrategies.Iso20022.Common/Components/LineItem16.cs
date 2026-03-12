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
[IsoId("_QD8hYcNPEeWGDrnsYu2p6g")]
[DisplayName("Line Item")]
public partial record LineItem16
{
    #nullable enable
    
    /// <summary>
    /// The unique identification of this invoice line item.
    /// </summary>
    [IsoId("_QTRW0cNPEeWGDrnsYu2p6g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Something that is produced and sold as the result of an industrial process.
    /// </summary>
    [IsoId("_QTRW08NPEeWGDrnsYu2p6g")]
    [DisplayName("Trade Product")]
    [IsoXmlTag("TradPdct")]
    public TradeProduct2? TradeProduct { get; init; } 
    
    /// <summary>
    /// Purchase order reference assigned by the buyer related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_QTRW1cNPEeWGDrnsYu2p6g")]
    [DisplayName("Buyer Order Identification")]
    [IsoXmlTag("BuyrOrdrId")]
    public DocumentIdentification23? BuyerOrderIdentification { get; init; } 
    
    /// <summary>
    /// Contract reference related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_QTRW18NPEeWGDrnsYu2p6g")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    public DocumentIdentification22? ContractIdentification { get; init; } 
    
    /// <summary>
    /// Specific purchase account for recording debits and credits for accounting purposes.
    /// </summary>
    [IsoId("_QTRW2cNPEeWGDrnsYu2p6g")]
    [DisplayName("Purchase Accounting Account")]
    [IsoXmlTag("PurchsAcctgAcct")]
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QTRW28NPEeWGDrnsYu2p6g")]
    [DisplayName("Net Price")]
    [IsoXmlTag("NetPric")]
    public CurrencyAndAmount? NetPrice { get; init; } 
    
    /// <summary>
    /// Quantity and conversion factor on which the net price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_QTRW3cNPEeWGDrnsYu2p6g")]
    [DisplayName("Net Price Quantity")]
    [IsoXmlTag("NetPricQty")]
    public Quantity9? NetPriceQuantity { get; init; } 
    
    /// <summary>
    /// Allowance or charge applied to the net price.
    /// </summary>
    [IsoId("_QTRW38NPEeWGDrnsYu2p6g")]
    [DisplayName("Net Price Allowance Charge")]
    [IsoXmlTag("NetPricAllwncChrg")]
    public LineItemAllowanceCharge2? NetPriceAllowanceCharge { get; init; } 
    
    /// <summary>
    /// Net weight of the product.
    /// </summary>
    [IsoId("_QTRW4cNPEeWGDrnsYu2p6g")]
    [DisplayName("Net Weight")]
    [IsoXmlTag("NetWght")]
    public Quantity10? NetWeight { get; init; } 
    
    /// <summary>
    /// Gross price of the product and/or service.
    /// </summary>
    [IsoId("_QTRW48NPEeWGDrnsYu2p6g")]
    [DisplayName("Gross Price")]
    [IsoXmlTag("GrssPric")]
    public CurrencyAndAmount? GrossPrice { get; init; } 
    
    /// <summary>
    /// Quantity and conversion factor on which the gross price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_QTRW5cNPEeWGDrnsYu2p6g")]
    [DisplayName("Gross Price Quantity")]
    [IsoXmlTag("GrssPricQty")]
    public Quantity9? GrossPriceQuantity { get; init; } 
    
    /// <summary>
    /// Gross weight of the product.
    /// </summary>
    [IsoId("_QTRW58NPEeWGDrnsYu2p6g")]
    [DisplayName("Gross Weight")]
    [IsoXmlTag("GrssWght")]
    public Quantity10? GrossWeight { get; init; } 
    
    /// <summary>
    /// Logistics service charge for this line item.
    /// </summary>
    [IsoId("_QTRW6cNPEeWGDrnsYu2p6g")]
    [DisplayName("Logistics Charge")]
    [IsoXmlTag("LogstcsChrg")]
    public ChargesDetails4? LogisticsCharge { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_QTRW68NPEeWGDrnsYu2p6g")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public LineItemTax1? Tax { get; init; } 
    
    /// <summary>
    /// Allowance or charge specified for this line item.
    /// </summary>
    [IsoId("_QTRW7cNPEeWGDrnsYu2p6g")]
    [DisplayName("Allowance Charge")]
    [IsoXmlTag("AllwncChrg")]
    public LineItemAllowanceCharge2? AllowanceCharge { get; init; } 
    
    /// <summary>
    /// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
    /// </summary>
    [IsoId("_QTRW78NPEeWGDrnsYu2p6g")]
    [DisplayName("Financial Adjustment")]
    [IsoXmlTag("FinAdjstmnt")]
    public Adjustment6? FinancialAdjustment { get; init; } 
    
    /// <summary>
    /// Quantity billed for this line item.
    /// </summary>
    [IsoId("_QTRW8cNPEeWGDrnsYu2p6g")]
    [DisplayName("Billed Quantity")]
    [IsoXmlTag("BlldQty")]
    public Quantity10? BilledQuantity { get; init; } 
    
    /// <summary>
    /// Number of product packages delivered.
    /// </summary>
    [IsoId("_QTRW88NPEeWGDrnsYu2p6g")]
    [DisplayName("Package Quantity")]
    [IsoXmlTag("PackgQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PackageQuantity { get; init; } 
    
    /// <summary>
    /// Number of units per package in this line item for a supply chain trade delivery.
    /// </summary>
    [IsoId("_QTRW9cNPEeWGDrnsYu2p6g")]
    [DisplayName("Per Package Unit Quantity")]
    [IsoXmlTag("PerPackgUnitQty")]
    public Quantity10? PerPackageUnitQuantity { get; init; } 
    
    /// <summary>
    /// Physical packaging of the product.
    /// </summary>
    [IsoId("_QTRW98NPEeWGDrnsYu2p6g")]
    [DisplayName("Packaging")]
    [IsoXmlTag("Packgng")]
    public Packaging1? Packaging { get; init; } 
    
    /// <summary>
    /// Quantity that is free of charge for this line item.
    /// </summary>
    [IsoId("_QTRW-cNPEeWGDrnsYu2p6g")]
    [DisplayName("Charge Free Quantity")]
    [IsoXmlTag("ChrgFreeQty")]
    public Quantity10? ChargeFreeQuantity { get; init; } 
    
    /// <summary>
    /// Quantity value on which the quantity measurement started for a line item. For instance the start amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_QTRW-8NPEeWGDrnsYu2p6g")]
    [DisplayName("Measure Quantity Start")]
    [IsoXmlTag("MeasrQtyStart")]
    public Quantity10? MeasureQuantityStart { get; init; } 
    
    /// <summary>
    /// Quantity value on which the quantity measurement ended for a line item. For instance the end amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_QTRW_cNPEeWGDrnsYu2p6g")]
    [DisplayName("Measure Quantity End")]
    [IsoXmlTag("MeasrQtyEnd")]
    public Quantity10? MeasureQuantityEnd { get; init; } 
    
    /// <summary>
    /// Date/time on which the clock time measure started for a line item.
    /// </summary>
    [IsoId("_QTRW_8NPEeWGDrnsYu2p6g")]
    [DisplayName("Measure Date Time Start")]
    [IsoXmlTag("MeasrDtTmStart")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MeasureDateTimeStart { get; init; } 
    
    /// <summary>
    /// Date/time on which the clock time measure ended for a line item.
    /// </summary>
    [IsoId("_QTRXAcNPEeWGDrnsYu2p6g")]
    [DisplayName("Measure Date Time End")]
    [IsoXmlTag("MeasrDtTmEnd")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MeasureDateTimeEnd { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_QTRXA8NPEeWGDrnsYu2p6g")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public TradeParty3? ShipTo { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_QTRXBcNPEeWGDrnsYu2p6g")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms3? Incoterms { get; init; } 
    
    /// <summary>
    /// Actual delivery date/time of the products and/or services for this line item.
    /// </summary>
    [IsoId("_QTRXB8NPEeWGDrnsYu2p6g")]
    [DisplayName("Delivery Date Time")]
    [IsoXmlTag("DlvryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeliveryDateTime { get; init; } 
    
    /// <summary>
    /// Delivery note related to the delivery of the products and/or services for this line item.
    /// </summary>
    [IsoId("_QTRXCcNPEeWGDrnsYu2p6g")]
    [DisplayName("Delivery Note Identification")]
    [IsoXmlTag("DlvryNoteId")]
    public DocumentIdentification22? DeliveryNoteIdentification { get; init; } 
    
    /// <summary>
    /// Monetary totals for this line item.
    /// </summary>
    [IsoId("_QTRXC8NPEeWGDrnsYu2p6g")]
    [DisplayName("Monetary Summation")]
    [IsoXmlTag("MntrySummtn")]
    public LineItemMonetarySummation1? MonetarySummation { get; init; } 
    
    /// <summary>
    /// Note included in this line item.
    /// </summary>
    [IsoId("_QTRXDcNPEeWGDrnsYu2p6g")]
    [DisplayName("Included Note")]
    [IsoXmlTag("InclNote")]
    public AdditionalInformation1? IncludedNote { get; init; } 
    
    
    #nullable disable
    
}
