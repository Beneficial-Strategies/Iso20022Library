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
[IsoId("_rL3mQWEUEe2P-L9DBerEgA")]
[DisplayName("Common Trade Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommonTradeDataReport69
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommonTradeDataReport69 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommonTradeDataReport69( TradeTransaction49 reqTransactionData )
    {
        TransactionData = reqTransactionData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_rMuh4WEUEe2P-L9DBerEgA")]
    [DisplayName("Contract Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctData")]
    #endif
    [IsoXmlTag("CtrctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractType14? ContractData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractType14? ContractData { get; init; } 
    #else
    public ContractType14? ContractData { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a trade transaction.
    /// </summary>
    [IsoId("_rMuh42EUEe2P-L9DBerEgA")]
    [DisplayName("Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxData")]
    #endif
    [IsoXmlTag("TxData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeTransaction49 TransactionData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeTransaction49 TransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransaction49 TransactionData { get; init; } 
    #else
    public TradeTransaction49 TransactionData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
