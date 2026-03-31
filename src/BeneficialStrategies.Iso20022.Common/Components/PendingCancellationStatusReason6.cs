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
[IsoId("_ce_gq5KQEeWHWpTQn1FFVg")]
[DisplayName("Pending Cancellation Status Reason")]
public record PendingCancellationStatusReason6
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_ce_gsZKQEeWHWpTQn1FFVg")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingCancellationReason4Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_ce_guZKQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
}
