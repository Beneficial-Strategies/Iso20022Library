// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the card transaction.
/// </summary>
[IsoId("_ONxHoY2mEeuPp4VyLQDHhg")]
[DisplayName("Transaction Amounts")]
public partial record TransactionAmounts2
{
    #nullable enable
    
    /// <summary>
    /// Qualifier or type of amount.
    /// ISO 8583:93/2003 bit 24
    /// </summary>
    [IsoId("_OUlhUY2mEeuPp4VyLQDHhg")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount22Code? AmountQualifier { get; init; } 
    
    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    [IsoId("_OUlhU42mEeuPp4VyLQDHhg")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public required TransactionAmount1 TransactionAmount { get; init; } 
    
    /// <summary>
    /// Present when the cardholder billing currency differs from the transaction currency expressed in the amount of the transaction. It may be populated by the card scheme or an intermediary processor as normally the acceptor does not know the billing currency for which the cardholder will be debited.
    /// </summary>
    [IsoId("_OUlhVY2mEeuPp4VyLQDHhg")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public Amount15? CardholderBillingAmount { get; init; } 
    
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    [IsoId("_OUlhV42mEeuPp4VyLQDHhg")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount15? ReconciliationAmount { get; init; } 
    
    /// <summary>
    /// Further details of some or all amounts in the transaction amount. 
    /// </summary>
    [IsoId("_OUlhWY2mEeuPp4VyLQDHhg")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount22? DetailedAmount { get; init; } 
    
    /// <summary>
    /// Amount related to the original transaction.
    /// ISO 8583:87 bit 95
    /// ISO 8583:93/2003 bit 30
    /// </summary>
    [IsoId("_OUlhW42mEeuPp4VyLQDHhg")]
    [DisplayName("Original Transaction Amounts")]
    [IsoXmlTag("OrgnlTxAmts")]
    public OriginalTransactionAmount2? OriginalTransactionAmounts { get; init; } 
    
    
    #nullable disable
    
}
