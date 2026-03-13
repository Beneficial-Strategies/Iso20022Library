// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NotificationCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiYWxdp-Ed-ak6NoX_4Aeg_891409846")]
    [DisplayName("Rejected Status")]
    public partial record RejectedStatus : NotificationCancellationRequestStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_RkLGhNp-Ed-ak6NoX_4Aeg_1166618034")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason11FormatChoice_> Reason { get; init; } = [];
        // ID for the above is _RkLGhNp-Ed-ak6NoX_4Aeg_1166618034
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RkLGhdp-Ed-ak6NoX_4Aeg_1166618064")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
