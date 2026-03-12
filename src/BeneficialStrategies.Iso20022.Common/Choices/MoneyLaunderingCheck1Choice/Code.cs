// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MoneyLaunderingCheck1Choice
{
    /// <summary>
    /// Money laundering status expressed as a code.
    /// </summary>
    [IsoId("_PZS2KBdDEeK5g-3oYI0_9Q")]
    [DisplayName("Code")]
    public partial record Code : MoneyLaunderingCheck1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of money laundering identification procedures.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MoneyLaunderingCheck1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
