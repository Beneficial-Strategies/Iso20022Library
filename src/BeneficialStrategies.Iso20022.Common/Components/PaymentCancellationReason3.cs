// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the cancellation request.
/// </summary>
[IsoId("_wapyAUgtEeaGKYpLDboHPQ")]
[DisplayName("Payment Cancellation Reason")]
public record PaymentCancellationReason3
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_wjlEg0gtEeaGKYpLDboHPQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_wjlEhUgtEeaGKYpLDboHPQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationReason33Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_wjlEh0gtEeaGKYpLDboHPQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
