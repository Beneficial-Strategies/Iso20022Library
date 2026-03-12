// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters to synchronise a real time clock.
/// </summary>
[IsoId("_cBJKsQ0WEeqUVL7sB4m7NA")]
[DisplayName("Clock Synchronisation")]
public partial record ClockSynchronisation3
{
    #nullable enable
    
    /// <summary>
    /// Name of the time zone where is located the POI (Point Of Interaction), as definined by the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_cMQ1kQ0WEeqUVL7sB4m7NA")]
    [DisplayName("POI Time Zone")]
    [IsoXmlTag("POITmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text POITimeZone { get; init; } 
    
    /// <summary>
    /// Parameters to contact a time server.
    /// </summary>
    [IsoId("_cMQ1kw0WEeqUVL7sB4m7NA")]
    [DisplayName("Synchronisation Server")]
    [IsoXmlTag("SynctnSvr")]
    public NetworkParameters7? SynchronisationServer { get; init; } 
    
    /// <summary>
    /// Delay between two contacts of the server.
    /// </summary>
    [IsoId("_cMQ1lQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Delay")]
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Delay { get; init; } 
    
    
    #nullable disable
    
}
