// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity47Choice
{
    /// <summary>
    /// Textual description of the delivery quantity.
    /// </summary>
    [IsoId("_cAW1Y5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Description")]
    public partial record Description : Quantity47Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 52 characters.
        /// </summary>
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
