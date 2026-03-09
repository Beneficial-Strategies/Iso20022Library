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
/// Attributes of the instalment plan.
/// </summary>
[IsoId("_gbtqIEVGEeea-M6VZkEPUw")]
[DisplayName("Plan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Plan1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_ytQu4EVGEeea-M6VZkEPUw")]
    [DisplayName("Plan Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanId")]
    #endif
    [IsoXmlTag("PlanId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PlanIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlanIdentification { get; init; } 
    #else
    public System.String? PlanIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// List of plan owners.
    /// </summary>
    [IsoId("_pO6_wduKEei2qvU6FBLZYA")]
    [DisplayName("Plan Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanOwnr")]
    #endif
    [IsoXmlTag("PlanOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlanOwner1Code? PlanOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlanOwner1Code? PlanOwner { get; init; } 
    #else
    public PlanOwner1Code? PlanOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Other plan owner, used when PlanOwner is OtherNational or OtherPrivate.
    /// </summary>
    [IsoId("_uuKPoduKEei2qvU6FBLZYA")]
    [DisplayName("Other Plan Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPlanOwnr")]
    #endif
    [IsoXmlTag("OthrPlanOwnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherPlanOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherPlanOwner { get; init; } 
    #else
    public System.String? OtherPlanOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Instalment payment type.
    /// </summary>
    [IsoId("_PYbrkOkYEemeDPHh-U9b6w")]
    [DisplayName("Instalment Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtPmtTp")]
    #endif
    [IsoXmlTag("InstlmtPmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InstalmentPaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstalmentPaymentType { get; init; } 
    #else
    public System.String? InstalmentPaymentType { get; set; } 
    #endif
    
    /// <summary>
    /// Period unit between consecutive payments.
    /// </summary>
    [IsoId("_4f7REEVGEeea-M6VZkEPUw")]
    [DisplayName("Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdUnit")]
    #endif
    [IsoXmlTag("PrdUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency12Code? PeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency12Code? PeriodUnit { get; init; } 
    #else
    public Frequency12Code? PeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_Arj1wEVHEeea-M6VZkEPUw")]
    [DisplayName("Number Of Periods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfPrds")]
    #endif
    [IsoXmlTag("NbOfPrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfPeriods { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfPeriods { get; init; } 
    #else
    public System.UInt64? NumberOfPeriods { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    [IsoId("_M7qVwdubEei2qvU6FBLZYA")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateDetails1? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateDetails1? InterestRate { get; init; } 
    #else
    public InterestRateDetails1? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_P33n4EVHEeea-M6VZkEPUw")]
    [DisplayName("First Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstPmtDt")]
    #endif
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FirstPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FirstPaymentDate { get; init; } 
    #else
    public System.DateOnly? FirstPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the first payment when different from the subsequent payments.
    /// </summary>
    [IsoId("_g0XlQEVHEeea-M6VZkEPUw")]
    [DisplayName("First Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstAmt")]
    #endif
    [IsoXmlTag("FrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? FirstAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of subsequent payments.
    /// </summary>
    [IsoId("_sVYxYEVHEeea-M6VZkEPUw")]
    [DisplayName("Subsequent Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbsqntAmt")]
    #endif
    [IsoXmlTag("SbsqntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? SubsequentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? SubsequentAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? SubsequentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of instalment payments.
    /// ISO 8583 bit 59
    /// </summary>
    [IsoId("_zLtwAEVHEeea-M6VZkEPUw")]
    [DisplayName("Total Number Of Payments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfPmts")]
    #endif
    [IsoXmlTag("TtlNbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfPayments { get; init; } 
    #else
    public System.UInt64? TotalNumberOfPayments { get; set; } 
    #endif
    
    /// <summary>
    /// Currency code associated with the instalment amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_5X9UUNuUEei2qvU6FBLZYA")]
    [DisplayName("Instalment Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtCcy")]
    #endif
    [IsoXmlTag("InstlmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? InstalmentCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InstalmentCurrency { get; init; } 
    #else
    public string? InstalmentCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Contains grace period details.
    /// </summary>
    [IsoId("_IcL5cEVHEeea-M6VZkEPUw")]
    [DisplayName("Grace Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GracePrd")]
    #endif
    [IsoXmlTag("GracePrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GracePeriod1? GracePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GracePeriod1? GracePeriod { get; init; } 
    #else
    public GracePeriod1? GracePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount details of an instalment plan.
    /// </summary>
    [IsoId("_3FE5cduZEei2qvU6FBLZYA")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstalmentAmountDetails1? AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstalmentAmountDetails1? AmountDetails { get; init; } 
    #else
    public InstalmentAmountDetails1? AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the instalment including charges, insurance and taxes in addition to the funded amount.
    /// </summary>
    [IsoId("_BEHDMEVIEeea-M6VZkEPUw")]
    [DisplayName("Grand Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrdTtlAmt")]
    #endif
    [IsoXmlTag("GrdTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? GrandTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? GrandTotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? GrandTotalAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
