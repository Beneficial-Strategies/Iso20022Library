// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ElectionCancellationStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiiHxNp-Ed-ak6NoX_4Aeg_1829260914")]
    [DisplayName("Rejected Status")]
    [IsoXmlTag("RjctdSts")]
    public record RejectedStatus : ElectionCancellationStatus1Choice_
    {
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_RlNoUNp-Ed-ak6NoX_4Aeg_-1877428616")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason9FormatChoice_> Reason { get; init; } = [];

        // ID for the above is _RlNoUNp-Ed-ak6NoX_4Aeg_-1877428616

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RlNoUdp-Ed-ak6NoX_4Aeg_-1877428585")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
