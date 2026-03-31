// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_t0oSlcWEEeiRga8tPu1L4Q")]
[DisplayName("Position Set Metrics")]
public record PositionSetMetrics1
{
    /// <summary>
    /// Refers to the total number of trades contained in the position set.
    /// </summary>
    [IsoId("_t0oSoMWEEeiRga8tPu1L4Q")]
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public PositionSetBuyerAndSeller1? Total { get; init; }

    /// <summary>
    /// Refers to the aggregated number of trades contained in the position set.
    /// </summary>
    [IsoId("_t0oSo8WEEeiRga8tPu1L4Q")]
    [DisplayName("Clean")]
    [IsoXmlTag("Clean")]
    public PositionSetBuyerAndSeller1? Clean { get; init; }
}
