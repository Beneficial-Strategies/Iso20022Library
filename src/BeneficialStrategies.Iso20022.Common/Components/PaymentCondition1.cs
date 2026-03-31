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
[IsoId("_BmRRkHVjEeiEU7thYTAN1w")]
[DisplayName("Payment Condition")]
public record PaymentCondition1
{
    /// <summary>
    /// Indicates if the debtor is allowed to pay a different amount then the requested amount.
    /// </summary>
    [IsoId("_zg-VYHVjEeiEU7thYTAN1w")]
    [DisplayName("Amount Modification Allowed")]
    [IsoXmlTag("AmtModAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator AmountModificationAllowed { get; init; }

    /// <summary>
    /// Indicates if the debtor is allowed to pay before the requested execution date.
    /// </summary>
    [IsoId("_3QRRoXVjEeiEU7thYTAN1w")]
    [DisplayName("Early Payment Allowed")]
    [IsoXmlTag("EarlyPmtAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EarlyPaymentAllowed { get; init; }

    /// <summary>
    /// Penalty to be applied for a delayed payment, that is when the payment is made after the requested execution date.
    /// </summary>
    [IsoId("_YiSE4HVkEeiEU7thYTAN1w")]
    [DisplayName("Delay Penalty")]
    [IsoXmlTag("DelyPnlty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? DelayPenalty { get; init; }

    /// <summary>
    /// Discount rate applied for immediate payment upon receipt of the request.
    /// </summary>
    [IsoId("_jw1A8HVkEeiEU7thYTAN1w")]
    [DisplayName("Immediate Payment Rebate")]
    [IsoXmlTag("ImdtPmtRbt")]
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; init; }

    /// <summary>
    /// Indicates if a payment guarantee is requested, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    [IsoId("_-63wYHVkEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment Requested")]
    [IsoXmlTag("GrntedPmtReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator GuaranteedPaymentRequested { get; init; }
}
