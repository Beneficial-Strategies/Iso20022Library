// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data on transaction requiring reconciliation or pairing.
/// </summary>
[IsoId("_cIzsx1ovEe23K4GXSpBSeg")]
[DisplayName("Reconciliation Report")]
public partial record ReconciliationReport14
{
    #nullable enable
    
    /// <summary>
    /// Set of information related to transactions that are subject of reconciliation.
    /// </summary>
    [IsoId("_cKa2UVovEe23K4GXSpBSeg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Criteria used to match the sides of the contract.
    /// </summary>
    [IsoId("_cKa2U1ovEe23K4GXSpBSeg")]
    [DisplayName("Matching Criteria")]
    [IsoXmlTag("MtchgCrit")]
    public required MatchingCriteria16 MatchingCriteria { get; init; } 
    
    
    #nullable disable
    
}
