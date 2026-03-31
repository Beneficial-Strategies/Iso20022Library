// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to commodities and related fields used as a collateral.
/// </summary>
[IsoId("_EvTYIdR8EemZdYGWu384Zw")]
[DisplayName("Commodity")]
public record Commodity21
{
    /// <summary>
    /// Specifies whether the values defined asset class commodity are matching or not.
    /// </summary>
    [IsoId("_EzO14dR8EemZdYGWu384Zw")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public CompareCommodityAssetClass2? Classification { get; init; }

    /// <summary>
    /// Specifies whether the values defined as decimal number are matching or not.
    /// </summary>
    [IsoId("_EzO149R8EemZdYGWu384Zw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public CompareDecimalNumber2? Quantity { get; init; }

    /// <summary>
    /// Specifies whether the the unit prices are matching or not.
    /// </summary>
    [IsoId("_EzO15dR8EemZdYGWu384Zw")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public CompareUnitPrice3? UnitPrice { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_EzO159R8EemZdYGWu384Zw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public CompareActiveOrHistoricCurrencyAndAmount2? MarketValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as unit of measure code are matching or not.
    /// </summary>
    [IsoId("_EzO16dR8EemZdYGWu384Zw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public CompareUnitOfMeasure2? UnitOfMeasure { get; init; }
}
