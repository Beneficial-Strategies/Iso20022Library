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
/// Location on the Earth specified by the Universal Transverse Mercator coordinate system, using the WGS84 geodesic system.
/// </summary>
[IsoId("_wETkwIn5EeShMpas3885ww")]
[DisplayName("UTM Coordinates")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UTMCoordinates1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UTMCoordinates1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UTMCoordinates1( System.String reqUTMZone,System.UInt64 reqUTMEastward,System.UInt64 reqUTMNorthward )
    {
        UTMZone = reqUTMZone;
        UTMEastward = reqUTMEastward;
        UTMNorthward = reqUTMNorthward;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// UTM grid zone combination of the longitude zone (1 to 60) and the latitude band, C to X, excluding I and O (for example Eiffel tower UTM zone is 31U).
    /// </summary>
    [IsoId("_4AW1UIn5EeShMpas3885ww")]
    [DisplayName("UTM Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTMZone")]
    #endif
    [IsoXmlTag("UTMZone")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text UTMZone { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UTMZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UTMZone { get; init; } 
    #else
    public System.String UTMZone { get; set; } 
    #endif
    
    /// <summary>
    /// X-coordinate of the Universal Transverse Mercator coordinate system in meters (for example 448 265m for Eiffel Tower X-coordinate).
    /// </summary>
    [IsoId("_7o5CQIn5EeShMpas3885ww")]
    [DisplayName("UTM Eastward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTMEstwrd")]
    #endif
    [IsoXmlTag("UTMEstwrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber UTMEastward { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 UTMEastward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 UTMEastward { get; init; } 
    #else
    public System.UInt64 UTMEastward { get; set; } 
    #endif
    
    /// <summary>
    /// Y-coordinate of the Universal Transverse Mercator coordinate system (for example 5 411 920m for Eiffel Tower Y-coordinate).
    /// </summary>
    [IsoId("_--JG0In5EeShMpas3885ww")]
    [DisplayName("UTM Northward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTMNrthwrd")]
    #endif
    [IsoXmlTag("UTMNrthwrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber UTMNorthward { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 UTMNorthward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 UTMNorthward { get; init; } 
    #else
    public System.UInt64 UTMNorthward { get; set; } 
    #endif
    
    
    #nullable disable
    
}
