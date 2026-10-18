// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReturnReason7"/>
[Description(@"Provides further details on the reason of the return of the transaction.")]
[IsoId("_wrllwTEyEe6g-ffJsqGiSA")]
[DisplayName("Payment Return Reason7")]
public partial record PaymentReturnReason7
{
    /// <inheritdoc cref="IPaymentReturnReason7.AdditionalInformation"/>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentReturnReason7.Originator"/>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification272? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReturnReason7.Reason"/>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; }
}
