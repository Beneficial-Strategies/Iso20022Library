// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a unit of measure.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure5Choice.Code))]
    [KnownType(typeof(UnitOfMeasure5Choice.Proprietary))]
    [JsonDerivedType(typeof(UnitOfMeasure5Choice.Code),nameof(UnitOfMeasure5Choice.Code))]
    [JsonDerivedType(typeof(UnitOfMeasure5Choice.Proprietary),nameof(UnitOfMeasure5Choice.Proprietary))]
    [IsoId("_arSvUPp2EeaQh_7a05rSJQ")]
    [DisplayName("Unit Of Measure 5 Choice")]
    public abstract partial record UnitOfMeasure5Choice_
    {
    }
}
