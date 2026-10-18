// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentReturnReason1"/>
[IsoId("_t3s_ElkyEeGeoaLUQk__nA_-1045029043")]
[DisplayName("Payment Return Reason")]
public partial record PaymentReturnReason1
{
    /// <inheritdoc cref="IPaymentReturnReason1.Originator"/>
    [IsoId("_t3s_E1kyEeGeoaLUQk__nA_1886907482")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <inheritdoc cref="IPaymentReturnReason1.Reason"/>
    [IsoId("_t32wEFkyEeGeoaLUQk__nA_1419289072")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; }

    /// <inheritdoc cref="IPaymentReturnReason1.AdditionalInformation"/>
    [IsoId("_t32wEVkyEeGeoaLUQk__nA_1844100220")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
