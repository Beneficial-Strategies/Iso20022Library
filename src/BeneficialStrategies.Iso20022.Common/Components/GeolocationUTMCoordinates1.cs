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
/// Location on the Earth specified by the Universal Transverse Mercator coordinate system.
/// Identifies the geographic location using the WGS84 ellipsoid spatial reference system.
/// </summary>
[IsoId("_IRYb8Nj-EeiojJsa6FYyew")]
[DisplayName("Geolocation UTM Coordinates")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeolocationUTMCoordinates1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GeolocationUTMCoordinates1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GeolocationUTMCoordinates1( System.String reqUTMZone,System.String reqUTMEastward,System.String reqUTMNorthward )
    {
        UTMZone = reqUTMZone;
        UTMEastward = reqUTMEastward;
        UTMNorthward = reqUTMNorthward;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// UTM grid zone combination of the longitude zone (1 to 60) and the latitude band (C to X, excluding I and O).
    /// </summary>
    [IsoId("_S03o0Nj-EeiojJsa6FYyew")]
    [DisplayName("UTM Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTMZone")]
    #endif
    [IsoXmlTag("UTMZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text UTMZone { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UTMZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UTMZone { get; init; } 
    #else
    public System.String UTMZone { get; set; } 
    #endif
    
    /// <summary>
    /// X-coordinate of the Universal Transverse Mercator 
    /// coordinate system.
    /// </summary>
    [IsoId("_bxdJUNj-EeiojJsa6FYyew")]
    [DisplayName("UTM Eastward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTMEstwrd")]
    #endif
    [IsoXmlTag("UTMEstwrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text UTMEastward { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UTMEastward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UTMEastward { get; init; } 
    #else
    public System.String UTMEastward { get; set; } 
    #endif
    
    /// <summary>
    /// Y-coordinate of the Universal Transverse Mercator 
    /// coordinate system.
    /// </summary>
    [IsoId("_iqNJ0Nj-EeiojJsa6FYyew")]
    [DisplayName("UTM Northward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTMNrthwrd")]
    #endif
    [IsoXmlTag("UTMNrthwrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text UTMNorthward { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UTMNorthward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UTMNorthward { get; init; } 
    #else
    public System.String UTMNorthward { get; set; } 
    #endif
    
    
    #nullable disable
    
}
