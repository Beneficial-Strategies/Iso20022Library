// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a reason for an instruction to change the status of an account.
    /// </summary>
    [KnownType(typeof(AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(AccountStatusUpdateInstructionReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason),
        nameof(AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AccountStatusUpdateInstructionReason1Choice.Reason),
        nameof(AccountStatusUpdateInstructionReason1Choice.Reason)
    )]
    [IsoId("_MizyUXi8EeaRm5xIK6nGuQ")]
    [DisplayName("Account Status Update Instruction Reason 1 Choice")]
    public abstract record AccountStatusUpdateInstructionReason1Choice_ { }
}
