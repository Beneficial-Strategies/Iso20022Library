// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConsentOrRejectionReason5Choice
{
    /// <summary>
    /// Specifies the reason why the counterparty response has a rejection status.
    /// </summary>
    [IsoId("_Vl2wT5NSEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : ConsentOrRejectionReason5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of counterparty&apos;s action the response is related to.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CounterpartyResponseStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
