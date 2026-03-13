// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of criteria following the OR logic.
/// </summary>
[IsoId("_BBbMYN6QEeiwsev40qZGEQ")]
[DisplayName("Search Or")]
public partial record SearchOr1
{
    #nullable enable
    
    /// <summary>
    /// List of criteria following the AND logic.
    /// </summary>
    [IsoId("_InLc0N6QEeiwsev40qZGEQ")]
    [DisplayName("Search And")]
    [IsoXmlTag("SchAnd")]
    public ValueList<SearchAnd1> SearchAnd { get; init; } = [];
    // ID for the above is _InLc0N6QEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
