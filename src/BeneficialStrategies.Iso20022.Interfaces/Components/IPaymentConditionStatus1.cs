// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the status of the payment conditions.
/// </summary>
[IsoId("_IGiOt3VlEeiEU7thYTAN1w")]
public interface IPaymentConditionStatus1 : IIsoComponent
{
    /// <summary>
    /// Amount accepted to be paid.
    /// Usage:
    /// May only be present when AmountModificationAllowed is present in the request.
    /// </summary>
    [IsoId("_p7y48HVlEeiEU7thYTAN1w")]
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    ActiveCurrencyAndAmount? AcceptedAmount { get; }

    /// <summary>
    /// Indicates if the DebtorAgent guarantees the payment, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    [IsoId("_IGiOvXVlEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment")]
    [IsoXmlTag("GrntedPmt")]
    IsoTrueFalseIndicator GuaranteedPayment { get; }

    /// <summary>
    /// Indicates if the debtor will pay before the requested execution date.
    /// </summary>
    [IsoId("_IGiOuHVlEeiEU7thYTAN1w")]
    [DisplayName("Early Payment")]
    [IsoXmlTag("EarlyPmt")]
    IsoTrueFalseIndicator EarlyPayment { get; }
}
