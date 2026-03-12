// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason4Choice
{
    /// <summary>
    /// Standard code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [IsoId("_ce_gxZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : PendingCancellationReason4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Standard code to specify.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
