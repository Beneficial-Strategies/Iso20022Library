// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type and information about a price.
/// </summary>
[IsoId("_UjRo0QycEeuG8M5giQ2e0w")]
[DisplayName("Price")]
public record Price10
{
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_UyctQQycEeuG8M5giQ2e0w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required YieldedOrValueType2Choice_ Type { get; init; }

    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_UyctQwycEeuG8M5giQ2e0w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmount3Choice_ Value { get; init; }
}
