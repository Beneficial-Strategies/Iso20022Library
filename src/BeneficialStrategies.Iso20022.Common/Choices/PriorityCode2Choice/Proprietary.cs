// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriorityCode2Choice
{
    /// <summary>
    /// Priority code bilaterally agreed between parties.
    /// </summary>
    [IsoId("_74UMtKMgEeCJ6YNENx4h-w_1712573446")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : PriorityCode2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
