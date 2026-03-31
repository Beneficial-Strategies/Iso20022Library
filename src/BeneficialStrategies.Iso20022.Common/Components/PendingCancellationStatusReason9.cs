// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the pending cancellation status.
/// </summary>
[IsoId("_Y1ol8f0wEeiKOe8GCUL1Lg")]
[DisplayName("Pending Cancellation Status Reason")]
public record PendingCancellationStatusReason9
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_ZgCN1f0wEeiKOe8GCUL1Lg")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingCancellationReason6Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_ZgCN3f0wEeiKOe8GCUL1Lg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINMax210Text? AdditionalReasonInformation { get; init; }
}
