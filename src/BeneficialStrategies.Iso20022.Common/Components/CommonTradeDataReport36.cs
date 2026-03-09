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
[IsoId("_ifb7qQ1JEeqV4s5SpzR1dQ")]
[DisplayName("Common Trade Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommonTradeDataReport36
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specifically related to contract.
    /// </summary>
    [IsoId("_igMJkw1JEeqV4s5SpzR1dQ")]
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
    /// Data related specifically to the transaction.
    /// </summary>
    [IsoId("_igMJlQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxData")]
    #endif
    [IsoXmlTag("TxData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransaction27? TransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransaction27? TransactionData { get; init; } 
    #else
    public TradeTransaction27? TransactionData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
