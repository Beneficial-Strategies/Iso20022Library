// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on market exposures.
/// </summary>
[IsoId("_zg_J065QEeuo-IflVgGqiA")]
[DisplayName("Exposure Metrics")]
public record ExposureMetrics6
{
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [IsoId("_zwe-Ya5QEeuo-IflVgGqiA")]
    [DisplayName("Posted Margin Or Collateral")]
    [IsoXmlTag("PstdMrgnOrColl")]
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; }
}
