// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a unit of measure with a code or free text.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure6Choice.UnitOfMeasureCode))]
    [KnownType(typeof(UnitOfMeasure6Choice.OtherUnitOfMeasure))]
    [JsonDerivedType(
        typeof(UnitOfMeasure6Choice.UnitOfMeasureCode),
        nameof(UnitOfMeasure6Choice.UnitOfMeasureCode)
    )]
    [JsonDerivedType(
        typeof(UnitOfMeasure6Choice.OtherUnitOfMeasure),
        nameof(UnitOfMeasure6Choice.OtherUnitOfMeasure)
    )]
    [IsoId("_QMk1cfFSEee_LsXdoqzkWg")]
    [DisplayName("Unit Of Measure 6 Choice")]
    public abstract record UnitOfMeasure6Choice_ { }
}
