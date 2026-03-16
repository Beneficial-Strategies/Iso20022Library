// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the reversal of the transaction.
/// </summary>
[IsoId("_YEpCuW49EeiU9cctagi5ow")]
[DisplayName("Payment Reversal Reason")]
public record PaymentReversalReason9
{
    /// <summary>
    /// Party that issues the reversal.
    /// </summary>
    [IsoId("_YNljQ249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_YNljRW49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReversalReason4Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_YNljR249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
