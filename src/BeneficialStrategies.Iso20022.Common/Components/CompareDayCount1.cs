// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a day count.
/// </summary>
[IsoId("_RiiO4E0jEeyQkYR0RbXyEg")]
[DisplayName("Compare Day Count")]
public partial record CompareDayCount1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_ZSzGME0jEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public InterestComputationMethodFormat7? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_bPxwQE0jEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public InterestComputationMethodFormat7? Value2 { get; init; } 
    
    
    #nullable disable
    
}
