// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the transaction expressed within the terminal currency.
/// </summary>
[IsoId("_eU1l0Xu1EeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Amount")]
public partial record CardTransactionAmount5
{
    #nullable enable
    
    /// <summary>
    /// Total amount of the transaction.
    /// It corresponds to ISO 8583, field number 4, completed by the field number 49 for the versions 87 and 93.
    /// </summary>
    [IsoId("_ehNN4Xu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; } 
    
    /// <summary>
    /// Present when cardholder billing currency differs from transaction currency expressed in TransactionAmount. It may be populated by the scheme or intermediary processor as normally Acceptor does not know cardholder billing currency.
    /// </summary>
    [IsoId("_ehNN5Xu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Cardholder Billing Transaction Amount")]
    [IsoXmlTag("CrdhldrBllgTxAmt")]
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; } 
    
    /// <summary>
    /// Only present within financial transactions when reconciliation currency differs from transaction currency. It may be populated by acquirers in the request or by the schemes in the responses, depending where the reconciliation point is located.
    /// </summary>
    [IsoId("_ehNN53u1EeS2Z_kGi7H1VQ")]
    [DisplayName("Reconciliation Transaction Amount")]
    [IsoXmlTag("RcncltnTxAmt")]
    public DetailedAmount8? ReconciliationTransactionAmount { get; init; } 
    
    
    #nullable disable
    
}
