// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction
/// </summary>
[IsoId("_AQ89wPNBEei4qfiLgRIZBA")]
[DisplayName("Invoice Line Item")]
public record InvoiceLineItem1
{
    /// <summary>
    /// Invoice date.
    /// </summary>
    [IsoId("_AQ89z_NBEei4qfiLgRIZBA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Invoice order date.
    /// </summary>
    [IsoId("_AQ89xPNBEei4qfiLgRIZBA")]
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OrderDate { get; init; }

    /// <summary>
    /// Contains the corporate contract number.
    /// </summary>
    [IsoId("_AQ890vNBEei4qfiLgRIZBA")]
    [DisplayName("Contract Number")]
    [IsoXmlTag("CtrctNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ContractNumber { get; init; }

    /// <summary>
    /// Shipping date of the product or the date services rendered.
    /// </summary>
    [IsoId("_AQ89xvNBEei4qfiLgRIZBA")]
    [DisplayName("Shipping Date")]
    [IsoXmlTag("ShppgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ShippingDate { get; init; }

    /// <summary>
    /// Rebilling indicator.
    /// </summary>
    [IsoId("_AQ89zfNBEei4qfiLgRIZBA")]
    [DisplayName("Rebilling Indicator")]
    [IsoXmlTag("RbllgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RebillingIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not the invoice line item represents a medical service.
    /// </summary>
    [IsoId("_AQ89yfNBEei4qfiLgRIZBA")]
    [DisplayName("Medical Services Indicator")]
    [IsoXmlTag("MdclSvcsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MedicalServicesIndicator { get; init; }

    /// <summary>
    /// Contains the health industry number to which the medical services are being shipped (for example, Medical Services ship to Health Industry Number).
    /// </summary>
    [IsoId("_AQ89x_NBEei4qfiLgRIZBA")]
    [DisplayName("Ship To Industry Code")]
    [IsoXmlTag("ShipToIndstryCd")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? ShipToIndustryCode { get; init; }

    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_AQ89w_NBEei4qfiLgRIZBA")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ProductCode { get; init; }

    /// <summary>
    /// Contains a code that identifies the product number qualifier of the product (for example, medical services).
    /// </summary>
    [IsoId("_uOCOEfNEEei4qfiLgRIZBA")]
    [DisplayName("Product Qualifier")]
    [IsoXmlTag("PdctQlfr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProductQualifier { get; init; }

    /// <summary>
    /// May contain further clarifying data, such as event name, etc.
    /// </summary>
    [IsoId("_vzcFofNEEei4qfiLgRIZBA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Indicates whether the purchase is categorized
    /// as goods or services.
    /// </summary>
    [IsoId("_Dj4KQfNFEei4qfiLgRIZBA")]
    [DisplayName("Type Of Supply")]
    [IsoXmlTag("TpOfSpply")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? TypeOfSupply { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_AQ89yPNBEei4qfiLgRIZBA")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_AQ89xfNBEei4qfiLgRIZBA")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; }

    /// <summary>
    /// Contains the price for one unit of the product or service.
    /// </summary>
    [IsoId("_AQ89y_NBEei4qfiLgRIZBA")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; }

    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_AQ89zvNBEei4qfiLgRIZBA")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; }

    /// <summary>
    /// Total line item amount, inclusive of adjustments and exclusive of taxes.
    /// </summary>
    [IsoId("_AQ89yvNBEei4qfiLgRIZBA")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment11? Adjustment { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_BdwV0fNGEei4qfiLgRIZBA")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_AQ890PNBEei4qfiLgRIZBA")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_AQ890fNBEei4qfiLgRIZBA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax33? Tax { get; init; }

    /// <summary>
    /// Identifies the value-added tax (VAT) invoice or tax receipt.
    /// </summary>
    [IsoId("_AQ89wfNBEei4qfiLgRIZBA")]
    [DisplayName("Unique VAT Invoice Reference")]
    [IsoXmlTag("UnqVATInvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? UniqueVATInvoiceReference { get; init; }

    /// <summary>
    /// Total amount of line item, inclusive of any applicable adjustments and taxes.
    /// </summary>
    [IsoId("_AQ89zPNBEei4qfiLgRIZBA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Indicates whether or not the line item is a credit amount.
    /// </summary>
    [IsoId("_ZLr40fNIEei4qfiLgRIZBA")]
    [DisplayName("Credit Indicator")]
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not the line item carries a cost.
    /// True : Line item does not have any cost associated to the customer.
    /// False : Line item has cost associated to the customer.
    /// </summary>
    [IsoId("_d2QxkfNIEei4qfiLgRIZBA")]
    [DisplayName("Zero Cost To Customer Indicator")]
    [IsoXmlTag("ZeroCostToCstmrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ZeroCostToCustomerIndicator { get; init; }

    /// <summary>
    /// Additional data.
    /// </summary>
    [IsoId("_eTQ2ofNIEei4qfiLgRIZBA")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
