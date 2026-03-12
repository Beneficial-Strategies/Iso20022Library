// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the information on the frequency units are matching or not.
/// </summary>
[IsoId("_2k8xoE0jEeyQkYR0RbXyEg")]
[DisplayName("Compare Frequency Unit")]
public partial record CompareFrequencyUnit1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_ruNmsE0lEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public Frequency13Code? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_uH0iYE0lEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public Frequency13Code? Value2 { get; init; } 
    
    
    #nullable disable
    
}
