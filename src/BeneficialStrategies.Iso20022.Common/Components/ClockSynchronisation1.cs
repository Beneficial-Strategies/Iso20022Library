// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters to synchronise a real time clock.
/// </summary>
[IsoId("_2S7tMEeUEeODR7vDcYOqmg")]
[DisplayName("Clock Synchronisation")]
public record ClockSynchronisation1
{
    /// <summary>
    /// Name of the time zone where is located the POI (Point Of Interaction), as definined by the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_LwD9IEeVEeODR7vDcYOqmg")]
    [DisplayName("POI Time Zone")]
    [IsoXmlTag("POITmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text POITimeZone { get; init; }

    /// <summary>
    /// Parameters to contact a time server.
    /// </summary>
    [IsoId("_Spmn0EeVEeODR7vDcYOqmg")]
    [DisplayName("Synchronisation Server")]
    [IsoXmlTag("SynctnSvr")]
    public NetworkParameters2? SynchronisationServer { get; init; }
}
