// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
/// </summary>
[IsoId("_Amb4cZJKEeuuktRxxQZoNQ")]
[DisplayName("Instalment")]
public record Instalment4
{
    /// <summary>
    /// Indicates the occurrence of a single instalment payment within a series of instalment payments.
    /// </summary>
    [IsoId("_AsZ9kZJKEeuuktRxxQZoNQ")]
    [DisplayName("Payment Sequence Number")]
    [IsoXmlTag("PmtSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PaymentSequenceNumber { get; init; }

    /// <summary>
    /// Attributes of the instalment plan.
    /// </summary>
    [IsoId("_AsZ9k5JKEeuuktRxxQZoNQ")]
    [DisplayName("Plan")]
    [IsoXmlTag("Plan")]
    public ValueList<Plan2> Plan { get; init; } = [];
}
