// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_z7QP4UevEeODR7vDcYOqmg")]
[DisplayName("Commission")]
public record Commission18
{
    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_0F-5QUevEeODR7vDcYOqmg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }

    /// <summary>
    /// Additional information about the type of markup.
    /// </summary>
    [IsoId("_IFfUkEewEeODR7vDcYOqmg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
