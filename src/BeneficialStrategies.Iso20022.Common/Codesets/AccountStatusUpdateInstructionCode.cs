// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account status update instructed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-lU1sHi5EeaRm5xIK6nGuQ")]
[Description(@"Specifies the type of account status update instructed.")]
[Derivations(typeof(AccountStatusUpdateInstruction1Code))]
public enum AccountStatusUpdateInstructionCode
{
    /// <summary>
    /// Account is to be reactivated, any previous instruction to close the account is rescinded.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_IYG-YHi6EeaRm5xIK6nGuQ")]
    [Description(@"Account is to be reactivated, any previous instruction to close the account is rescinded.")]
    Reactive,
    
    /// <summary>
    /// Account is to be closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_Lh2WgHi6EeaRm5xIK6nGuQ")]
    [Description(@"Account is to be closed.")]
    Close,
    
}
