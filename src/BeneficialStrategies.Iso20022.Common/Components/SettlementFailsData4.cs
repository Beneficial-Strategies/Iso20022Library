// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data of settlement fails instructions.
/// </summary>
[IsoId("_nUbWwSGkEeqlG_HhjTmcZg")]
[DisplayName("Settlement Fails Data")]
public partial record SettlementFailsData4
{
    #nullable enable
    
    /// <summary>
    /// Total of all types of settlement transactions.
    /// </summary>
    [IsoId("_nWXQcSGkEeqlG_HhjTmcZg")]
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public required SettlementTotalData1 Total { get; init; } 
    
    /// <summary>
    /// Further details on the reason for the settlement fails.
    /// </summary>
    [IsoId("_nWXQcyGkEeqlG_HhjTmcZg")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public required SettlementFailureReason3 FailureReason { get; init; } 
    
    /// <summary>
    /// Eligible for derogation under the local regulation on settlement discipline, including the justification.
    /// </summary>
    [IsoId("_nWXQdSGkEeqlG_HhjTmcZg")]
    [DisplayName("Eligible For Derogation")]
    [IsoXmlTag("ElgblForDrgtn")]
    public required SettlementFailsDerogation1 EligibleForDerogation { get; init; } 
    
    
    #nullable disable
    
}
