// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account status update instructed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PFBiUHi6EeaRm5xIK6nGuQ")]
[Description(@"Specifies the type of account status update instructed.")]
[DerivedFrom(typeof(AccountStatusUpdateInstructionCode))]
public enum AccountStatusUpdateInstruction1Code
{
    /// <summary>
    /// Account is to be closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_SuwCEXi6EeaRm5xIK6nGuQ")]
    [Description(@"Account is to be closed.")]
    Close = AccountStatusUpdateInstructionCode.Close, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is to be reactivated, any previous instruction to close the account is rescinded.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_S6f_EXi6EeaRm5xIK6nGuQ")]
    [Description(
        @"Account is to be reactivated, any previous instruction to close the account is rescinded."
    )]
    Reactive = AccountStatusUpdateInstructionCode.Reactive, // same ordinal as derivation source for type conversions
}
