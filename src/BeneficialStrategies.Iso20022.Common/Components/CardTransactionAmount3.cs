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
[IsoId("_t4bwwYNvEeSXtJ8rlirVJw")]
[DisplayName("Card Transaction Amount")]
public partial record CardTransactionAmount3
{
    #nullable enable
    
    /// <summary>
    /// Total amount of the transaction.
    /// It corresponds to ISO 8583, field number 4, completed by the field number 49 for the versions 87 and 93.
    /// </summary>
    [IsoId("_uGQxYYNvEeSXtJ8rlirVJw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; } 
    
    /// <summary>
    /// Qualifies the amount of the transaction.
    /// </summary>
    [IsoId("_uGQxY4NvEeSXtJ8rlirVJw")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    
    /// <summary>
    /// Present when cardholder billing currency differs from transaction currency expressed in TransactionAmount. It may be populated by the scheme or intermediary processor as normally Acceptor does not know cardholder billing currency.
    /// </summary>
    [IsoId("_uGQxZYNvEeSXtJ8rlirVJw")]
    [DisplayName("Cardholder Billing Transaction Amount")]
    [IsoXmlTag("CrdhldrBllgTxAmt")]
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; } 
    
    /// <summary>
    /// Only present within financial transactions when reconciliation currency differs from transaction currency. It may be populated by acquirers in the request or by the schemes in the responses, depending where the reconciliation point is located.
    /// </summary>
    [IsoId("_5RukQINvEeSXtJ8rlirVJw")]
    [DisplayName("Reconciliation Transaction Amount")]
    [IsoXmlTag("RcncltnTxAmt")]
    public DetailedAmount8? ReconciliationTransactionAmount { get; init; } 
    
    /// <summary>
    /// Details of the transaction amount, for informational purpose, for instance to be included within cardholder statement.
    /// It corresponds partially to ISO 8583, field number 54.
    /// </summary>
    [IsoId("_uGQxZ4NvEeSXtJ8rlirVJw")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount9? DetailedAmount { get; init; } 
    
    
    #nullable disable
    
}
