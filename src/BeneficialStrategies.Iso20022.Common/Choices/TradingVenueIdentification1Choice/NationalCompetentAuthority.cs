// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradingVenueIdentification1Choice
{
    /// <summary>
    /// Identification used where reporting entity is a national competent authority.
    /// </summary>
    [IsoId("_-PXYoAkWEeWGouz230Xp5Q")]
    [DisplayName("National Competent Authority")]
    public partial record NationalCompetentAuthority : TradingVenueIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [IsoXmlTag("NtlCmptntAuthrty")]
        public required CountryCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
