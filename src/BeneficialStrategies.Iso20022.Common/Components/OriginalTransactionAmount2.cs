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
/// Amount related to the original transaction.
/// </summary>
[IsoId("_K-cTUZF0EeukDPgU2BMkjQ")]
[DisplayName("Original Transaction Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalTransactionAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalTransactionAmount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalTransactionAmount2( TransactionAmount1 reqTransactionAmount )
    {
        TransactionAmount = reqTransactionAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Qualifies the amount of the transaction.
    /// </summary>
    [IsoId("_LEVf8ZF0EeukDPgU2BMkjQ")]
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
    [IsoId("_LEVf85F0EeukDPgU2BMkjQ")]
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
    /// Amount to be billed to cardholder.
    /// </summary>
    [IsoId("_LEVf9ZF0EeukDPgU2BMkjQ")]
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
    /// </summary>
    [IsoId("_LEVf95F0EeukDPgU2BMkjQ")]
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
    
    
    #nullable disable
    
}
