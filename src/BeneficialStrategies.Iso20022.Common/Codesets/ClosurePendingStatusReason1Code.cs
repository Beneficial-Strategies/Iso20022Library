// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the closure pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eduTYGCMEeabZtzjEVWYCQ")]
[Description(@"Specifies the reason for the closure pending status.")]
[DerivedFrom(typeof(ClosurePendingStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClosurePendingStatusReason1Code>))]
#endif
public enum ClosurePendingStatusReason1Code
{
    /// <summary>
    /// Account closing is in process.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_gh-qIWCMEeabZtzjEVWYCQ")]
    [Description(@"Account closing is in process.")]
    AccountClosingInProcess = ClosurePendingStatusReasonCode.AccountClosingInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account will be closed when conditions are met.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_grWokWCMEeabZtzjEVWYCQ")]
    [Description(@"Account will be closed when conditions are met.")]
    PendingConditions = ClosurePendingStatusReasonCode.PendingConditions, // same ordinal as derivation source for type conversions
}
