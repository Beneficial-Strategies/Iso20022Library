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
[IsoId("_Sn0U0tp-Ed-ak6NoX_4Aeg_-1482532458")]
[DisplayName("Pending Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PendingBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PendingBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PendingBalance1( SignedQuantityFormat2 reqBalance )
    {
        Balance = reqBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_Sn0U09p-Ed-ak6NoX_4Aeg_-1154682647")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignedQuantityFormat2 Balance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SignedQuantityFormat2 Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2 Balance { get; init; } 
    #else
    public SignedQuantityFormat2 Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_Sn0U1Np-Ed-ak6NoX_4Aeg_2128817829")]
    [DisplayName("Pending Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgTxs")]
    #endif
    [IsoXmlTag("PdgTxs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTypeAndIdentification2? PendingTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTypeAndIdentification2? PendingTransactions { get; init; } 
    #else
    public SettlementTypeAndIdentification2? PendingTransactions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
