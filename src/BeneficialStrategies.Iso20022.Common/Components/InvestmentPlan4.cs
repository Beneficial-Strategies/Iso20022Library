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
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
[IsoId("_QMaCWNp-Ed-ak6NoX_4Aeg_-262632071")]
[DisplayName("Investment Plan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentPlan4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentPlan4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentPlan4( EventFrequency1Code reqFrequency,System.String reqExtendedFrequency,System.DateOnly reqStartDate,ActiveCurrencyAndAmount reqAmount )
    {
        Frequency = reqFrequency;
        ExtendedFrequency = reqExtendedFrequency;
        StartDate = reqStartDate;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_QMaCWdp-Ed-ak6NoX_4Aeg_-262631881")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventFrequency1Code Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventFrequency1Code Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency1Code Frequency { get; init; } 
    #else
    public EventFrequency1Code Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_QMaCWtp-Ed-ak6NoX_4Aeg_386548944")]
    [DisplayName("Extended Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedFrqcy")]
    #endif
    [IsoXmlTag("XtndedFrqcy")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedFrequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedFrequency { get; init; } 
    #else
    public System.String ExtendedFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_QMaCW9p-Ed-ak6NoX_4Aeg_-262631029")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate StartDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly StartDate { get; init; } 
    #else
    public System.DateOnly StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    [IsoId("_QMjMQNp-Ed-ak6NoX_4Aeg_-262630596")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency and amount of the periodical payments.
    /// </summary>
    [IsoId("_QMjMQdp-Ed-ak6NoX_4Aeg_-262630536")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including all charges, commissions, tax). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    [IsoId("_QMjMQtp-Ed-ak6NoX_4Aeg_-261710504")]
    [DisplayName("Gross Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmtInd")]
    #endif
    [IsoXmlTag("GrssAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GrossAmountIndicator { get; init; } 
    #else
    public System.String? GrossAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_QMjMQ9p-Ed-ak6NoX_4Aeg_-261710469")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference1Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference1Code? IncomePreference { get; init; } 
    #else
    public IncomePreference1Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Number of pre-paid instalment periods at the time the investment plan is created.
    /// </summary>
    [IsoId("_QMjMRNp-Ed-ak6NoX_4Aeg_-261710427")]
    [DisplayName("Initial Number Of Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlNbOfInstlmt")]
    #endif
    [IsoXmlTag("InitlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? InitialNumberOfInstalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? InitialNumberOfInstalment { get; init; } 
    #else
    public System.UInt64? InitialNumberOfInstalment { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_QMjMRdp-Ed-ak6NoX_4Aeg_-261710374")]
    [DisplayName("Total Number Of Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfInstlmt")]
    #endif
    [IsoXmlTag("TtlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfInstalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfInstalment { get; init; } 
    #else
    public System.UInt64? TotalNumberOfInstalment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    [IsoId("_QMjMRtp-Ed-ak6NoX_4Aeg_-2101951286")]
    [DisplayName("Rounding Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgDrctn")]
    #endif
    [IsoXmlTag("RndgDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    #else
    public RoundingDirection1Code? RoundingDirection { get; set; } 
    #endif
    
    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    [IsoId("_QMjMR9p-Ed-ak6NoX_4Aeg_-261709915")]
    [DisplayName("Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDtls")]
    #endif
    [IsoXmlTag("SctyDtls")]
    [MinLength(1)]
    [MaxLength(50)]
    public ValueList<Repartition1> SecurityDetails { get; init; } = new ValueList<Repartition1>(){};
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan.
    /// </summary>
    [IsoId("_QMjMSNp-Ed-ak6NoX_4Aeg_-261709011")]
    [DisplayName("Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlm")]
    #endif
    [IsoXmlTag("CshSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; init; } 
    #else
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
