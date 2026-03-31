// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details on the settlement fails split per intra-CSD and cross-CSD instructions or explicit no data report.
    /// </summary>
    [KnownType(typeof(SettlementFailsDailyCSD1Choice.DataSetAction))]
    [KnownType(typeof(SettlementFailsDailyCSD1Choice.Data))]
    [JsonDerivedType(
        typeof(SettlementFailsDailyCSD1Choice.DataSetAction),
        nameof(SettlementFailsDailyCSD1Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(SettlementFailsDailyCSD1Choice.Data),
        nameof(SettlementFailsDailyCSD1Choice.Data)
    )]
    [IsoId("_OxcU0zOaEeqBfed1bmSPqg")]
    [DisplayName("Settlement Fails Daily CSD 1 Choice")]
    public abstract record SettlementFailsDailyCSD1Choice_ { }
}
