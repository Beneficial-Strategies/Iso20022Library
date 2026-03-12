// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradingVenueIdentification1Choice
{
    /// <summary>
    /// Identification used where a venue does not have an already defined code type.
    /// </summary>
    [IsoId("_IkBp4Dd7EeWebbGLlGzH3g")]
    [DisplayName("Other")]
    public partial record Other : TradingVenueIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification field of the submitting entity.
        /// </summary>
        [IsoId("_4sMdk10hEeWErPfQ7BYx8A")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max50Text)]
        [StringLength(maximumLength: 50 ,MinimumLength = 1)]
        public required IsoMax50Text Identification { get; init; } 
        
        /// <summary>
        /// Code list of venues to populate free form text identification.
        /// </summary>
        [IsoId("_4sMdkV0hEeWErPfQ7BYx8A")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required TradingVenue2Code Type { get; init; } 
        
        
        #nullable disable
        
    }
}
