// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus1Choice
{
    /// <summary>
    /// Reason for the pending cancellation status.
    /// </summary>
    [IsoId("_QyGwYdp-Ed-ak6NoX_4Aeg_834538036")]
    [DisplayName("Reason")]
    public partial record Reason : PendingCancellationStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the cancellation request is pending.
        /// </summary>
        [IsoId("_Qx8_Zdp-Ed-ak6NoX_4Aeg_-806168771")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PendingCancellationReason1Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_Qx8_Ztp-Ed-ak6NoX_4Aeg_-806168831")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
