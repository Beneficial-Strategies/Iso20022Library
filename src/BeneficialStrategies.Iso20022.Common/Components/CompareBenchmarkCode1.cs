// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a benchmark code.
/// </summary>
[IsoId("_IaYPcTIQEe2fXedS_ucFOA")]
[DisplayName("Compare Benchmark Code")]
public record CompareBenchmarkCode1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_IbN88TIQEe2fXedS_ucFOA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ExternalBenchmarkCurveName1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_IbN88zIQEe2fXedS_ucFOA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ExternalBenchmarkCurveName1Code? Value2 { get; init; }
}
