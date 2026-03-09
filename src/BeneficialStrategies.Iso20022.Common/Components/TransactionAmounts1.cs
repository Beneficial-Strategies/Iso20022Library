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
/// Amounts of the card transaction.
/// </summary>
[IsoId("_1-7FQESIEeeb1MmUPTrSMw")]
[DisplayName("Transaction Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionAmounts1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Qualifier or type of amount.
    /// ISO 8583:93/2003 bit 24
    /// </summary>
    [IsoId("_AusaoESJEeeb1MmUPTrSMw")]
    [DisplayName("Amount Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtQlfr")]
    #endif
    [IsoXmlTag("AmtQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount11Code? AmountQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount11Code? AmountQualifier { get; init; } 
    #else
    public TypeOfAmount11Code? AmountQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    [IsoId("_T6zDIESJEeeb1MmUPTrSMw")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionAmount1? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAmount1? TransactionAmount { get; init; } 
    #else
    public TransactionAmount1? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Present when the cardholder billing currency differs from the transaction currency expressed in the amount of the transaction. It may be populated by the card scheme or an intermediary processor as normally the acceptor does not know the billing currency for which the cardholder will be debited.
    /// </summary>
    [IsoId("_KdbJwESJEeeb1MmUPTrSMw")]
    [DisplayName("Cardholder Billing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrBllgAmt")]
    #endif
    [IsoXmlTag("CrdhldrBllgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount4? CardholderBillingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount4? CardholderBillingAmount { get; init; } 
    #else
    public Amount4? CardholderBillingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    [IsoId("_gwLaIESJEeeb1MmUPTrSMw")]
    [DisplayName("Reconciliation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnAmt")]
    #endif
    [IsoXmlTag("RcncltnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount4? ReconciliationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount4? ReconciliationAmount { get; init; } 
    #else
    public Amount4? ReconciliationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of some or all amounts in the transaction amount. 
    /// </summary>
    [IsoId("_M9dY8EUKEeea986VZkEPUw")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount19? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount19? DetailedAmount { get; init; } 
    #else
    public DetailedAmount19? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount related to the original transaction.
    /// ISO 8583:87 bit 95
    /// ISO 8583:93/2003 bit 30
    /// </summary>
    [IsoId("_jFo7kEULEeea-M6VZkEPUw")]
    [DisplayName("Original Transaction Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxAmts")]
    #endif
    [IsoXmlTag("OrgnlTxAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionAmount1? OriginalTransactionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionAmount1? OriginalTransactionAmounts { get; init; } 
    #else
    public OriginalTransactionAmount1? OriginalTransactionAmounts { get; set; } 
    #endif
    
    
    #nullable disable
    
}
