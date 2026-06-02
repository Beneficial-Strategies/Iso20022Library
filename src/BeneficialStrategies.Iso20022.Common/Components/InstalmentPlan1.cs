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
[IsoId("_dJGhAT1-EfCQAqQ9lolFUg")]
[DisplayName("Instalment Plan1")]
public record InstalmentPlan1
{
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    [IsoId("_dLQdIT1-EfCQAqQ9lolFUg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// List of plan owners. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_dLQdIz1-EfCQAqQ9lolFUg")]
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PlanOwner2Code? Owner { get; init; }

    /// <summary>
    /// Name of the instalment owner.
    /// </summary>
    [IsoId("_dLQdJz1-EfCQAqQ9lolFUg")]
    [DisplayName("Owner Name")]
    [IsoXmlTag("OwnrNm")]
    public IsoMax256Text? OwnerName { get; init; }

    /// <summary>
    /// Contains plan registration system identifier.
    /// </summary>
    [IsoId("_dLQdKT1-EfCQAqQ9lolFUg")]
    [DisplayName("Registration System Identification")]
    [IsoXmlTag("RegnSysId")]
    public IsoMax35Text? RegistrationSystemIdentification { get; init; }

    /// <summary>
    /// Instalment payment type.
    /// </summary>
    [IsoId("_dLQdKz1-EfCQAqQ9lolFUg")]
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public IsoMax35Text? PaymentType { get; init; }

    /// <summary>
    /// Indicate a deferred Instalment plan.
    /// </summary>
    [IsoId("_dLQdLT1-EfCQAqQ9lolFUg")]
    [DisplayName("Deferred")]
    [IsoXmlTag("Dfrrd")]
    public IsoTrueFalseIndicator? Deferred { get; init; }

    /// <summary>
    /// Period unit between consecutive payments.
    /// </summary>
    [IsoId("_dLQdLz1-EfCQAqQ9lolFUg")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency18Code? PeriodUnit { get; init; }

    /// <summary>
    /// Contains the number of period units between initiation of instalment plan and the date of required first payment.
    /// </summary>
    [IsoId("_dLQdMz1-EfCQAqQ9lolFUg")]
    [DisplayName("Deferred Periods")]
    [IsoXmlTag("DfrrdPrds")]
    public IsoNumber? DeferredPeriods { get; init; }

    /// <summary>
    /// Monthly interest rate.
    /// </summary>
    [IsoId("_dLQdNT1-EfCQAqQ9lolFUg")]
    [DisplayName("Monthly Interest Rate")]
    [IsoXmlTag("MnthlyIntrstRate")]
    public IsoBaseOneRate? MonthlyInterestRate { get; init; }

    /// <summary>
    /// Annual interest rate.
    /// </summary>
    [IsoId("_CkF70T1_EfCQAqQ9lolFUg")]
    [DisplayName("Annual Interest Rate")]
    [IsoXmlTag("AnlIntrstRate")]
    public IsoBaseOneRate? AnnualInterestRate { get; init; }

    /// <summary>
    /// Date of the first payment.
    /// </summary>
    [IsoId("_dLQdNz1-EfCQAqQ9lolFUg")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <summary>
    /// Amount of the first payment when different from the subsequent payments.
    /// </summary>
    [IsoId("_dLQdOT1-EfCQAqQ9lolFUg")]
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; }

    /// <summary>
    /// Normal payment amount.
    /// </summary>
    [IsoId("_dLQdOz1-EfCQAqQ9lolFUg")]
    [DisplayName("Normal Payment Amount")]
    [IsoXmlTag("NrmlPmtAmt")]
    public ImpliedCurrencyAndAmount? NormalPaymentAmount { get; init; }

    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_dLQdPT1-EfCQAqQ9lolFUg")]
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    public IsoNumber? TotalNumberOfPayments { get; init; }

    /// <summary>
    /// Currency code associated with the instalment amount. ISO 4217 "Codes for the representation of currencies and funds".
    /// </summary>
    [IsoId("_dLQdPz1-EfCQAqQ9lolFUg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Grace period unit type. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_dLQdQT1-EfCQAqQ9lolFUg")]
    [DisplayName("Grace Period Unit Type")]
    [IsoXmlTag("GracePrdUnitTp")]
    public GracePeriodUnitType2Code? GracePeriodUnitType { get; init; }

    /// <summary>
    /// Number of grace period as defined by grace period unit type.
    /// </summary>
    [IsoId("_dLQdRT1-EfCQAqQ9lolFUg")]
    [DisplayName("Number Of Grace Period Units")]
    [IsoXmlTag("NbOfGracePrdUnits")]
    public IsoMax3NumericText? NumberOfGracePeriodUnits { get; init; }

    /// <summary>
    /// Indicates a customer selected grace period.
    /// </summary>
    [IsoId("_dLQdRz1-EfCQAqQ9lolFUg")]
    [DisplayName("Customer Selected Grace Period")]
    [IsoXmlTag("CstmrSelctdGracePrd")]
    public IsoTrueFalseIndicator? CustomerSelectedGracePeriod { get; init; }

    /// <summary>
    /// Contains the amount details of an instalment plan.
    /// </summary>
    [IsoId("_dLQdST1-EfCQAqQ9lolFUg")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public ValueList<InstalmentAmountData1> AmountDetails { get; init; } = [];

    /// <summary>
    /// Total amount of the instalment including charges, insurance and taxes in addition to the funded amount.
    /// </summary>
    [IsoId("_dLQdSz1-EfCQAqQ9lolFUg")]
    [DisplayName("Grand Total Amount")]
    [IsoXmlTag("GrdTtlAmt")]
    public ImpliedCurrencyAndAmount? GrandTotalAmount { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_aWXVYkVaEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_aWXVY0VaEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
