// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the standing settlement instruction information.
    /// </summary>
    [KnownType(typeof(SettlementStandingInstructionDatabase1Choice.Code))]
    [KnownType(typeof(SettlementStandingInstructionDatabase1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStandingInstructionDatabase1Choice.Code),
        nameof(SettlementStandingInstructionDatabase1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementStandingInstructionDatabase1Choice.Proprietary),
        nameof(SettlementStandingInstructionDatabase1Choice.Proprietary)
    )]
    [IsoId("_QtyRF9p-Ed-ak6NoX_4Aeg_-4724885")]
    [DisplayName("Settlement Standing Instruction Database 1 Choice")]
    public abstract record SettlementStandingInstructionDatabase1Choice_ { }
}
