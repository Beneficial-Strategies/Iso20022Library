// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus54Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_NpuWQl99Ee262vCSVgjImg")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedStatus54Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been rejected.
        /// </summary>
        [IsoId("_NpuWUl99Ee262vCSVgjImg")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required RejectedReason56Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_NpuWWl99Ee262vCSVgjImg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
