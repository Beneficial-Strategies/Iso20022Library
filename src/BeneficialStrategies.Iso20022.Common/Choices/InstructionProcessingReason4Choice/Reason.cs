// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingReason4Choice
{
    /// <summary>
    /// Specifies the reason of the InRepairStatus.
    /// </summary>
    [IsoId("_gtxGEwd3Ee2fOITqoTnSLQ")]
    [DisplayName("Reason")]
    public partial record Reason : InstructionProcessingReason4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction is in repair.
        /// </summary>
        [IsoId("_g_M0UQd3Ee2fOITqoTnSLQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RepairReason19Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_g_M0WQd3Ee2fOITqoTnSLQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
