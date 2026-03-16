// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Amount4Choice
{
    /// <summary>
    /// Increase Amount.
    /// </summary>
    [DisplayName("Increase Amount")]
    public partial record IncreaseAmount : Amount4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IncrAmt")]
        public required Amount2Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
