// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatusChoice
{
    /// <summary>
    /// Explains the reason for rejecting a payment cancellation request.
    /// </summary>
    [IsoId("_UuYYtdp-Ed-ak6NoX_4Aeg_1934789984")]
    [DisplayName("Rejected Cancellation")]
    public partial record RejectedCancellation : InvestigationStatusChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Justification for the rejection of the cancellation.
        /// </summary>
        [IsoId("_T9gVY9p-Ed-ak6NoX_4Aeg_173058696")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PaymentCancellationRejection1Code ReasonCode { get; init; } 
        
        /// <summary>
        /// Free text justification for rejecting a cancellation.
        /// </summary>
        [IsoId("_T9gVZNp-Ed-ak6NoX_4Aeg_1563536447")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? Reason { get; init; } 
        
        
        #nullable disable
        
    }
}
