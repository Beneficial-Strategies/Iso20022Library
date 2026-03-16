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
[IsoId("_SqWrcNp-Ed-ak6NoX_4Aeg_1674748039")]
[DisplayName("Line Item Details")]
public record LineItemDetails9
{
    /// <summary>
    /// Sequential number assigned to a line item.
    /// </summary>
    [IsoId("_SqWrcdp-Ed-ak6NoX_4Aeg_1674748070")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text LineItemIdentification { get; init; }

    /// <summary>
    /// Specifies the quantity of a product in a trade transaction.
    /// </summary>
    [IsoId("_SqWrctp-Ed-ak6NoX_4Aeg_1674748988")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity4 Quantity { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_SqWrc9p-Ed-ak6NoX_4Aeg_1674748564")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public UnitPrice9? UnitPrice { get; init; }

    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_SqWrdNp-Ed-ak6NoX_4Aeg_1674748161")]
    [DisplayName("Product Name")]
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ProductName { get; init; }

    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_SqWrddp-Ed-ak6NoX_4Aeg_1674749110")]
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; }

    /// <summary>
    /// Identifies the characteristics of product.
    /// </summary>
    [IsoId("_SqWrdtp-Ed-ak6NoX_4Aeg_1674749080")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; }

    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_SqWrd9p-Ed-ak6NoX_4Aeg_1674749018")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; }

    /// <summary>
    /// Country of origin of the goods.
    /// </summary>
    [IsoId("_SqWreNp-Ed-ak6NoX_4Aeg_1674748470")]
    [DisplayName("Product Origin")]
    [IsoXmlTag("PdctOrgn")]
    public CountryCode? ProductOrigin { get; init; }

    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_SqgccNp-Ed-ak6NoX_4Aeg_1674748709")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment4? Adjustment { get; init; }

    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_Sqgccdp-Ed-ak6NoX_4Aeg_1674748625")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge13? FreightCharges { get; init; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_Sqgcctp-Ed-ak6NoX_4Aeg_1674748678")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax12? Tax { get; init; }

    /// <summary>
    /// Total amount of the line item after adjustments have been applied.
    /// </summary>
    [IsoId("_Sqgcc9p-Ed-ak6NoX_4Aeg_1674748131")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; }
}
