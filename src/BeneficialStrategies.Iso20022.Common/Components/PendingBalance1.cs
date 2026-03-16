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
[IsoId("_Sn0U0tp-Ed-ak6NoX_4Aeg_-1482532458")]
[DisplayName("Pending Balance")]
public record PendingBalance1
{
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_Sn0U09p-Ed-ak6NoX_4Aeg_-1154682647")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat2 Balance { get; init; }

    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_Sn0U1Np-Ed-ak6NoX_4Aeg_2128817829")]
    [DisplayName("Pending Transactions")]
    [IsoXmlTag("PdgTxs")]
    public SettlementTypeAndIdentification2? PendingTransactions { get; init; }
}
