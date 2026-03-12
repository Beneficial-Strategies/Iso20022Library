// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedReason3Choice
{
    /// <summary>
    /// Rejected reason expressed as a code.
    /// </summary>
    [IsoId("_HZZNFBdTEeK5g-3oYI0_9Q")]
    [DisplayName("Code")]
    public partial record Code : RejectedReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectedStatusReason6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
