// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount related to the original transaction.
/// </summary>
[IsoId("_K-cTUZF0EeukDPgU2BMkjQ")]
[DisplayName("Original Transaction Amount")]
public partial record OriginalTransactionAmount2
{
    #nullable enable
    
    /// <summary>
    /// Qualifies the amount of the transaction.
    /// </summary>
    [IsoId("_LEVf8ZF0EeukDPgU2BMkjQ")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount22Code? AmountQualifier { get; init; } 
    
    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    [IsoId("_LEVf85F0EeukDPgU2BMkjQ")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public required TransactionAmount1 TransactionAmount { get; init; } 
    
    /// <summary>
    /// Amount to be billed to cardholder.
    /// </summary>
    [IsoId("_LEVf9ZF0EeukDPgU2BMkjQ")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public Amount15? CardholderBillingAmount { get; init; } 
    
    /// <summary>
    /// Amount used for reconciliation.
    /// </summary>
    [IsoId("_LEVf95F0EeukDPgU2BMkjQ")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount15? ReconciliationAmount { get; init; } 
    
    
    #nullable disable
    
}
