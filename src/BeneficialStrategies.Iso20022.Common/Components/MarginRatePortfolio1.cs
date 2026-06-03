// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies long and short margin rates for a defined portfolio.
/// </summary>
[IsoId("_DzJ80ND0EfCCRJ-TKQa7sQ")]
[DisplayName("Margin Rate Portfolio1")]
public record MarginRatePortfolio1
{
    /// <summary>
    /// Margin charged on a portfolio where the value of the contract increases when the value of the underlying increases.
    /// </summary>
    [IsoId("_pAMbMND0EfCCRJ-TKQa7sQ")]
    [DisplayName("Long Margin Rate")]
    [IsoXmlTag("LngMrgnRate")]
    public required ActiveCurrencyAnd24Amount LongMarginRate { get; init; }

    /// <summary>
    /// Margin charged on a portfolio where the value of the contract decreases when the value of the underlying increases.
    /// </summary>
    [IsoId("_zCtpAND0EfCCRJ-TKQa7sQ")]
    [DisplayName("Short Margin Rate")]
    [IsoXmlTag("ShrtMrgnRate")]
    public required ActiveCurrencyAnd24Amount ShortMarginRate { get; init; }

    /// <summary>
    /// Description of the fixed portfolio used for the purposes of the calculation.
    /// </summary>
    [IsoId("_6LJEQND0EfCCRJ-TKQa7sQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public required IsoMax2000Text Description { get; init; }
}
