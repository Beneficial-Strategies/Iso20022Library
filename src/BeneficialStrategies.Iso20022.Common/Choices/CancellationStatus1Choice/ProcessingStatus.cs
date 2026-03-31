// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus1Choice
{
    /// <summary>
    /// Status advising on the processing of the cancellation request.
    /// </summary>
    [IsoId("_RVa41tp-Ed-ak6NoX_4Aeg_-538392762")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public record ProcessingStatus : CancellationStatus1Choice_
    {
        /// <summary>
        /// Status of the request for cancellation.
        /// </summary>
        [IsoId("_RVkCx9p-Ed-ak6NoX_4Aeg_-1468645420")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required CancellationStatus3Code Status { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RVkCyNp-Ed-ak6NoX_4Aeg_-1468645405")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
