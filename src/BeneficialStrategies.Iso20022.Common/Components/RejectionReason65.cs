// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request has a rejected status.
/// </summary>
[IsoId("_f9799Ti8Eeydid5dcNPKvg")]
[DisplayName("Rejection Reason")]
public record RejectionReason65
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    [IsoId("_f9799zi8Eeydid5dcNPKvg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RejectionReason50Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_f979-zi8Eeydid5dcNPKvg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
}
