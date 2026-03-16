// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details for a specific date on the daily data on settlement fails instructions.
/// </summary>
[IsoId("_XevB0TOqEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily Data")]
public record SettlementFailsDailyData3
{
    /// <summary>
    /// Date for each reporting day in the month.
    /// </summary>
    [IsoId("_XfxjoTOqEeqX8uoQQ3KffQ")]
    [DisplayName("Reporting Date")]
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReportingDate { get; init; }

    /// <summary>
    /// Data related to the failed settlement instructions for the reporting date.
    /// </summary>
    [IsoId("_XfxjozOqEeqX8uoQQ3KffQ")]
    [DisplayName("Daily Record")]
    [IsoXmlTag("DalyRcrd")]
    public required SettlementFailsDailyInstrument3 DailyRecord { get; init; }
}
