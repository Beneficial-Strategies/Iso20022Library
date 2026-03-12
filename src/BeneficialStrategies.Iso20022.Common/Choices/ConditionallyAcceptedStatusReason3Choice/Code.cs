// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConditionallyAcceptedStatusReason3Choice
{
    /// <summary>
    /// Conditionally accepted reason expressed as a code.
    /// </summary>
    [IsoId("_JgUNAEHaEeamVPoS58KxXA")]
    [DisplayName("Code")]
    public partial record Code : ConditionallyAcceptedStatusReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a conditionally accepted status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConditionallyAcceptedStatusReason2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
