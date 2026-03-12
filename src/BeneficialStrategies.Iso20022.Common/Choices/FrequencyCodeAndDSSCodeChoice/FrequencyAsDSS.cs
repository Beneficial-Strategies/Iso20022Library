// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FrequencyCodeAndDSSCodeChoice
{
    /// <summary>
    /// Frequency expressed as a data source scheme and a code used within the data source scheme.
    /// </summary>
    [IsoId("_Uuhiotp-Ed-ak6NoX_4Aeg_726684116")]
    [DisplayName("Frequency As DSS")]
    public partial record FrequencyAsDSS : FrequencyCodeAndDSSCodeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_luVtp-Ed-ak6NoX_4Aeg_858746211")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        public required IsoMax8Text Issuer { get; init; } 
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P_luV9p-Ed-ak6NoX_4Aeg_858746099")]
        [DisplayName("Information")]
        [IsoXmlTag("Inf")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Information { get; init; } 
        
        
        #nullable disable
        
    }
}
