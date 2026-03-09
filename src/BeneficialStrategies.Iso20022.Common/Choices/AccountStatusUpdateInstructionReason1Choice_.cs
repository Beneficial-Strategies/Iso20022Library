// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a reason for an instruction to change the status of an account.
    /// </summary>
    [KnownType(typeof(AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(AccountStatusUpdateInstructionReason1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason),nameof(AccountStatusUpdateInstructionReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AccountStatusUpdateInstructionReason1Choice.Reason),nameof(AccountStatusUpdateInstructionReason1Choice.Reason))]
    #endif
    [IsoId("_MizyUXi8EeaRm5xIK6nGuQ")]
    [DisplayName("Account Status Update Instruction Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountStatusUpdateInstructionReason1Choice_
    #else
    public abstract partial class AccountStatusUpdateInstructionReason1Choice_
    #endif
    {
    }
}
