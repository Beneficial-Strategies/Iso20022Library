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
[IsoId("_Ays4p8K3EeuFNp8LZAnorg")]
[DisplayName("Matching Criteria")]
public partial record MatchingCriteria10
{
    #nullable enable
    
    /// <summary>
    /// Compares information related to both sides of a loan.
    /// </summary>
    [IsoId("_A0Exo8K3EeuFNp8LZAnorg")]
    [DisplayName("Counterparty Matching Criteria")]
    [IsoXmlTag("CtrPtyMtchgCrit")]
    public CounterpartyMatchingCriteria4? CounterpartyMatchingCriteria { get; init; } 
    
    /// <summary>
    /// Compares information related to both sides of a loan.
    /// </summary>
    [IsoId("_A0ExpcK3EeuFNp8LZAnorg")]
    [DisplayName("Loan Matching Criteria")]
    [IsoXmlTag("LnMtchgCrit")]
    public LoanMatchingCriteria9? LoanMatchingCriteria { get; init; } 
    
    /// <summary>
    /// Compares information related to both sides of a collateral.
    /// </summary>
    [IsoId("_A0Exp8K3EeuFNp8LZAnorg")]
    [DisplayName("Collateral Matching Criteria")]
    [IsoXmlTag("CollMtchgCrit")]
    public CollateralMatchingCriteria6? CollateralMatchingCriteria { get; init; } 
    
    
    #nullable disable
    
}
