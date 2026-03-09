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
[IsoId("_hshvcQ0yEeqUVL7sB4m7NA")]
[DisplayName("Login Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoginResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoginResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoginResponse2( System.DateTime reqPOIDateTime )
    {
        POIDateTime = reqPOIDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    [IsoId("_h4V94Q0yEeqUVL7sB4m7NA")]
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
    [IsoId("_h4V94w0yEeqUVL7sB4m7NA")]
    [DisplayName("POI Software")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POISftwr")]
    #endif
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent10> POISoftware { get; init; } = new ValueList<PointOfInteractionComponent10>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _h4V94w0yEeqUVL7sB4m7NA
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_h4V95Q0yEeqUVL7sB4m7NA")]
    [DisplayName("POI Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICpblties")]
    #endif
    [IsoXmlTag("POICpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    #else
    public PointOfInteractionCapabilities9? POICapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_utBKQQ0yEeqUVL7sB4m7NA")]
    [DisplayName("Output Display")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptDisp")]
    #endif
    [IsoXmlTag("OutptDisp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage7? OutputDisplay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage7? OutputDisplay { get; init; } 
    #else
    public ActionMessage7? OutputDisplay { get; set; } 
    #endif
    
    
    #nullable disable
    
}
