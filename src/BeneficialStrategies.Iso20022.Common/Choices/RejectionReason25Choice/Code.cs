// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason25Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejection status using a code.
    /// </summary>
    [IsoId("_e9ksYTt5EeW638lNyHKv7A")]
    [DisplayName("Code")]
    public partial record Code : RejectionReason25Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the settlement instruction has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason40Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
