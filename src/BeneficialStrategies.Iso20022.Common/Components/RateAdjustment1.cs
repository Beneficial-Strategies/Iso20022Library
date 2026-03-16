// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the rate adjustments as determined by the rate schedule.
/// </summary>
[IsoId("_D6Df4CDwEeahCJeThTBhHA")]
[DisplayName("Rate Adjustment")]
public record RateAdjustment1
{
    /// <summary>
    /// Specifies the rate as determined by the rate schedule.
    /// </summary>
    [IsoId("_J3YZ8CDwEeahCJeThTBhHA")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }

    /// <summary>
    /// Specifies date as of which the rate is effective.
    /// </summary>
    [IsoId("_OaFwICDwEeahCJeThTBhHA")]
    [DisplayName("Adjustment Date")]
    [IsoXmlTag("AdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate AdjustmentDate { get; init; }
}
