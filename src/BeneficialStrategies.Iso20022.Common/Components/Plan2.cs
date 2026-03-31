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
[IsoId("_0uO7YZJJEeuuktRxxQZoNQ")]
[DisplayName("Plan")]
public record Plan2
{
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_00pscZJJEeuuktRxxQZoNQ")]
    [DisplayName("Plan Identification")]
    [IsoXmlTag("PlanId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PlanIdentification { get; init; }

    /// <summary>
    /// List of plan owners.
    /// </summary>
    [IsoId("_00qTgZJJEeuuktRxxQZoNQ")]
    [DisplayName("Plan Owner")]
    [IsoXmlTag("PlanOwnr")]
    public PlanOwner1Code? PlanOwner { get; init; }

    /// <summary>
    /// Other plan owner, used when PlanOwner is OtherNational or OtherPrivate.
    /// </summary>
    [IsoId("_00qTg5JJEeuuktRxxQZoNQ")]
    [DisplayName("Other Plan Owner")]
    [IsoXmlTag("OthrPlanOwnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherPlanOwner { get; init; }

    /// <summary>
    /// Instalment payment type.
    /// </summary>
    [IsoId("_00qThZJJEeuuktRxxQZoNQ")]
    [DisplayName("Instalment Payment Type")]
    [IsoXmlTag("InstlmtPmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstalmentPaymentType { get; init; }

    /// <summary>
    /// Indicate a deferred Instalment plan.
    /// </summary>
    [IsoId("_qVTp4CuCEeyg-aG5nXcnfg")]
    [DisplayName("Deferred Instalment Indicator")]
    [IsoXmlTag("DfrrdInstlmtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeferredInstalmentIndicator { get; init; }

    /// <summary>
    /// Period unit between consecutive payments.
    /// </summary>
    [IsoId("_00qTh5JJEeuuktRxxQZoNQ")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency18Code? PeriodUnit { get; init; }

    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_00qTiZJJEeuuktRxxQZoNQ")]
    [DisplayName("Number Of Periods")]
    [IsoXmlTag("NbOfPrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfPeriods { get; init; }

    /// <summary>
    /// Details of the interest rate.
    /// </summary>
    [IsoId("_00qTi5JJEeuuktRxxQZoNQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public ValueList<InterestRateDetails2> InterestRate { get; init; } = [];

    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_00qTjZJJEeuuktRxxQZoNQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Amount of the first payment when different from the subsequent payments.
    /// </summary>
    [IsoId("_00qTj5JJEeuuktRxxQZoNQ")]
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; }

    /// <summary>
    /// Normal payment amount.
    /// </summary>
    [IsoId("_00qTkZJJEeuuktRxxQZoNQ")]
    [DisplayName("Normal Payment Amount")]
    [IsoXmlTag("NrmlPmtAmt")]
    public ImpliedCurrencyAndAmount? NormalPaymentAmount { get; init; }

    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_00qTk5JJEeuuktRxxQZoNQ")]
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfPayments { get; init; }

    /// <summary>
    /// Currency code associated with the instalment amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_00qTlZJJEeuuktRxxQZoNQ")]
    [DisplayName("Instalment Currency")]
    [IsoXmlTag("InstlmtCcy")]
    public ISO3NumericCurrencyCode? InstalmentCurrency { get; init; }

    /// <summary>
    /// Contains grace period details.
    /// </summary>
    [IsoId("_00qTl5JJEeuuktRxxQZoNQ")]
    [DisplayName("Grace Period")]
    [IsoXmlTag("GracePrd")]
    public GracePeriod2? GracePeriod { get; init; }

    /// <summary>
    /// Contains the amount details of an instalment plan.
    /// </summary>
    [IsoId("_00qTmZJJEeuuktRxxQZoNQ")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public ValueList<InstalmentAmountDetails2> AmountDetails { get; init; } = [];

    /// <summary>
    /// Total amount of the instalment including charges, insurance and taxes in addition to the funded amount.
    /// </summary>
    [IsoId("_00qTm5JJEeuuktRxxQZoNQ")]
    [DisplayName("Grand Total Amount")]
    [IsoXmlTag("GrdTtlAmt")]
    public ImpliedCurrencyAndAmount? GrandTotalAmount { get; init; }

    /// <summary>
    /// Additional plan data
    /// </summary>
    [IsoId("_5Q7OAJJKEeuuktRxxQZoNQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
