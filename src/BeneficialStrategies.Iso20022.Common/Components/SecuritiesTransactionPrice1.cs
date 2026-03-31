// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Descriptive fields capturing where no strike price is known.
/// </summary>
[IsoId("_cqBnQOI_EeWWKb0jFHxViQ")]
[DisplayName("Securities Transaction Price")]
public record SecuritiesTransactionPrice1
{
    /// <summary>
    /// Price is currently not available, but pending.
    /// </summary>
    [IsoId("_lr-v8OI_EeWWKb0jFHxViQ")]
    [DisplayName("Pending")]
    [IsoXmlTag("Pdg")]
    public required PriceStatus1Code Pending { get; init; }

    /// <summary>
    /// Currency that will be used but for which no price is yet known.
    /// </summary>
    [IsoId("_tbdkIOI_EeWWKb0jFHxViQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }
}
