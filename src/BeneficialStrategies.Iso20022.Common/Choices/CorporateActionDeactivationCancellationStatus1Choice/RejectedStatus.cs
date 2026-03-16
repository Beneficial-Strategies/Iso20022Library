// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionDeactivationCancellationStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiYWwtp-Ed-ak6NoX_4Aeg_1549781490")]
    [DisplayName("Rejected Status")]
    [IsoXmlTag("RjctdSts")]
    public record RejectedStatus : CorporateActionDeactivationCancellationStatus1Choice_
    {
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_RkeBcdp-Ed-ak6NoX_4Aeg_1510068594")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason7FormatChoice_> Reason { get; init; } = [];

        // ID for the above is _RkeBcdp-Ed-ak6NoX_4Aeg_1510068594

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RkeBctp-Ed-ak6NoX_4Aeg_1510068595")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
