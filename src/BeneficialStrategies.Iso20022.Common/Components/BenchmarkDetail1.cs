// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies further details of the benchmark.
/// </summary>
[IsoId("_ZCkIIPKNEeaz_YGUGLjP6A")]
[DisplayName("Benchmark Detail")]
public record BenchmarkDetail1
{
    /// <summary>
    /// Full name of the benchmark.
    /// </summary>
    [IsoId("_D5BoIBnVEee-a6ThOKLTug")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullName { get; init; }

    /// <summary>
    /// Index name of the benchmark.
    /// </summary>
    [IsoId("_QgI5oBnVEee-a6ThOKLTug")]
    [DisplayName("Index")]
    [IsoXmlTag("Indx")]
    public BenchmarkCurveName2Code? Index { get; init; }

    /// <summary>
    /// Any other additional information about the benchmark.
    /// </summary>
    [IsoId("_-cTTsDrkEeedCZZ8dIPp6g")]
    [DisplayName("Comment")]
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? Comment { get; init; }
}
