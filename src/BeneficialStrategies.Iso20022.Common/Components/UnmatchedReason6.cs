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
[IsoId("_5xWf_f7YEeCtrO5qCU90cA")]
[DisplayName("Unmatched Reason")]
public record UnmatchedReason6
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_5xWf__7YEeCtrO5qCU90cA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required UnmatchedReason9Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_5xWgCf7YEeCtrO5qCU90cA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
