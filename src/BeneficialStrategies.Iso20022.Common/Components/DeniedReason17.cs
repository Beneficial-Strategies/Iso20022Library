// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_fmPDQZkNEeWn2ur3BXxtdg")]
[DisplayName("Denied Reason")]
public record DeniedReason17
{
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    [IsoId("_f0zqwZkNEeWn2ur3BXxtdg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DeniedReason24Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_f0zqyZkNEeWn2ur3BXxtdg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
}
