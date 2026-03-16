// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative4Choice
{
    /// <summary>
    /// A credit default swap on an index.
    /// </summary>
    [IsoId("_xSzjUye0Eei12pGEsJIAeQ")]
    [DisplayName("Credit Default Swap Index")]
    [IsoXmlTag("CdtDfltSwpIndx")]
    public record CreditDefaultSwapIndex : CreditDefaultSwapsDerivative4Choice_
    {
        /// <summary>
        /// Derivative on a credit default swap with the ISIN code of the underlying index.
        /// </summary>
        [IsoId("_wRgo8ie1Eei12pGEsJIAeQ")]
        [DisplayName("Underlying Index Identification")]
        [IsoXmlTag("UndrlygIndxId")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? UnderlyingIndexIdentification { get; init; }

        /// <summary>
        /// To be populated for derivatives on a CDS index with the standardized name of the index.
        /// </summary>
        [IsoId("_5bH40Ce1Eei12pGEsJIAeQ")]
        [DisplayName("Underlying Index Name")]
        [IsoXmlTag("UndrlygIndxNm")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25, MinimumLength = 1)]
        public IsoMax25Text? UnderlyingIndexName { get; init; }

        /// <summary>
        /// Series number of the composition of the index if applicable.
        /// </summary>
        [IsoId("_qD_WwSe1Eei12pGEsJIAeQ")]
        [DisplayName("Series")]
        [IsoXmlTag("Srs")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Series { get; init; }

        /// <summary>
        /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
        /// </summary>
        [IsoId("_qD_Wwye1Eei12pGEsJIAeQ")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// All months when the roll is expected as established by the index provider for a given year. Field should be repeated for each month in the roll.
        /// </summary>
        [IsoId("_qD_WxSe1Eei12pGEsJIAeQ")]
        [DisplayName("Roll Month")]
        [IsoXmlTag("RollMnth")]
        [IsoSimpleType(IsoSimpleType.RestrictedMonthExact2Number)]
        [MinLength(0)]
        [MaxLength(12)]
        public SimpleValueList<System.UInt64> RollMonth { get; init; } = [];

        /// <summary>
        /// To be populated in the case of a CDS Index or a derivative CDS Index with the next roll date of the index as established by the index provider.
        /// </summary>
        [IsoId("_qD_Wxye1Eei12pGEsJIAeQ")]
        [DisplayName("Next Roll Date")]
        [IsoXmlTag("NxtRollDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? NextRollDate { get; init; }

        /// <summary>
        /// Currency in which the notional is denominated.
        /// </summary>
        [IsoId("_qD_WySe1Eei12pGEsJIAeQ")]
        [DisplayName("Notional Currency")]
        [IsoXmlTag("NtnlCcy")]
        public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; }
    }
}
