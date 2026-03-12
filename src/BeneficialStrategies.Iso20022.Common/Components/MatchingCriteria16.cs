// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on loan and collateral matching criteria.
/// </summary>
[IsoId("_cKa2VVovEe23K4GXSpBSeg")]
[DisplayName("Matching Criteria")]
public partial record MatchingCriteria16
{
    #nullable enable
    
    /// <summary>
    /// Compares information related to both sides of a counterparty.
    /// </summary>
    [IsoId("_cL1LkVovEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Matching Criteria")]
    [IsoXmlTag("CtrPtyMtchgCrit")]
    public CounterpartyMatchingCriteria6? CounterpartyMatchingCriteria { get; init; } 
    
    /// <summary>
    /// Compares information related to both sides of a contract valuation.
    /// </summary>
    [IsoId("_cL1Lk1ovEe23K4GXSpBSeg")]
    [DisplayName("Valuation Matching Criteria")]
    [IsoXmlTag("ValtnMtchgCrit")]
    public ValuationMatchingCriteria1? ValuationMatchingCriteria { get; init; } 
    
    /// <summary>
    /// Compares information related to both sides of a contract.
    /// </summary>
    [IsoId("_cL1LlVovEe23K4GXSpBSeg")]
    [DisplayName("Contract Matching Criteria")]
    [IsoXmlTag("CtrctMtchgCrit")]
    public ContractMatchingCriteria3? ContractMatchingCriteria { get; init; } 
    
    /// <summary>
    /// Compares information related to both sides of a transaction.
    /// </summary>
    [IsoId("_cL1Ll1ovEe23K4GXSpBSeg")]
    [DisplayName("Transaction Matching Criteria")]
    [IsoXmlTag("TxMtchgCrit")]
    public TransactionMatchingCriteria6? TransactionMatchingCriteria { get; init; } 
    
    
    #nullable disable
    
}
