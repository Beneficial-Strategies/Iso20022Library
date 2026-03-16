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
[IsoId("_mvoC0bTREeeyuKckOGlwuA")]
[DisplayName("Payment Reversal Reason")]
public record PaymentReversalReason8
{
    /// <summary>
    /// Party that issues the reversal.
    /// </summary>
    [IsoId("_m3YQo7TREeeyuKckOGlwuA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification125? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_m3YQpbTREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReversalReason4Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_m3YQp7TREeeyuKckOGlwuA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; }
}
