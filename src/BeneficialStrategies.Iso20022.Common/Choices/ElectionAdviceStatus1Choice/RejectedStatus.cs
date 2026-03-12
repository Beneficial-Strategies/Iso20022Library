// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ElectionAdviceStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiiHwdp-Ed-ak6NoX_4Aeg_-1292537504")]
    [DisplayName("Rejected Status")]
    public partial record RejectedStatus : ElectionAdviceStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_Rkw8Ytp-Ed-ak6NoX_4Aeg_-147105631")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason18FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason18FormatChoice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _Rkw8Ytp-Ed-ak6NoX_4Aeg_-147105631
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_Rkw8Y9p-Ed-ak6NoX_4Aeg_-147105352")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
