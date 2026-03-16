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
[IsoId("__o7G4bQ_EemPBPgZjF7-nQ")]
[DisplayName("Compare Unit Of Measure")]
public record CompareUnitOfMeasure2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("__v9jAbQ_EemPBPgZjF7-nQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public UnitOfMeasure11Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("__v9jA7Q_EemPBPgZjF7-nQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public UnitOfMeasure11Code? Value2 { get; init; }
}
