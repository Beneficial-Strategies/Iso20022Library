// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NotificationCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides information about the processing status of the cancellation request.
    /// </summary>
    [IsoId("_RiYWxNp-Ed-ak6NoX_4Aeg_878482485")]
    [DisplayName("Processed Status")]
    [IsoXmlTag("PrcdSts")]
    public record ProcessedStatus : NotificationCancellationRequestStatus1Choice_
    {
        /// <summary>
        /// The processing status.
        /// </summary>
        [IsoId("_RkBVh9p-Ed-ak6NoX_4Aeg_818452581")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required ProcessedStatus2FormatChoice_ Status { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RkBViNp-Ed-ak6NoX_4Aeg_818452582")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
