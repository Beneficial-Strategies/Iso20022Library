// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReturnReason4"/>
[IsoId("_nTY3MbTREeeyuKckOGlwuA")]
[DisplayName("Payment Return Reason")]
public partial record PaymentReturnReason4
{
    /// <inheritdoc cref="IPaymentReturnReason4.Originator"/>
    [IsoId("_ncBOxbTREeeyuKckOGlwuA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification125? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReturnReason4.Reason"/>
    [IsoId("_ncBOx7TREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; }

    /// <inheritdoc cref="IPaymentReturnReason4.AdditionalInformation"/>
    [IsoId("_ncBOybTREeeyuKckOGlwuA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
