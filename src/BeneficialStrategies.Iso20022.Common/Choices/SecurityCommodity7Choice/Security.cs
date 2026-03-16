// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityCommodity7Choice
{
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_Ul6y8cgyEeuGrNSsxk3B0A")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public record Security : SecurityCommodity7Choice_
    {
        /// <summary>
        /// Specifies whether the values defined as ISIN (International Securities Identification Number-ISO 6166) identifier are matching or not.
        /// </summary>
        [IsoId("_A4HkI8K3EeuFNp8LZAnorg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public CompareISINIdentifier4? Identification { get; init; }

        /// <summary>
        /// Specifies whether the values defined as CFI (Classification of Financial Instruments-ISO 10962) identifier are matching or not.
        /// </summary>
        [IsoId("_A4HkJcK3EeuFNp8LZAnorg")]
        [DisplayName("Classification Type")]
        [IsoXmlTag("ClssfctnTp")]
        public CompareCFIIdentifier3? ClassificationType { get; init; }

        /// <summary>
        /// Specifies whether the values defined as decimal number are matching or not.
        /// </summary>
        [IsoId("_A4HkJ8K3EeuFNp8LZAnorg")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public CompareDecimalNumber3? Quantity { get; init; }

        /// <summary>
        /// Specifies whether the values defined as active or historic currency and amount are matching or not.
        /// </summary>
        [IsoId("_A4HkKcK3EeuFNp8LZAnorg")]
        [DisplayName("Nominal Value")]
        [IsoXmlTag("NmnlVal")]
        public CompareAmountAndDirection2? NominalValue { get; init; }

        /// <summary>
        /// Specifies whether the values defined as collateral quality type code are matching or not.
        /// </summary>
        [IsoId("_A4HkK8K3EeuFNp8LZAnorg")]
        [DisplayName("Quality")]
        [IsoXmlTag("Qlty")]
        public CompareCollateralQualityType3? Quality { get; init; }

        /// <summary>
        /// Specifies whether the values defined as ISO date are matching or not.
        /// </summary>
        [IsoId("_A4HkLcK3EeuFNp8LZAnorg")]
        [DisplayName("Maturity")]
        [IsoXmlTag("Mtrty")]
        public CompareDate3? Maturity { get; init; }

        /// <summary>
        /// Specifies whether the values defined as LEI identifier are matching or not.
        /// </summary>
        [IsoId("_A4HkL8K3EeuFNp8LZAnorg")]
        [DisplayName("Issuer Identification")]
        [IsoXmlTag("IssrId")]
        public CompareOrganisationIdentification6? IssuerIdentification { get; init; }

        /// <summary>
        /// Specifies whether the values defined as country code are matching or not.
        /// </summary>
        [IsoId("_A4HkMcK3EeuFNp8LZAnorg")]
        [DisplayName("Issuer Country")]
        [IsoXmlTag("IssrCtry")]
        public CompareCountryCode3? IssuerCountry { get; init; }

        /// <summary>
        /// Specifies whether the values defined as securities lending type are matching or not.
        /// </summary>
        [IsoId("_A4HkM8K3EeuFNp8LZAnorg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public CompareSecuritiesLendingType3? Type { get; init; }

        /// <summary>
        /// Specifies whether the the unit prices are matching or not.
        /// </summary>
        [IsoId("_A4HkNcK3EeuFNp8LZAnorg")]
        [DisplayName("Unit Price")]
        [IsoXmlTag("UnitPric")]
        public CompareUnitPrice6? UnitPrice { get; init; }

        /// <summary>
        /// Specifies whether the values defined as true/false indicator are matching or not.
        /// </summary>
        [IsoId("_A4HkN8K3EeuFNp8LZAnorg")]
        [DisplayName("Exclusive Arrangement")]
        [IsoXmlTag("ExclsvArrgmnt")]
        public CompareTrueFalseIndicator3? ExclusiveArrangement { get; init; }

        /// <summary>
        /// Specifies whether the values defined as active or historic currency and amount are matching or not.
        /// </summary>
        [IsoId("_A4HkOcK3EeuFNp8LZAnorg")]
        [DisplayName("Market Value")]
        [IsoXmlTag("MktVal")]
        public CompareAmountAndDirection2? MarketValue { get; init; }

        /// <summary>
        /// Specifies whether the values defined as true/false indicator are matching or not.
        /// </summary>
        [IsoId("_A4HkO8K3EeuFNp8LZAnorg")]
        [DisplayName("Available For Collateral Reuse")]
        [IsoXmlTag("AvlblForCollReuse")]
        public CompareTrueFalseIndicator3? AvailableForCollateralReuse { get; init; }

        /// <summary>
        /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
        /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
        /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
        /// </summary>
        [IsoId("_A4HkPcK3EeuFNp8LZAnorg")]
        [DisplayName("Haircut Or Margin")]
        [IsoXmlTag("HrcutOrMrgn")]
        public ComparePercentageRate3? HaircutOrMargin { get; init; }
    }
}
