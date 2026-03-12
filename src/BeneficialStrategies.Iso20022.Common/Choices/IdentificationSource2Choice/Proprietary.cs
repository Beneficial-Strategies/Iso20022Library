// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationSource2Choice
{
    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    [IsoId("_XKZIJNp-Ed-ak6NoX_4Aeg_-819984102")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : IdentificationSource2Choice_
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
