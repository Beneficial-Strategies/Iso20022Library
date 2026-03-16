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
[IsoId("_gXIANhkMEeKSublfJr3XCg")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes44
{
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_gXIAvRkMEeKSublfJr3XCg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Assessment of securities credit and investment risk.
    /// </summary>
    [IsoId("_gXIARRkMEeKSublfJr3XCg")]
    [DisplayName("Rating")]
    [IsoXmlTag("Ratg")]
    public Rating1? Rating { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_gXRwsxkMEeKSublfJr3XCg")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateNumber { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_gXRwrRkMEeKSublfJr3XCg")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat3Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_gXIA3hkMEeKSublfJr3XCg")]
    [DisplayName("Registration Form")]
    [IsoXmlTag("RegnForm")]
    public FormOfSecurity4Choice_? RegistrationForm { get; init; }

    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_gXIAgRkMEeKSublfJr3XCg")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency7Choice_? PaymentFrequency { get; init; }

    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_gXIAYBkMEeKSublfJr3XCg")]
    [DisplayName("Variable Rate Change Frequency")]
    [IsoXmlTag("VarblRateChngFrqcy")]
    public Frequency7Choice_? VariableRateChangeFrequency { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_gXIAzxkMEeKSublfJr3XCg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType30Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_gXRwoRkMEeKSublfJr3XCg")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle6Choice_? OptionStyle { get; init; }

    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_gXIAVxkMEeKSublfJr3XCg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType4Choice_? OptionType { get; init; }

    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_gXRwwhkMEeKSublfJr3XCg")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_gXRwyBkMEeKSublfJr3XCg")]
    [DisplayName("Coupon Date")]
    [IsoXmlTag("CpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CouponDate { get; init; }

    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_gXIAnBkMEeKSublfJr3XCg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    [IsoId("_gXRw1BkMEeKSublfJr3XCg")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_gXIAURkMEeKSublfJr3XCg")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_gXIAhxkMEeKSublfJr3XCg")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_gXIAZhkMEeKSublfJr3XCg")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Deadline by which a convertible security must be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_gXRwqhkMEeKSublfJr3XCg")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_gXIA_xkMEeKSublfJr3XCg")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_gXIA6hkMEeKSublfJr3XCg")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_gXIAeBkMEeKSublfJr3XCg")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Date on which the current factor will be changed to the next factor.
    /// </summary>
    [IsoId("_gXIAmRkMEeKSublfJr3XCg")]
    [DisplayName("Next Factor Date")]
    [IsoXmlTag("NxtFctrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextFactorDate { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_gXIArhkMEeKSublfJr3XCg")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? PreviousFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_gXRwmxkMEeKSublfJr3XCg")]
    [DisplayName("Current Factor")]
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? CurrentFactor { get; init; }

    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_gXRwuRkMEeKSublfJr3XCg")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? NextFactor { get; init; }

    /// <summary>
    /// End ratio of principal outstanding to the original balance.
    /// </summary>
    [IsoId("_gXIAohkMEeKSublfJr3XCg")]
    [DisplayName("End Factor")]
    [IsoXmlTag("EndFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? EndFactor { get; init; }

    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_gXIAjRkMEeKSublfJr3XCg")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_gXIAwxkMEeKSublfJr3XCg")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextInterestRate { get; init; }

    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_gXIA5BkMEeKSublfJr3XCg")]
    [DisplayName("Index Rate Basis")]
    [IsoXmlTag("IndxRateBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? IndexRateBasis { get; init; }

    /// <summary>
    /// Percentage of the underlying assets of a fund that represents a debt, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_gXIApRkMEeKSublfJr3XCg")]
    [DisplayName("Percentage Of Debt Claims")]
    [IsoXmlTag("PctgOfDebtClms")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfDebtClaims { get; init; }

    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_gXIAPxkMEeKSublfJr3XCg")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    public Number1Choice_? CouponAttachedNumber { get; init; }

    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_gXIAtxkMEeKSublfJr3XCg")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    public GenericIdentification37? PoolNumber { get; init; }

    /// <summary>
    /// Number allocated by options exchanges to record that an option has undergone a change in its contract specifications (particularly adjustment of the strike price).
    /// </summary>
    [IsoId("_gXIAXRkMEeKSublfJr3XCg")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    public Number1Choice_? VersionNumber { get; init; }

    /// <summary>
    /// Indicates whether the interest bearing security is convertible into another type of security.
    /// </summary>
    [IsoId("_gXIAbBkMEeKSublfJr3XCg")]
    [DisplayName("Convertible Indicator")]
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; }

    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_gXIAqBkMEeKSublfJr3XCg")]
    [DisplayName("Variable Rate Indicator")]
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? VariableRateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the underlying security is owned by the writer of the entitlement.
    /// </summary>
    [IsoId("_gXIA2xkMEeKSublfJr3XCg")]
    [DisplayName("Covered Indicator")]
    [IsoXmlTag("CvrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CoveredIndicator { get; init; }

    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_gXIA-RkMEeKSublfJr3XCg")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_gXIA8BkMEeKSublfJr3XCg")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PutableIndicator { get; init; }

    /// <summary>
    /// Indicates whether the warrants on a financial instrument (which has been traded cum warrants) will be attached on delivery.
    /// </summary>
    [IsoId("_gXIA2BkMEeKSublfJr3XCg")]
    [DisplayName("Warrant Attached On Delivery")]
    [IsoXmlTag("WarrtAttchdOnDlvry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WarrantAttachedOnDelivery { get; init; }

    /// <summary>
    /// Indicates whether the payment of the coupon (interest) on an interest bearing instrument is off the normal schedule.
    /// </summary>
    [IsoId("_gXIAchkMEeKSublfJr3XCg")]
    [DisplayName("Odd Coupon Indicator")]
    [IsoXmlTag("OddCpnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OddCouponIndicator { get; init; }

    /// <summary>
    /// Indicates whether, in the case of a debt security subject to redemption before maturity, such redemption could have an impact on the yield.
    /// </summary>
    [IsoId("_gXIAbxkMEeKSublfJr3XCg")]
    [DisplayName("Redemption Yield Impact")]
    [IsoXmlTag("RedYldImpct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RedemptionYieldImpact { get; init; }

    /// <summary>
    /// Indicates whether the actual yield of an asset-backed security may vary according to the rate at which the underlying receivables or other financial assets are prepaid.
    /// </summary>
    [IsoId("_gXRwvxkMEeKSublfJr3XCg")]
    [DisplayName("Yield Variance")]
    [IsoXmlTag("YldVar")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? YieldVariance { get; init; }

    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_gXIAyRkMEeKSublfJr3XCg")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public Price4? ExercisePrice { get; init; }

    /// <summary>
    /// Fixed price at which a new securities issue is being offered to the public.
    /// </summary>
    [IsoId("_gXIAkxkMEeKSublfJr3XCg")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public Price4? SubscriptionPrice { get; init; }

    /// <summary>
    /// Price at which a given convertible security can be converted to common stock.
    /// </summary>
    [IsoId("_gXIAORkMEeKSublfJr3XCg")]
    [DisplayName("Conversion Price")]
    [IsoXmlTag("ConvsPric")]
    public Price4? ConversionPrice { get; init; }

    /// <summary>
    /// Amount included in the Net Asset Value(NAV) that corresponds to gains directly or indirectly derived from interest payment, for example in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_gXIA9hkMEeKSublfJr3XCg")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public Price4? TaxableIncomePerShare { get; init; }

    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_gXRwlRkMEeKSublfJr3XCg")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_gXRwpxkMEeKSublfJr3XCg")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_gXRwthkMEeKSublfJr3XCg")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    [IsoXmlTag("MinExrcblMltplQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; }

    /// <summary>
    /// Signed face amount and amortised value of security.
    /// </summary>
    [IsoId("_gXIAdRkMEeKSublfJr3XCg")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_gXRwzhkMEeKSublfJr3XCg")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity18Choice_? ContractSize { get; init; }

    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_gXIASxkMEeKSublfJr3XCg")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; }
}
