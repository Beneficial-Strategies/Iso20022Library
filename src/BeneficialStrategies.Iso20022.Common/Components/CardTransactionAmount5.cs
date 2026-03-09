// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the transaction expressed within the terminal currency.
/// </summary>
[IsoId("_eU1l0Xu1EeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionAmount5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionAmount5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionAmount5( CurrencyAndAmount reqTotalAmount )
    {
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total amount of the transaction.
    /// It corresponds to ISO 8583, field number 4, completed by the field number 49 for the versions 87 and 93.
    /// </summary>
    [IsoId("_ehNN4Xu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount TotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount TotalAmount { get; init; } 
    #else
    public CurrencyAndAmount TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Present when cardholder billing currency differs from transaction currency expressed in TransactionAmount. It may be populated by the scheme or intermediary processor as normally Acceptor does not know cardholder billing currency.
    /// </summary>
    [IsoId("_ehNN5Xu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Cardholder Billing Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrBllgTxAmt")]
    #endif
    [IsoXmlTag("CrdhldrBllgTxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; } 
    #else
    public DetailedAmount8? CardholderBillingTransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Only present within financial transactions when reconciliation currency differs from transaction currency. It may be populated by acquirers in the request or by the schemes in the responses, depending where the reconciliation point is located.
    /// </summary>
    [IsoId("_ehNN53u1EeS2Z_kGi7H1VQ")]
    [DisplayName("Reconciliation Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnTxAmt")]
    #endif
    [IsoXmlTag("RcncltnTxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount8? ReconciliationTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount8? ReconciliationTransactionAmount { get; init; } 
    #else
    public DetailedAmount8? ReconciliationTransactionAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
