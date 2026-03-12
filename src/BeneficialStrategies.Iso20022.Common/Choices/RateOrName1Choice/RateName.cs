// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateOrName1Choice
{
    /// <summary>
    /// Pricing expressed as a rate name.
    /// </summary>
    [IsoId("_Q-xTatp-Ed-ak6NoX_4Aeg_-1877843628")]
    [DisplayName("Rate Name")]
    public partial record RateName : RateOrName1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_Q-niZtp-Ed-ak6NoX_4Aeg_-1174778268")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        public IsoMax8Text? Issuer { get; init; } 
        
        /// <summary>
        /// Rate Name specifies the reference rate or basis rate on which a variable rate is based (ex: EONIA, EURIBOR, LIBOR, FEFUND, EURREPO).
        /// </summary>
        [IsoXmlTag("RateNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
