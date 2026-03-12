// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AirportName1Choice
{
    /// <summary>
    /// Identifies an airport by its location and by its name.
    /// </summary>
    [IsoId("_SsSlJdp-Ed-ak6NoX_4Aeg_-564217545")]
    [DisplayName("Other Airport Description")]
    public partial record OtherAirportDescription : AirportName1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the town where the airport is located. For example: London.
        /// </summary>
        [IsoId("_SsSlIdp-Ed-ak6NoX_4Aeg_-1352905988")]
        [DisplayName("Town")]
        [IsoXmlTag("Twn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Town { get; init; } 
        
        /// <summary>
        /// Identifies the airport by its name. For example: Heathrow.
        /// </summary>
        [IsoId("_SsSlItp-Ed-ak6NoX_4Aeg_-1308575071")]
        [DisplayName("Airport Name")]
        [IsoXmlTag("AirprtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? AirportName { get; init; } 
        
        
        #nullable disable
        
    }
}
