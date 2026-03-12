// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionRejectionStatus1Choice
{
    /// <summary>
    /// Reason advising the rejection of the instruction in the form of a code.
    /// </summary>
    [IsoId("_RCfVxtp-Ed-ak6NoX_4Aeg_-867514428")]
    [DisplayName("Code")]
    public partial record Code : InstructionRejectionStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction/cancellation request has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
