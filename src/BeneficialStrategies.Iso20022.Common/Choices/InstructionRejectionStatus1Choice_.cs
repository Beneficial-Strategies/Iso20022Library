// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of instruction rejection status.
    /// </summary>
    [KnownType(typeof(InstructionRejectionStatus1Choice.Code))]
    [KnownType(typeof(InstructionRejectionStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InstructionRejectionStatus1Choice.Code),
        nameof(InstructionRejectionStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InstructionRejectionStatus1Choice.Proprietary),
        nameof(InstructionRejectionStatus1Choice.Proprietary)
    )]
    [IsoId("_RCfVxdp-Ed-ak6NoX_4Aeg_-1295104262")]
    [DisplayName("Instruction Rejection Status 1 Choice")]
    public abstract record InstructionRejectionStatus1Choice_ { }
}
