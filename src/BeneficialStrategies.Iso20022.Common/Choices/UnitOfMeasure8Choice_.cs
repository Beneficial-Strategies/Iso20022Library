// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure8Choice.Code))]
    [KnownType(typeof(UnitOfMeasure8Choice.Proprietary))]
    [JsonDerivedType(typeof(UnitOfMeasure8Choice.Code), nameof(UnitOfMeasure8Choice.Code))]
    [JsonDerivedType(
        typeof(UnitOfMeasure8Choice.Proprietary),
        nameof(UnitOfMeasure8Choice.Proprietary)
    )]
    [IsoId("_D7l4ADNlEe2UWZuK9pqFtg")]
    [DisplayName("Unit Of Measure 8 Choice")]
    public abstract record UnitOfMeasure8Choice_ { }
}
