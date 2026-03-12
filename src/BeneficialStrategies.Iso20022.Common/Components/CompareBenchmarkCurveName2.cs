// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a benchmark curve name.
/// </summary>
[IsoId("_FQ6Gsax3Eem81-uIvTF5rQ")]
[DisplayName("Compare Benchmark Curve Name")]
public partial record CompareBenchmarkCurveName2
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_FVYXAax3Eem81-uIvTF5rQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public BenchmarkCurveName10Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_FVYXA6x3Eem81-uIvTF5rQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public BenchmarkCurveName10Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
