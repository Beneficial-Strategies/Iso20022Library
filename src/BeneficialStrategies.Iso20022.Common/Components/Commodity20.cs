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
[IsoId("_MMF1181VEem4K5qLxnWwMA")]
[DisplayName("Commodity")]
public record Commodity20
{
    /// <summary>
    /// Details on commodities assignments to sectors.
    /// </summary>
    [IsoId("_MR5i4c1VEem4K5qLxnWwMA")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public AssetClassCommodity5Choice_? Classification { get; init; }

    /// <summary>
    /// Quantity of the commodity.
    /// </summary>
    [IsoId("_MR5i481VEem4K5qLxnWwMA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity17? Quantity { get; init; }

    /// <summary>
    /// Price of unit of asset or collateral component, including accrued interest for interest-bearing securities, used to value the commodity .
    /// </summary>
    [IsoId("_MR5i5c1VEem4K5qLxnWwMA")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; }

    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_MR5i581VEem4K5qLxnWwMA")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveOrHistoricCurrencyAndAmount? MarketValue { get; init; }
}
