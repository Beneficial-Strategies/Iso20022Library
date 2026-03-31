// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the pending status.
/// </summary>
[IsoId("_UZJ7MVhbEeSewsfsZR0hxA")]
[DisplayName("Pending Status Reason")]
public record PendingStatusReason7
{
    /// <summary>
    /// Specifies the reason why the instruction&apos;s processing is pending.
    /// </summary>
    [IsoId("_U0rZg1hbEeSewsfsZR0hxA")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingReason24Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_U0rZi1hbEeSewsfsZR0hxA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
