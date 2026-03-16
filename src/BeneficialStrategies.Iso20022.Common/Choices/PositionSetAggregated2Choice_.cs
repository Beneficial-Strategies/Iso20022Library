// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Position Set Aggregated2Choice.
    /// </summary>
    [KnownType(typeof(PositionSetAggregated2Choice.DataSetAction))]
    [KnownType(typeof(PositionSetAggregated2Choice.Report))]
    [JsonDerivedType(typeof(PositionSetAggregated2Choice.DataSetAction),nameof(PositionSetAggregated2Choice.DataSetAction))]
    [JsonDerivedType(typeof(PositionSetAggregated2Choice.Report),nameof(PositionSetAggregated2Choice.Report))]
    [IsoId("_jPMiIRTjEe61h9tfoUrWyw")]
    [DisplayName("Position Set Aggregated2Choice")]
    public abstract partial record PositionSetAggregated2Choice_
    {
    }
}
