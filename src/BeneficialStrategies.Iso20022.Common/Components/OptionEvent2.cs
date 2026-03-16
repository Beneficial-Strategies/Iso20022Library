// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Events specified in the contract terms of an option.
/// </summary>
[IsoId("_b29F0ZR0Eeeymf3kpbtgrA")]
[DisplayName("Option Event")]
public record OptionEvent2
{
    /// <summary>
    /// Type of event in the life of the option.
    /// </summary>
    [IsoId("_cHKsEZR0Eeeymf3kpbtgrA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OptionEventType1Choice_ Type { get; init; }

    /// <summary>
    /// Description of the event.
    /// </summary>
    [IsoId("_cHKsE5R0Eeeymf3kpbtgrA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Description { get; init; }
}
