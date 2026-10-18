// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions for the execution of the payment.
/// </summary>
[IsoId("_4N9WwTFNEe6e4MbXgPVc4A")]
public interface IPaymentCondition2 : IIsoComponent
{
    /// <summary>
    /// Indicates if the debtor is allowed to pay a different amount then the requested amount.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Amount Modification Allowed")]
    [IsoXmlTag("AmtModAllwd")]
    IsoTrueFalseIndicator? AmountModificationAllowed { get; }

    /// <summary>
    /// Penalty to be applied for a delayed payment, that is when the payment is made after the requested execution date.
    /// </summary>
    [DisplayName("Delay Penalty")]
    [IsoXmlTag("DelyPnlty")]
    IsoMax140Text? DelayPenalty { get; }

    /// <summary>
    /// Indicates if the debtor is allowed to pay before the requested execution date.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Early Payment Allowed")]
    [IsoXmlTag("EarlyPmtAllwd")]
    IsoTrueFalseIndicator? EarlyPaymentAllowed { get; }

    /// <summary>
    /// Indicates if a payment guarantee is requested, assuming a payment guarantee contract exists between the different actors.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Guaranteed Payment Requested")]
    [IsoXmlTag("GrntedPmtReqd")]
    IsoTrueFalseIndicator? GuaranteedPaymentRequested { get; }

    /// <summary>
    /// Discount rate applied for immediate payment upon receipt of the request.
    /// </summary>
    [DisplayName("Immediate Payment Rebate")]
    [IsoXmlTag("ImdtPmtRbt")]
    IAmountOrRate1Choice? ImmediatePaymentRebate { get; }
}
