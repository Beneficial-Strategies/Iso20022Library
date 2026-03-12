// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus1Choice
{
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_Qy2XSNp-Ed-ak6NoX_4Aeg_319084509")]
    [DisplayName("Reason")]
    public partial record Reason : CancelledStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
        /// </summary>
        [IsoId("_Qy2XQdp-Ed-ak6NoX_4Aeg_-1378812956")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required CancelledReason1Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_Qy2XQtp-Ed-ak6NoX_4Aeg_-924896262")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
