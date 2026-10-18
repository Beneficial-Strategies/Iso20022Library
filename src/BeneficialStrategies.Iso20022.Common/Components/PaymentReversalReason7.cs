// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReversalReason7"/>
[IsoId("_t3aEIVkyEeGeoaLUQk__nA_20263708")]
[DisplayName("Payment Reversal Reason")]
public partial record PaymentReversalReason7
{
    /// <inheritdoc cref="IPaymentReversalReason7.Originator"/>
    [IsoId("_t3aEIlkyEeGeoaLUQk__nA_1241275489")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReversalReason7.Reason"/>
    [IsoId("_t3aEI1kyEeGeoaLUQk__nA_-1778414709")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReversalReason4Choice_? Reason { get; init; }

    /// <inheritdoc cref="IPaymentReversalReason7.AdditionalInformation"/>
    [IsoId("_t3aEJFkyEeGeoaLUQk__nA_-878513043")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
