// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and quantity information related to a pending instruction request.
/// </summary>
[IsoId("_JWF6waKuEfCHi7w3_0pcpw")]
[DisplayName("Pending Status3")]
public record PendingStatus3
{
    /// <summary>
    /// Quantity of instructed securities for which processing is pending.
    /// </summary>
    [IsoId("_JcT3gaKuEfCHi7w3_0pcpw")]
    [DisplayName("Pending Quantity")]
    [IsoXmlTag("PdgQty")]
    public Quantity51Choice? PendingQuantity { get; init; }

    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_JcT3g6KuEfCHi7w3_0pcpw")]
    [DisplayName("Pending Reason")]
    [IsoXmlTag("PdgRsn")]
    public required PendingStatus80Choice PendingReason { get; init; }
}
