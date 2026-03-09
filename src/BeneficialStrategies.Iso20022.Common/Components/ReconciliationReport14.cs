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
/// Data on transaction requiring reconciliation or pairing.
/// </summary>
[IsoId("_cIzsx1ovEe23K4GXSpBSeg")]
[DisplayName("Reconciliation Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationReport14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationReport14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationReport14( TradeTransactionIdentification24 reqTransactionIdentification,MatchingCriteria16 reqMatchingCriteria )
    {
        TransactionIdentification = reqTransactionIdentification;
        MatchingCriteria = reqMatchingCriteria;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of information related to transactions that are subject of reconciliation.
    /// </summary>
    [IsoId("_cKa2UVovEe23K4GXSpBSeg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    #else
    public TradeTransactionIdentification24 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Criteria used to match the sides of the contract.
    /// </summary>
    [IsoId("_cKa2U1ovEe23K4GXSpBSeg")]
    [DisplayName("Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgCrit")]
    #endif
    [IsoXmlTag("MtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MatchingCriteria16 MatchingCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MatchingCriteria16 MatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingCriteria16 MatchingCriteria { get; init; } 
    #else
    public MatchingCriteria16 MatchingCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
