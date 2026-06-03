// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a pending cancellation status.
/// </summary>
[IsoId("_dNYZMa8uEfCx2aBifPEdRg")]
[DisplayName("Pending Cancellation Status Reason14")]
public record PendingCancellationStatusReason14
{
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_dUfGxa8uEfCx2aBifPEdRg")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingCancellationReason7Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    [IsoId("_dUfGza8uEfCx2aBifPEdRg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax350Text? AdditionalReasonInformation { get; init; }
}
