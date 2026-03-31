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
[IsoId("_pUIcLx9QEeuFz_FaCzCLgQ")]
[DisplayName("Rejected Status Reason")]
public record RejectedStatusReason37
{
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been rejected.
    /// </summary>
    [IsoId("_pUIcMx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason39Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_pUIcOx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINMax210Text? AdditionalReasonInformation { get; init; }
}
