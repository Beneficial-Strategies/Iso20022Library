// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentConditionStatus1"/>
[IsoId("_IGiOt3VlEeiEU7thYTAN1w")]
[DisplayName("Payment Condition Status")]
public partial record PaymentConditionStatus1
{
    /// <inheritdoc cref="IPaymentConditionStatus1.AcceptedAmount"/>
    [IsoId("_p7y48HVlEeiEU7thYTAN1w")]
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; }

    /// <inheritdoc cref="IPaymentConditionStatus1.GuaranteedPayment"/>
    [IsoId("_IGiOvXVlEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment")]
    [IsoXmlTag("GrntedPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator GuaranteedPayment { get; init; }

    /// <inheritdoc cref="IPaymentConditionStatus1.EarlyPayment"/>
    [IsoId("_IGiOuHVlEeiEU7thYTAN1w")]
    [DisplayName("Early Payment")]
    [IsoXmlTag("EarlyPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EarlyPayment { get; init; }
}
