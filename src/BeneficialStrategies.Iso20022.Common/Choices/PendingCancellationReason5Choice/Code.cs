// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason5Choice
{
    /// <summary>
    /// Standard code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [IsoId("_2t4r4YluEeavwKddCbm3hg")]
    [DisplayName("Code")]
    public partial record Code : PendingCancellationReason5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the cancellation request has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
