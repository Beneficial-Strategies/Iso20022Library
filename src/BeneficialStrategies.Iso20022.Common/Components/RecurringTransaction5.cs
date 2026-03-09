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
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[IsoId("_I0Ew0XDlEe2MCaKO5AtGsA")]
[DisplayName("Recurring Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecurringTransaction5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    [IsoId("_I60SAXDlEe2MCaKO5AtGsA")]
    [DisplayName("Instalment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtPlan")]
    #endif
    [IsoXmlTag("InstlmtPlan")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstalmentPlan1Code? InstalmentPlan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstalmentPlan1Code? InstalmentPlan { get; init; } 
    #else
    public InstalmentPlan1Code? InstalmentPlan { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_I60SA3DlEe2MCaKO5AtGsA")]
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
    /// Type of the Plan Owner.
    /// </summary>
    [IsoId("_I60SBXDlEe2MCaKO5AtGsA")]
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
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_I60SB3DlEe2MCaKO5AtGsA")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SequenceNumber { get; init; } 
    #else
    public System.UInt64? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [IsoId("_I60SCXDlEe2MCaKO5AtGsA")]
    [DisplayName("Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdUnit")]
    #endif
    [IsoXmlTag("PrdUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Code? PeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Code? PeriodUnit { get; init; } 
    #else
    public Frequency3Code? PeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_I60SC3DlEe2MCaKO5AtGsA")]
    [DisplayName("Instalment Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtPrd")]
    #endif
    [IsoXmlTag("InstlmtPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? InstalmentPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? InstalmentPeriod { get; init; } 
    #else
    public System.UInt64? InstalmentPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_I60SDXDlEe2MCaKO5AtGsA")]
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
    /// Date of the first payment.
    /// </summary>
    [IsoId("_I60SD3DlEe2MCaKO5AtGsA")]
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
    /// Cumulative amount of all the instalments.
    /// </summary>
    [IsoId("_I60SEXDlEe2MCaKO5AtGsA")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public CurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    [IsoId("_I60SE3DlEe2MCaKO5AtGsA")]
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
    /// Amount of subsequent payments but the first one.
    /// </summary>
    [IsoId("_I60SFXDlEe2MCaKO5AtGsA")]
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
    /// Amount of the last payment.
    /// </summary>
    [IsoId("_I60SF3DlEe2MCaKO5AtGsA")]
    [DisplayName("Last Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastAmt")]
    #endif
    [IsoXmlTag("LastAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? LastAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? LastAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? LastAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    [IsoId("_I60SGXDlEe2MCaKO5AtGsA")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Charges { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Charges { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the charge details of an instalment plan.
    /// </summary>
    [IsoId("_I60SG3DlEe2MCaKO5AtGsA")]
    [DisplayName("Detailed Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldChrgs")]
    #endif
    [IsoXmlTag("DtldChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstalmentAmountDetails1? DetailedCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstalmentAmountDetails1? DetailedCharges { get; init; } 
    #else
    public InstalmentAmountDetails1? DetailedCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    [IsoId("_I60SHXDlEe2MCaKO5AtGsA")]
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
    /// Contains grace period details.
    /// </summary>
    [IsoId("_I60SH3DlEe2MCaKO5AtGsA")]
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
    /// Notice related to the InstalmentPlan.
    /// </summary>
    [IsoId("_5ug1AHDmEe2MCaKO5AtGsA")]
    [DisplayName("Plan Notice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanNtce")]
    #endif
    [IsoXmlTag("PlanNtce")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? PlanNotice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? PlanNotice { get; init; } 
    #else
    public ActionMessage10? PlanNotice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
