// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationReason36Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [IsoId("_IYQ_MdB7EeihG9bKfarOOA")]
    [DisplayName("Code")]
    public partial record Code : CancellationReason36Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the cancellation status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason16Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
