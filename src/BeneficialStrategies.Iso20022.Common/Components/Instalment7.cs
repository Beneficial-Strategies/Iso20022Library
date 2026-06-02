// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
/// </summary>
[IsoId("_ycNGMbZnEfCUZfsQO4rYeA")]
[DisplayName("Instalment7")]
public record Instalment7
{
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    [IsoId("_ydRdMbZnEfCUZfsQO4rYeA")]
    [DisplayName("Instalment Plan")]
    [IsoXmlTag("InstlmtPlan")]
    public SimpleValueList<InstalmentPlan1Code> InstalmentPlan { get; init; } = [];

    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_ydRdM7ZnEfCUZfsQO4rYeA")]
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    public IsoMax35Text? PlanIdentification { get; init; }

    /// <summary>
    /// Type of the Plan Owner.
    /// </summary>
    [IsoId("_ydRdNbZnEfCUZfsQO4rYeA")]
    [DisplayName("Plan Owner")]
    [IsoXmlTag("PlanOwnr")]
    public PlanOwner1Code? PlanOwner { get; init; }

    /// <summary>
    /// Indicates the instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_ydRdN7ZnEfCUZfsQO4rYeA")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [IsoId("_ydRdObZnEfCUZfsQO4rYeA")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency3Code? PeriodUnit { get; init; }

    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_ydRdO7ZnEfCUZfsQO4rYeA")]
    [DisplayName("Instalment Period")]
    [IsoXmlTag("InstlmtPrd")]
    public IsoNumber? InstalmentPeriod { get; init; }

    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_ydRdPbZnEfCUZfsQO4rYeA")]
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    public IsoNumber? TotalNumberOfPayments { get; init; }

    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_ydRdP7ZnEfCUZfsQO4rYeA")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Cumulative amount of all the instalments.
    /// </summary>
    [IsoId("_ydRdQbZnEfCUZfsQO4rYeA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    [IsoId("_ydRdQ7ZnEfCUZfsQO4rYeA")]
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; }

    /// <summary>
    /// Amount of subsequent payments but the first one.
    /// </summary>
    [IsoId("_ydRdRbZnEfCUZfsQO4rYeA")]
    [DisplayName("Subsequent Amount")]
    [IsoXmlTag("SbsqntAmt")]
    public ImpliedCurrencyAndAmount? SubsequentAmount { get; init; }

    /// <summary>
    /// Amount of the last payment.
    /// </summary>
    [IsoId("_ydRdR7ZnEfCUZfsQO4rYeA")]
    [DisplayName("Last Amount")]
    [IsoXmlTag("LastAmt")]
    public ImpliedCurrencyAndAmount? LastAmount { get; init; }

    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    [IsoId("_ydRdSbZnEfCUZfsQO4rYeA")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ImpliedCurrencyAndAmount? Charges { get; init; }

    /// <summary>
    /// Contains the charge details of an instalment plan.
    /// </summary>
    [IsoId("_ydRdS7ZnEfCUZfsQO4rYeA")]
    [DisplayName("Detailed Charges")]
    [IsoXmlTag("DtldChrgs")]
    public ValueList<InstalmentAmountDetails1> DetailedCharges { get; init; } = [];

    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    [IsoId("_ydRdTbZnEfCUZfsQO4rYeA")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public ValueList<InterestRateDetails1> InterestRate { get; init; } = [];

    /// <summary>
    /// Contains grace period details.
    /// </summary>
    [IsoId("_ydRdT7ZnEfCUZfsQO4rYeA")]
    [DisplayName("Grace Period")]
    [IsoXmlTag("GracePrd")]
    public ValueList<GracePeriod1> GracePeriod { get; init; } = [];

    /// <summary>
    /// Notice related to the InstalmentPlan.
    /// </summary>
    [IsoId("_ydRdUbZnEfCUZfsQO4rYeA")]
    [DisplayName("Plan Notice")]
    [IsoXmlTag("PlanNtce")]
    public ValueList<ActionMessage12> PlanNotice { get; init; } = [];
}
