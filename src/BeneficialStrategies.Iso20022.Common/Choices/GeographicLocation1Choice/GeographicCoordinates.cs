// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.GeographicLocation1Choice
{
    /// <summary>
    /// Location on the earth specified by two numbers representing vertical and horizontal position.
    /// </summary>
    [IsoId("_hutYMIn5EeShMpas3885ww")]
    [DisplayName("Geographic Coordinates")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record GeographicCoordinates : GeographicLocation1Choice_
    #else
    public partial class GeographicCoordinates : GeographicLocation1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a GeographicCoordinates instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public GeographicCoordinates( System.String reqLatitude,System.String reqLongitude )
        {
            Latitude = reqLatitude;
            Longitude = reqLongitude;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Latitude measured in degrees, minutes and seconds, following by &apos;N&apos; for the north and &apos;S&apos; for the south of the equator (for example 48°51&apos;29&quot; N for the Eiffel Tower latitude).
        /// </summary>
        [IsoId("_WtE2wIn5EeShMpas3885ww")]
        [DisplayName("Latitude")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Lat")]
        #endif
        [IsoXmlTag("Lat")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax16Text Latitude { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Latitude { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Latitude { get; init; } 
        #else
        public System.String Latitude { get; set; } 
        #endif
        
        /// <summary>
        /// Angular measurement of the distance of a location on the earth east or west of the Greenwich observatory.
        /// The longitude is measured in degrees, minutes and seconds, following by &apos;E&apos; for the east and &apos;W&apos; for the west (for example 2°17&apos;40&quot; E for the Eiffel Tower longitude).
        /// </summary>
        [IsoId("_a-iE4In5EeShMpas3885ww")]
        [DisplayName("Longitude")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Long")]
        #endif
        [IsoXmlTag("Long")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax16Text Longitude { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Longitude { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Longitude { get; init; } 
        #else
        public System.String Longitude { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
