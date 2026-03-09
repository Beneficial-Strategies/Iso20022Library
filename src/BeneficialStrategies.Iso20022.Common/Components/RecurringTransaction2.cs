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
[IsoId("_3s3JETDhEeO9waS4ina8CA")]
[DisplayName("Recurring Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecurringTransaction2
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
    [IsoId("_gVyDADDjEeO9waS4ina8CA")]
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
    [IsoId("_wDl_sDDjEeO9waS4ina8CA")]
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
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_37vSkTDhEeO9waS4ina8CA")]
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
    [IsoId("_37vSkzDhEeO9waS4ina8CA")]
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
    [IsoId("_37vSlTDhEeO9waS4ina8CA")]
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
    [IsoId("_37vSlzDhEeO9waS4ina8CA")]
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
    [IsoId("_2bU70DD5EeO9waS4ina8CA")]
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
    [IsoId("_FDQ1kDD6EeO9waS4ina8CA")]
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
    [IsoId("_kvf90DD6EeO9waS4ina8CA")]
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
    /// Charges related to the transaction.
    /// </summary>
    [IsoId("_c2KFADDkEeO9waS4ina8CA")]
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
    
    
    #nullable disable
    
}
