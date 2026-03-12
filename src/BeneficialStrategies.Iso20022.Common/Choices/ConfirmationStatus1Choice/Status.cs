// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConfirmationStatus1Choice
{
    /// <summary>
    /// Status of the order confirmation is accepted or received or sent to next party or there is a communication problem with next party. There is no reason attached.
    /// </summary>
    [IsoId("_1BFlFUhCEea8pJjypp-yMQ")]
    [DisplayName("Status")]
    public partial record Status : ConfirmationStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the current status of an order confirmation or of an order confirmation amendment.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required OrderConfirmationStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
