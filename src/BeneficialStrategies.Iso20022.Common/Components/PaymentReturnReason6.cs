// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReturnReason6"/>
[IsoId("_I5-c23L_EeidQ_AAdEzxQA")]
[DisplayName("Payment Return Reason")]
public partial record PaymentReturnReason6
{
    /// <inheritdoc cref="IPaymentReturnReason6.Originator"/>
    [IsoId("_JEjVJXL_EeidQ_AAdEzxQA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReturnReason6.Reason"/>
    [IsoId("_JEjVJ3L_EeidQ_AAdEzxQA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; }

    /// <inheritdoc cref="IPaymentReturnReason6.AdditionalInformation"/>
    [IsoId("_JEjVKXL_EeidQ_AAdEzxQA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
