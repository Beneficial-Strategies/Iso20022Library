// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a MIC identifier.
/// </summary>
[IsoId("_VwtkgdSZEemZdYGWu384Zw")]
[DisplayName("Compare MIC Identifier")]
public record CompareMICIdentifier2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_V1kPUdSZEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_V1kPU9SZEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? Value2 { get; init; }
}
