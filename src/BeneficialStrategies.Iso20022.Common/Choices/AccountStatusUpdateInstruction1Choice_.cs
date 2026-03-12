// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an account status update instruction.
    /// </summary>
    [KnownType(typeof(AccountStatusUpdateInstruction1Choice.Code))]
    [KnownType(typeof(AccountStatusUpdateInstruction1Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountStatusUpdateInstruction1Choice.Code),nameof(AccountStatusUpdateInstruction1Choice.Code))]
    [JsonDerivedType(typeof(AccountStatusUpdateInstruction1Choice.Proprietary),nameof(AccountStatusUpdateInstruction1Choice.Proprietary))]
    [IsoId("_rZMYAHi5EeaRm5xIK6nGuQ")]
    [DisplayName("Account Status Update Instruction 1 Choice")]
    public abstract partial record AccountStatusUpdateInstruction1Choice_
    {
    }
}
