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
/// Location on the Earth specified by two numbers representing vertical and horizontal position.
/// </summary>
[IsoId("_S4tccNj9EeiojJsa6FYyew")]
[DisplayName("Geolocation Geographic Coordinates")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeolocationGeographicCoordinates1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GeolocationGeographicCoordinates1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GeolocationGeographicCoordinates1( System.String reqLatitude,System.String reqLongitude )
    {
        Latitude = reqLatitude;
        Longitude = reqLongitude;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Angular distance of a location on the earth south or north of the equator.
    /// The latitude is measured in degrees, minutes and seconds, following by &quot;N&quot; for the north and &quot;S&quot; for the south of the equator. For example: 48°51&apos;29&quot; N the Eiffel Tower latitude.
    /// </summary>
    [IsoId("_enk3UNj9EeiojJsa6FYyew")]
    [DisplayName("Latitude")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lat")]
    #endif
    [IsoXmlTag("Lat")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Latitude { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Latitude { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Latitude { get; init; } 
    #else
    public System.String Latitude { get; set; } 
    #endif
    
    /// <summary>
    /// Angular measurement of the distance of a location on the earth east or west of the Greenwich observatory.
    /// The longitude is measured in degrees, minutes and seconds, following by &quot;E&quot; for the east and &quot;W&quot; for the west. For example: 23°27&apos;30&quot; E.
    /// </summary>
    [IsoId("_o1RaYNj9EeiojJsa6FYyew")]
    [DisplayName("Longitude")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Long")]
    #endif
    [IsoXmlTag("Long")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Longitude { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Longitude { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Longitude { get; init; } 
    #else
    public System.String Longitude { get; set; } 
    #endif
    
    
    #nullable disable
    
}
