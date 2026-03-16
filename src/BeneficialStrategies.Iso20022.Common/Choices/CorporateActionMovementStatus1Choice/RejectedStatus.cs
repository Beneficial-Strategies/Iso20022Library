// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionMovementStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiPM2Np-Ed-ak6NoX_4Aeg_-1502312147")]
    [DisplayName("Rejected Status")]
    public record RejectedStatus : CorporateActionMovementStatus1Choice_
    {
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_Rkw8aNp-Ed-ak6NoX_4Aeg_-1516165446")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason13FormatChoice_> Reason { get; init; } = [];

        // ID for the above is _Rkw8aNp-Ed-ak6NoX_4Aeg_-1516165446

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_Rk6tYNp-Ed-ak6NoX_4Aeg_-1516165445")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
