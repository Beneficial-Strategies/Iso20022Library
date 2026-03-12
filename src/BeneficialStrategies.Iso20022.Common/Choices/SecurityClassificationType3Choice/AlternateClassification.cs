// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityClassificationType3Choice
{
    /// <summary>
    /// Other type of classification of the financial instrument.
    /// </summary>
    [IsoId("_SimIQ_35EeimOuZbLgw0bg")]
    [DisplayName("Alternate Classification")]
    public partial record AlternateClassification : SecurityClassificationType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary information issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_7MqLRRHnEeG9eo4v8X6Ubw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINMax30Text)]
        [StringLength(maximumLength: 30 ,MinimumLength = 1)]
        public required IsoRestrictedFINMax30Text Identification { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_7MqLSRHnEeG9eo4v8X6Ubw")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINMax8Text)]
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        public IsoRestrictedFINMax8Text? Issuer { get; init; } 
        
        
        #nullable disable
        
    }
}
