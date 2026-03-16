// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Goods or services that are part of a commercial trade agreement.
/// </summary>
[IsoId("_SqDwgdp-Ed-ak6NoX_4Aeg_-733825048")]
[DisplayName("Line Item Details")]
public record LineItemDetails7
{
    /// <summary>
    /// Identification assigned to a line item.
    /// </summary>
    [IsoId("_SqDwgtp-Ed-ak6NoX_4Aeg_-733824910")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text LineItemIdentification { get; init; }

    /// <summary>
    /// Specifies the quantity of goods on a line in a trade transaction.
    /// </summary>
    [IsoId("_SqDwg9p-Ed-ak6NoX_4Aeg_-732903030")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity4 Quantity { get; init; }

    /// <summary>
    /// Variance allowed in the quantity of goods.
    /// </summary>
    [IsoId("_SqDwhNp-Ed-ak6NoX_4Aeg_-732904297")]
    [DisplayName("Quantity Tolerance")]
    [IsoXmlTag("QtyTlrnce")]
    public PercentageTolerance1? QuantityTolerance { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_SqDwhdp-Ed-ak6NoX_4Aeg_-732904392")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public UnitPrice9? UnitPrice { get; init; }

    /// <summary>
    /// Variance allowed on a price.
    /// </summary>
    [IsoId("_SqDwhtp-Ed-ak6NoX_4Aeg_-732902437")]
    [DisplayName("Price Tolerance")]
    [IsoXmlTag("PricTlrnce")]
    public PercentageTolerance1? PriceTolerance { get; init; }

    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_SqDwh9p-Ed-ak6NoX_4Aeg_-733824581")]
    [DisplayName("Product Name")]
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ProductName { get; init; }

    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_SqDwiNp-Ed-ak6NoX_4Aeg_-732903900")]
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; }

    /// <summary>
    /// Identifies the characteristics of a product.
    /// </summary>
    [IsoId("_SqDwidp-Ed-ak6NoX_4Aeg_-732902953")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; }

    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_SqM6cNp-Ed-ak6NoX_4Aeg_-732902516")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; }

    /// <summary>
    /// Country from which the product originates.
    /// </summary>
    [IsoId("_SqM6cdp-Ed-ak6NoX_4Aeg_-733824521")]
    [DisplayName("Product Origin")]
    [IsoXmlTag("PdctOrgn")]
    public CountryCode? ProductOrigin { get; init; }

    /// <summary>
    /// Specifies the shipment schedule for the goods.
    /// </summary>
    [IsoId("_SqM6ctp-Ed-ak6NoX_4Aeg_-314547877")]
    [DisplayName("Shipment Schedule")]
    [IsoXmlTag("ShipmntSchdl")]
    public ShipmentSchedule1Choice_? ShipmentSchedule { get; init; }

    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_SqM6c9p-Ed-ak6NoX_4Aeg_1596164645")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public TransportMeans1? RoutingSummary { get; init; }

    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_SqM6dNp-Ed-ak6NoX_4Aeg_-732902858")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms1? Incoterms { get; init; }

    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_SqM6ddp-Ed-ak6NoX_4Aeg_-732903385")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment3? Adjustment { get; init; }

    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_SqM6dtp-Ed-ak6NoX_4Aeg_-732903830")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge12? FreightCharges { get; init; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_SqM6d9p-Ed-ak6NoX_4Aeg_-732903480")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax13? Tax { get; init; }

    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    [IsoId("_SqM6eNp-Ed-ak6NoX_4Aeg_-733824858")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; }
}
