// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for unit of measure.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure4Choice.Code))]
    [KnownType(typeof(UnitOfMeasure4Choice.Proprietary))]
    [JsonDerivedType(typeof(UnitOfMeasure4Choice.Code),nameof(UnitOfMeasure4Choice.Code))]
    [JsonDerivedType(typeof(UnitOfMeasure4Choice.Proprietary),nameof(UnitOfMeasure4Choice.Proprietary))]
    [IsoId("_eda0K-LaEeWFtOV72FbX9w")]
    [DisplayName("Unit Of Measure 4 Choice")]
    public abstract partial record UnitOfMeasure4Choice_
    {
    }
}
