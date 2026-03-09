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
[IsoId("_0uO7YZJJEeuuktRxxQZoNQ")]
[DisplayName("Plan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Plan2
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
    [IsoId("_00pscZJJEeuuktRxxQZoNQ")]
    [DisplayName("Plan Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanId")]
    #endif
    [IsoXmlTag("PlanId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? PlanIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlanIdentification { get; init; } 
    #else
    public System.String? PlanIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// List of plan owners.
    /// </summary>
    [IsoId("_00qTgZJJEeuuktRxxQZoNQ")]
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
    [IsoId("_00qTg5JJEeuuktRxxQZoNQ")]
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
    [IsoId("_00qThZJJEeuuktRxxQZoNQ")]
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
    /// Indicate a deferred Instalment plan.
    /// </summary>
    [IsoId("_qVTp4CuCEeyg-aG5nXcnfg")]
    [DisplayName("Deferred Instalment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfrrdInstlmtInd")]
    #endif
    [IsoXmlTag("DfrrdInstlmtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DeferredInstalmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeferredInstalmentIndicator { get; init; } 
    #else
    public System.String? DeferredInstalmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Period unit between consecutive payments.
    /// </summary>
    [IsoId("_00qTh5JJEeuuktRxxQZoNQ")]
    [DisplayName("Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdUnit")]
    #endif
    [IsoXmlTag("PrdUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency18Code? PeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency18Code? PeriodUnit { get; init; } 
    #else
    public Frequency18Code? PeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_00qTiZJJEeuuktRxxQZoNQ")]
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
    [IsoId("_00qTi5JJEeuuktRxxQZoNQ")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateDetails2? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateDetails2? InterestRate { get; init; } 
    #else
    public InterestRateDetails2? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_00qTjZJJEeuuktRxxQZoNQ")]
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
    [IsoId("_00qTj5JJEeuuktRxxQZoNQ")]
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
    /// Normal payment amount.
    /// </summary>
    [IsoId("_00qTkZJJEeuuktRxxQZoNQ")]
    [DisplayName("Normal Payment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrmlPmtAmt")]
    #endif
    [IsoXmlTag("NrmlPmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? NormalPaymentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? NormalPaymentAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? NormalPaymentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_00qTk5JJEeuuktRxxQZoNQ")]
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
    [IsoId("_00qTlZJJEeuuktRxxQZoNQ")]
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
    [IsoId("_00qTl5JJEeuuktRxxQZoNQ")]
    [DisplayName("Grace Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GracePrd")]
    #endif
    [IsoXmlTag("GracePrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GracePeriod2? GracePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GracePeriod2? GracePeriod { get; init; } 
    #else
    public GracePeriod2? GracePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount details of an instalment plan.
    /// </summary>
    [IsoId("_00qTmZJJEeuuktRxxQZoNQ")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstalmentAmountDetails2? AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstalmentAmountDetails2? AmountDetails { get; init; } 
    #else
    public InstalmentAmountDetails2? AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the instalment including charges, insurance and taxes in addition to the funded amount.
    /// </summary>
    [IsoId("_00qTm5JJEeuuktRxxQZoNQ")]
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
    
    /// <summary>
    /// Additional plan data
    /// </summary>
    [IsoId("_5Q7OAJJKEeuuktRxxQZoNQ")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
