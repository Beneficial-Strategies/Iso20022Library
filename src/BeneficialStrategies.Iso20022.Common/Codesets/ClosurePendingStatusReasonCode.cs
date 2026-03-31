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
[IsoId("_HkvJcGCMEeabZtzjEVWYCQ")]
[Description(@"Specifies the reason for the closure pending status.")]
[Derivations(typeof(ClosurePendingStatusReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ClosurePendingStatusReasonCode>))]
#endif
public enum ClosurePendingStatusReasonCode
{
    /// <summary>
    /// Account will be closed when conditions are met.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_OTSsIGCMEeabZtzjEVWYCQ")]
    [Description(@"Account will be closed when conditions are met.")]
    PendingConditions,

    /// <summary>
    /// Account closing is in process.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_SQzDgGCMEeabZtzjEVWYCQ")]
    [Description(@"Account closing is in process.")]
    AccountClosingInProcess,
}
