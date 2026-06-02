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
[IsoId("_Nfxw0T2AEfCQAqQ9lolFUg")]
[DisplayName("Instalment8")]
public record Instalment8
{
    /// <summary>
    /// Indicates the occurrence of a single instalment payment within a series of instalment payments.
    /// </summary>
    [IsoId("_Nh-JMT2AEfCQAqQ9lolFUg")]
    [DisplayName("Payment Sequence Number")]
    [IsoXmlTag("PmtSeqNb")]
    public IsoNumber? PaymentSequenceNumber { get; init; }

    /// <summary>
    /// Attributes of the instalment plan.
    /// </summary>
    [IsoId("_Nh-JMz2AEfCQAqQ9lolFUg")]
    [DisplayName("Plan")]
    [IsoXmlTag("Plan")]
    public ValueList<InstalmentPlan1> Plan { get; init; } = [];
}
