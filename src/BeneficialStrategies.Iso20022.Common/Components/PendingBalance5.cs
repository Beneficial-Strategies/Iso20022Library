// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about pending balance and pending transactions.
/// </summary>
[IsoId("_UkjYkbQYEeeKRKrD60ELBQ")]
[DisplayName("Pending Balance")]
public record PendingBalance5
{
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_UzRxEbQYEeeKRKrD60ELBQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat6 Balance { get; init; }

    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_UzRxGbQYEeeKRKrD60ELBQ")]
    [DisplayName("Pending Transactions")]
    [IsoXmlTag("PdgTxs")]
    public ValueList<SettlementTypeAndIdentification25> PendingTransactions { get; init; } = [];
}
