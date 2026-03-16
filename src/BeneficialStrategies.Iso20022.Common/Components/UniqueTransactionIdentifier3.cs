// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique Transaction Identifier3.
/// </summary>
[IsoId("_F1OxV0jrEe-KhcStGV4xTg")]
[DisplayName("Unique Transaction Identifier3")]
public record UniqueTransactionIdentifier3
{
    /// <summary>
    /// Prior Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Prior Unique Transaction Identifier")]
    [IsoXmlTag("PrrUnqTxIdr")]
    public ValueList<IsoUTIIdentifier> PriorUniqueTransactionIdentifier { get; init; } = [];

    /// <summary>
    /// Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public required IsoUTIIdentifier UniqueTransactionIdentifier { get; init; }
}
