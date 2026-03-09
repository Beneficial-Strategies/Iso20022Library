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
/// Geographic location specified by geographic or UTM coordinates.
/// </summary>
[IsoId("_4ORaINj8EeiojJsa6FYyew")]
[DisplayName("Geolocation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Geolocation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Geographic location specified by geographic coordinates.
    /// </summary>
    [IsoId("_A7PU0Nj-EeiojJsa6FYyew")]
    [DisplayName("Geographic Coordinates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GeogcCordints")]
    #endif
    [IsoXmlTag("GeogcCordints")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GeolocationGeographicCoordinates1? GeographicCoordinates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeolocationGeographicCoordinates1? GeographicCoordinates { get; init; } 
    #else
    public GeolocationGeographicCoordinates1? GeographicCoordinates { get; set; } 
    #endif
    
    /// <summary>
    /// Geographic location specified by UTM coordinates.
    /// </summary>
    [IsoId("_wMXuUNj-EeiojJsa6FYyew")]
    [DisplayName("UTM Coordinates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTMCordints")]
    #endif
    [IsoXmlTag("UTMCordints")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GeolocationUTMCoordinates1? UTMCoordinates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeolocationUTMCoordinates1? UTMCoordinates { get; init; } 
    #else
    public GeolocationUTMCoordinates1? UTMCoordinates { get; set; } 
    #endif
    
    
    #nullable disable
    
}
