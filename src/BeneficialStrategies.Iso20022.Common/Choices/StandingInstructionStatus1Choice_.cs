// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between various statuses.
    /// </summary>
    [KnownType(typeof(StandingInstructionStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(StandingInstructionStatus1Choice.RejectedStatus))]
    [JsonDerivedType(typeof(StandingInstructionStatus1Choice.ProcessedStatus),nameof(StandingInstructionStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(StandingInstructionStatus1Choice.RejectedStatus),nameof(StandingInstructionStatus1Choice.RejectedStatus))]
    [IsoId("_RiiHyNp-Ed-ak6NoX_4Aeg_-2004656056")]
    [DisplayName("Standing Instruction Status 1 Choice")]
    public abstract partial record StandingInstructionStatus1Choice_
    {
    }
}
