// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingInstructionStatus1Choice
{
    /// <summary>
    /// Provides information about the processing status of the request.
    /// </summary>
    [IsoId("_RirRsNp-Ed-ak6NoX_4Aeg_5921182")]
    [DisplayName("Processed Status")]
    [IsoXmlTag("PrcdSts")]
    public record ProcessedStatus : StandingInstructionStatus1Choice_
    {
        /// <summary>
        /// The processing status.
        /// </summary>
        [IsoId("_RlD3UNp-Ed-ak6NoX_4Aeg_-495553264")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required ProcessedStatus3FormatChoice_ Status { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RlD3Udp-Ed-ak6NoX_4Aeg_-495553232")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
