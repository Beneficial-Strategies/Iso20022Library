// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus26Choice
{
    /// <summary>
    /// Status advising on the processing of the instruction cancellation request.
    /// </summary>
    [IsoId("_iKIaprKfEemux5trsZcCpw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public record ProcessingStatus : CancellationStatus26Choice_
    {
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoId("_VqsBIbLQEemDyeh7tbvg1w")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required CancellationStatus6Code Status { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_VqsBI7LQEemDyeh7tbvg1w")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
