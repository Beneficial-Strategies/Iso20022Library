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
[IsoId("_-jk90SzyEeOsiuMH68so7Q")]
[DisplayName("Cancellation Reason")]
public record CancellationReason7
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    [IsoId("_-7YZ0SzyEeOsiuMH68so7Q")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CancellationReason17Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_-7YZ2SzyEeOsiuMH68so7Q")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
