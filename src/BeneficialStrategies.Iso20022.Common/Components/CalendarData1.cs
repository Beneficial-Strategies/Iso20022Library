// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes information needed to identify a change for a static data, the time when it was performed and the user requesting the change and approving it.
/// </summary>
[IsoId("_dVcQ04m7Eeipw6hHPgB4Sw")]
[DisplayName("Calendar Data")]
public record CalendarData1
{
    /// <summary>
    /// Date for which the calendar information is provided.
    /// </summary>
    [IsoId("_-zQEYom7Eeipw6hHPgB4Sw")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SystemDate { get; init; }

    /// <summary>
    /// Status of the system.
    /// </summary>
    [IsoId("_-zQEY4m7Eeipw6hHPgB4Sw")]
    [DisplayName("System Status")]
    [IsoXmlTag("SysSts")]
    public required SystemStatus3Choice_ SystemStatus { get; init; }
}
