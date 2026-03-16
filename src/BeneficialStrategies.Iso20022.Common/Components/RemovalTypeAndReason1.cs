// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the removal type, the reason, the exclusion period, the extension date and the termination date.
/// </summary>
[IsoId("_50I1UPolEeiAfJEqh4xF_Q")]
[DisplayName("Removal Type And Reason")]
public record RemovalTypeAndReason1
{
    /// <summary>
    /// Specifies the removal processing change requested.
    /// </summary>
    [IsoId("_FKebcPomEeiAfJEqh4xF_Q")]
    [DisplayName("Removal Type")]
    [IsoXmlTag("RmvlTp")]
    public required Removal1Choice_ RemovalType { get; init; }

    /// <summary>
    /// Identifies the reason for the removal, the extension of the removal or the termination of the removal.
    /// </summary>
    [IsoId("_HcgTAfonEeiAfJEqh4xF_Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public GenericIdentification30? Reason { get; init; }

    /// <summary>
    /// Identifies the period, the start date or the end date of the exclusion period.
    /// </summary>
    [IsoId("_RRHq4forEeiAfJEqh4xF_Q")]
    [DisplayName("Exclusion Period")]
    [IsoXmlTag("ExclsnPrd")]
    public DateOrDateTimePeriod3Choice_? ExclusionPeriod { get; init; }
}
