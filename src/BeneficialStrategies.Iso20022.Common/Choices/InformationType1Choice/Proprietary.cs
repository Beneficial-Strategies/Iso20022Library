// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InformationType1Choice
{
    /// <summary>
    /// Type of additional information not catered for by the available codes.
    /// </summary>
    [IsoId("_RYGZYdp-Ed-ak6NoX_4Aeg_603460919")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : InformationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 140 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public required IsoMax140Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
