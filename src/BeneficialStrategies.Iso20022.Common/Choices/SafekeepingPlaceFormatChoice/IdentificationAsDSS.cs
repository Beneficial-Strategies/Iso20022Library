// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormatChoice
{
    /// <summary>
    /// Place of safekeeping expressed with a propriety identification scheme.
    /// </summary>
    [IsoId("_RB5f5tp-Ed-ak6NoX_4Aeg_-292430851")]
    [DisplayName("Identification As DSS")]
    public partial record IdentificationAsDSS : SafekeepingPlaceFormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_b9Wtp-Ed-ak6NoX_4Aeg_691069232")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        public required IsoMax8Text Issuer { get; init; } 
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P_b9W9p-Ed-ak6NoX_4Aeg_691068172")]
        [DisplayName("Information")]
        [IsoXmlTag("Inf")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText Information { get; init; } 
        
        /// <summary>
        /// Additional information.
        /// </summary>
        [IsoId("_P_luUNp-Ed-ak6NoX_4Aeg_691069664")]
        [DisplayName("Narrative")]
        [IsoXmlTag("Nrrtv")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Narrative { get; init; } 
        
        
        #nullable disable
        
    }
}
