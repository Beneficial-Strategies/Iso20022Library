// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Cancellation Reason6.
/// </summary>
[IsoId("_wwdesTEyEe6g-ffJsqGiSA")]
[DisplayName("Payment Cancellation Reason6")]
public record PaymentCancellationReason6
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification272? Originator { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationReason33Choice_? Reason { get; init; }
}
