// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction(s) and/or batched entries.
/// </summary>
[IsoId("f37a9c75-bb94-4d3b-9fd4-a92231f41be9")]
[DisplayName("Entry Details16")]
public record EntryDetails16
{
    /// <summary>
    /// Provides details on batched transactions.
    /// </summary>
    [IsoId("02a784dc-e6c7-42e6-9922-0fcaa093d29b")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation2? Batch { get; init; }

    /// <summary>
    /// Provides information on the underlying transaction(s).
    /// </summary>
    [IsoId("e7918090-f987-4885-bbae-8c889078120d")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<EntryTransaction16> TransactionDetails { get; init; } = [];
}
