// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateFormat12Choice
{
    /// <summary>
    /// Value of the rate not specified.
    /// </summary>
    [IsoId("_uT61WSqiEeObprHJy8Zrxg")]
    [DisplayName("Not Specified Rate")]
    public partial record NotSpecifiedRate : RateFormat12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
