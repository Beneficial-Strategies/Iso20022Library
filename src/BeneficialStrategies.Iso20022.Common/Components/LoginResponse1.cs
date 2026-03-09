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
/// Content of the Login Response message.
/// </summary>
[IsoId("_oud7oN6LEeiwsev40qZGEQ")]
[DisplayName("Login Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoginResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoginResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoginResponse1( System.DateTime reqPOIDateTime )
    {
        POIDateTime = reqPOIDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    [IsoId("_v7TVwN6LEeiwsev40qZGEQ")]
    [DisplayName("POI Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIDtTm")]
    #endif
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime POIDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime POIDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime POIDateTime { get; init; } 
    #else
    public System.DateTime POIDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_yzUEsN6LEeiwsev40qZGEQ")]
    [DisplayName("POI Software")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POISftwr")]
    #endif
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent9> POISoftware { get; init; } = new ValueList<PointOfInteractionComponent9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _yzUEsN6LEeiwsev40qZGEQ
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_14FdQN6LEeiwsev40qZGEQ")]
    [DisplayName("POI Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICpblties")]
    #endif
    [IsoXmlTag("POICpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionCapabilities8? POICapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionCapabilities8? POICapabilities { get; init; } 
    #else
    public PointOfInteractionCapabilities8? POICapabilities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
