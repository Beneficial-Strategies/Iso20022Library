// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CurrencyOrDigitalTokenAmount2Choice
{
    /// <summary>
    /// Digital Token Amount.
    /// </summary>
    [DisplayName("Digital Token Amount")]
    public partial record DigitalTokenAmount : CurrencyOrDigitalTokenAmount2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DgtlTknAmt")]
        public required DigitalTokenAmount3 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
