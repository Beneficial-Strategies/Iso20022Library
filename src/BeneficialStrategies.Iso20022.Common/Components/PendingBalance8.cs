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
[IsoId("_pgBMvzi7Eeydid5dcNPKvg")]
[DisplayName("Pending Balance")]
public record PendingBalance8
{
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_pgBMwTi7Eeydid5dcNPKvg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat13 Balance { get; init; }

    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_pgBMyTi7Eeydid5dcNPKvg")]
    [DisplayName("Pending Transactions")]
    [IsoXmlTag("PdgTxs")]
    public ValueList<SettlementTypeAndIdentification26> PendingTransactions { get; init; } = [];
}
