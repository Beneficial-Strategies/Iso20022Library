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
[IsoId("_l5agcTq5EeWQ1Y7f8kds2A")]
[DisplayName("Pending Balance")]
public partial record PendingBalance3
{
    #nullable enable
    
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_mF6rUTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required SignedQuantityFormat6 Balance { get; init; } 
    
    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_mF6rWTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Pending Transactions")]
    [IsoXmlTag("PdgTxs")]
    public SettlementTypeAndIdentification20? PendingTransactions { get; init; } 
    
    
    #nullable disable
    
}
