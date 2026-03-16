// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AgreedAmount1Choice
{
    /// <summary>
    /// Provides details about the agreed amount for the segregated independent amount.
    /// </summary>
    [IsoId("_Qm7bJ9p-Ed-ak6NoX_4Aeg_-1857537663")]
    [DisplayName("Segregated Independent Amount")]
    public record SegregatedIndependentAmount : AgreedAmount1Choice_
    {
        /// <summary>
        /// Undisputed amount of the margin call request.
        /// </summary>
        [IsoId("_Ul4kB9p-Ed-ak6NoX_4Aeg_-1514098340")]
        [DisplayName("Agreed Amount")]
        [IsoXmlTag("AgrdAmt")]
        public required ActiveCurrencyAndAmount AgreedAmount { get; init; }

        /// <summary>
        /// Unique identifier for the margin call request.
        /// </summary>
        [IsoId("_UmCVANp-Ed-ak6NoX_4Aeg_419184137")]
        [DisplayName("Margin Call Request Identification")]
        [IsoXmlTag("MrgnCallReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MarginCallRequestIdentification { get; init; }

        /// <summary>
        /// Provides additional information related to the margin call amount that has been agreed.
        /// </summary>
        [IsoId("_UmCVAdp-Ed-ak6NoX_4Aeg_-131236975")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalInformation { get; init; }
    }
}
