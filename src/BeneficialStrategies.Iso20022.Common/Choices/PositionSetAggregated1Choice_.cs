// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(PositionSetAggregated1Choice.DataSetAction))]
    [KnownType(typeof(PositionSetAggregated1Choice.Report))]
    [JsonDerivedType(typeof(PositionSetAggregated1Choice.DataSetAction),nameof(PositionSetAggregated1Choice.DataSetAction))]
    [JsonDerivedType(typeof(PositionSetAggregated1Choice.Report),nameof(PositionSetAggregated1Choice.Report))]
    [IsoId("_CHENw0whEeqwfMIOLcNxbw")]
    [DisplayName("Position Set Aggregated 1 Choice")]
    public abstract partial record PositionSetAggregated1Choice_
    {
    }
}
