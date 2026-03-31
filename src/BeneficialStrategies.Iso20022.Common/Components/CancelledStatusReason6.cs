// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the cancelled status.
/// </summary>
[IsoId("_X0CsYeJxEd-Q6MzBzY5WkA")]
[DisplayName("Cancelled Status Reason")]
public record CancelledStatusReason6
{
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
    /// </summary>
    [IsoId("_X0L2UeJxEd-Q6MzBzY5WkA")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required CancelledReason3Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_X0L2U-JxEd-Q6MzBzY5WkA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
