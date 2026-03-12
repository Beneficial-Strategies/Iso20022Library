// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GeographicLocation1Choice
{
    /// <summary>
    /// Location on the earth specified by two numbers representing vertical and horizontal position.
    /// </summary>
    [IsoId("_hutYMIn5EeShMpas3885ww")]
    [DisplayName("Geographic Coordinates")]
    public partial record GeographicCoordinates : GeographicLocation1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Latitude measured in degrees, minutes and seconds, following by &apos;N&apos; for the north and &apos;S&apos; for the south of the equator (for example 48°51&apos;29&quot; N for the Eiffel Tower latitude).
        /// </summary>
        [IsoId("_WtE2wIn5EeShMpas3885ww")]
        [DisplayName("Latitude")]
        [IsoXmlTag("Lat")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public required IsoMax16Text Latitude { get; init; } 
        
        /// <summary>
        /// Angular measurement of the distance of a location on the earth east or west of the Greenwich observatory.
        /// The longitude is measured in degrees, minutes and seconds, following by &apos;E&apos; for the east and &apos;W&apos; for the west (for example 2°17&apos;40&quot; E for the Eiffel Tower longitude).
        /// </summary>
        [IsoId("_a-iE4In5EeShMpas3885ww")]
        [DisplayName("Longitude")]
        [IsoXmlTag("Long")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public required IsoMax16Text Longitude { get; init; } 
        
        
        #nullable disable
        
    }
}
