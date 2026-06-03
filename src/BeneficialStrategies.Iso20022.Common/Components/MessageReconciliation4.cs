// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains message reconciliation data.
/// </summary>
[IsoId("_3TzIAWP5EfCX7uJiAWHfoQ")]
[DisplayName("Message Reconciliation4")]
public record MessageReconciliation4
{
    /// <summary>
    /// Contains the reconciliation message type. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_3WGOEWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReconciliationMessageType2Code Type { get; init; }

    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_3WGOFWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    public required IsoNumber Count { get; init; }
}
