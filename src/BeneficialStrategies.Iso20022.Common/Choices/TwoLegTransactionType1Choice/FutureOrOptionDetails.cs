// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TwoLegTransactionType1Choice
{
    /// <summary>
    /// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price or contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
    /// </summary>
    [IsoId("_AYOINtokEeC60axPepSq7g_921777527")]
    [DisplayName("Future Or Option Details")]
    [IsoXmlTag("FutrOrOptnDtls")]
    public record FutureOrOptionDetails : TwoLegTransactionType1Choice_
    {
        /// <summary>
        /// Specifies the type of the contract for futures and options.
        /// </summary>
        [IsoId("_AvBeodokEeC60axPepSq7g_2030935240")]
        [DisplayName("Future And Option Contract Type")]
        [IsoXmlTag("FutrAndOptnCtrctTp")]
        public FutureAndOptionContractType1Code? FutureAndOptionContractType { get; init; }

        /// <summary>
        /// Last date/time by which the option for physical delivery may still be exercised.
        /// </summary>
        [IsoId("_AvBeotokEeC60axPepSq7g_-376226312")]
        [DisplayName("Last Delivery Date")]
        [IsoXmlTag("LastDlvryDt")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? LastDeliveryDate { get; init; }

        /// <summary>
        /// Used to indicate the size of the underlying commodity on which the contract is based (e.g., 2500 lbs of lean cattle, 1000 barrels of crude oil, 1000 bushels of corn, etc.).
        /// </summary>
        [IsoId("_AvBeo9okEeC60axPepSq7g_365772849")]
        [DisplayName("Unit Of Measure")]
        [IsoXmlTag("UnitOfMeasr")]
        public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

        /// <summary>
        /// Date on which future contracts settle.
        /// </summary>
        [IsoId("_AvBepNokEeC60axPepSq7g_354674072")]
        [DisplayName("Future Date")]
        [IsoXmlTag("FutrDt")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? FutureDate { get; init; }

        /// <summary>
        /// Specifies the minimum ratio or multiply factor used to convert from contracts to shares.
        /// </summary>
        [IsoId("_AvBepdokEeC60axPepSq7g_-1243311832")]
        [DisplayName("Minimum Size")]
        [IsoXmlTag("MinSz")]
        public ActiveCurrencyAndAmount? MinimumSize { get; init; }

        /// <summary>
        /// Date/time, as announced by the issuer, at which the securities will be issued.
        /// </summary>
        [IsoId("_AvKokNokEeC60axPepSq7g_-1945802058")]
        [DisplayName("Announcement Date")]
        [IsoXmlTag("AnncmntDt")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? AnnouncementDate { get; init; }

        /// <summary>
        /// Specifies the deliverability of a security.
        /// </summary>
        [IsoId("_AvKokdokEeC60axPepSq7g_2021219608")]
        [DisplayName("Appearance")]
        [IsoXmlTag("Apprnc")]
        public Appearance1Code? Appearance { get; init; }

        /// <summary>
        /// Indicates whether the interest is separable from the principal.
        /// </summary>
        [IsoId("_AvKoktokEeC60axPepSq7g_-1763165363")]
        [DisplayName("Strippable Indicator")]
        [IsoXmlTag("StrpblInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? StrippableIndicator { get; init; }

        /// <summary>
        /// Indicates the maximum number of listed option contracts on a single security which can be held by an investor or group of investors acting jointly.
        /// </summary>
        [IsoId("_AvKok9okEeC60axPepSq7g_839621736")]
        [DisplayName("Position Limit")]
        [IsoXmlTag("PosLmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? PositionLimit { get; init; }

        /// <summary>
        /// Position limit in the near-term contract for a given exchange-traded product.
        /// </summary>
        [IsoId("_AvKolNokEeC60axPepSq7g_521845075")]
        [DisplayName("Near Term Position Limit")]
        [IsoXmlTag("NearTermPosLmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? NearTermPositionLimit { get; init; }

        /// <summary>
        /// Minimum price increase for a given exchange-traded Instrument.
        /// </summary>
        [IsoId("_AvKoldokEeC60axPepSq7g_1879656031")]
        [DisplayName("Minimum Trading Pricing Increment")]
        [IsoXmlTag("MinTradgPricgIncrmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? MinimumTradingPricingIncrement { get; init; }

        /// <summary>
        /// Reason for which money is raised through the issuance of a security.
        /// </summary>
        [IsoId("_AvKoltokEeC60axPepSq7g_-988373229")]
        [DisplayName("Purpose")]
        [IsoXmlTag("Purp")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public IsoMax256Text? Purpose { get; init; }

        /// <summary>
        /// Specifies when the contract (i.e. MBS/TBA) will settle.
        /// </summary>
        [IsoId("_AvUZkNokEeC60axPepSq7g_-1299764488")]
        [DisplayName("Contract Settlement Month")]
        [IsoXmlTag("CtrctSttlmMnth")]
        [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
        public IsoISOYearMonth? ContractSettlementMonth { get; init; }

        /// <summary>
        /// Date on which new securities begin trading.
        /// </summary>
        [IsoId("_AvUZkdokEeC60axPepSq7g_-1495565773")]
        [DisplayName("First Dealing Date")]
        [IsoXmlTag("FrstDealgDt")]
        public DateAndDateTime1Choice_? FirstDealingDate { get; init; }

        /// <summary>
        /// Ratio applied to convert the related security.
        /// </summary>
        [IsoId("_AvUZktokEeC60axPepSq7g_1965979375")]
        [DisplayName("Ratio")]
        [IsoXmlTag("Ratio")]
        public UnderlyingRatio1? Ratio { get; init; }

        /// <summary>
        /// Rating(s) of the security.
        /// </summary>
        [IsoId("_AvUZk9okEeC60axPepSq7g_-1389041298")]
        [DisplayName("Rating")]
        [IsoXmlTag("Ratg")]
        public Rating1? Rating { get; init; }

        /// <summary>
        /// Initial issue price of a financial instrument.
        /// </summary>
        [IsoId("_AvUZlNokEeC60axPepSq7g_-1424901255")]
        [DisplayName("Issue Price")]
        [IsoXmlTag("IssePric")]
        public Price4? IssuePrice { get; init; }

        /// <summary>
        /// Rights to exercise the privilege to purchase or to sell the assets specified at a predetermined price or formula at or within a time in the future.
        /// </summary>
        [IsoId("_AvUZldokEeC60axPepSq7g_-305341311")]
        [DisplayName("Option Rights")]
        [IsoXmlTag("OptnRghts")]
        public OptionRight1Choice_? OptionRights { get; init; }

        /// <summary>
        /// Indicates whether or not this is the last transaction.
        /// </summary>
        [IsoId("_AvUZltokEeC60axPepSq7g_-1808362353")]
        [DisplayName("Last Transaction")]
        [IsoXmlTag("LastTx")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? LastTransaction { get; init; }

        /// <summary>
        /// Specifies that there will be one price and one transaction when two contracts are carried out simultaneously, one to buy and the other one to sell with two different expiration dates.
        /// </summary>
        [IsoId("_AvdjgNokEeC60axPepSq7g_90977262")]
        [DisplayName("Spread Transaction")]
        [IsoXmlTag("SprdTx")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SpreadTransaction { get; init; }
    }
}
