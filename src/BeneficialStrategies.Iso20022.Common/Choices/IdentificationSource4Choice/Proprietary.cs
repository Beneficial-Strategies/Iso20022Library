// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationSource4Choice
{
    /// <summary>
    /// Unique and unambiguous identification source using a proprietary identification scheme.
    /// </summary>
    [IsoId("_uPv-aggWEeCVlvYcV4HKqQ")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : IdentificationSource4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with an exact length of 2 characters that must has a pattern XX|TS.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINExact2Text)]
        public required IsoRestrictedFINExact2Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
