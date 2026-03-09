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
/// Provides details on loan and collateral matching criteria.
/// </summary>
[IsoId("_cKa2VVovEe23K4GXSpBSeg")]
[DisplayName("Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MatchingCriteria16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Compares information related to both sides of a counterparty.
    /// </summary>
    [IsoId("_cL1LkVovEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyMtchgCrit")]
    #endif
    [IsoXmlTag("CtrPtyMtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyMatchingCriteria6? CounterpartyMatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyMatchingCriteria6? CounterpartyMatchingCriteria { get; init; } 
    #else
    public CounterpartyMatchingCriteria6? CounterpartyMatchingCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Compares information related to both sides of a contract valuation.
    /// </summary>
    [IsoId("_cL1Lk1ovEe23K4GXSpBSeg")]
    [DisplayName("Valuation Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnMtchgCrit")]
    #endif
    [IsoXmlTag("ValtnMtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationMatchingCriteria1? ValuationMatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationMatchingCriteria1? ValuationMatchingCriteria { get; init; } 
    #else
    public ValuationMatchingCriteria1? ValuationMatchingCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Compares information related to both sides of a contract.
    /// </summary>
    [IsoId("_cL1LlVovEe23K4GXSpBSeg")]
    [DisplayName("Contract Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctMtchgCrit")]
    #endif
    [IsoXmlTag("CtrctMtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractMatchingCriteria3? ContractMatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractMatchingCriteria3? ContractMatchingCriteria { get; init; } 
    #else
    public ContractMatchingCriteria3? ContractMatchingCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Compares information related to both sides of a transaction.
    /// </summary>
    [IsoId("_cL1Ll1ovEe23K4GXSpBSeg")]
    [DisplayName("Transaction Matching Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxMtchgCrit")]
    #endif
    [IsoXmlTag("TxMtchgCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionMatchingCriteria6? TransactionMatchingCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionMatchingCriteria6? TransactionMatchingCriteria { get; init; } 
    #else
    public TransactionMatchingCriteria6? TransactionMatchingCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
