// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligibility parameters for a transaction to be part of transaction report.
/// </summary>
[IsoId("_5HATgN6PEeiwsev40qZGEQ")]
[DisplayName("Search Criteria")]
public partial record SearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// List of criteria following the OR logic.
    /// </summary>
    [IsoId("_APMeMN6QEeiwsev40qZGEQ")]
    [DisplayName("Search Or")]
    [IsoXmlTag("SchOr")]
    public ValueList<SearchOr1> SearchOr { get; init; } = [];
    // ID for the above is _APMeMN6QEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
