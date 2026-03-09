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
/// Provides information about pending balance and pending transactions.
/// </summary>
[IsoId("_l5agcTq5EeWQ1Y7f8kds2A")]
[DisplayName("Pending Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PendingBalance3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PendingBalance3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PendingBalance3( SignedQuantityFormat6 reqBalance )
    {
        Balance = reqBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_mF6rUTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignedQuantityFormat6 Balance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SignedQuantityFormat6 Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6 Balance { get; init; } 
    #else
    public SignedQuantityFormat6 Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_mF6rWTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Pending Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgTxs")]
    #endif
    [IsoXmlTag("PdgTxs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTypeAndIdentification20? PendingTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTypeAndIdentification20? PendingTransactions { get; init; } 
    #else
    public SettlementTypeAndIdentification20? PendingTransactions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
