// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginCallResult2Choice
{
    /// <summary>
    /// Provides the summation of the call amounts for the segregated independent amount only.
    /// </summary>
    [IsoId("_9boCQqMPEeCojJW5vEuTEQ_-1606532938")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public record SegregatedIndependentAmount : MarginCallResult2Choice_
    {
        /// <summary>
        /// Amount payable by party B to party A.
        /// </summary>
        [IsoId("_UlvaE9p-Ed-ak6NoX_4Aeg_-97807248")]
        [DisplayName("Due To Party A")]
        [IsoXmlTag("DueToPtyA")]
        public ActiveCurrencyAndAmount? DueToPartyA { get; init; }

        /// <summary>
        /// Amount payable by party A to party B.
        /// </summary>
        [IsoId("_UlvaFNp-Ed-ak6NoX_4Aeg_-1435615045")]
        [DisplayName("Due To Party B")]
        [IsoXmlTag("DueToPtyB")]
        public ActiveCurrencyAndAmount? DueToPartyB { get; init; }

        /// <summary>
        /// Provides additional information related to the collateral that may be requested.
        /// </summary>
        [IsoId("_UlvaFdp-Ed-ak6NoX_4Aeg_903687993")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalInformation { get; init; }
    }
}
