// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the aggregated data of settlement instructions or explicit no data report.
    /// </summary>
    [KnownType(typeof(SettlementTotalData1Choice.DataSetAction))]
    [KnownType(typeof(SettlementTotalData1Choice.Data))]
    [JsonDerivedType(
        typeof(SettlementTotalData1Choice.DataSetAction),
        nameof(SettlementTotalData1Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(SettlementTotalData1Choice.Data),
        nameof(SettlementTotalData1Choice.Data)
    )]
    [IsoId("_allUdx2lEeqF2P5v-Rtejg")]
    [DisplayName("Settlement Total Data 1 Choice")]
    public abstract record SettlementTotalData1Choice_ { }
}
