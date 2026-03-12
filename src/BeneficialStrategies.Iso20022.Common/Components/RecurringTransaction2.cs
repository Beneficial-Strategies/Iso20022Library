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
[IsoId("_3s3JETDhEeO9waS4ina8CA")]
[DisplayName("Recurring Transaction")]
public partial record RecurringTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    [IsoId("_gVyDADDjEeO9waS4ina8CA")]
    [DisplayName("Instalment Plan")]
    [IsoXmlTag("InstlmtPlan")]
    public InstalmentPlan1Code? InstalmentPlan { get; init; } 
    
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_wDl_sDDjEeO9waS4ina8CA")]
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PlanIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_37vSkTDhEeO9waS4ina8CA")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [IsoId("_37vSkzDhEeO9waS4ina8CA")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency3Code? PeriodUnit { get; init; } 
    
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_37vSlTDhEeO9waS4ina8CA")]
    [DisplayName("Instalment Period")]
    [IsoXmlTag("InstlmtPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? InstalmentPeriod { get; init; } 
    
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_37vSlzDhEeO9waS4ina8CA")]
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_2bU70DD5EeO9waS4ina8CA")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; } 
    
    /// <summary>
    /// Cumulative amount of all the instalments.
    /// </summary>
    [IsoId("_FDQ1kDD6EeO9waS4ina8CA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public CurrencyAndAmount? TotalAmount { get; init; } 
    
    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    [IsoId("_kvf90DD6EeO9waS4ina8CA")]
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    
    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    [IsoId("_c2KFADDkEeO9waS4ina8CA")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ImpliedCurrencyAndAmount? Charges { get; init; } 
    
    
    #nullable disable
    
}
