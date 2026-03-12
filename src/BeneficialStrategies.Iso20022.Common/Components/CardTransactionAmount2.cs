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
[IsoId("_8lwpoXuUEeSVeNXcmBQ4hQ")]
[DisplayName("Card Transaction Amount")]
public partial record CardTransactionAmount2
{
    #nullable enable
    
    /// <summary>
    /// Total amount of the transaction.
    /// It corresponds to ISO 8583, field number 4, completed by the field number 49 for the versions 87 and 93.
    /// </summary>
    [IsoId("_8yIRsXuUEeSVeNXcmBQ4hQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required CurrencyAndAmount TotalAmount { get; init; } 
    
    /// <summary>
    /// Present when cardholder billing currency differs from transaction currency expressed in TransactionAmount. It may be populated by the scheme or intermediary processor as normally Acceptor does not know cardholder billing currency.
    /// </summary>
    [IsoId("_8yIRtXuUEeSVeNXcmBQ4hQ")]
    [DisplayName("Cardholder Billing Transaction Amount")]
    [IsoXmlTag("CrdhldrBllgTxAmt")]
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; } 
    
    /// <summary>
    /// Details of the TransactionAmount, for informational purposes only, except for cash back which is mandatory for a payment transaction with cashback. The transaction amount is not necessarly the sum of all the detailed amount values.
    /// </summary>
    [IsoId("_8yIRuXuUEeSVeNXcmBQ4hQ")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount9? DetailedAmount { get; init; } 
    
    
    #nullable disable
    
}
