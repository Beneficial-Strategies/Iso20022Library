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
[IsoId("_cfvHi5KQEeWHWpTQn1FFVg")]
[DisplayName("Pending Balance")]
public record PendingBalance4
{
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_cfvHjZKQEeWHWpTQn1FFVg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat9 Balance { get; init; }

    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_cfvHlZKQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Transactions")]
    [IsoXmlTag("PdgTxs")]
    public ValueList<SettlementTypeAndIdentification21> PendingTransactions { get; init; } = [];
}
