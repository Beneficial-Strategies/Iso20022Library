// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReversalReason8"/>
[IsoId("_mvoC0bTREeeyuKckOGlwuA")]
[DisplayName("Payment Reversal Reason")]
public partial record PaymentReversalReason8
{
    /// <inheritdoc cref="IPaymentReversalReason8.Originator"/>
    [IsoId("_m3YQo7TREeeyuKckOGlwuA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification125? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReversalReason8.Reason"/>
    [IsoId("_m3YQpbTREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReversalReason4Choice_? Reason { get; init; }

    /// <inheritdoc cref="IPaymentReversalReason8.AdditionalInformation"/>
    [IsoId("_m3YQp7TREeeyuKckOGlwuA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
