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
[IsoId("_SKLU183yEee5nJBZsW8MFQ")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes95
{
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_SKLU383yEee5nJBZsW8MFQ")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification4Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_SKLU583yEee5nJBZsW8MFQ")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies the form, this is, ownership, of the security.
    /// </summary>
    [IsoId("_SKLU783yEee5nJBZsW8MFQ")]
    [DisplayName("Registration Form")]
    [IsoXmlTag("RegnForm")]
    public FormOfSecurity7Choice_? RegistrationForm { get; init; }

    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_SKLU983yEee5nJBZsW8MFQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency27Choice_? PaymentFrequency { get; init; }

    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_SKLU_83yEee5nJBZsW8MFQ")]
    [DisplayName("Payment Status")]
    [IsoXmlTag("PmtSts")]
    public SecuritiesPaymentStatus6Choice_? PaymentStatus { get; init; }

    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_SKLVB83yEee5nJBZsW8MFQ")]
    [DisplayName("Variable Rate Change Frequency")]
    [IsoXmlTag("VarblRateChngFrqcy")]
    public Frequency27Choice_? VariableRateChangeFrequency { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_SKLVD83yEee5nJBZsW8MFQ")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType33Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_SKLVF83yEee5nJBZsW8MFQ")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle9Choice_? OptionStyle { get; init; }

    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_SKLVH83yEee5nJBZsW8MFQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType7Choice_? OptionType { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_SKLVJ83yEee5nJBZsW8MFQ")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_SKLVL83yEee5nJBZsW8MFQ")]
    [DisplayName("Coupon Date")]
    [IsoXmlTag("CpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CouponDate { get; init; }

    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_SKLVN83yEee5nJBZsW8MFQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    [IsoId("_SKLVP83yEee5nJBZsW8MFQ")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_SKLVR83yEee5nJBZsW8MFQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_SKLVT83yEee5nJBZsW8MFQ")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_SKLVV83yEee5nJBZsW8MFQ")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_SKLVX83yEee5nJBZsW8MFQ")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_SKLVZ83yEee5nJBZsW8MFQ")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_SKLVb83yEee5nJBZsW8MFQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_SKLVd83yEee5nJBZsW8MFQ")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? PreviousFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_SKLVf83yEee5nJBZsW8MFQ")]
    [DisplayName("Current Factor")]
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? CurrentFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_SKLVh83yEee5nJBZsW8MFQ")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? NextFactor { get; init; }

    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_SKLVj83yEee5nJBZsW8MFQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Rate of return anticipated on a bond when held until maturity date.
    /// </summary>
    [IsoId("_SKLVl83yEee5nJBZsW8MFQ")]
    [DisplayName("Yield To Maturity Rate")]
    [IsoXmlTag("YldToMtrtyRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? YieldToMaturityRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_SKLVmc3yEee5nJBZsW8MFQ")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextInterestRate { get; init; }

    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_SKLVoc3yEee5nJBZsW8MFQ")]
    [DisplayName("Index Rate Basis")]
    [IsoXmlTag("IndxRateBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? IndexRateBasis { get; init; }

    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_SKLVqc3yEee5nJBZsW8MFQ")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    public Number23Choice_? CouponAttachedNumber { get; init; }

    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_SKLVsc3yEee5nJBZsW8MFQ")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    public GenericIdentification39? PoolNumber { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_SKLVuc3yEee5nJBZsW8MFQ")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown33> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_SKLVu83yEee5nJBZsW8MFQ")]
    [DisplayName("Variable Rate Indicator")]
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? VariableRateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_SKLVw83yEee5nJBZsW8MFQ")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_SKLVy83yEee5nJBZsW8MFQ")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PutableIndicator { get; init; }

    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    [IsoId("_SKLV083yEee5nJBZsW8MFQ")]
    [DisplayName("Market Or Indicative Price")]
    [IsoXmlTag("MktOrIndctvPric")]
    public PriceType5Choice_? MarketOrIndicativePrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_SKLV283yEee5nJBZsW8MFQ")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public Price3? ExercisePrice { get; init; }

    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_SKLV483yEee5nJBZsW8MFQ")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public Price3? SubscriptionPrice { get; init; }

    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    [IsoId("_SKLV683yEee5nJBZsW8MFQ")]
    [DisplayName("Conversion Price")]
    [IsoXmlTag("ConvsPric")]
    public Price3? ConversionPrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_SKLV883yEee5nJBZsW8MFQ")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public Price3? StrikePrice { get; init; }

    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    [IsoId("_SKLV-83yEee5nJBZsW8MFQ")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_SKLWA83yEee5nJBZsW8MFQ")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; init; }

    /// <summary>
    /// Identification of the underlying security.
    /// </summary>
    [IsoId("_SKLWC83yEee5nJBZsW8MFQ")]
    [DisplayName("Underlying Financial Instrument Identification")]
    [IsoXmlTag("UndrlygFinInstrmId")]
    public ValueList<SecurityIdentification32> UnderlyingFinancialInstrumentIdentification { get; init; } =
        [];

    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_SKLWE83yEee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; }
}
