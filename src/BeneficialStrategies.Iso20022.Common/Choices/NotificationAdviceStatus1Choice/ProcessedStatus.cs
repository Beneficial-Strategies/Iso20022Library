// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus1Choice
{
    /// <summary>
    /// Provides information about the processing status of advice.
    /// </summary>
    [IsoId("_Ri1Cttp-Ed-ak6NoX_4Aeg_288350026")]
    [DisplayName("Processed Status")]
    public partial record ProcessedStatus : NotificationAdviceStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The processing status.
        /// </summary>
        [IsoId("_RkLGgdp-Ed-ak6NoX_4Aeg_364081629")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required ProcessedStatus1FormatChoice_ Status { get; init; } 
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RkLGgtp-Ed-ak6NoX_4Aeg_364081652")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
