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
[IsoId("_3GaD4d0SEd-Cb-IGbQ4hBQ")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes15
{
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_3GaD490SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification5? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_fnmm4fk8Ed-u1pLmCBlmpg")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    [IsoId("_3GaD590SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Registration Form")]
    [IsoXmlTag("RegnForm")]
    public FormOfSecurity2Choice_? RegistrationForm { get; init; }

    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_3GaD6d0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency3Choice_? PaymentFrequency { get; init; }

    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_3GaD690SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Payment Status")]
    [IsoXmlTag("PmtSts")]
    public SecuritiesPaymentStatus2Choice_? PaymentStatus { get; init; }

    /// <summary>
    /// Indicates the direction of payment for asset or mortgage backed securities, that is, whether the repaid capital is distributed (payment direction is down) or capitalized (payment direction is up).
    /// </summary>
    [IsoId("_3GaD7d0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Payment Direction")]
    [IsoXmlTag("PmtDrctn")]
    public PaymentDirection2Choice_? PaymentDirection { get; init; }

    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_3GaD790SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Variable Rate Change Frequency")]
    [IsoXmlTag("VarblRateChngFrqcy")]
    public Frequency3Choice_? VariableRateChangeFrequency { get; init; }

    /// <summary>
    /// Indicates the level of priority to claim on income and assets of the company in case of the payment of dividends and in the event of a bankruptcy, for example, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// </summary>
    [IsoId("_3GaD8d0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Preference To Income")]
    [IsoXmlTag("PrefToIncm")]
    public PreferenceToIncome2Choice_? PreferenceToIncome { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_3GaD890SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType2Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_3GaD9d0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle4Choice_? OptionStyle { get; init; }

    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_3GaD990SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType2Choice_? OptionType { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_3GaD-d0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_3GaD-90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Coupon Date")]
    [IsoXmlTag("CpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CouponDate { get; init; }

    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_3GaD_d0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    [IsoId("_3GaD_90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_3GaEAd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_3GaEA90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_3GaEBd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_3GaEB90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_3GaECd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_3GaEC90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_3GaEDd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? PreviousFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_3GaED90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Current Factor")]
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? CurrentFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_3GaEEd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? NextFactor { get; init; }

    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_3GaEE90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_3GaEFd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextInterestRate { get; init; }

    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_3GaEF90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Index Rate Basis")]
    [IsoXmlTag("IndxRateBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? IndexRateBasis { get; init; }

    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_3GaEGd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    public Number2Choice_? CouponAttachedNumber { get; init; }

    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_3GaEG90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    public Number2Choice_? PoolNumber { get; init; }

    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_3GaEHd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Variable Rate Indicator")]
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? VariableRateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_3GaEH90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_3GaEId0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PutableIndicator { get; init; }

    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    [IsoId("_3GaEI90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Market Or Indicative Price")]
    [IsoXmlTag("MktOrIndctvPric")]
    public PriceType1Choice_? MarketOrIndicativePrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_3GaEJd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public Price2? ExercisePrice { get; init; }

    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_3GaEJ90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public Price2? SubscriptionPrice { get; init; }

    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    [IsoId("_3GaEKd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Conversion Price")]
    [IsoXmlTag("ConvsPric")]
    public Price2? ConversionPrice { get; init; }

    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_3GaEK90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public Price2? StrikePrice { get; init; }

    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_3GaELd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_3GaEL90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; }

    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_3GaEMd0SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Underlying Financial Instrument Identification")]
    [IsoXmlTag("UndrlygFinInstrmId")]
    public ValueList<SecurityIdentification14> UnderlyingFinancialInstrumentIdentification { get; init; } =
        [];

    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_3GaEM90SEd-Cb-IGbQ4hBQ")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; }
}
