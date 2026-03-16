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
[IsoId("_pK6Eof_hEeCcv6nahBzk1w")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes35
{
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_pK6Es__hEeCcv6nahBzk1w")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_pK6Evf_hEeCcv6nahBzk1w")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies the form, this is, ownership, of the security.
    /// </summary>
    [IsoId("_pK6Ex__hEeCcv6nahBzk1w")]
    [DisplayName("Registration Form")]
    [IsoXmlTag("RegnForm")]
    public FormOfSecurity2Choice_? RegistrationForm { get; init; }

    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_pK6E0f_hEeCcv6nahBzk1w")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency3Choice_? PaymentFrequency { get; init; }

    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_pK6E2__hEeCcv6nahBzk1w")]
    [DisplayName("Payment Status")]
    [IsoXmlTag("PmtSts")]
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; init; }

    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_pK6E7__hEeCcv6nahBzk1w")]
    [DisplayName("Variable Rate Change Frequency")]
    [IsoXmlTag("VarblRateChngFrqcy")]
    public Frequency3Choice_? VariableRateChangeFrequency { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_pK6FA__hEeCcv6nahBzk1w")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType2Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_pK6FDf_hEeCcv6nahBzk1w")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle4Choice_? OptionStyle { get; init; }

    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_pK6FF__hEeCcv6nahBzk1w")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType2Choice_? OptionType { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_pK6FIf_hEeCcv6nahBzk1w")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_pK6FK__hEeCcv6nahBzk1w")]
    [DisplayName("Coupon Date")]
    [IsoXmlTag("CpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CouponDate { get; init; }

    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_pK6FNf_hEeCcv6nahBzk1w")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    [IsoId("_pK6FP__hEeCcv6nahBzk1w")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_pK6FSf_hEeCcv6nahBzk1w")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_pK6FU__hEeCcv6nahBzk1w")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_pK6FXf_hEeCcv6nahBzk1w")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_pK6FZ__hEeCcv6nahBzk1w")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_pK6Fcf_hEeCcv6nahBzk1w")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_pK6Fe__hEeCcv6nahBzk1w")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_pK6Fhf_hEeCcv6nahBzk1w")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? PreviousFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_pK6Fj__hEeCcv6nahBzk1w")]
    [DisplayName("Current Factor")]
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? CurrentFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_pK6Fmf_hEeCcv6nahBzk1w")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? NextFactor { get; init; }

    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_pK6Fo__hEeCcv6nahBzk1w")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Rate of return anticipated on a bond when held until maturity date.
    /// </summary>
    [IsoId("_j2S1WwBuEeG6psVUIgNTZQ")]
    [DisplayName("Yield To Maturity Rate")]
    [IsoXmlTag("YldToMtrtyRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? YieldToMaturityRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_pK6Frf_hEeCcv6nahBzk1w")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextInterestRate { get; init; }

    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_pK6Ft__hEeCcv6nahBzk1w")]
    [DisplayName("Index Rate Basis")]
    [IsoXmlTag("IndxRateBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? IndexRateBasis { get; init; }

    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_pK6Fwf_hEeCcv6nahBzk1w")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    public Number2Choice_? CouponAttachedNumber { get; init; }

    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_pK6Fy__hEeCcv6nahBzk1w")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    public GenericIdentification37? PoolNumber { get; init; }

    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_pK6F1f_hEeCcv6nahBzk1w")]
    [DisplayName("Variable Rate Indicator")]
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? VariableRateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_pK6F3__hEeCcv6nahBzk1w")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_pK6F6f_hEeCcv6nahBzk1w")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PutableIndicator { get; init; }

    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    [IsoId("_pK6F8__hEeCcv6nahBzk1w")]
    [DisplayName("Market Or Indicative Price")]
    [IsoXmlTag("MktOrIndctvPric")]
    public PriceType1Choice_? MarketOrIndicativePrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_pK6F_f_hEeCcv6nahBzk1w")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public Price2? ExercisePrice { get; init; }

    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_pK6GB__hEeCcv6nahBzk1w")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public Price2? SubscriptionPrice { get; init; }

    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    [IsoId("_pK6GEf_hEeCcv6nahBzk1w")]
    [DisplayName("Conversion Price")]
    [IsoXmlTag("ConvsPric")]
    public Price2? ConversionPrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_pK6GG__hEeCcv6nahBzk1w")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public Price2? StrikePrice { get; init; }

    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_pK6GJf_hEeCcv6nahBzk1w")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_pK6GL__hEeCcv6nahBzk1w")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; }

    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_pK6GOf_hEeCcv6nahBzk1w")]
    [DisplayName("Underlying Financial Instrument Identification")]
    [IsoXmlTag("UndrlygFinInstrmId")]
    public ValueList<SecurityIdentification14> UnderlyingFinancialInstrumentIdentification { get; init; } =
        [];

    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_pLDOmf_hEeCcv6nahBzk1w")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; }
}
