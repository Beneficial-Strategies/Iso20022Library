// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional restrictions on the financial instrument, related to the stipulation.
/// </summary>
[IsoId("_vv4qsNooEeCWg-hsBVGrDA_-742473127")]
[DisplayName("Financial Instrument Stipulations")]
public record FinancialInstrumentStipulations2
{
    /// <summary>
    /// Type of stipulation expressing geographical constraints on a fixed income instrument. It is expressed with a state or country abbreviation and a minimum or maximum percentage. Example: CA 0-80 (minimum of 80 percent in Californian assests).
    /// </summary>
    [IsoId("_vv4qsdooEeCWg-hsBVGrDA_-856312193")]
    [DisplayName("Geographics")]
    [IsoXmlTag("Geogcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Geographics { get; init; }

    /// <summary>
    /// Range of allowed yield.
    /// </summary>
    [IsoId("_vwCbsNooEeCWg-hsBVGrDA_-1853384546")]
    [DisplayName("Yield Range")]
    [IsoXmlTag("YldRg")]
    public AmountOrPercentageRange? YieldRange { get; init; }

    /// <summary>
    /// Range of assessment of securities credit and investment risk.
    /// </summary>
    [IsoId("_vwCbsdooEeCWg-hsBVGrDA_1444510397")]
    [DisplayName("Rating")]
    [IsoXmlTag("Ratg")]
    public Rating1? Rating { get; init; }

    /// <summary>
    /// Identification of a range of coupon numbers attached to its related financial instrument.
    /// </summary>
    [IsoId("_vwCbstooEeCWg-hsBVGrDA_447438044")]
    [DisplayName("Coupon Range")]
    [IsoXmlTag("CpnRg")]
    public AmountOrPercentageRange? CouponRange { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument repays the principal amount in parts during the life cycle of the security.
    /// </summary>
    [IsoId("_vwCbs9ooEeCWg-hsBVGrDA_-549634309")]
    [DisplayName("Amortisable Indicator")]
    [IsoXmlTag("AmtsblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AmortisableIndicator { get; init; }

    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_vwCbtNooEeCWg-hsBVGrDA_-1546706662")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Purpose { get; init; }

    /// <summary>
    /// Identifies whether the issue is subject to alternative minimum taxation (used for municipal bonds).
    /// </summary>
    [IsoId("_vwCbtdooEeCWg-hsBVGrDA_1751188281")]
    [DisplayName("Alternative Minimum Tax Indicator")]
    [IsoXmlTag("AltrntvMinTaxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AlternativeMinimumTaxIndicator { get; init; }

    /// <summary>
    /// Indicates an instruction to reinvest dividends in the underlying security (or proceeds at maturity in a similar instrument) if the current rate is &lt;rate&gt; or better.
    /// </summary>
    [IsoId("_vwLloNooEeCWg-hsBVGrDA_754115928")]
    [DisplayName("Auto Reinvestment")]
    [IsoXmlTag("AutoRinvstmt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AutoReinvestment { get; init; }

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_vwLlodooEeCWg-hsBVGrDA_-242956425")]
    [DisplayName("Transaction Conditions")]
    [IsoXmlTag("TxConds")]
    public TradeTransactionCondition2Code? TransactionConditions { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_vwLlotooEeCWg-hsBVGrDA_-1240028778")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Indicates an instruction to override an investment&apos;s default start and/or end date with a custom date.
    /// </summary>
    [IsoId("_vwLlo9ooEeCWg-hsBVGrDA_2057866165")]
    [DisplayName("Custom Date")]
    [IsoXmlTag("CstmDt")]
    public DateTimePeriodDetails1? CustomDate { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_vwLlpNooEeCWg-hsBVGrDA_1060793812")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Identifies whether the lender is assured partial or full payment by a third party if the borrower defaults.
    /// </summary>
    [IsoId("_vwLlpdooEeCWg-hsBVGrDA_1829703902")]
    [DisplayName("Insured Indicator")]
    [IsoXmlTag("InsrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InsuredIndicator { get; init; }

    /// <summary>
    /// Indicates an instruction or attribute giving the number of days to be included in the look-back period for the investment. E.g. some options allow exercise based on the underlying asset&apos;s optimal value over the look-back period.
    /// </summary>
    [IsoId("_vwLlptooEeCWg-hsBVGrDA_832631549")]
    [DisplayName("Look Back")]
    [IsoXmlTag("LookBck")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LookBack { get; init; }

    /// <summary>
    /// Indicates the maturity date.
    /// </summary>
    [IsoId("_vwVWoNooEeCWg-hsBVGrDA_-164440804")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? MaturityDate { get; init; }

    /// <summary>
    /// Indicates the issue date.
    /// </summary>
    [IsoId("_vwVWodooEeCWg-hsBVGrDA_-1161513157")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? IssueDate { get; init; }

    /// <summary>
    /// Identification of the issuer.
    /// </summary>
    [IsoId("_vwVWotooEeCWg-hsBVGrDA_2136381786")]
    [DisplayName("Issuer Identification")]
    [IsoXmlTag("IssrId")]
    [IsoSimpleType(IsoSimpleType.BICNonFIIdentifier)]
    public IsoBICNonFIIdentifier? IssuerIdentification { get; init; }

    /// <summary>
    /// Identifies the issue size range.
    /// </summary>
    [IsoId("_vwVWo9ooEeCWg-hsBVGrDA_1139309433")]
    [DisplayName("Issue Size")]
    [IsoXmlTag("IsseSz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? IssueSize { get; init; }

    /// <summary>
    /// Indicates the minimum denomination of a security.
    /// </summary>
    [IsoId("_vwVWpNooEeCWg-hsBVGrDA_142237080")]
    [DisplayName("Minimum Denomination")]
    [IsoXmlTag("MinDnmtn")]
    public FinancialInstrumentQuantityChoice_? MinimumDenomination { get; init; }

    /// <summary>
    /// Maximum number of time the collateral can be substitute.
    /// </summary>
    [IsoId("_vwVWpdooEeCWg-hsBVGrDA_-854835273")]
    [DisplayName("Maximum Substitution")]
    [IsoXmlTag("MaxSbstitn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumSubstitution { get; init; }

    /// <summary>
    /// Indicates the minimum tradable increments of a security.
    /// </summary>
    [IsoId("_vwfHoNooEeCWg-hsBVGrDA_-1851907626")]
    [DisplayName("Minimum Increment")]
    [IsoXmlTag("MinIncrmt")]
    public FinancialInstrumentQuantityChoice_? MinimumIncrement { get; init; }

    /// <summary>
    /// Indicates the periodic or regular cycle of interest payments.
    /// </summary>
    [IsoId("_vwfHodooEeCWg-hsBVGrDA_1445987317")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency1Code? PaymentFrequency { get; init; }

    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_vwfHotooEeCWg-hsBVGrDA_525953665")]
    [DisplayName("Minimum Quantity")]
    [IsoXmlTag("MinQty")]
    public FinancialInstrumentQuantityChoice_? MinimumQuantity { get; init; }

    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond, particularly an MBS, issued in a particular year.
    /// </summary>
    [IsoId("_vwfHo9ooEeCWg-hsBVGrDA_-2083023729")]
    [DisplayName("Production")]
    [IsoXmlTag("Pdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Production { get; init; }

    /// <summary>
    /// Identifies if the securities is restricted or not (as per Rule 144).
    /// </summary>
    [IsoId("_vwfHpNooEeCWg-hsBVGrDA_1214871214")]
    [DisplayName("Restricted Indicator")]
    [IsoXmlTag("RstrctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictedIndicator { get; init; }

    /// <summary>
    /// Indicates the frequency at which the bond is re-rated and therefore re-priced (bond attribute, particularly of floating rate and index linked instruments).
    /// </summary>
    [IsoId("_vwfHpdooEeCWg-hsBVGrDA_217798861")]
    [DisplayName("Price Frequency")]
    [IsoXmlTag("PricFrqcy")]
    public Frequency1Code? PriceFrequency { get; init; }

    /// <summary>
    /// Indicates the market sector the security is classified as. E.g. pharmacuticals, automobile, housing, etc.
    /// </summary>
    [IsoId("_vwfHptooEeCWg-hsBVGrDA_-779273492")]
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Sector { get; init; }

    /// <summary>
    /// Indicates the maximum number of times collateral can be substituted.
    /// </summary>
    [IsoId("_vwoRkNooEeCWg-hsBVGrDA_-1776345845")]
    [DisplayName("Substitution Frequency")]
    [IsoXmlTag("SbstitnFrqcy")]
    public Frequency1Code? SubstitutionFrequency { get; init; }

    /// <summary>
    /// Number of remaining times the collateral can be substitute.
    /// </summary>
    [IsoId("_vwoRkdooEeCWg-hsBVGrDA_1521549098")]
    [DisplayName("Substitution Left")]
    [IsoXmlTag("SbstitnLft")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SubstitutionLeft { get; init; }

    /// <summary>
    /// Indicates a search criterion when looking to buy an MBS that either is [yes] or is not [no] an entire pool.
    /// </summary>
    [IsoId("_vwoRktooEeCWg-hsBVGrDA_524476745")]
    [DisplayName("Whole Pool Indicator")]
    [IsoXmlTag("WhlPoolInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WholePoolIndicator { get; init; }

    /// <summary>
    /// Identifies the Benchmark source price (eg. BB Generic, BB Fairvalue, Brokertec.).
    /// </summary>
    [IsoId("_vwoRk9ooEeCWg-hsBVGrDA_-472595608")]
    [DisplayName("Price Source")]
    [IsoXmlTag("PricSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PriceSource { get; init; }

    /// <summary>
    /// Date/time at which an interest bearing security becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_vwoRlNooEeCWg-hsBVGrDA_-1469667961")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExpirationDate { get; init; }

    /// <summary>
    /// Amount for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_vwoRldooEeCWg-hsBVGrDA_1828226982")]
    [DisplayName("Over Allotment Amount")]
    [IsoXmlTag("OverAlltmtAmt")]
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; init; }

    /// <summary>
    /// Percentage for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_vwyCkNooEeCWg-hsBVGrDA_831154629")]
    [DisplayName("Over Allotment Rate")]
    [IsoXmlTag("OverAlltmtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? OverAllotmentRate { get; init; }

    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond within a particular price range.
    /// </summary>
    [IsoId("_vwyCkdooEeCWg-hsBVGrDA_-165917724")]
    [DisplayName("Price Range")]
    [IsoXmlTag("PricRg")]
    public AmountOrPercentageRange? PriceRange { get; init; }

    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_vwyCktooEeCWg-hsBVGrDA_-1162990077")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableIndicator { get; init; }

    /// <summary>
    /// Indicates whether the interest bearing security is convertible into another type of security.
    /// </summary>
    [IsoId("_vwyCk9ooEeCWg-hsBVGrDA_2134904866")]
    [DisplayName("Convertible Indicator")]
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_vwyClNooEeCWg-hsBVGrDA_1137832513")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PutableIndicator { get; init; }

    /// <summary>
    /// Indicates whether an interest bearing instrument is deposited in a fund that will be used to pay debt service on refunded securities.
    /// </summary>
    [IsoId("_vwyCldooEeCWg-hsBVGrDA_140760160")]
    [DisplayName("Pre Funded Indicator")]
    [IsoXmlTag("PreFnddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PreFundedIndicator { get; init; }

    /// <summary>
    /// Indicates whether an interest bearing instrument is being escrowed or collateralized either by direct obligations guaranteed by the US government, or by other types of securities. The maturity schedules of the securities in the escrow fund are determined in such a way to pay the maturity value, coupon, and premium payments (if any) of the refunded bonds.
    /// </summary>
    [IsoId("_vwyCltooEeCWg-hsBVGrDA_-856312193")]
    [DisplayName("Escrowed Indicator")]
    [IsoXmlTag("EscrwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EscrowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the security has no maturity date.
    /// </summary>
    [IsoId("_vw7MgNooEeCWg-hsBVGrDA_-1853384546")]
    [DisplayName("Perpetual Indicator")]
    [IsoXmlTag("PerptlInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PerpetualIndicator { get; init; }
}
