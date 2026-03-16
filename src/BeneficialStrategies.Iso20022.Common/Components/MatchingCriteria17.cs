// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Matching Criteria17.
/// </summary>
[IsoId("_BVxjlZBIEe6Ojt1b3tfu9Q")]
[DisplayName("Matching Criteria17")]
public partial record MatchingCriteria17
{
    #nullable enable

    /// <summary>
    /// Contract Matching Criteria.
    /// </summary>
    [DisplayName("Contract Matching Criteria")]
    [IsoXmlTag("CtrctMtchgCrit")]
    public ContractMatchingCriteria3? ContractMatchingCriteria { get; init; } 

    /// <summary>
    /// Counterparty Matching Criteria.
    /// </summary>
    [DisplayName("Counterparty Matching Criteria")]
    [IsoXmlTag("CtrPtyMtchgCrit")]
    public CounterpartyMatchingCriteria6? CounterpartyMatchingCriteria { get; init; } 

    /// <summary>
    /// Transaction Matching Criteria.
    /// </summary>
    [DisplayName("Transaction Matching Criteria")]
    [IsoXmlTag("TxMtchgCrit")]
    public TransactionMatchingCriteria7? TransactionMatchingCriteria { get; init; } 

    /// <summary>
    /// Valuation Matching Criteria.
    /// </summary>
    [DisplayName("Valuation Matching Criteria")]
    [IsoXmlTag("ValtnMtchgCrit")]
    public ValuationMatchingCriteria1? ValuationMatchingCriteria { get; init; } 

    
    #nullable disable
    
}
