// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data used to assign specific conditions such as liability shift or preferential interchange fees.
/// </summary>
[IsoId("_z1TloEayEeeIjf8aP9KbJA")]
[DisplayName("Special Conditions")]
public record SpecialConditions1
{
    /// <summary>
    /// Identification of the special condition.
    /// </summary>
    [IsoId("_Tc0JcEa0EeeIjf8aP9KbJA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Level of the condition.
    /// </summary>
    [IsoId("_mhZ0sEa0EeeIjf8aP9KbJA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Value { get; init; }
}
