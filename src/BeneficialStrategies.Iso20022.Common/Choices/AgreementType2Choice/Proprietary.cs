// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AgreementType2Choice
{
    /// <summary>
    /// Name of the identification scheme, in a free text form.
    /// </summary>
    [IsoId("_OI9M0y4yEeuxhbw_aW6haw")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : AgreementType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 50 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max50Text)]
        [StringLength(maximumLength: 50 ,MinimumLength = 1)]
        public required IsoMax50Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
