// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus39Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_pUIcIx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedStatus39Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been rejected.
        /// </summary>
        [IsoId("_pUIcMx9QEeuFz_FaCzCLgQ")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required RejectedReason39Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_pUIcOx9QEeuFz_FaCzCLgQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINMax210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoRestrictedFINMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
