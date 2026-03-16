// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a unit of measure.
/// </summary>
[IsoId("_Atb7Aa5nEeuo-IflVgGqiA")]
[DisplayName("Compare Unit Of Measure")]
public record CompareUnitOfMeasure3
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_A8fqsa5nEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public UnitOfMeasure11Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_A8fqs65nEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public UnitOfMeasure11Code? Value2 { get; init; }
}
