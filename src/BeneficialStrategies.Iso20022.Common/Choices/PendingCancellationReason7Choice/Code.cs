// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason7Choice
{
    /// <summary>
    /// Pending reason specified as a code.
    /// </summary>
    [IsoId("_ccJAQbKjEemux5trsZcCpw")]
    [DisplayName("Code")]
    public partial record Code : PendingCancellationReason7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a reason why the cancellation request has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
