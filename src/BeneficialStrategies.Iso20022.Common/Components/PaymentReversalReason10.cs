// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReversalReason10"/>
[IsoId("_yEc2KTEyEe6g-ffJsqGiSA")]
[Description(@"Provides further details on the reason of the reversal of the transaction.")]
[DisplayName("Payment Reversal Reason10")]
public partial record PaymentReversalReason10
{
    /// <inheritdoc cref="IPaymentReversalReason10.AdditionalInformation"/>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentReversalReason10.Originator"/>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification272? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReversalReason10.Reason"/>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReversalReason4Choice_? Reason { get; init; }
}
