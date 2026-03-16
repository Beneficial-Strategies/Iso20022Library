// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Condition2.
/// </summary>
[IsoId("_4N9WwTFNEe6e4MbXgPVc4A")]
[DisplayName("Payment Condition2")]
public record PaymentCondition2
{
    /// <summary>
    /// Amount Modification Allowed.
    /// </summary>
    [DisplayName("Amount Modification Allowed")]
    [IsoXmlTag("AmtModAllwd")]
    public IsoTrueFalseIndicator? AmountModificationAllowed { get; init; }

    /// <summary>
    /// Delay Penalty.
    /// </summary>
    [DisplayName("Delay Penalty")]
    [IsoXmlTag("DelyPnlty")]
    public IsoMax140Text? DelayPenalty { get; init; }

    /// <summary>
    /// Early Payment Allowed.
    /// </summary>
    [DisplayName("Early Payment Allowed")]
    [IsoXmlTag("EarlyPmtAllwd")]
    public IsoTrueFalseIndicator? EarlyPaymentAllowed { get; init; }

    /// <summary>
    /// Guaranteed Payment Requested.
    /// </summary>
    [DisplayName("Guaranteed Payment Requested")]
    [IsoXmlTag("GrntedPmtReqd")]
    public IsoTrueFalseIndicator? GuaranteedPaymentRequested { get; init; }

    /// <summary>
    /// Immediate Payment Rebate.
    /// </summary>
    [DisplayName("Immediate Payment Rebate")]
    [IsoXmlTag("ImdtPmtRbt")]
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; init; }
}
