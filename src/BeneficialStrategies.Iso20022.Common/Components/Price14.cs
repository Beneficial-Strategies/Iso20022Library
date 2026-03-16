// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the value and optionaly the type of price.
/// </summary>
[IsoId("_UazzwQeEEe2fOITqoTnSLQ")]
[DisplayName("Price")]
public record Price14
{
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_UrpFEQeEEe2fOITqoTnSLQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmount3Choice_ Value { get; init; }

    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_UrpFEweEEe2fOITqoTnSLQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PriceValueType7Code? Type { get; init; }
}
