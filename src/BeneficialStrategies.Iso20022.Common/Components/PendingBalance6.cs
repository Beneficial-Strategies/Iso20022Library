// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about pending balance and pending transactions.
/// </summary>
[IsoId("_qrJj1c3iEee5nJBZsW8MFQ")]
[DisplayName("Pending Balance")]
public partial record PendingBalance6
{
    #nullable enable
    
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_qrJj183iEee5nJBZsW8MFQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat9 Balance { get; init; } 
    
    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_qrJj383iEee5nJBZsW8MFQ")]
    [DisplayName("Pending Transactions")]
    [IsoXmlTag("PdgTxs")]
    public SettlementTypeAndIdentification26? PendingTransactions { get; init; } 
    
    
    #nullable disable
    
}
