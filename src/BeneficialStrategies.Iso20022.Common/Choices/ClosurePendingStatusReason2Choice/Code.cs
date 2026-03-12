// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosurePendingStatusReason2Choice
{
    /// <summary>
    /// Reason for the closure pending status expressed as a code.
    /// </summary>
    [IsoId("_9J7XcWCLEeabZtzjEVWYCQ")]
    [DisplayName("Code")]
    public partial record Code : ClosurePendingStatusReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the closure pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ClosurePendingStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
