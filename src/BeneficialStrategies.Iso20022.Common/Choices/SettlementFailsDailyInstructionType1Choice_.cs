// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details on the settlement fails split per instruction types or explicit no data report..
    /// </summary>
    [KnownType(typeof(SettlementFailsDailyInstructionType1Choice.DataSetAction))]
    [KnownType(typeof(SettlementFailsDailyInstructionType1Choice.Data))]
    [JsonDerivedType(
        typeof(SettlementFailsDailyInstructionType1Choice.DataSetAction),
        nameof(SettlementFailsDailyInstructionType1Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(SettlementFailsDailyInstructionType1Choice.Data),
        nameof(SettlementFailsDailyInstructionType1Choice.Data)
    )]
    [IsoId("_-9n1xTOkEeqX8uoQQ3KffQ")]
    [DisplayName("Settlement Fails Daily Instruction Type 1 Choice")]
    public abstract record SettlementFailsDailyInstructionType1Choice_ { }
}
