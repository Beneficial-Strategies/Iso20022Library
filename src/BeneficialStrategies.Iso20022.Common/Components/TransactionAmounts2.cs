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
[IsoId("_ONxHoY2mEeuPp4VyLQDHhg")]
[DisplayName("Transaction Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionAmounts2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionAmounts2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionAmounts2( TransactionAmount1 reqTransactionAmount )
    {
        TransactionAmount = reqTransactionAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Qualifier or type of amount.
    /// ISO 8583:93/2003 bit 24
    /// </summary>
    [IsoId("_OUlhUY2mEeuPp4VyLQDHhg")]
    [DisplayName("Amount Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtQlfr")]
    #endif
    [IsoXmlTag("AmtQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount22Code? AmountQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount22Code? AmountQualifier { get; init; } 
    #else
    public TypeOfAmount22Code? AmountQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    [IsoId("_OUlhU42mEeuPp4VyLQDHhg")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionAmount1 TransactionAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionAmount1 TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAmount1 TransactionAmount { get; init; } 
    #else
    public TransactionAmount1 TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Present when the cardholder billing currency differs from the transaction currency expressed in the amount of the transaction. It may be populated by the card scheme or an intermediary processor as normally the acceptor does not know the billing currency for which the cardholder will be debited.
    /// </summary>
    [IsoId("_OUlhVY2mEeuPp4VyLQDHhg")]
    [DisplayName("Cardholder Billing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrBllgAmt")]
    #endif
    [IsoXmlTag("CrdhldrBllgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount15? CardholderBillingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount15? CardholderBillingAmount { get; init; } 
    #else
    public Amount15? CardholderBillingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    [IsoId("_OUlhV42mEeuPp4VyLQDHhg")]
    [DisplayName("Reconciliation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnAmt")]
    #endif
    [IsoXmlTag("RcncltnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount15? ReconciliationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount15? ReconciliationAmount { get; init; } 
    #else
    public Amount15? ReconciliationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of some or all amounts in the transaction amount. 
    /// </summary>
    [IsoId("_OUlhWY2mEeuPp4VyLQDHhg")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount22? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount22? DetailedAmount { get; init; } 
    #else
    public DetailedAmount22? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount related to the original transaction.
    /// ISO 8583:87 bit 95
    /// ISO 8583:93/2003 bit 30
    /// </summary>
    [IsoId("_OUlhW42mEeuPp4VyLQDHhg")]
    [DisplayName("Original Transaction Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxAmts")]
    #endif
    [IsoXmlTag("OrgnlTxAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionAmount2? OriginalTransactionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionAmount2? OriginalTransactionAmounts { get; init; } 
    #else
    public OriginalTransactionAmount2? OriginalTransactionAmounts { get; set; } 
    #endif
    
    
    #nullable disable
    
}
