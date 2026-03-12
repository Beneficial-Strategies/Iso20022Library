// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DrawdownType2Choice
{
    /// <summary>
    /// Type of drawdown expressed as a code.
    /// </summary>
    [IsoId("_m7wmEZNwEembCsVG-3f_AA")]
    [DisplayName("Code")]
    public partial record Code : DrawdownType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of drawdown.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DrawdownType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
