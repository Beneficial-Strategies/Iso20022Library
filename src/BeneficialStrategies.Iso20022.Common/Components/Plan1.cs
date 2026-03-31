// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of the instalment plan.
/// </summary>
[IsoId("_gbtqIEVGEeea-M6VZkEPUw")]
[DisplayName("Plan")]
public record Plan1
{
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_ytQu4EVGEeea-M6VZkEPUw")]
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PlanIdentification { get; init; }

    /// <summary>
    /// List of plan owners.
    /// </summary>
    [IsoId("_pO6_wduKEei2qvU6FBLZYA")]
    [DisplayName("Plan Owner")]
    [IsoXmlTag("PlanOwnr")]
    public PlanOwner1Code? PlanOwner { get; init; }

    /// <summary>
    /// Other plan owner, used when PlanOwner is OtherNational or OtherPrivate.
    /// </summary>
    [IsoId("_uuKPoduKEei2qvU6FBLZYA")]
    [DisplayName("Other Plan Owner")]
    [IsoXmlTag("OthrPlanOwnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherPlanOwner { get; init; }

    /// <summary>
    /// Instalment payment type.
    /// </summary>
    [IsoId("_PYbrkOkYEemeDPHh-U9b6w")]
    [DisplayName("Instalment Payment Type")]
    [IsoXmlTag("InstlmtPmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstalmentPaymentType { get; init; }

    /// <summary>
    /// Period unit between consecutive payments.
    /// </summary>
    [IsoId("_4f7REEVGEeea-M6VZkEPUw")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency12Code? PeriodUnit { get; init; }

    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_Arj1wEVHEeea-M6VZkEPUw")]
    [DisplayName("Number Of Periods")]
    [IsoXmlTag("NbOfPrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfPeriods { get; init; }

    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    [IsoId("_M7qVwdubEei2qvU6FBLZYA")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public ValueList<InterestRateDetails1> InterestRate { get; init; } = [];

    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_P33n4EVHEeea-M6VZkEPUw")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Amount of the first payment when different from the subsequent payments.
    /// </summary>
    [IsoId("_g0XlQEVHEeea-M6VZkEPUw")]
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; }

    /// <summary>
    /// Amount of subsequent payments.
    /// </summary>
    [IsoId("_sVYxYEVHEeea-M6VZkEPUw")]
    [DisplayName("Subsequent Amount")]
    [IsoXmlTag("SbsqntAmt")]
    public ImpliedCurrencyAndAmount? SubsequentAmount { get; init; }

    /// <summary>
    /// Total number of instalment payments.
    /// ISO 8583 bit 59
    /// </summary>
    [IsoId("_zLtwAEVHEeea-M6VZkEPUw")]
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfPayments { get; init; }

    /// <summary>
    /// Currency code associated with the instalment amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_5X9UUNuUEei2qvU6FBLZYA")]
    [DisplayName("Instalment Currency")]
    [IsoXmlTag("InstlmtCcy")]
    public ISO3NumericCurrencyCode? InstalmentCurrency { get; init; }

    /// <summary>
    /// Contains grace period details.
    /// </summary>
    [IsoId("_IcL5cEVHEeea-M6VZkEPUw")]
    [DisplayName("Grace Period")]
    [IsoXmlTag("GracePrd")]
    public GracePeriod1? GracePeriod { get; init; }

    /// <summary>
    /// Contains the amount details of an instalment plan.
    /// </summary>
    [IsoId("_3FE5cduZEei2qvU6FBLZYA")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public ValueList<InstalmentAmountDetails1> AmountDetails { get; init; } = [];

    /// <summary>
    /// Total amount of the instalment including charges, insurance and taxes in addition to the funded amount.
    /// </summary>
    [IsoId("_BEHDMEVIEeea-M6VZkEPUw")]
    [DisplayName("Grand Total Amount")]
    [IsoXmlTag("GrdTtlAmt")]
    public ImpliedCurrencyAndAmount? GrandTotalAmount { get; init; }
}
