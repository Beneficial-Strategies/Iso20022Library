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
[IsoId("_phGVqQ1LEeqV4s5SpzR1dQ")]
[DisplayName("Common Trade Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommonTradeDataReport39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommonTradeDataReport39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommonTradeDataReport39( TradeTransaction25 reqTransactionData )
    {
        TransactionData = reqTransactionData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_ph2jkQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctData")]
    #endif
    [IsoXmlTag("CtrctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractType8? ContractData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractType8? ContractData { get; init; } 
    #else
    public ContractType8? ContractData { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a trade transaction.
    /// </summary>
    [IsoId("_ph2jkw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxData")]
    #endif
    [IsoXmlTag("TxData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeTransaction25 TransactionData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeTransaction25 TransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransaction25 TransactionData { get; init; } 
    #else
    public TradeTransaction25 TransactionData { get; set; } 
    #endif
    
    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_ph2jlQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctMod")]
    #endif
    [IsoXmlTag("CtrctMod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractModification1? ContractModification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractModification1? ContractModification { get; init; } 
    #else
    public ContractModification1? ContractModification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
