// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingOpeningStatusReason2Choice
{
    /// <summary>
    /// Reason for the pending account opening status expressed as a code.
    /// </summary>
    [IsoId("_xb8YQWCJEeabZtzjEVWYCQ")]
    [DisplayName("Code")]
    public partial record Code : PendingOpeningStatusReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a pending account opening status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingOpeningStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
