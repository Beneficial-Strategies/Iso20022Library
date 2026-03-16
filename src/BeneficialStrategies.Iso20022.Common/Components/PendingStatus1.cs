// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pending Status1.
/// </summary>
[IsoId("_XZkHAYWBEe-ufOxNNkEXmg")]
[DisplayName("Pending Status1")]
public record PendingStatus1
{
    /// <summary>
    /// Pending Quantity.
    /// </summary>
    [DisplayName("Pending Quantity")]
    [IsoXmlTag("PdgQty")]
    public Quantity51Choice_? PendingQuantity { get; init; }

    /// <summary>
    /// Pending Reason.
    /// </summary>
    [DisplayName("Pending Reason")]
    [IsoXmlTag("PdgRsn")]
    public required PendingStatus71Choice_ PendingReason { get; init; }
}
