// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Metrics14.
/// </summary>
[IsoId("_7JD5QRTuEe61h9tfoUrWyw")]
[DisplayName("Position Set Metrics14")]
public record PositionSetMetrics14
{
    /// <summary>
    /// Clean.
    /// </summary>
    [DisplayName("Clean")]
    [IsoXmlTag("Clean")]
    public PositionSetBuyerAndSeller2? Clean { get; init; }

    /// <summary>
    /// Total.
    /// </summary>
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public PositionSetBuyerAndSeller2? Total { get; init; }
}
