// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pending Status2.
/// </summary>
[IsoId("_s7SzsZzmEe-DHYbvdRjdbA")]
[DisplayName("Pending Status2")]
public record PendingStatus2
{
    /// <summary>
    /// Pending Quantity.
    /// </summary>
    [DisplayName("Pending Quantity")]
    [IsoXmlTag("PdgQty")]
    public Quantity54Choice_? PendingQuantity { get; init; }

    /// <summary>
    /// Pending Reason.
    /// </summary>
    [DisplayName("Pending Reason")]
    [IsoXmlTag("PdgRsn")]
    public required PendingStatus76Choice_ PendingReason { get; init; }
}
