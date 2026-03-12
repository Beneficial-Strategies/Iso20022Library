// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_gIw9wQeGEe2fOITqoTnSLQ")]
[DisplayName("Financial Instrument Attributes")]
public partial record FinancialInstrumentAttributes124
{
    #nullable enable
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_gbP05weGEe2fOITqoTnSLQ")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    
    /// <summary>
    /// Assessment of securities credit and investment risk.
    /// </summary>
    [IsoId("_gbP07weGEe2fOITqoTnSLQ")]
    [DisplayName("Rating")]
    [IsoXmlTag("Ratg")]
    public Rating1? Rating { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_gbP09weGEe2fOITqoTnSLQ")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CertificateNumber { get; init; } 
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_gbP0-QeGEe2fOITqoTnSLQ")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; } 
    
    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_gbP1AQeGEe2fOITqoTnSLQ")]
    [DisplayName("Registration Form")]
    [IsoXmlTag("RegnForm")]
    public FormOfSecurity6Choice_? RegistrationForm { get; init; } 
    
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_gbP1CQeGEe2fOITqoTnSLQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency23Choice_? PaymentFrequency { get; init; } 
    
    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    [IsoId("_gbP1EQeGEe2fOITqoTnSLQ")]
    [DisplayName("Variable Rate Change Frequency")]
    [IsoXmlTag("VarblRateChngFrqcy")]
    public Frequency23Choice_? VariableRateChangeFrequency { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_gbP1GQeGEe2fOITqoTnSLQ")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; } 
    
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_gbP1IQeGEe2fOITqoTnSLQ")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle10Choice_? OptionStyle { get; init; } 
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_gbP1KQeGEe2fOITqoTnSLQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType6Choice_? OptionType { get; init; } 
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_gbP1MQeGEe2fOITqoTnSLQ")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_gbP1OQeGEe2fOITqoTnSLQ")]
    [DisplayName("Coupon Date")]
    [IsoXmlTag("CpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CouponDate { get; init; } 
    
    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_gbP1QQeGEe2fOITqoTnSLQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    [IsoId("_gbP1SQeGEe2fOITqoTnSLQ")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_gbP1UQeGEe2fOITqoTnSLQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; } 
    
    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_gbP1WQeGEe2fOITqoTnSLQ")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; } 
    
    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    [IsoId("_gbP1YQeGEe2fOITqoTnSLQ")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; } 
    
    /// <summary>
    /// Deadline by which a convertible security must be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_gbP1aQeGEe2fOITqoTnSLQ")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; } 
    
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_gbP1aweGEe2fOITqoTnSLQ")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; } 
    
    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_gbP1cweGEe2fOITqoTnSLQ")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; } 
    
    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_gbP1eweGEe2fOITqoTnSLQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; } 
    
    /// <summary>
    /// Date on which the current factor will be changed to the next factor.
    /// </summary>
    [IsoId("_gbP1gweGEe2fOITqoTnSLQ")]
    [DisplayName("Next Factor Date")]
    [IsoXmlTag("NxtFctrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextFactorDate { get; init; } 
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_gbP1hQeGEe2fOITqoTnSLQ")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? PreviousFactor { get; init; } 
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_gbP1jQeGEe2fOITqoTnSLQ")]
    [DisplayName("Current Factor")]
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? CurrentFactor { get; init; } 
    
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    [IsoId("_gbP1lQeGEe2fOITqoTnSLQ")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? NextFactor { get; init; } 
    
    /// <summary>
    /// End ratio of principal outstanding to the original balance.
    /// </summary>
    [IsoId("_gbP1nQeGEe2fOITqoTnSLQ")]
    [DisplayName("End Factor")]
    [IsoXmlTag("EndFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? EndFactor { get; init; } 
    
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_gbP1nweGEe2fOITqoTnSLQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; } 
    
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_gbP1pweGEe2fOITqoTnSLQ")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextInterestRate { get; init; } 
    
    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    [IsoId("_gbP1rweGEe2fOITqoTnSLQ")]
    [DisplayName("Index Rate Basis")]
    [IsoXmlTag("IndxRateBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? IndexRateBasis { get; init; } 
    
    /// <summary>
    /// Percentage of the underlying assets of a fund that represents a debt, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_gbP1tweGEe2fOITqoTnSLQ")]
    [DisplayName("Percentage Of Debt Claims")]
    [IsoXmlTag("PctgOfDebtClms")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfDebtClaims { get; init; } 
    
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_gbP1uQeGEe2fOITqoTnSLQ")]
    [DisplayName("Coupon Attached Number")]
    [IsoXmlTag("CpnAttchdNb")]
    public Number1Choice_? CouponAttachedNumber { get; init; } 
    
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_gbP1wQeGEe2fOITqoTnSLQ")]
    [DisplayName("Pool Number")]
    [IsoXmlTag("PoolNb")]
    public GenericIdentification37? PoolNumber { get; init; } 
    
    /// <summary>
    /// Number allocated by options exchanges to record that an option has undergone a change in its contract specifications (particularly adjustment of the strike price).
    /// </summary>
    [IsoId("_gbP1yQeGEe2fOITqoTnSLQ")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    public Number1Choice_? VersionNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest bearing security is convertible into another type of security.
    /// </summary>
    [IsoId("_gbP1yweGEe2fOITqoTnSLQ")]
    [DisplayName("Convertible Indicator")]
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_gbP1zQeGEe2fOITqoTnSLQ")]
    [DisplayName("Variable Rate Indicator")]
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? VariableRateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the underlying security is owned by the writer of the entitlement.
    /// </summary>
    [IsoId("_gbP11QeGEe2fOITqoTnSLQ")]
    [DisplayName("Covered Indicator")]
    [IsoXmlTag("CvrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CoveredIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_gbP11weGEe2fOITqoTnSLQ")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_gbP13weGEe2fOITqoTnSLQ")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the warrants on a financial instrument (which has been traded cum warrants) will be attached on delivery.
    /// </summary>
    [IsoId("_gbP15weGEe2fOITqoTnSLQ")]
    [DisplayName("Warrant Attached On Delivery")]
    [IsoXmlTag("WarrtAttchdOnDlvry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WarrantAttachedOnDelivery { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment of the coupon (interest) on an interest bearing instrument is off the normal schedule.
    /// </summary>
    [IsoId("_gbP16QeGEe2fOITqoTnSLQ")]
    [DisplayName("Odd Coupon Indicator")]
    [IsoXmlTag("OddCpnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OddCouponIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether, in the case of a debt security subject to redemption before maturity, such redemption could have an impact on the yield.
    /// </summary>
    [IsoId("_gbP16weGEe2fOITqoTnSLQ")]
    [DisplayName("Redemption Yield Impact")]
    [IsoXmlTag("RedYldImpct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RedemptionYieldImpact { get; init; } 
    
    /// <summary>
    /// Indicates whether the actual yield of an asset-backed security may vary according to the rate at which the underlying receivables or other financial assets are prepaid.
    /// </summary>
    [IsoId("_gbP17QeGEe2fOITqoTnSLQ")]
    [DisplayName("Yield Variance")]
    [IsoXmlTag("YldVar")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? YieldVariance { get; init; } 
    
    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_gbP17weGEe2fOITqoTnSLQ")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public Price14? ExercisePrice { get; init; } 
    
    /// <summary>
    /// Fixed price at which a new securities issue is being offered to the public.
    /// </summary>
    [IsoId("_gbP19weGEe2fOITqoTnSLQ")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public Price14? SubscriptionPrice { get; init; } 
    
    /// <summary>
    /// Price at which a given convertible security can be converted to common stock.
    /// </summary>
    [IsoId("_gbP1_weGEe2fOITqoTnSLQ")]
    [DisplayName("Conversion Price")]
    [IsoXmlTag("ConvsPric")]
    public Price14? ConversionPrice { get; init; } 
    
    /// <summary>
    /// Amount included in the Net Asset Value(NAV) that corresponds to gains directly or indirectly derived from interest payment, for example in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_gbP2BweGEe2fOITqoTnSLQ")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public Price14? TaxableIncomePerShare { get; init; } 
    
    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_gbP2CQeGEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    
    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_gbP2EQeGEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    
    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_gbP2EweGEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    [IsoXmlTag("MinExrcblMltplQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    
    /// <summary>
    /// Signed face amount and amortised value of security.
    /// </summary>
    [IsoId("_gbP2FQeGEe2fOITqoTnSLQ")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; } 
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_gbP2FweGEe2fOITqoTnSLQ")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity18Choice_? ContractSize { get; init; } 
    
    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    [IsoId("_gbP2HweGEe2fOITqoTnSLQ")]
    [DisplayName("Financial Instrument Attribute Additional Details")]
    [IsoXmlTag("FinInstrmAttrAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    
    
    #nullable disable
    
}
