// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instruments evidencing moneys owed by the issuer to the holder on terms as specified.
/// </summary>
[IsoId("_MS6w6ZJOEeuAlLVx8pyt3w")]
[DisplayName("Debt")]
public partial record Debt5
{
    #nullable enable
    
    /// <summary>
    /// Currency of the payment.
    /// </summary>
    [IsoId("_MVJlhZJOEeuAlLVx8pyt3w")]
    [DisplayName("Payment Currency")]
    [IsoXmlTag("PmtCcy")]
    public ActiveCurrencyCode? PaymentCurrency { get; init; } 
    
    /// <summary>
    /// Unit value of a debt security.
    /// </summary>
    [IsoId("_MVJlh5JOEeuAlLVx8pyt3w")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public ActiveCurrencyAndAmount? FaceAmount { get; init; } 
    
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_MVJliZJOEeuAlLVx8pyt3w")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency35Choice_? PaymentFrequency { get; init; } 
    
    /// <summary>
    /// Date/time at which the rate determination is made, also called determination date.
    /// </summary>
    [IsoId("_MVJli5JOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Fixing Date")]
    [IsoXmlTag("IntrstFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InterestFixingDate { get; init; } 
    
    /// <summary>
    /// First date/time at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_MVJljZJOEeuAlLVx8pyt3w")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DatedDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_MVJllZJOEeuAlLVx8pyt3w")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FirstPaymentDate { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_MVJll5JOEeuAlLVx8pyt3w")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MaturityDate { get; init; } 
    
    /// <summary>
    /// Date of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_MVJlq5JOEeuAlLVx8pyt3w")]
    [DisplayName("Next Coupon Date")]
    [IsoXmlTag("NxtCpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? NextCouponDate { get; init; } 
    
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_MVJls5JOEeuAlLVx8pyt3w")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? PutableDate { get; init; } 
    
    /// <summary>
    /// Next date/time at which the issuer has the right to pay the securitiy prior to maturity.
    /// </summary>
    [IsoId("_MVJltZJOEeuAlLVx8pyt3w")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? NextCallableDate { get; init; } 
    
    /// <summary>
    /// The date that the current factor will be changed to a new factor.
    /// </summary>
    [IsoId("_MVJlt5JOEeuAlLVx8pyt3w")]
    [DisplayName("Next Factor Date")]
    [IsoXmlTag("NxtFctrDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? NextFactorDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an interest bearing security becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_MVJluZJOEeuAlLVx8pyt3w")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExpirationDate { get; init; } 
    
    /// <summary>
    /// Indicates the direction of payment for asset or mortgage backed securities, ie, whether the repaid capital is distributed (payment direction is down) or capitalized (payment direction is up).
    /// </summary>
    [IsoId("_MVJlu5JOEeuAlLVx8pyt3w")]
    [DisplayName("Payment Direction Indicator")]
    [IsoXmlTag("PmtDrctnInd")]
    [IsoSimpleType(IsoSimpleType.PaymentDirectionIndicator)]
    public IsoPaymentDirectionIndicator? PaymentDirectionIndicator { get; init; } 
    
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_MVJlvZJOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; } 
    
    /// <summary>
    /// Specifies the interest rate applicable to the next interest payment period.
    /// </summary>
    [IsoId("_MVJlxZJOEeuAlLVx8pyt3w")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextInterestRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the payment of the coupon (interest) on a bond is off the normal schedule.
    /// </summary>
    [IsoId("_MVJlx5JOEeuAlLVx8pyt3w")]
    [DisplayName("Odd Coupon Indicator")]
    [IsoXmlTag("OddCpnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OddCouponIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_MVJlyZJOEeuAlLVx8pyt3w")]
    [DisplayName("Callable Indicator")]
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    
    /// <summary>
    /// The program under which a commercial paper is issued. The values that are most used are:
    /// 0 = N/A
    /// 1 = 3(a)3
    /// 2 = 4(2)
    /// 3 = 3(a)4
    /// 4 = 3(c)7
    /// 5 = 144A
    /// 6 = 3(a)2
    /// 99 = Other.
    /// </summary>
    [IsoId("_MVJly5JOEeuAlLVx8pyt3w")]
    [DisplayName("CP Program")]
    [IsoXmlTag("CPPrgm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? CPProgram { get; init; } 
    
    /// <summary>
    /// Registration type of a commercial paper issuance.
    /// </summary>
    [IsoId("_MVJl05JOEeuAlLVx8pyt3w")]
    [DisplayName("CP Registration Type")]
    [IsoXmlTag("CPRegnTp")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? CPRegistrationType { get; init; } 
    
    /// <summary>
    /// Start date used for calculating accrued interest on debt instruments which are being sold between interest payment dates. Often but not always the same as the issue date and the dated date.
    /// </summary>
    [IsoId("_MVJl25JOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Accrual Date")]
    [IsoXmlTag("IntrstAcrlDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InterestAccrualDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_MVJl45JOEeuAlLVx8pyt3w")]
    [DisplayName("Putable Indicator")]
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether an interest bearing instrument is being escrowed or collateralized either by direct obligations guaranteed by the US government, or by other types of securities. The maturity schedules of the securities in the escrow fund are determined in such a way to pay the maturity value, coupon, and premium payments (if any) of the refunded bonds.
    /// </summary>
    [IsoId("_MVJl5ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pre Funded Indicator")]
    [IsoXmlTag("PreFnddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PreFundedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether an interest bearing instrument is deposited in a fund that will be used to pay debt service on refunded securities.
    /// </summary>
    [IsoId("_MVJl55JOEeuAlLVx8pyt3w")]
    [DisplayName("Escrowed Indicator")]
    [IsoXmlTag("EscrwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EscrowedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the security has no maturity date.
    /// </summary>
    [IsoId("_MVJl6ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Perpetual Indicator")]
    [IsoXmlTag("PerptlInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PerpetualIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the security is a subordinated security.
    /// </summary>
    [IsoId("_MVJl65JOEeuAlLVx8pyt3w")]
    [DisplayName("Subordinated Indicator")]
    [IsoXmlTag("SubrdntdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SubordinatedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the security is extendible,eg, repayment may be extended or maturity changed.
    /// </summary>
    [IsoId("_MVJl7ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Extendible Indicator")]
    [IsoXmlTag("XtndblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExtendibleIndicator { get; init; } 
    
    /// <summary>
    /// Period during which a date might be extended.
    /// </summary>
    [IsoId("_MVJl75JOEeuAlLVx8pyt3w")]
    [DisplayName("Extendible Period")]
    [IsoXmlTag("XtndblPrd")]
    public DateTimePeriod1Choice_? ExtendiblePeriod { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_MVJl8ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Variable Rate Indicator")]
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? VariableRateIndicator { get; init; } 
    
    /// <summary>
    /// Amount for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_MVJl85JOEeuAlLVx8pyt3w")]
    [DisplayName("Over Allotment Amount")]
    [IsoXmlTag("OverAlltmtAmt")]
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; init; } 
    
    /// <summary>
    /// Percentage for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_MVJl9ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Over Allotment Rate")]
    [IsoXmlTag("OverAlltmtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? OverAllotmentRate { get; init; } 
    
    /// <summary>
    /// Indicates whether repayment is made via regular principal and interest payments over time.
    /// </summary>
    [IsoId("_MVJl95JOEeuAlLVx8pyt3w")]
    [DisplayName("Amortisable Indicator")]
    [IsoXmlTag("AmtsblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AmortisableIndicator { get; init; } 
    
    /// <summary>
    /// Calculation method used to calculate interest and/or yield for a bond, for example, street convention.
    /// </summary>
    [IsoId("_MVJl-ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Calculation Method")]
    [IsoXmlTag("IntrstClctnMtd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? InterestCalculationMethod { get; init; } 
    
    /// <summary>
    /// Specifies whether the interest amount is capitalised until maturity date or paid out at each interest payment date.
    /// </summary>
    [IsoId("_MVJl-5JOEeuAlLVx8pyt3w")]
    [DisplayName("Capitalised Interest")]
    [IsoXmlTag("CptlsdIntrst")]
    public DistributionPolicy2Choice_? CapitalisedInterest { get; init; } 
    
    /// <summary>
    /// Nominal value per security unit.
    /// </summary>
    [IsoId("_MVJl_ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Actual Denomination Amount")]
    [IsoXmlTag("ActlDnmtnAmt")]
    public ActiveCurrencyAndAmount? ActualDenominationAmount { get; init; } 
    
    /// <summary>
    /// Identifies the current factor expressed as a decimal between 0 and 1 defining the outstanding principal of the bond (for factored securities).
    /// </summary>
    [IsoId("_MVJl_5JOEeuAlLVx8pyt3w")]
    [DisplayName("Current Factor")]
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CurrentFactor { get; init; } 
    
    /// <summary>
    /// Identifies the new factor expressed as a decimal between 0 and 1 defining the outstanding principal of the bond (for factored securities).
    /// </summary>
    [IsoId("_MVJmAZJOEeuAlLVx8pyt3w")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextFactor { get; init; } 
    
    /// <summary>
    /// Identifies the previous factor expressed as a decimal between 0 and 1 defining the outstanding principal of the bond (for factored securities).
    /// </summary>
    [IsoId("_MVJmA5JOEeuAlLVx8pyt3w")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PreviousFactor { get; init; } 
    
    /// <summary>
    /// Number of pieces composing a pool of financial assets.
    /// </summary>
    [IsoId("_MVJmBZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pieces")]
    [IsoXmlTag("Pcs")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Pieces { get; init; } 
    
    /// <summary>
    /// Collection of assets by which a security is backed.
    /// </summary>
    [IsoId("_MVJmB5JOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Maximum")]
    [IsoXmlTag("PlsMax")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PoolsMaximum { get; init; } 
    
    /// <summary>
    /// Indicates per million the collection of loans, mortgages or other assets assembled by an originator as the basis for a security.
    /// </summary>
    [IsoId("_MVJmCZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Per Million")]
    [IsoXmlTag("PlsPerMln")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PoolsPerMillion { get; init; } 
    
    /// <summary>
    /// Indicates per lot the collection of loans, mortgages or other assets assembled by an originator as the basis for a security.
    /// </summary>
    [IsoId("_MVJmC5JOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Per Lot")]
    [IsoXmlTag("PlsPerLot")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PoolsPerLot { get; init; } 
    
    /// <summary>
    /// Indicates per trade the collection of loans, mortgages or other assets assembled by an originator as the basis for a security.
    /// </summary>
    [IsoId("_MVJmDZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Per Trade")]
    [IsoXmlTag("PlsPerTrad")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? PoolsPerTrade { get; init; } 
    
    /// <summary>
    /// Indicates whether a penalty might be imposed to the borrower of a mortgage in case of prepayments occurring during the lockout period.
    /// </summary>
    [IsoId("_MVJmD5JOEeuAlLVx8pyt3w")]
    [DisplayName("Constant Pre Payment Penalty Indicator")]
    [IsoXmlTag("CstPrePmtPnltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConstantPrePaymentPenaltyIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the lot constituting an asset backed or mortgage backed security issue.
    /// </summary>
    [IsoId("_MVJmEZJOEeuAlLVx8pyt3w")]
    [DisplayName("Lot Identification")]
    [IsoXmlTag("LotId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LotIdentification { get; init; } 
    
    /// <summary>
    /// Measure of prepayment as a yield of the current outstanding loan balance.
    /// </summary>
    [IsoId("_MVJmE5JOEeuAlLVx8pyt3w")]
    [DisplayName("Constant Pre Payment Yield")]
    [IsoXmlTag("CstPrePmtYld")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ConstantPrePaymentYield { get; init; } 
    
    /// <summary>
    /// Contains the weighted average coupon of the fixed income instrument (expressed as a percentage).
    /// </summary>
    [IsoId("_MVJmFZJOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Coupon")]
    [IsoXmlTag("WghtdAvrgCpn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? WeightedAverageCoupon { get; init; } 
    
    /// <summary>
    /// Contains the weighted average life of the fixed income instrument (expressed in months).
    /// </summary>
    [IsoId("_MVJmF5JOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Life")]
    [IsoXmlTag("WghtdAvrgLife")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? WeightedAverageLife { get; init; } 
    
    /// <summary>
    /// Contains the weighted average loan of the fixed income instrument (expressed in months).
    /// </summary>
    [IsoId("_MVJmGZJOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Loan")]
    [IsoXmlTag("WghtdAvrgLn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? WeightedAverageLoan { get; init; } 
    
    /// <summary>
    /// Contains the weighted average maturity of the fixed income instrument (expressed in months).
    /// </summary>
    [IsoId("_MVJmG5JOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Maturity")]
    [IsoXmlTag("WghtdAvrgMtrty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? WeightedAverageMaturity { get; init; } 
    
    /// <summary>
    /// Indicates whether the instrument is backed by any kind of asset or not.
    /// </summary>
    [IsoId("_MVJmHZJOEeuAlLVx8pyt3w")]
    [DisplayName("Insured Indicator")]
    [IsoXmlTag("InsrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InsuredIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the security is bank qualified (usually applies to loan products).
    /// </summary>
    [IsoId("_MVJmH5JOEeuAlLVx8pyt3w")]
    [DisplayName("Bank Qualified Indicator")]
    [IsoXmlTag("BkQlfdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BankQualifiedIndicator { get; init; } 
    
    /// <summary>
    /// Rate of return on an investment, based on the price.
    /// </summary>
    [IsoId("_MVJmIZJOEeuAlLVx8pyt3w")]
    [DisplayName("Yield Calculation")]
    [IsoXmlTag("YldClctn")]
    public YieldCalculation6? YieldCalculation { get; init; } 
    
    /// <summary>
    /// Indicates whether interest rate is fixed, variable or other.
    /// </summary>
    [IsoId("_MVJmI5JOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Type")]
    [IsoXmlTag("IntrstTp")]
    public InterestType3Code? InterestType { get; init; } 
    
    /// <summary>
    /// Indicates the type of deal for structured finance.
    /// </summary>
    [IsoId("_MVJmJZJOEeuAlLVx8pyt3w")]
    [DisplayName("Instrument Structure Type")]
    [IsoXmlTag("InstrmStrTp")]
    public InstrumentSubStructureType2Choice_? InstrumentStructureType { get; init; } 
    
    /// <summary>
    /// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
    /// New Global Note (NGN): Form of global certificate which refers to the books and records of the ICSDs to determine the issue outstanding amount (IOA). 
    /// Classical Global Note (CGN): Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the issue outstanding amount (IOA).
    /// </summary>
    [IsoId("_MVJmJ5JOEeuAlLVx8pyt3w")]
    [DisplayName("Global Type")]
    [IsoXmlTag("GblTp")]
    public GlobalNote2Choice_? GlobalType { get; init; } 
    
    /// <summary>
    /// Flag to indicate the security is intended to be held in a manner that could allow the Eurosystem eligibility.
    /// </summary>
    [IsoId("_MVJmKZJOEeuAlLVx8pyt3w")]
    [DisplayName("Potential Euro System Eligibility")]
    [IsoXmlTag("PotntlEuroSysElgblty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PotentialEuroSystemEligibility { get; init; } 
    
    /// <summary>
    /// Type of stipulation expressing geographical constraints on a fixed income instrument. It is expressed with a state or country abbreviation and a minimum or maximum percentage. Example: CA 0-80 (minimum of 80 percent in Californian assets).
    /// </summary>
    [IsoId("_MVJmK5JOEeuAlLVx8pyt3w")]
    [DisplayName("Geographics")]
    [IsoXmlTag("Geogcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Geographics { get; init; } 
    
    /// <summary>
    /// Range of allowed yield.
    /// </summary>
    [IsoId("_MVJmM5JOEeuAlLVx8pyt3w")]
    [DisplayName("Yield Range")]
    [IsoXmlTag("YldRg")]
    public AmountOrPercentageRange1? YieldRange { get; init; } 
    
    /// <summary>
    /// Identification of a range of coupon numbers attached to its related financial instrument.
    /// </summary>
    [IsoId("_MVJmNZJOEeuAlLVx8pyt3w")]
    [DisplayName("Coupon Range")]
    [IsoXmlTag("CpnRg")]
    public AmountOrPercentageRange1? CouponRange { get; init; } 
    
    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_MVJmN5JOEeuAlLVx8pyt3w")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Purpose { get; init; } 
    
    /// <summary>
    /// Identifies whether the issue is subject to alternative minimum taxation (used for municipal bonds).
    /// </summary>
    [IsoId("_MVJmOZJOEeuAlLVx8pyt3w")]
    [DisplayName("Alternative Minimum Tax Indicator")]
    [IsoXmlTag("AltrntvMinTaxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AlternativeMinimumTaxIndicator { get; init; } 
    
    /// <summary>
    /// Indicates an instruction to reinvest dividends in the underlying security (or proceeds at maturity in a similar instrument) if the current rate is &lt;rate&gt; or better.
    /// </summary>
    [IsoId("_MVJmO5JOEeuAlLVx8pyt3w")]
    [DisplayName("Auto Reinvestment")]
    [IsoXmlTag("AutoRinvstmt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AutoReinvestment { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_MVJmPZJOEeuAlLVx8pyt3w")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_MVJmP5JOEeuAlLVx8pyt3w")]
    [DisplayName("Transaction Conditions")]
    [IsoXmlTag("TxConds")]
    public TradeTransactionCondition7Choice_? TransactionConditions { get; init; } 
    
    /// <summary>
    /// Indicates an instruction or attribute giving the number of days to be included in the look-back period for the investment. For example some options allow exercise based on the underlying asset&apos;s optimal value over the look-back period.
    /// </summary>
    [IsoId("_MVJmQZJOEeuAlLVx8pyt3w")]
    [DisplayName("Look Back")]
    [IsoXmlTag("LookBck")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LookBack { get; init; } 
    
    /// <summary>
    /// Maximum number of time the collateral can be substitute.
    /// </summary>
    [IsoId("_MVJmSZJOEeuAlLVx8pyt3w")]
    [DisplayName("Maximum Substitution")]
    [IsoXmlTag("MaxSbstitn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumSubstitution { get; init; } 
    
    /// <summary>
    /// Indicates the minimum tradable increments of a security.
    /// </summary>
    [IsoId("_MVJmS5JOEeuAlLVx8pyt3w")]
    [DisplayName("Minimum Increment")]
    [IsoXmlTag("MinIncrmt")]
    public FinancialInstrumentQuantity1Choice_? MinimumIncrement { get; init; } 
    
    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_MVJmTZJOEeuAlLVx8pyt3w")]
    [DisplayName("Minimum Quantity")]
    [IsoXmlTag("MinQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumQuantity { get; init; } 
    
    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond, particularly an mortgage back security (MBS), issued in a particular year.
    /// </summary>
    [IsoId("_MVJmT5JOEeuAlLVx8pyt3w")]
    [DisplayName("Production")]
    [IsoXmlTag("Pdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Production { get; init; } 
    
    /// <summary>
    /// Identifies if the securities is restricted or not (as per Rule 144).
    /// </summary>
    [IsoId("_MVJmUZJOEeuAlLVx8pyt3w")]
    [DisplayName("Restricted Indicator")]
    [IsoXmlTag("RstrctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates the frequency at which the bond is re-rated and therefore re-priced (bond attribute, particularly of floating rate and index linked instruments).
    /// </summary>
    [IsoId("_MVJmU5JOEeuAlLVx8pyt3w")]
    [DisplayName("Price Frequency")]
    [IsoXmlTag("PricFrqcy")]
    public Frequency35Choice_? PriceFrequency { get; init; } 
    
    /// <summary>
    /// Indicates the market sector the security is classified as for example pharmaceuticals, automobile, housing, etc.
    /// </summary>
    [IsoId("_MVJmVZJOEeuAlLVx8pyt3w")]
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Sector { get; init; } 
    
    /// <summary>
    /// Indicates the maximum number of times collateral can be substituted.
    /// </summary>
    [IsoId("_MVJmV5JOEeuAlLVx8pyt3w")]
    [DisplayName("Substitution Frequency")]
    [IsoXmlTag("SbstitnFrqcy")]
    public Frequency35Choice_? SubstitutionFrequency { get; init; } 
    
    /// <summary>
    /// Number of remaining times the collateral can be substitute.
    /// </summary>
    [IsoId("_MVJmWZJOEeuAlLVx8pyt3w")]
    [DisplayName("Substitution Left")]
    [IsoXmlTag("SbstitnLft")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SubstitutionLeft { get; init; } 
    
    /// <summary>
    /// Indicates a search criterion when looking to buy a mortgaged backed security that either is [yes] or is not [no] an entire pool.
    /// </summary>
    [IsoId("_MVJmW5JOEeuAlLVx8pyt3w")]
    [DisplayName("Whole Pool Indicator")]
    [IsoXmlTag("WhlPoolInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WholePoolIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the Benchmark source price (eg. BB Generic, BB Fairvalue, Brokertec.).
    /// </summary>
    [IsoId("_MVJmXZJOEeuAlLVx8pyt3w")]
    [DisplayName("Price Source")]
    [IsoXmlTag("PricSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PriceSource { get; init; } 
    
    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond within a particular price range.
    /// </summary>
    [IsoId("_MVJmX5JOEeuAlLVx8pyt3w")]
    [DisplayName("Price Range")]
    [IsoXmlTag("PricRg")]
    public AmountOrPercentageRange1? PriceRange { get; init; } 
    
    
    #nullable disable
    
}
