// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reasons for a pending instruction status.
/// </summary>
[IsoId("_RlhqUbMVEfCEXew4g5B5oA")]
[DisplayName("Pending Status Reason34")]
public record PendingStatusReason34
{
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_RsZuY7MVEfCEXew4g5B5oA")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingReason81Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    [IsoId("_RsZua7MVEfCEXew4g5B5oA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax350Text? AdditionalReasonInformation { get; init; }
}
