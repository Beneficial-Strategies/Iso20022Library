// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a energy load type.
/// </summary>
[IsoId("_95CA8E6cEeyEpI66tm807w")]
[DisplayName("Compare Energy Load Type")]
public record CompareEnergyLoadType1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_DhZ-sE6dEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public EnergyLoadType1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_FSPDIE6dEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public EnergyLoadType1Code? Value2 { get; init; }
}
