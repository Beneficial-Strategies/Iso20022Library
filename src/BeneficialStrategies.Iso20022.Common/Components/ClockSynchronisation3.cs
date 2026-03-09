// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters to synchronise a real time clock.
/// </summary>
[IsoId("_cBJKsQ0WEeqUVL7sB4m7NA")]
[DisplayName("Clock Synchronisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClockSynchronisation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClockSynchronisation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClockSynchronisation3( System.String reqPOITimeZone )
    {
        POITimeZone = reqPOITimeZone;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the time zone where is located the POI (Point Of Interaction), as definined by the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_cMQ1kQ0WEeqUVL7sB4m7NA")]
    [DisplayName("POI Time Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POITmZone")]
    #endif
    [IsoXmlTag("POITmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text POITimeZone { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String POITimeZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String POITimeZone { get; init; } 
    #else
    public System.String POITimeZone { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters to contact a time server.
    /// </summary>
    [IsoId("_cMQ1kw0WEeqUVL7sB4m7NA")]
    [DisplayName("Synchronisation Server")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SynctnSvr")]
    #endif
    [IsoXmlTag("SynctnSvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters7? SynchronisationServer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters7? SynchronisationServer { get; init; } 
    #else
    public NetworkParameters7? SynchronisationServer { get; set; } 
    #endif
    
    /// <summary>
    /// Delay between two contacts of the server.
    /// </summary>
    [IsoId("_cMQ1lQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Delay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dely")]
    #endif
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Delay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Delay { get; init; } 
    #else
    public System.TimeOnly? Delay { get; set; } 
    #endif
    
    
    #nullable disable
    
}
