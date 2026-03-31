// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionInformationStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiPM1Np-Ed-ak6NoX_4Aeg_-878703757")]
    [DisplayName("Rejected Status")]
    [IsoXmlTag("RjctdSts")]
    public record RejectedStatus : CorporateActionInformationStatus1Choice_
    {
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_Rknyddp-Ed-ak6NoX_4Aeg_35582095")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason15FormatChoice_> Reason { get; init; } = [];

        // ID for the above is _Rknyddp-Ed-ak6NoX_4Aeg_35582095

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_Rknydtp-Ed-ak6NoX_4Aeg_35582096")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
