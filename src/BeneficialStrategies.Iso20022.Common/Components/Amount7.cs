// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed amount in a given numeric currency
/// </summary>
[IsoId("_0qRtJPGhEeiGNursv3uE_g")]
[DisplayName("Amount")]
public record Amount7
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_0qRtJ_GhEeiGNursv3uE_g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency code associated with the applicable type of amount.
    /// ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_0qRtJfGhEeiGNursv3uE_g")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }
}
