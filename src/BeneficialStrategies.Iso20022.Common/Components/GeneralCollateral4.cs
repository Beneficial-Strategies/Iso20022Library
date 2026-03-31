// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General Collateral4.
/// </summary>
[IsoId("_yqzGUZh8EeyJwbhKOp9Ehg")]
[DisplayName("General Collateral4")]
public record GeneralCollateral4
{
    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<FinancialInstrument104> FinancialInstrumentIdentification { get; init; } = [];

    /// <summary>
    /// Market Value.
    /// </summary>
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveCurrencyAnd24Amount MarketValue { get; init; }
}
