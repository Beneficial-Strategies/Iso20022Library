// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionInformationStatus1Choice
{
    /// <summary>
    /// Provides information about the processing status of the advice.
    /// </summary>
    [IsoId("_RiPM09p-Ed-ak6NoX_4Aeg_-880551807")]
    [DisplayName("Processed Status")]
    public record ProcessedStatus : CorporateActionInformationStatus1Choice_
    {
        /// <summary>
        /// The processing status.
        /// </summary>
        [IsoId("_Rknyctp-Ed-ak6NoX_4Aeg_6027375")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required ProcessedStatus5FormatChoice_ Status { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_Rknyc9p-Ed-ak6NoX_4Aeg_6027405")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
