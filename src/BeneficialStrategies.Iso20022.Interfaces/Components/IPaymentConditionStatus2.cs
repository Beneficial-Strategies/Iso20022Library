// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the status of the payment conditions.
/// </summary>
[IsoId("_FJs0oWwLEe6Mn47rYvO6fQ")]
public interface IPaymentConditionStatus2 : IIsoComponent
{
    /// <summary>
    /// Amount accepted to be paid.
    /// Usage:
    /// May only be present when AmountModificationAllowed is present in the request.
    /// </summary>
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    ActiveCurrencyAndAmount? AcceptedAmount { get; }

    /// <summary>
    /// Indicates if the debtor will pay before the requested execution date.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Early Payment")]
    [IsoXmlTag("EarlyPmt")]
    IsoTrueFalseIndicator? EarlyPayment { get; }

    /// <summary>
    /// Indicates if the DebtorAgent guarantees the payment, assuming a payment guarantee contract exists between the different actors.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Guaranteed Payment")]
    [IsoXmlTag("GrntedPmt")]
    IsoTrueFalseIndicator? GuaranteedPayment { get; }
}
