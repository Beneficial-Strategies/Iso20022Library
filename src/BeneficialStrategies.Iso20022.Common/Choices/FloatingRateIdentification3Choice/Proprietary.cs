// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FloatingRateIdentification3Choice
{
    /// <summary>
    /// Defines a floating rate which is not included in the list of predefined floating curves.
    /// </summary>
    [IsoId("_GRIIQw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : FloatingRateIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 350 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
