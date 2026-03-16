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
[IsoId("_Sx2PAefIEeKNfc-Rw_dPYg")]
[DisplayName("Line Item Details")]
public record LineItemDetails10
{
    /// <summary>
    /// Identification assigned to a line item.
    /// </summary>
    [IsoId("_TPud0efIEeKNfc-Rw_dPYg")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text LineItemIdentification { get; init; }

    /// <summary>
    /// Specifies the quantity of goods on a line in a trade transaction.
    /// </summary>
    [IsoId("_TPud0-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity9 Quantity { get; init; }

    /// <summary>
    /// Variance allowed in the quantity of goods.
    /// </summary>
    [IsoId("_TPud1efIEeKNfc-Rw_dPYg")]
    [DisplayName("Quantity Tolerance")]
    [IsoXmlTag("QtyTlrnce")]
    public PercentageTolerance1? QuantityTolerance { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_TPud1-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public UnitPrice18? UnitPrice { get; init; }

    /// <summary>
    /// Variance allowed on a price.
    /// </summary>
    [IsoId("_TPud2efIEeKNfc-Rw_dPYg")]
    [DisplayName("Price Tolerance")]
    [IsoXmlTag("PricTlrnce")]
    public PercentageTolerance1? PriceTolerance { get; init; }

    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_TPud2-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Name")]
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ProductName { get; init; }

    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_TPud3efIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; }

    /// <summary>
    /// Identifies the characteristics of a product.
    /// </summary>
    [IsoId("_TPud3-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; }

    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_TPud4efIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; }

    /// <summary>
    /// Country from which the product originates.
    /// </summary>
    [IsoId("_TPud4-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Product Origin")]
    [IsoXmlTag("PdctOrgn")]
    public CountryCode? ProductOrigin { get; init; }

    /// <summary>
    /// Specifies the shipment schedule for the goods.
    /// </summary>
    [IsoId("_TPud5efIEeKNfc-Rw_dPYg")]
    [DisplayName("Shipment Schedule")]
    [IsoXmlTag("ShipmntSchdl")]
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; }

    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_TPud5-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Routing Summary")]
    [IsoXmlTag("RtgSummry")]
    public TransportMeans5? RoutingSummary { get; init; }

    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_TPvE4-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment7? Adjustment { get; init; }

    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_TPvE5efIEeKNfc-Rw_dPYg")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge24? FreightCharges { get; init; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_TPvE5-fIEeKNfc-Rw_dPYg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax23? Tax { get; init; }

    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    [IsoId("_TPvE6efIEeKNfc-Rw_dPYg")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_TPvE4efIEeKNfc-Rw_dPYg")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; }
}
