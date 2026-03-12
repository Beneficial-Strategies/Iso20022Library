// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderWaiverReason3Choice
{
    /// <summary>
    /// Reason for the waiver expressed as a code.
    /// </summary>
    [IsoId("_PibkEToREeabspMEjqY5TQ")]
    [DisplayName("Code")]
    public partial record Code : OrderWaiverReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Relates to non-standard orders, to handle them differently, probably in a manual fashion.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OrderWaiverReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
