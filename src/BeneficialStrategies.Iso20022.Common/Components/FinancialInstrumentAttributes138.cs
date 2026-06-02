// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_kMyPIag6EfCXwLUUylXgrQ")]
[DisplayName("Financial Instrument Attributes138")]
public record FinancialInstrumentAttributes138
{
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_kPMC6ag6EfCXwLUUylXgrQ")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_kPMC9ag6EfCXwLUUylXgrQ")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat4Choice? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies the form, this is, ownership, of the security.
    /// </summary>
    [IsoId("_kPMDAag6EfCXwLUUylXgrQ")]
    [DisplayName("Registration Form")]
    [IsoXmlTag("RegnForm")]
    public FormOfSecurity6Choice? RegistrationForm { get; init; }

    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_kPMDDag6EfCXwLUUylXgrQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency23Choice? PaymentFrequency { get; init; }

    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_kPMDGag6EfCXwLUUylXgrQ")]
    [DisplayName("Payment Status")]
    [IsoXmlTag("PmtSts")]
    public SecuritiesPaymentStatus5Choice? PaymentStatus { get; init; }

    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_kPMDJag6EfCXwLUUylXgrQ")]
    [DisplayName("Variable Rate Change Frequency")]
    [IsoXmlTag("VarblRateChngFrqcy")]
    public Frequency23Choice? VariableRateChangeFrequency { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification.
    /// </summary>
    [IsoId("_kPMDMag6EfCXwLUUylXgrQ")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_kPMDPag6EfCXwLUUylXgrQ")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle8Choice? OptionStyle { get; init; }

    /// <summary>
    /// Specifies whether it is a Call option or a Put option.
    /// </summary>
    [IsoId("_kPMDSag6EfCXwLUUylXgrQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType6Choice? OptionType { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_kPMDVag6EfCXwLUUylXgrQ")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_kPMDYag6EfCXwLUUylXgrQ")]
    [DisplayName("Coupon Date")]
    [IsoXmlTag("CpnDt")]
    public IsoISODate? CouponDate { get; init; }

    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_kPMDbag6EfCXwLUUylXgrQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset.
    /// </summary>
    [IsoId("_kPMDeag6EfCXwLUUylXgrQ")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_kPMDhag6EfCXwLUUylXgrQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_kPMDkag6EfCXwLUUylXgrQ")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_kPMDnag6EfCXwLUUylXgrQ")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_kPMDqag6EfCXwLUUylXgrQ")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_kPMDtag6EfCXwLUUylXgrQ")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_kPMDwag6EfCXwLUUylXgrQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor.
    /// </summary>
    [IsoId("_kPMDzag6EfCXwLUUylXgrQ")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public IsoBaseOneRate? PreviousFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument.
    /// </summary>
    [IsoId("_kPMD2ag6EfCXwLUUylXgrQ")]
    [DisplayName("Current Factor")]
    [IsoXmlTag("CurFctr")]
    public IsoBaseOneRate? CurrentFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date.
    /// </summary>
    [IsoId("_kPMD5ag6EfCXwLUUylXgrQ")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public IsoBaseOneRate? NextFactor { get; init; }

    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_kPMD8ag6EfCXwLUUylXgrQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public IsoPercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Rate of return anticipated on a bond when held until maturity date.
    /// </summary>
    [IsoId("_kPMD_ag6EfCXwLUUylXgrQ")]
    [DisplayName("Yield To Maturity Rate")]
    [IsoXmlTag("YldToMtrtyRate")]
    public IsoPercentageRate? YieldToMaturityRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_kPMEA6g6EfCXwLUUylXgrQ")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    public IsoPercentageRate? NextInterestRate { get; init; }

    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_kPMED6g6EfCXwLUUylXgrQ")]
    [DisplayName("Index Rate Basis")]
    [IsoXmlTag("IndxRateBsis")]
    public IsoPercentageRate? IndexRateBasis { get; init; }

    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_kPMEG6g6EfCXwLUUylXgrQ")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    public Number22Choice? CouponAttachedNumber { get; init; }

    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_kPMEJ6g6EfCXwLUUylXgrQ")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    public GenericIdentification37? PoolNumber { get; init; }

    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_kPMEM6g6EfCXwLUUylXgrQ")]
    [DisplayName("Variable Rate Indicator")]
    [IsoXmlTag("VarblRateInd")]
    public IsoYesNoIndicator? VariableRateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_kPMEP6g6EfCXwLUUylXgrQ")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    public IsoYesNoIndicator? CallableIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_kPMES6g6EfCXwLUUylXgrQ")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    public IsoYesNoIndicator? PutableIndicator { get; init; }

    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    [IsoId("_kPMEV6g6EfCXwLUUylXgrQ")]
    [DisplayName("Market Or Indicative Price")]
    [IsoXmlTag("MktOrIndctvPric")]
    public PriceType4Choice? MarketOrIndicativePrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_kPMEY6g6EfCXwLUUylXgrQ")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public Price7? ExercisePrice { get; init; }

    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_kPMEb6g6EfCXwLUUylXgrQ")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public Price7? SubscriptionPrice { get; init; }

    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    [IsoId("_kPMEe6g6EfCXwLUUylXgrQ")]
    [DisplayName("Conversion Price")]
    [IsoXmlTag("ConvsPric")]
    public Price7? ConversionPrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_kPMEh6g6EfCXwLUUylXgrQ")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public Price7? StrikePrice { get; init; }

    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    [IsoId("_kPMEk6g6EfCXwLUUylXgrQ")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity1Choice? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_kPMEn6g6EfCXwLUUylXgrQ")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity1Choice? ContractSize { get; init; }

    /// <summary>
    /// Identification of the underlying security.
    /// </summary>
    [IsoId("_kPMEq6g6EfCXwLUUylXgrQ")]
    [DisplayName("Underlying Financial Instrument Identification")]
    [IsoXmlTag("UndrlygFinInstrmId")]
    public ValueList<SecurityIdentification19> UnderlyingFinancialInstrumentIdentification { get; init; } = [];

    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_kPMEt6g6EfCXwLUUylXgrQ")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    public IsoMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; }
}
