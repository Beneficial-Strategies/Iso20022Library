// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of criteria following the AND logic.
/// </summary>
[IsoId("_JdNs8N6QEeiwsev40qZGEQ")]
[DisplayName("Search And")]
public partial record SearchAnd1
{
    #nullable enable
    
    /// <summary>
    /// Identifier of target element.
    /// </summary>
    [IsoId("_Sh7OsN6QEeiwsev40qZGEQ")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public required IsoMax500Text Target { get; init; } 
    
    /// <summary>
    /// Comparison operator used to evaluate matching transactions vs criteria.
    /// </summary>
    [IsoId("_VruRMN6QEeiwsev40qZGEQ")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operator1Code Operator { get; init; } 
    
    /// <summary>
    /// Reference value to be used when evaluating against the target element value using the criteria operator.
    /// </summary>
    [IsoId("_Y_OCQN6QEeiwsev40qZGEQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public required IsoMax500Text Value { get; init; } 
    
    
    #nullable disable
    
}
