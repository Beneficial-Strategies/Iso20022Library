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
/// Information related to contract and transaction details.
/// </summary>
[IsoId("_qXWz0XhCEeu3kecHd7QKUQ")]
[DisplayName("Common Trade Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommonTradeDataReport49
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommonTradeDataReport49 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommonTradeDataReport49( TradeTransaction37 reqTransactionData )
    {
        TransactionData = reqTransactionData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_qmrCMXhCEeu3kecHd7QKUQ")]
    [DisplayName("Contract Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctData")]
    #endif
    [IsoXmlTag("CtrctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractType10? ContractData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractType10? ContractData { get; init; } 
    #else
    public ContractType10? ContractData { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a trade transaction.
    /// </summary>
    [IsoId("_qmrCM3hCEeu3kecHd7QKUQ")]
    [DisplayName("Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxData")]
    #endif
    [IsoXmlTag("TxData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeTransaction37 TransactionData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeTransaction37 TransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransaction37 TransactionData { get; init; } 
    #else
    public TradeTransaction37 TransactionData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
