// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentConditionStatus2"/>
[IsoId("_FJs0oWwLEe6Mn47rYvO6fQ")]
[Description(@"Specifies the details on the status of the payment conditions.")]
[DisplayName("Payment Condition Status2")]
public partial record PaymentConditionStatus2
{
    /// <inheritdoc cref="IPaymentConditionStatus2.AcceptedAmount"/>
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; }

    /// <inheritdoc cref="IPaymentConditionStatus2.EarlyPayment"/>
    [DisplayName("Early Payment")]
    [IsoXmlTag("EarlyPmt")]
    public IsoTrueFalseIndicator? EarlyPayment { get; init; }

    /// <inheritdoc cref="IPaymentConditionStatus2.GuaranteedPayment"/>
    [DisplayName("Guaranteed Payment")]
    [IsoXmlTag("GrntedPmt")]
    public IsoTrueFalseIndicator? GuaranteedPayment { get; init; }
}
