// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instalment5.
/// </summary>
[IsoId("_taMPoJUNEe6YroSumzeMDQ")]
[DisplayName("Instalment5")]
public partial record Instalment5
{
    #nullable enable

    /// <summary>
    /// Charges.
    /// </summary>
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ImpliedCurrencyAndAmount? Charges { get; init; } 

    /// <summary>
    /// Detailed Charges.
    /// </summary>
    [DisplayName("Detailed Charges")]
    [IsoXmlTag("DtldChrgs")]
    public ValueList<InstalmentAmountDetails1> DetailedCharges { get; init; } = [];

    /// <summary>
    /// First Amount.
    /// </summary>
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; } 

    /// <summary>
    /// First Payment Date.
    /// </summary>
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    public IsoISODate? FirstPaymentDate { get; init; } 

    /// <summary>
    /// Grace Period.
    /// </summary>
    [DisplayName("Grace Period")]
    [IsoXmlTag("GracePrd")]
    public ValueList<GracePeriod1> GracePeriod { get; init; } = [];

    /// <summary>
    /// Instalment Period.
    /// </summary>
    [DisplayName("Instalment Period")]
    [IsoXmlTag("InstlmtPrd")]
    public IsoNumber? InstalmentPeriod { get; init; } 

    /// <summary>
    /// Instalment Plan.
    /// </summary>
    [DisplayName("Instalment Plan")]
    [IsoXmlTag("InstlmtPlan")]
    public ValueList<InstalmentPlan1Code> InstalmentPlan { get; init; } = [];

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public ValueList<InterestRateDetails1> InterestRate { get; init; } = [];

    /// <summary>
    /// Last Amount.
    /// </summary>
    [DisplayName("Last Amount")]
    [IsoXmlTag("LastAmt")]
    public ImpliedCurrencyAndAmount? LastAmount { get; init; } 

    /// <summary>
    /// Period Unit.
    /// </summary>
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency3Code? PeriodUnit { get; init; } 

    /// <summary>
    /// Plan Identification.
    /// </summary>
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    public IsoMax35Text? PlanIdentification { get; init; } 

    /// <summary>
    /// Plan Notice.
    /// </summary>
    [DisplayName("Plan Notice")]
    [IsoXmlTag("PlanNtce")]
    public ValueList<ActionMessage11> PlanNotice { get; init; } = [];

    /// <summary>
    /// Plan Owner.
    /// </summary>
    [DisplayName("Plan Owner")]
    [IsoXmlTag("PlanOwnr")]
    public PlanOwner1Code? PlanOwner { get; init; } 

    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoNumber? SequenceNumber { get; init; } 

    /// <summary>
    /// Subsequent Amount.
    /// </summary>
    [DisplayName("Subsequent Amount")]
    [IsoXmlTag("SbsqntAmt")]
    public ImpliedCurrencyAndAmount? SubsequentAmount { get; init; } 

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveCurrencyAndAmount? TotalAmount { get; init; } 

    /// <summary>
    /// Total Number Of Payments.
    /// </summary>
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    public IsoNumber? TotalNumberOfPayments { get; init; } 

    
    #nullable disable
    
}
