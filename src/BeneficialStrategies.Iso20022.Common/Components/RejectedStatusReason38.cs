// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the rejected status.
/// </summary>
[IsoId("_9FBMox9QEeuFz_FaCzCLgQ")]
[DisplayName("Rejected Status Reason")]
public record RejectedStatusReason38
{
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been rejected.
    /// </summary>
    [IsoId("_9FBMpx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason40Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_9FBMrx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
}
