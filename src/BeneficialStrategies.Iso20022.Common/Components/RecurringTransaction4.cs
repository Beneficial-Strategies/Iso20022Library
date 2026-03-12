// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[IsoId("_X2eMsU3UEey_VecAUE-C9Q")]
[DisplayName("Recurring Transaction")]
public partial record RecurringTransaction4
{
    #nullable enable
    
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    [IsoId("_YAz0cU3UEey_VecAUE-C9Q")]
    [DisplayName("Instalment Plan")]
    [IsoXmlTag("InstlmtPlan")]
    public InstalmentPlan1Code? InstalmentPlan { get; init; } 
    
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_YAz0c03UEey_VecAUE-C9Q")]
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PlanIdentification { get; init; } 
    
    /// <summary>
    /// Type of the Plan Owner.
    /// </summary>
    [IsoId("_kev70E3UEey_VecAUE-C9Q")]
    [DisplayName("Plan Owner")]
    [IsoXmlTag("PlanOwnr")]
    public PlanOwner1Code? PlanOwner { get; init; } 
    
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_YAz0dU3UEey_VecAUE-C9Q")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [IsoId("_YAz0d03UEey_VecAUE-C9Q")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency3Code? PeriodUnit { get; init; } 
    
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_YAz0eU3UEey_VecAUE-C9Q")]
    [DisplayName("Instalment Period")]
    [IsoXmlTag("InstlmtPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? InstalmentPeriod { get; init; } 
    
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_YAz0e03UEey_VecAUE-C9Q")]
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_YAz0fU3UEey_VecAUE-C9Q")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; } 
    
    /// <summary>
    /// Cumulative amount of all the instalments.
    /// </summary>
    [IsoId("_YAz0f03UEey_VecAUE-C9Q")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public CurrencyAndAmount? TotalAmount { get; init; } 
    
    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    [IsoId("_YAz0gU3UEey_VecAUE-C9Q")]
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    
    /// <summary>
    /// Amount of subsequent payments but the first one.
    /// </summary>
    [IsoId("_tlKtwU3UEey_VecAUE-C9Q")]
    [DisplayName("Subsequent Amount")]
    [IsoXmlTag("SbsqntAmt")]
    public ImpliedCurrencyAndAmount? SubsequentAmount { get; init; } 
    
    /// <summary>
    /// Amount of the last payment.
    /// </summary>
    [IsoId("_6iuJUU3UEey_VecAUE-C9Q")]
    [DisplayName("Last Amount")]
    [IsoXmlTag("LastAmt")]
    public ImpliedCurrencyAndAmount? LastAmount { get; init; } 
    
    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    [IsoId("_YAz0g03UEey_VecAUE-C9Q")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ImpliedCurrencyAndAmount? Charges { get; init; } 
    
    /// <summary>
    /// Contains the charge details of an instalment plan.
    /// </summary>
    [IsoId("_-8UxYU3VEey_VecAUE-C9Q")]
    [DisplayName("Detailed Charges")]
    [IsoXmlTag("DtldChrgs")]
    public InstalmentAmountDetails1? DetailedCharges { get; init; } 
    
    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    [IsoId("_Yd0rIU3VEey_VecAUE-C9Q")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRateDetails1? InterestRate { get; init; } 
    
    /// <summary>
    /// Contains grace period details.
    /// </summary>
    [IsoId("_icQqMU3VEey_VecAUE-C9Q")]
    [DisplayName("Grace Period")]
    [IsoXmlTag("GracePrd")]
    public GracePeriod1? GracePeriod { get; init; } 
    
    
    #nullable disable
    
}
