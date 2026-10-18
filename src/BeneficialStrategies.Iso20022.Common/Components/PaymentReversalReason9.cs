// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReversalReason9"/>
[IsoId("_YEpCuW49EeiU9cctagi5ow")]
[DisplayName("Payment Reversal Reason")]
public partial record PaymentReversalReason9
{
    /// <inheritdoc cref="IPaymentReversalReason9.Originator"/>
    [IsoId("_YNljQ249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReversalReason9.Reason"/>
    [IsoId("_YNljRW49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReversalReason4Choice_? Reason { get; init; }

    /// <inheritdoc cref="IPaymentReversalReason9.AdditionalInformation"/>
    [IsoId("_YNljR249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
