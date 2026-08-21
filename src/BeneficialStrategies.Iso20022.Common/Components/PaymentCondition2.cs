// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions for the execution of the payment.
/// </summary>
[IsoId("_4N9WwTFNEe6e4MbXgPVc4A")]
[Description(@"Specifies the conditions for the execution of the payment.")]
[DisplayName("Payment Condition2")]
public record PaymentCondition2
{
    /// <summary>
    /// Indicates if the debtor is allowed to pay a different amount then the requested amount.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Amount Modification Allowed")]
    [IsoXmlTag("AmtModAllwd")]
    public IsoTrueFalseIndicator? AmountModificationAllowed { get; init; }

    /// <summary>
    /// Penalty to be applied for a delayed payment, that is when the payment is made after the requested execution date.
    /// </summary>
    [DisplayName("Delay Penalty")]
    [IsoXmlTag("DelyPnlty")]
    public IsoMax140Text? DelayPenalty { get; init; }

    /// <summary>
    /// Indicates if the debtor is allowed to pay before the requested execution date.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Early Payment Allowed")]
    [IsoXmlTag("EarlyPmtAllwd")]
    public IsoTrueFalseIndicator? EarlyPaymentAllowed { get; init; }

    /// <summary>
    /// Indicates if a payment guarantee is requested, assuming a payment guarantee contract exists between the different actors.
    /// Usage: When element is not present, the default value is "Not Applicable".
    /// </summary>
    [DisplayName("Guaranteed Payment Requested")]
    [IsoXmlTag("GrntedPmtReqd")]
    public IsoTrueFalseIndicator? GuaranteedPaymentRequested { get; init; }

    /// <summary>
    /// Discount rate applied for immediate payment upon receipt of the request.
    /// </summary>
    [DisplayName("Immediate Payment Rebate")]
    [IsoXmlTag("ImdtPmtRbt")]
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; init; }
}
