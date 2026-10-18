// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentCondition2"/>
[IsoId("_4N9WwTFNEe6e4MbXgPVc4A")]
[Description(@"Specifies the conditions for the execution of the payment.")]
[DisplayName("Payment Condition2")]
public partial record PaymentCondition2
{
    /// <inheritdoc cref="IPaymentCondition2.AmountModificationAllowed"/>
    [DisplayName("Amount Modification Allowed")]
    [IsoXmlTag("AmtModAllwd")]
    public IsoTrueFalseIndicator? AmountModificationAllowed { get; init; }

    /// <inheritdoc cref="IPaymentCondition2.DelayPenalty"/>
    [DisplayName("Delay Penalty")]
    [IsoXmlTag("DelyPnlty")]
    public IsoMax140Text? DelayPenalty { get; init; }

    /// <inheritdoc cref="IPaymentCondition2.EarlyPaymentAllowed"/>
    [DisplayName("Early Payment Allowed")]
    [IsoXmlTag("EarlyPmtAllwd")]
    public IsoTrueFalseIndicator? EarlyPaymentAllowed { get; init; }

    /// <inheritdoc cref="IPaymentCondition2.GuaranteedPaymentRequested"/>
    [DisplayName("Guaranteed Payment Requested")]
    [IsoXmlTag("GrntedPmtReqd")]
    public IsoTrueFalseIndicator? GuaranteedPaymentRequested { get; init; }

    /// <inheritdoc cref="IPaymentCondition2.ImmediatePaymentRebate"/>
    [DisplayName("Immediate Payment Rebate")]
    [IsoXmlTag("ImdtPmtRbt")]
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; init; }
}
