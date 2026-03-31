// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a unit of measure with a code or free text.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure3Choice.UnitOfMeasureCode))]
    [KnownType(typeof(UnitOfMeasure3Choice.OtherUnitOfMeasure))]
    [JsonDerivedType(
        typeof(UnitOfMeasure3Choice.UnitOfMeasureCode),
        nameof(UnitOfMeasure3Choice.UnitOfMeasureCode)
    )]
    [JsonDerivedType(
        typeof(UnitOfMeasure3Choice.OtherUnitOfMeasure),
        nameof(UnitOfMeasure3Choice.OtherUnitOfMeasure)
    )]
    [IsoId("__YQFQBrZEeOVR9VN6fAMUg")]
    [DisplayName("Unit Of Measure 3 Choice")]
    public abstract record UnitOfMeasure3Choice_ { }
}
