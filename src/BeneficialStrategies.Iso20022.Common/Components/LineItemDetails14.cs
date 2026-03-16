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
[IsoId("_cM3m0TckEeSaC-PiOaz_KQ")]
[DisplayName("Line Item Details")]
public record LineItemDetails14
{
    /// <summary>
    /// Sequential number assigned to a line item.
    /// </summary>
    [IsoId("_cil_MTckEeSaC-PiOaz_KQ")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text LineItemIdentification { get; init; }

    /// <summary>
    /// Specifies the quantity of a product in a trade transaction.
    /// </summary>
    [IsoId("_cil_MzckEeSaC-PiOaz_KQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity9 Quantity { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_cil_NTckEeSaC-PiOaz_KQ")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public UnitPrice18? UnitPrice { get; init; }

    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_cil_NzckEeSaC-PiOaz_KQ")]
    [DisplayName("Product Name")]
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ProductName { get; init; }

    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_cil_OTckEeSaC-PiOaz_KQ")]
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; }

    /// <summary>
    /// Identifies the characteristics of product.
    /// </summary>
    [IsoId("_cil_OzckEeSaC-PiOaz_KQ")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; }

    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_cil_PTckEeSaC-PiOaz_KQ")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; }

    /// <summary>
    /// Country of origin of the goods.
    /// </summary>
    [IsoId("_cil_PzckEeSaC-PiOaz_KQ")]
    [DisplayName("Product Origin")]
    [IsoXmlTag("PdctOrgn")]
    public CountryCode? ProductOrigin { get; init; }

    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_cil_QTckEeSaC-PiOaz_KQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment6? Adjustment { get; init; }

    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_cil_QzckEeSaC-PiOaz_KQ")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge25? FreightCharges { get; init; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_cil_RTckEeSaC-PiOaz_KQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax22? Tax { get; init; }

    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    [IsoId("_cil_RzckEeSaC-PiOaz_KQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; }
}
