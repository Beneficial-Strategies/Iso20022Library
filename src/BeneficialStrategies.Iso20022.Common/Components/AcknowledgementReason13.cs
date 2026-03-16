// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[IsoId("_5SFnl5NLEeWGlc8L7oPDIg")]
[DisplayName("Acknowledgement Reason")]
public record AcknowledgementReason13
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_5SFnmZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AcknowledgementReason16Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_5SFnoZNLEeWGlc8L7oPDIg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
}
