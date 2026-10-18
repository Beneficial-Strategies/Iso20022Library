// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions for the execution of the payment.
/// </summary>
[IsoId("_BmRRkHVjEeiEU7thYTAN1w")]
public interface IPaymentCondition1 : IIsoComponent
{
    /// <summary>
    /// Indicates if the debtor is allowed to pay a different amount then the requested amount.
    /// </summary>
    [IsoId("_zg-VYHVjEeiEU7thYTAN1w")]
    [DisplayName("Amount Modification Allowed")]
    [IsoXmlTag("AmtModAllwd")]
    IsoTrueFalseIndicator AmountModificationAllowed { get; }

    /// <summary>
    /// Indicates if the debtor is allowed to pay before the requested execution date.
    /// </summary>
    [IsoId("_3QRRoXVjEeiEU7thYTAN1w")]
    [DisplayName("Early Payment Allowed")]
    [IsoXmlTag("EarlyPmtAllwd")]
    IsoTrueFalseIndicator EarlyPaymentAllowed { get; }

    /// <summary>
    /// Penalty to be applied for a delayed payment, that is when the payment is made after the requested execution date.
    /// </summary>
    [IsoId("_YiSE4HVkEeiEU7thYTAN1w")]
    [DisplayName("Delay Penalty")]
    [IsoXmlTag("DelyPnlty")]
    IsoMax140Text? DelayPenalty { get; }

    /// <summary>
    /// Discount rate applied for immediate payment upon receipt of the request.
    /// </summary>
    [IsoId("_jw1A8HVkEeiEU7thYTAN1w")]
    [DisplayName("Immediate Payment Rebate")]
    [IsoXmlTag("ImdtPmtRbt")]
    IAmountOrRate1Choice? ImmediatePaymentRebate { get; }

    /// <summary>
    /// Indicates if a payment guarantee is requested, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    [IsoId("_-63wYHVkEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment Requested")]
    [IsoXmlTag("GrntedPmtReqd")]
    IsoTrueFalseIndicator GuaranteedPaymentRequested { get; }
}
