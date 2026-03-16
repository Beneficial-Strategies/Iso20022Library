// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Accepted Status2.
/// </summary>
[IsoId("_nM3dIYWAEe-ufOxNNkEXmg")]
[DisplayName("Accepted Status2")]
public record AcceptedStatus2
{
    /// <summary>
    /// Accepted Quantity.
    /// </summary>
    [DisplayName("Accepted Quantity")]
    [IsoXmlTag("AccptdQty")]
    public Quantity51Choice_? AcceptedQuantity { get; init; }

    /// <summary>
    /// Accepted Reason.
    /// </summary>
    [DisplayName("Accepted Reason")]
    [IsoXmlTag("AccptdRsn")]
    public required AcceptedStatus8Choice_ AcceptedReason { get; init; }
}
