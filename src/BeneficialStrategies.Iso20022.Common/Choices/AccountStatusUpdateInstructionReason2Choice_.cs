// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a reason for an instruction to change the status of an account.
    /// </summary>
    [KnownType(typeof(AccountStatusUpdateInstructionReason2Choice.Code))]
    [KnownType(typeof(AccountStatusUpdateInstructionReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AccountStatusUpdateInstructionReason2Choice.Code),
        nameof(AccountStatusUpdateInstructionReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AccountStatusUpdateInstructionReason2Choice.Proprietary),
        nameof(AccountStatusUpdateInstructionReason2Choice.Proprietary)
    )]
    [IsoId("_0Y8Z4Xi8EeaRm5xIK6nGuQ")]
    [DisplayName("Account Status Update Instruction Reason 2 Choice")]
    public abstract record AccountStatusUpdateInstructionReason2Choice_ { }
}
