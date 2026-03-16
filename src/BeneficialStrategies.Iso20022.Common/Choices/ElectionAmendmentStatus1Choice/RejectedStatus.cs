// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ElectionAmendmentStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiiHx9p-Ed-ak6NoX_4Aeg_-1936329849")]
    [DisplayName("Rejected Status")]
    public record RejectedStatus : ElectionAmendmentStatus1Choice_
    {
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_RkUQdNp-Ed-ak6NoX_4Aeg_-1873733608")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason8FormatChoice_> Reason { get; init; } = [];

        // ID for the above is _RkUQdNp-Ed-ak6NoX_4Aeg_-1873733608

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RkUQddp-Ed-ak6NoX_4Aeg_-1873733607")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
