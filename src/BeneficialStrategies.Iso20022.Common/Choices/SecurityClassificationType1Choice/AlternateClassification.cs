// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityClassificationType1Choice
{
    /// <summary>
    /// Other type of classification of the financial instrument.
    /// </summary>
    [IsoId("_Q7pG49p-Ed-ak6NoX_4Aeg_-1089755250")]
    [DisplayName("Alternate Classification")]
    public partial record AlternateClassification : SecurityClassificationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
        /// </summary>
        [IsoId("_P-sWctp-Ed-ak6NoX_4Aeg_1256785338")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P-sWc9p-Ed-ak6NoX_4Aeg_1555083105")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; } 
        
        
        #nullable disable
        
    }
}
