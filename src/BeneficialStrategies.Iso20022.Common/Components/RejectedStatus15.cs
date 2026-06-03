// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and quantity information related to a rejected instruction request.
/// </summary>
[IsoId("_BkbKsaKtEfCHi7w3_0pcpw")]
[DisplayName("Rejected Status15")]
public record RejectedStatus15
{
    /// <summary>
    /// Quantity of instructed securities for which processing is rejected.
    /// </summary>
    [IsoId("_BqR7EaKtEfCHi7w3_0pcpw")]
    [DisplayName("Rejected Quantity")]
    [IsoXmlTag("RjctdQty")]
    public Quantity51Choice? RejectedQuantity { get; init; }

    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_BqR7E6KtEfCHi7w3_0pcpw")]
    [DisplayName("Rejected Reason")]
    [IsoXmlTag("RjctdRsn")]
    public required RejectedStatus64Choice RejectedReason { get; init; }
}
