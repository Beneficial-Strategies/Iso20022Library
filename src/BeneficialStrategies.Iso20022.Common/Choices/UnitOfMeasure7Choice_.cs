// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for unit of measure.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure7Choice.Code))]
    [KnownType(typeof(UnitOfMeasure7Choice.Proprietary))]
    [JsonDerivedType(typeof(UnitOfMeasure7Choice.Code), nameof(UnitOfMeasure7Choice.Code))]
    [JsonDerivedType(
        typeof(UnitOfMeasure7Choice.Proprietary),
        nameof(UnitOfMeasure7Choice.Proprietary)
    )]
    [IsoId("_rZT0YWp8EemmaZLSPtWX5A")]
    [DisplayName("Unit Of Measure 7 Choice")]
    public abstract record UnitOfMeasure7Choice_ { }
}
