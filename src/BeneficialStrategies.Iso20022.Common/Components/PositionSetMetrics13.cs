// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets.
/// </summary>
[IsoId("_jYQGYc-nEeufOvGsyZiDWA")]
[DisplayName("Position Set Metrics")]
public record PositionSetMetrics13
{
    /// <summary>
    /// Numeric variables calculated on the number of transactions or on market exposures.
    /// </summary>
    [IsoId("_jbN60c-nEeufOvGsyZiDWA")]
    [DisplayName("Volume Metrics")]
    [IsoXmlTag("VolMtrcs")]
    public required VolumeMetrics5 VolumeMetrics { get; init; }

    /// <summary>
    /// Numeric variables consisting in interest rates, lending fees or haircuts, calculated as weighted averages.
    /// </summary>
    [IsoId("_jbN608-nEeufOvGsyZiDWA")]
    [DisplayName("Price Metrics")]
    [IsoXmlTag("PricMtrcs")]
    public PriceMetrics3? PriceMetrics { get; init; }
}
