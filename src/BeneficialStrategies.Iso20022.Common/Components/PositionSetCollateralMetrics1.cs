// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for collateral position sets and currency collateral position sets reports.
/// </summary>
[IsoId("_imt2X8WJEeiRga8tPu1L4Q")]
[DisplayName("Position Set Collateral Metrics")]
public record PositionSetCollateralMetrics1
{
    /// <summary>
    /// Total values by the reporting counterparty to the other counterparty.
    /// Usage: Where the value is on a portfolio basis, this field should include the overall value  posted for the portfolio.
    /// </summary>
    [IsoId("_2AU54sWKEeiRga8tPu1L4Q")]
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public PositionSetCollateralTotal1? Total { get; init; }

    /// <summary>
    /// Clean values by the reporting counterparty to the other counterparty with outliers removed.
    /// Usage: Where the value is on a portfolio basis, this field should include the overall value posted for the portfolio.
    /// </summary>
    [IsoId("_2AU548WKEeiRga8tPu1L4Q")]
    [DisplayName("Clean")]
    [IsoXmlTag("Clean")]
    public PositionSetCollateralTotal1? Clean { get; init; }
}
