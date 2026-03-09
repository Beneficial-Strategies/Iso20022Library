// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instruments evidencing moneys owed by the issuer to the holder on terms as specified.
/// </summary>
[IsoId("_MS6w6ZJOEeuAlLVx8pyt3w")]
[DisplayName("Debt")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Debt5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the payment.
    /// </summary>
    [IsoId("_MVJlhZJOEeuAlLVx8pyt3w")]
    [DisplayName("Payment Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCcy")]
    #endif
    [IsoXmlTag("PmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? PaymentCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PaymentCurrency { get; init; } 
    #else
    public string? PaymentCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Unit value of a debt security.
    /// </summary>
    [IsoId("_MVJlh5JOEeuAlLVx8pyt3w")]
    [DisplayName("Face Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaceAmt")]
    #endif
    [IsoXmlTag("FaceAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? FaceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? FaceAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? FaceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    [IsoId("_MVJliZJOEeuAlLVx8pyt3w")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency35Choice_? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency35Choice_? PaymentFrequency { get; init; } 
    #else
    public Frequency35Choice_? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the rate determination is made, also called determination date.
    /// </summary>
    [IsoId("_MVJli5JOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxgDt")]
    #endif
    [IsoXmlTag("IntrstFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? InterestFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? InterestFixingDate { get; init; } 
    #else
    public System.DateTime? InterestFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// First date/time at which a security begins to accrue interest.
    /// </summary>
    [IsoId("_MVJljZJOEeuAlLVx8pyt3w")]
    [DisplayName("Dated Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtdDt")]
    #endif
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DatedDate { get; init; } 
    #else
    public System.DateTime? DatedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the first interest payment is due to holders of the security.
    /// </summary>
    [IsoId("_MVJllZJOEeuAlLVx8pyt3w")]
    [DisplayName("First Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstPmtDt")]
    #endif
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? FirstPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? FirstPaymentDate { get; init; } 
    #else
    public System.DateTime? FirstPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_MVJll5JOEeuAlLVx8pyt3w")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MaturityDate { get; init; } 
    #else
    public System.DateTime? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_MVJlq5JOEeuAlLVx8pyt3w")]
    [DisplayName("Next Coupon Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtCpnDt")]
    #endif
    [IsoXmlTag("NxtCpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? NextCouponDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? NextCouponDate { get; init; } 
    #else
    public System.DateTime? NextCouponDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    [IsoId("_MVJls5JOEeuAlLVx8pyt3w")]
    [DisplayName("Putable Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutblDt")]
    #endif
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? PutableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? PutableDate { get; init; } 
    #else
    public System.DateTime? PutableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Next date/time at which the issuer has the right to pay the securitiy prior to maturity.
    /// </summary>
    [IsoId("_MVJltZJOEeuAlLVx8pyt3w")]
    [DisplayName("Next Callable Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtCllblDt")]
    #endif
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? NextCallableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? NextCallableDate { get; init; } 
    #else
    public System.DateTime? NextCallableDate { get; set; } 
    #endif
    
    /// <summary>
    /// The date that the current factor will be changed to a new factor.
    /// </summary>
    [IsoId("_MVJlt5JOEeuAlLVx8pyt3w")]
    [DisplayName("Next Factor Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctrDt")]
    #endif
    [IsoXmlTag("NxtFctrDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? NextFactorDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? NextFactorDate { get; init; } 
    #else
    public System.DateTime? NextFactorDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an interest bearing security becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_MVJluZJOEeuAlLVx8pyt3w")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExpirationDate { get; init; } 
    #else
    public System.DateTime? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the direction of payment for asset or mortgage backed securities, ie, whether the repaid capital is distributed (payment direction is down) or capitalized (payment direction is up).
    /// </summary>
    [IsoId("_MVJlu5JOEeuAlLVx8pyt3w")]
    [DisplayName("Payment Direction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDrctnInd")]
    #endif
    [IsoXmlTag("PmtDrctnInd")]
    [IsoSimpleType(IsoSimpleType.PaymentDirectionIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPaymentDirectionIndicator? PaymentDirectionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentDirectionIndicator { get; init; } 
    #else
    public System.String? PaymentDirectionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    [IsoId("_MVJlvZJOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestRate { get; init; } 
    #else
    public System.Decimal? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the interest rate applicable to the next interest payment period.
    /// </summary>
    [IsoId("_MVJlxZJOEeuAlLVx8pyt3w")]
    [DisplayName("Next Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtIntrstRate")]
    #endif
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? NextInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextInterestRate { get; init; } 
    #else
    public System.Decimal? NextInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the payment of the coupon (interest) on a bond is off the normal schedule.
    /// </summary>
    [IsoId("_MVJlx5JOEeuAlLVx8pyt3w")]
    [DisplayName("Odd Coupon Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OddCpnInd")]
    #endif
    [IsoXmlTag("OddCpnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OddCouponIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OddCouponIndicator { get; init; } 
    #else
    public System.String? OddCouponIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_MVJlyZJOEeuAlLVx8pyt3w")]
    [DisplayName("Callable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CllblInd")]
    #endif
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CallableIndicator { get; init; } 
    #else
    public System.String? CallableIndicator { get; set; } 
    #endif
    
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
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CPPrgm")]
    #endif
    [IsoXmlTag("CPPrgm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? CPProgram { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CPProgram { get; init; } 
    #else
    public System.UInt64? CPProgram { get; set; } 
    #endif
    
    /// <summary>
    /// Registration type of a commercial paper issuance.
    /// </summary>
    [IsoId("_MVJl05JOEeuAlLVx8pyt3w")]
    [DisplayName("CP Registration Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CPRegnTp")]
    #endif
    [IsoXmlTag("CPRegnTp")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CPRegistrationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CPRegistrationType { get; init; } 
    #else
    public System.String? CPRegistrationType { get; set; } 
    #endif
    
    /// <summary>
    /// Start date used for calculating accrued interest on debt instruments which are being sold between interest payment dates. Often but not always the same as the issue date and the dated date.
    /// </summary>
    [IsoId("_MVJl25JOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Accrual Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstAcrlDt")]
    #endif
    [IsoXmlTag("IntrstAcrlDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? InterestAccrualDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? InterestAccrualDate { get; init; } 
    #else
    public System.DateTime? InterestAccrualDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_MVJl45JOEeuAlLVx8pyt3w")]
    [DisplayName("Putable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutblInd")]
    #endif
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PutableIndicator { get; init; } 
    #else
    public System.String? PutableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an interest bearing instrument is being escrowed or collateralized either by direct obligations guaranteed by the US government, or by other types of securities. The maturity schedules of the securities in the escrow fund are determined in such a way to pay the maturity value, coupon, and premium payments (if any) of the refunded bonds.
    /// </summary>
    [IsoId("_MVJl5ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pre Funded Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreFnddInd")]
    #endif
    [IsoXmlTag("PreFnddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PreFundedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreFundedIndicator { get; init; } 
    #else
    public System.String? PreFundedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an interest bearing instrument is deposited in a fund that will be used to pay debt service on refunded securities.
    /// </summary>
    [IsoId("_MVJl55JOEeuAlLVx8pyt3w")]
    [DisplayName("Escrowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EscrwdInd")]
    #endif
    [IsoXmlTag("EscrwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EscrowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EscrowedIndicator { get; init; } 
    #else
    public System.String? EscrowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the security has no maturity date.
    /// </summary>
    [IsoId("_MVJl6ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Perpetual Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PerptlInd")]
    #endif
    [IsoXmlTag("PerptlInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PerpetualIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PerpetualIndicator { get; init; } 
    #else
    public System.String? PerpetualIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the security is a subordinated security.
    /// </summary>
    [IsoId("_MVJl65JOEeuAlLVx8pyt3w")]
    [DisplayName("Subordinated Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubrdntdInd")]
    #endif
    [IsoXmlTag("SubrdntdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SubordinatedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubordinatedIndicator { get; init; } 
    #else
    public System.String? SubordinatedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the security is extendible,eg, repayment may be extended or maturity changed.
    /// </summary>
    [IsoId("_MVJl7ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Extendible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndblInd")]
    #endif
    [IsoXmlTag("XtndblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ExtendibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendibleIndicator { get; init; } 
    #else
    public System.String? ExtendibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which a date might be extended.
    /// </summary>
    [IsoId("_MVJl75JOEeuAlLVx8pyt3w")]
    [DisplayName("Extendible Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndblPrd")]
    #endif
    [IsoXmlTag("XtndblPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? ExtendiblePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? ExtendiblePeriod { get; init; } 
    #else
    public DateTimePeriod1Choice_? ExtendiblePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    [IsoId("_MVJl8ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Variable Rate Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateInd")]
    #endif
    [IsoXmlTag("VarblRateInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? VariableRateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VariableRateIndicator { get; init; } 
    #else
    public System.String? VariableRateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Amount for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_MVJl85JOEeuAlLVx8pyt3w")]
    [DisplayName("Over Allotment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverAlltmtAmt")]
    #endif
    [IsoXmlTag("OverAlltmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_MVJl9ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Over Allotment Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverAlltmtRate")]
    #endif
    [IsoXmlTag("OverAlltmtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? OverAllotmentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OverAllotmentRate { get; init; } 
    #else
    public System.Decimal? OverAllotmentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether repayment is made via regular principal and interest payments over time.
    /// </summary>
    [IsoId("_MVJl95JOEeuAlLVx8pyt3w")]
    [DisplayName("Amortisable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtsblInd")]
    #endif
    [IsoXmlTag("AmtsblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AmortisableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmortisableIndicator { get; init; } 
    #else
    public System.String? AmortisableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Calculation method used to calculate interest and/or yield for a bond, for example, street convention.
    /// </summary>
    [IsoId("_MVJl-ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Calculation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstClctnMtd")]
    #endif
    [IsoXmlTag("IntrstClctnMtd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? InterestCalculationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestCalculationMethod { get; init; } 
    #else
    public System.String? InterestCalculationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the interest amount is capitalised until maturity date or paid out at each interest payment date.
    /// </summary>
    [IsoId("_MVJl-5JOEeuAlLVx8pyt3w")]
    [DisplayName("Capitalised Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlsdIntrst")]
    #endif
    [IsoXmlTag("CptlsdIntrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionPolicy2Choice_? CapitalisedInterest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy2Choice_? CapitalisedInterest { get; init; } 
    #else
    public DistributionPolicy2Choice_? CapitalisedInterest { get; set; } 
    #endif
    
    /// <summary>
    /// Nominal value per security unit.
    /// </summary>
    [IsoId("_MVJl_ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Actual Denomination Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlDnmtnAmt")]
    #endif
    [IsoXmlTag("ActlDnmtnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ActualDenominationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ActualDenominationAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ActualDenominationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the current factor expressed as a decimal between 0 and 1 defining the outstanding principal of the bond (for factored securities).
    /// </summary>
    [IsoId("_MVJl_5JOEeuAlLVx8pyt3w")]
    [DisplayName("Current Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurFctr")]
    #endif
    [IsoXmlTag("CurFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CurrentFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CurrentFactor { get; init; } 
    #else
    public System.Decimal? CurrentFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the new factor expressed as a decimal between 0 and 1 defining the outstanding principal of the bond (for factored securities).
    /// </summary>
    [IsoId("_MVJmAZJOEeuAlLVx8pyt3w")]
    [DisplayName("Next Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctr")]
    #endif
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextFactor { get; init; } 
    #else
    public System.Decimal? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the previous factor expressed as a decimal between 0 and 1 defining the outstanding principal of the bond (for factored securities).
    /// </summary>
    [IsoId("_MVJmA5JOEeuAlLVx8pyt3w")]
    [DisplayName("Previous Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsFctr")]
    #endif
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreviousFactor { get; init; } 
    #else
    public System.Decimal? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Number of pieces composing a pool of financial assets.
    /// </summary>
    [IsoId("_MVJmBZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pieces")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pcs")]
    #endif
    [IsoXmlTag("Pcs")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Pieces { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Pieces { get; init; } 
    #else
    public System.UInt64? Pieces { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of assets by which a security is backed.
    /// </summary>
    [IsoId("_MVJmB5JOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Maximum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlsMax")]
    #endif
    [IsoXmlTag("PlsMax")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? PoolsMaximum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PoolsMaximum { get; init; } 
    #else
    public System.UInt64? PoolsMaximum { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates per million the collection of loans, mortgages or other assets assembled by an originator as the basis for a security.
    /// </summary>
    [IsoId("_MVJmCZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Per Million")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlsPerMln")]
    #endif
    [IsoXmlTag("PlsPerMln")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? PoolsPerMillion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PoolsPerMillion { get; init; } 
    #else
    public System.UInt64? PoolsPerMillion { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates per lot the collection of loans, mortgages or other assets assembled by an originator as the basis for a security.
    /// </summary>
    [IsoId("_MVJmC5JOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Per Lot")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlsPerLot")]
    #endif
    [IsoXmlTag("PlsPerLot")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? PoolsPerLot { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PoolsPerLot { get; init; } 
    #else
    public System.UInt64? PoolsPerLot { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates per trade the collection of loans, mortgages or other assets assembled by an originator as the basis for a security.
    /// </summary>
    [IsoId("_MVJmDZJOEeuAlLVx8pyt3w")]
    [DisplayName("Pools Per Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlsPerTrad")]
    #endif
    [IsoXmlTag("PlsPerTrad")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? PoolsPerTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PoolsPerTrade { get; init; } 
    #else
    public System.UInt64? PoolsPerTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a penalty might be imposed to the borrower of a mortgage in case of prepayments occurring during the lockout period.
    /// </summary>
    [IsoId("_MVJmD5JOEeuAlLVx8pyt3w")]
    [DisplayName("Constant Pre Payment Penalty Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstPrePmtPnltyInd")]
    #endif
    [IsoXmlTag("CstPrePmtPnltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConstantPrePaymentPenaltyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConstantPrePaymentPenaltyIndicator { get; init; } 
    #else
    public System.String? ConstantPrePaymentPenaltyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the lot constituting an asset backed or mortgage backed security issue.
    /// </summary>
    [IsoId("_MVJmEZJOEeuAlLVx8pyt3w")]
    [DisplayName("Lot Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotId")]
    #endif
    [IsoXmlTag("LotId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LotIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LotIdentification { get; init; } 
    #else
    public System.String? LotIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Measure of prepayment as a yield of the current outstanding loan balance.
    /// </summary>
    [IsoId("_MVJmE5JOEeuAlLVx8pyt3w")]
    [DisplayName("Constant Pre Payment Yield")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstPrePmtYld")]
    #endif
    [IsoXmlTag("CstPrePmtYld")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ConstantPrePaymentYield { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ConstantPrePaymentYield { get; init; } 
    #else
    public System.Decimal? ConstantPrePaymentYield { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the weighted average coupon of the fixed income instrument (expressed as a percentage).
    /// </summary>
    [IsoId("_MVJmFZJOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Coupon")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WghtdAvrgCpn")]
    #endif
    [IsoXmlTag("WghtdAvrgCpn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? WeightedAverageCoupon { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? WeightedAverageCoupon { get; init; } 
    #else
    public System.Decimal? WeightedAverageCoupon { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the weighted average life of the fixed income instrument (expressed in months).
    /// </summary>
    [IsoId("_MVJmF5JOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Life")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WghtdAvrgLife")]
    #endif
    [IsoXmlTag("WghtdAvrgLife")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? WeightedAverageLife { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WeightedAverageLife { get; init; } 
    #else
    public System.UInt64? WeightedAverageLife { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the weighted average loan of the fixed income instrument (expressed in months).
    /// </summary>
    [IsoId("_MVJmGZJOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WghtdAvrgLn")]
    #endif
    [IsoXmlTag("WghtdAvrgLn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? WeightedAverageLoan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WeightedAverageLoan { get; init; } 
    #else
    public System.UInt64? WeightedAverageLoan { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the weighted average maturity of the fixed income instrument (expressed in months).
    /// </summary>
    [IsoId("_MVJmG5JOEeuAlLVx8pyt3w")]
    [DisplayName("Weighted Average Maturity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WghtdAvrgMtrty")]
    #endif
    [IsoXmlTag("WghtdAvrgMtrty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? WeightedAverageMaturity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WeightedAverageMaturity { get; init; } 
    #else
    public System.UInt64? WeightedAverageMaturity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instrument is backed by any kind of asset or not.
    /// </summary>
    [IsoId("_MVJmHZJOEeuAlLVx8pyt3w")]
    [DisplayName("Insured Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrdInd")]
    #endif
    [IsoXmlTag("InsrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InsuredIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuredIndicator { get; init; } 
    #else
    public System.String? InsuredIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the security is bank qualified (usually applies to loan products).
    /// </summary>
    [IsoId("_MVJmH5JOEeuAlLVx8pyt3w")]
    [DisplayName("Bank Qualified Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkQlfdInd")]
    #endif
    [IsoXmlTag("BkQlfdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BankQualifiedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BankQualifiedIndicator { get; init; } 
    #else
    public System.String? BankQualifiedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of return on an investment, based on the price.
    /// </summary>
    [IsoId("_MVJmIZJOEeuAlLVx8pyt3w")]
    [DisplayName("Yield Calculation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="YldClctn")]
    #endif
    [IsoXmlTag("YldClctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public YieldCalculation6? YieldCalculation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public YieldCalculation6? YieldCalculation { get; init; } 
    #else
    public YieldCalculation6? YieldCalculation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether interest rate is fixed, variable or other.
    /// </summary>
    [IsoId("_MVJmI5JOEeuAlLVx8pyt3w")]
    [DisplayName("Interest Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstTp")]
    #endif
    [IsoXmlTag("IntrstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestType3Code? InterestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestType3Code? InterestType { get; init; } 
    #else
    public InterestType3Code? InterestType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of deal for structured finance.
    /// </summary>
    [IsoId("_MVJmJZJOEeuAlLVx8pyt3w")]
    [DisplayName("Instrument Structure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmStrTp")]
    #endif
    [IsoXmlTag("InstrmStrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstrumentSubStructureType2Choice_? InstrumentStructureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstrumentSubStructureType2Choice_? InstrumentStructureType { get; init; } 
    #else
    public InstrumentSubStructureType2Choice_? InstrumentStructureType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
    /// New Global Note (NGN): Form of global certificate which refers to the books and records of the ICSDs to determine the issue outstanding amount (IOA). 
    /// Classical Global Note (CGN): Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the issue outstanding amount (IOA).
    /// </summary>
    [IsoId("_MVJmJ5JOEeuAlLVx8pyt3w")]
    [DisplayName("Global Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GblTp")]
    #endif
    [IsoXmlTag("GblTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GlobalNote2Choice_? GlobalType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GlobalNote2Choice_? GlobalType { get; init; } 
    #else
    public GlobalNote2Choice_? GlobalType { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to indicate the security is intended to be held in a manner that could allow the Eurosystem eligibility.
    /// </summary>
    [IsoId("_MVJmKZJOEeuAlLVx8pyt3w")]
    [DisplayName("Potential Euro System Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PotntlEuroSysElgblty")]
    #endif
    [IsoXmlTag("PotntlEuroSysElgblty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PotentialEuroSystemEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PotentialEuroSystemEligibility { get; init; } 
    #else
    public System.String? PotentialEuroSystemEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Type of stipulation expressing geographical constraints on a fixed income instrument. It is expressed with a state or country abbreviation and a minimum or maximum percentage. Example: CA 0-80 (minimum of 80 percent in Californian assets).
    /// </summary>
    [IsoId("_MVJmK5JOEeuAlLVx8pyt3w")]
    [DisplayName("Geographics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Geogcs")]
    #endif
    [IsoXmlTag("Geogcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Geographics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Geographics { get; init; } 
    #else
    public System.String? Geographics { get; set; } 
    #endif
    
    /// <summary>
    /// Range of allowed yield.
    /// </summary>
    [IsoId("_MVJmM5JOEeuAlLVx8pyt3w")]
    [DisplayName("Yield Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="YldRg")]
    #endif
    [IsoXmlTag("YldRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountOrPercentageRange1? YieldRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentageRange1? YieldRange { get; init; } 
    #else
    public AmountOrPercentageRange1? YieldRange { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a range of coupon numbers attached to its related financial instrument.
    /// </summary>
    [IsoId("_MVJmNZJOEeuAlLVx8pyt3w")]
    [DisplayName("Coupon Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnRg")]
    #endif
    [IsoXmlTag("CpnRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountOrPercentageRange1? CouponRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentageRange1? CouponRange { get; init; } 
    #else
    public AmountOrPercentageRange1? CouponRange { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_MVJmN5JOEeuAlLVx8pyt3w")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Purpose { get; init; } 
    #else
    public System.String? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the issue is subject to alternative minimum taxation (used for municipal bonds).
    /// </summary>
    [IsoId("_MVJmOZJOEeuAlLVx8pyt3w")]
    [DisplayName("Alternative Minimum Tax Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrntvMinTaxInd")]
    #endif
    [IsoXmlTag("AltrntvMinTaxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AlternativeMinimumTaxIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternativeMinimumTaxIndicator { get; init; } 
    #else
    public System.String? AlternativeMinimumTaxIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates an instruction to reinvest dividends in the underlying security (or proceeds at maturity in a similar instrument) if the current rate is &lt;rate&gt; or better.
    /// </summary>
    [IsoId("_MVJmO5JOEeuAlLVx8pyt3w")]
    [DisplayName("Auto Reinvestment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutoRinvstmt")]
    #endif
    [IsoXmlTag("AutoRinvstmt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? AutoReinvestment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AutoReinvestment { get; init; } 
    #else
    public System.Decimal? AutoReinvestment { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_MVJmPZJOEeuAlLVx8pyt3w")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_MVJmP5JOEeuAlLVx8pyt3w")]
    [DisplayName("Transaction Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxConds")]
    #endif
    [IsoXmlTag("TxConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransactionCondition7Choice_? TransactionConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionCondition7Choice_? TransactionConditions { get; init; } 
    #else
    public TradeTransactionCondition7Choice_? TransactionConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates an instruction or attribute giving the number of days to be included in the look-back period for the investment. For example some options allow exercise based on the underlying asset&apos;s optimal value over the look-back period.
    /// </summary>
    [IsoId("_MVJmQZJOEeuAlLVx8pyt3w")]
    [DisplayName("Look Back")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LookBck")]
    #endif
    [IsoXmlTag("LookBck")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? LookBack { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? LookBack { get; init; } 
    #else
    public System.UInt64? LookBack { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of time the collateral can be substitute.
    /// </summary>
    [IsoId("_MVJmSZJOEeuAlLVx8pyt3w")]
    [DisplayName("Maximum Substitution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxSbstitn")]
    #endif
    [IsoXmlTag("MaxSbstitn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumSubstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumSubstitution { get; init; } 
    #else
    public System.UInt64? MaximumSubstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum tradable increments of a security.
    /// </summary>
    [IsoId("_MVJmS5JOEeuAlLVx8pyt3w")]
    [DisplayName("Minimum Increment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinIncrmt")]
    #endif
    [IsoXmlTag("MinIncrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumIncrement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumIncrement { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumIncrement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_MVJmTZJOEeuAlLVx8pyt3w")]
    [DisplayName("Minimum Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinQty")]
    #endif
    [IsoXmlTag("MinQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond, particularly an mortgage back security (MBS), issued in a particular year.
    /// </summary>
    [IsoId("_MVJmT5JOEeuAlLVx8pyt3w")]
    [DisplayName("Production")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdctn")]
    #endif
    [IsoXmlTag("Pdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Production { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Production { get; init; } 
    #else
    public System.String? Production { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies if the securities is restricted or not (as per Rule 144).
    /// </summary>
    [IsoId("_MVJmUZJOEeuAlLVx8pyt3w")]
    [DisplayName("Restricted Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctdInd")]
    #endif
    [IsoXmlTag("RstrctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RestrictedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictedIndicator { get; init; } 
    #else
    public System.String? RestrictedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the frequency at which the bond is re-rated and therefore re-priced (bond attribute, particularly of floating rate and index linked instruments).
    /// </summary>
    [IsoId("_MVJmU5JOEeuAlLVx8pyt3w")]
    [DisplayName("Price Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricFrqcy")]
    #endif
    [IsoXmlTag("PricFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency35Choice_? PriceFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency35Choice_? PriceFrequency { get; init; } 
    #else
    public Frequency35Choice_? PriceFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the market sector the security is classified as for example pharmaceuticals, automobile, housing, etc.
    /// </summary>
    [IsoId("_MVJmVZJOEeuAlLVx8pyt3w")]
    [DisplayName("Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sctr")]
    #endif
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Sector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sector { get; init; } 
    #else
    public System.String? Sector { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the maximum number of times collateral can be substituted.
    /// </summary>
    [IsoId("_MVJmV5JOEeuAlLVx8pyt3w")]
    [DisplayName("Substitution Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbstitnFrqcy")]
    #endif
    [IsoXmlTag("SbstitnFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency35Choice_? SubstitutionFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency35Choice_? SubstitutionFrequency { get; init; } 
    #else
    public Frequency35Choice_? SubstitutionFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Number of remaining times the collateral can be substitute.
    /// </summary>
    [IsoId("_MVJmWZJOEeuAlLVx8pyt3w")]
    [DisplayName("Substitution Left")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbstitnLft")]
    #endif
    [IsoXmlTag("SbstitnLft")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SubstitutionLeft { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SubstitutionLeft { get; init; } 
    #else
    public System.UInt64? SubstitutionLeft { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a search criterion when looking to buy a mortgaged backed security that either is [yes] or is not [no] an entire pool.
    /// </summary>
    [IsoId("_MVJmW5JOEeuAlLVx8pyt3w")]
    [DisplayName("Whole Pool Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhlPoolInd")]
    #endif
    [IsoXmlTag("WhlPoolInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WholePoolIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WholePoolIndicator { get; init; } 
    #else
    public System.String? WholePoolIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the Benchmark source price (eg. BB Generic, BB Fairvalue, Brokertec.).
    /// </summary>
    [IsoId("_MVJmXZJOEeuAlLVx8pyt3w")]
    [DisplayName("Price Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricSrc")]
    #endif
    [IsoXmlTag("PricSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PriceSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PriceSource { get; init; } 
    #else
    public System.String? PriceSource { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond within a particular price range.
    /// </summary>
    [IsoId("_MVJmX5JOEeuAlLVx8pyt3w")]
    [DisplayName("Price Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricRg")]
    #endif
    [IsoXmlTag("PricRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountOrPercentageRange1? PriceRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentageRange1? PriceRange { get; init; } 
    #else
    public AmountOrPercentageRange1? PriceRange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
