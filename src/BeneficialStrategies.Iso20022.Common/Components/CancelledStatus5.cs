// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancelled Status5.
/// </summary>
[IsoId("_aeMLEYWAEe-ufOxNNkEXmg")]
[DisplayName("Cancelled Status5")]
public record CancelledStatus5
{
    /// <summary>
    /// Cancellation Reason.
    /// </summary>
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancelledStatus12Choice_ CancellationReason { get; init; }

    /// <summary>
    /// Cancelled Quantity.
    /// </summary>
    [DisplayName("Cancelled Quantity")]
    [IsoXmlTag("CancQty")]
    public Quantity51Choice_? CancelledQuantity { get; init; }
}
