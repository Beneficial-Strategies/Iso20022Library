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
[IsoId("_f-Mf0HsyEeSTS7uHCe8FPQ")]
[DisplayName("Card Transaction Amount")]
public partial record CardTransactionAmount1
{
    #nullable enable
    
    /// <summary>
    /// Total amount of the transaction expressed within the terminal currency.
    /// It corresponds to ISO 8583 field number 4, completed by the field number 49 for the versions 87 and 93.
    /// </summary>
    [IsoId("_xvQtsHsyEeSTS7uHCe8FPQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; } 
    
    /// <summary>
    /// Qualifies the amount of the transaction.
    /// </summary>
    [IsoId("_5mfIoHsyEeSTS7uHCe8FPQ")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    
    /// <summary>
    /// Present when cardholder billing currency differs from transaction currency expressed in transaction amount. It may be populated by the scheme or intermediary processor as normally acceptor does not know cardholder billing currency.
    /// </summary>
    [IsoId("_JvIAIHszEeSTS7uHCe8FPQ")]
    [DisplayName("Cardholder Billing Transaction Amount")]
    [IsoXmlTag("CrdhldrBllgTxAmt")]
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; } 
    
    /// <summary>
    /// Details of the transaction amount, for informational purpose, for instance to be included within cardholder statement.
    /// It corresponds partially to ISO 8583 field number 54.
    /// </summary>
    [IsoId("_-JY2oHszEeSTS7uHCe8FPQ")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount9? DetailedAmount { get; init; } 
    
    
    #nullable disable
    
}
