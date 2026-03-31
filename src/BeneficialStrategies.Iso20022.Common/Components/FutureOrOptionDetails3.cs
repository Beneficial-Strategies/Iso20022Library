// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price or contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
/// </summary>
[IsoId("_TKaGYQeFEe2fOITqoTnSLQ")]
[DisplayName("Future Or Option Details")]
public record FutureOrOptionDetails3
{
    /// <summary>
    /// Specifies the type of the contract for futures and options.
    /// </summary>
    [IsoId("_TdVCYQeFEe2fOITqoTnSLQ")]
    [DisplayName("Future And Option Contract Type")]
    [IsoXmlTag("FutrAndOptnCtrctTp")]
    public FutureAndOptionContractType1Code? FutureAndOptionContractType { get; init; }

    /// <summary>
    /// Last date/time by which the option for physical delivery may still be exercised.
    /// </summary>
    [IsoId("_TdVCYweFEe2fOITqoTnSLQ")]
    [DisplayName("Last Delivery Date")]
    [IsoXmlTag("LastDlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastDeliveryDate { get; init; }

    /// <summary>
    /// Used to indicate the size of the underlying commodity on which the contract is based (e.g., 2500 lbs of lean cattle, 1000 barrels of crude oil, 1000 bushels of corn, etc.).
    /// </summary>
    [IsoId("_TdVCZQeFEe2fOITqoTnSLQ")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Date on which future contracts settle.
    /// </summary>
    [IsoId("_TdVCZweFEe2fOITqoTnSLQ")]
    [DisplayName("Future Date")]
    [IsoXmlTag("FutrDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FutureDate { get; init; }

    /// <summary>
    /// Specifies the minimum ratio or multiply factor used to convert from contracts to shares.
    /// </summary>
    [IsoId("_TdVCaQeFEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Size")]
    [IsoXmlTag("MinSz")]
    public ActiveCurrencyAndAmount? MinimumSize { get; init; }

    /// <summary>
    /// Date/time, as announced by the issuer, at which the securities will be issued.
    /// </summary>
    [IsoId("_TdVCaweFEe2fOITqoTnSLQ")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AnnouncementDate { get; init; }

    /// <summary>
    /// Specifies the deliverability of a security.
    /// </summary>
    [IsoId("_TdVCbQeFEe2fOITqoTnSLQ")]
    [DisplayName("Appearance")]
    [IsoXmlTag("Apprnc")]
    public Appearance1Code? Appearance { get; init; }

    /// <summary>
    /// Indicates whether the interest is separable from the principal.
    /// </summary>
    [IsoId("_TdVCbweFEe2fOITqoTnSLQ")]
    [DisplayName("Strippable Indicator")]
    [IsoXmlTag("StrpblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StrippableIndicator { get; init; }

    /// <summary>
    /// Indicates the maximum number of listed option contracts on a single security which can be held by an investor or group of investors acting jointly.
    /// </summary>
    [IsoId("_TdVCcQeFEe2fOITqoTnSLQ")]
    [DisplayName("Position Limit")]
    [IsoXmlTag("PosLmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PositionLimit { get; init; }

    /// <summary>
    /// Position limit in the near-term contract for a given exchange-traded product.
    /// </summary>
    [IsoId("_TdVCcweFEe2fOITqoTnSLQ")]
    [DisplayName("Near Term Position Limit")]
    [IsoXmlTag("NearTermPosLmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NearTermPositionLimit { get; init; }

    /// <summary>
    /// Minimum price increase for a given exchange-traded Instrument.
    /// </summary>
    [IsoId("_TdVCdQeFEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Trading Pricing Increment")]
    [IsoXmlTag("MinTradgPricgIncrmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumTradingPricingIncrement { get; init; }

    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_TdVCdweFEe2fOITqoTnSLQ")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Purpose { get; init; }

    /// <summary>
    /// Specifies when the contract (i.e. MBS/TBA) will settle.
    /// </summary>
    [IsoId("_TdVCeQeFEe2fOITqoTnSLQ")]
    [DisplayName("Contract Settlement Month")]
    [IsoXmlTag("CtrctSttlmMnth")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? ContractSettlementMonth { get; init; }

    /// <summary>
    /// Date on which new securities begin trading.
    /// </summary>
    [IsoId("_TdVCeweFEe2fOITqoTnSLQ")]
    [DisplayName("First Dealing Date")]
    [IsoXmlTag("FrstDealgDt")]
    public DateAndDateTime1Choice_? FirstDealingDate { get; init; }

    /// <summary>
    /// Ratio applied to convert the related security.
    /// </summary>
    [IsoId("_TdVCfQeFEe2fOITqoTnSLQ")]
    [DisplayName("Ratio")]
    [IsoXmlTag("Ratio")]
    public ValueList<UnderlyingRatio2> Ratio { get; init; } = [];

    /// <summary>
    /// Rating(s) of the security.
    /// </summary>
    [IsoId("_TdVCfweFEe2fOITqoTnSLQ")]
    [DisplayName("Rating")]
    [IsoXmlTag("Ratg")]
    public ValueList<Rating1> Rating { get; init; } = [];

    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [IsoId("_TdVCgQeFEe2fOITqoTnSLQ")]
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public Price14? IssuePrice { get; init; }

    /// <summary>
    /// Rights to exercise the privilege to purchase or to sell the assets specified at a predetermined price or formula at or within a time in the future.
    /// </summary>
    [IsoId("_TdVCgweFEe2fOITqoTnSLQ")]
    [DisplayName("Option Rights")]
    [IsoXmlTag("OptnRghts")]
    public OptionRight2Choice_? OptionRights { get; init; }

    /// <summary>
    /// Indicates whether or not this is the last transaction.
    /// </summary>
    [IsoId("_TdVChQeFEe2fOITqoTnSLQ")]
    [DisplayName("Last Transaction")]
    [IsoXmlTag("LastTx")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LastTransaction { get; init; }

    /// <summary>
    /// Specifies that there will be one price and one transaction when two contracts are carried out simultaneously, one to buy and the other one to sell with two different expiration dates.
    /// </summary>
    [IsoId("_TdVChweFEe2fOITqoTnSLQ")]
    [DisplayName("Spread Transaction")]
    [IsoXmlTag("SprdTx")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SpreadTransaction { get; init; }
}
