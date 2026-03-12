// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateOrName2Choice
{
    /// <summary>
    /// Pricing expressed as a rate name.
    /// </summary>
    [IsoId("_XO3YeNp-Ed-ak6NoX_4Aeg_-1288656582")]
    [DisplayName("Rate Name")]
    public partial record RateName : RateOrName2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_XO3YdNp-Ed-ak6NoX_4Aeg_-5894558")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax8Text)]
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax8Text? Issuer { get; init; } 
        
        /// <summary>
        /// Rate Name specifies the reference rate or basis rate on which a variable rate is based (ex: EONIA, EURIBOR, LIBOR, FEFUND, EURREPO).
        /// </summary>
        [IsoXmlTag("RateNm")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax24Text)]
        [StringLength(maximumLength: 24 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax24Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
