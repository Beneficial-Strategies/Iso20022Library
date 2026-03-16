// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CurrencyOrDigitalTokenAmount2Choice
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    public partial record Amount : CurrencyOrDigitalTokenAmount2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Amt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; } 
        
        
        #nullable disable
        
    }
}
