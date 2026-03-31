// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the status of the confirmation acknowledgement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wZYWYESsEeSTS-T7FO4CUQ")]
[Description(@"Identifies the status of the confirmation acknowledgement.")]
[Derivations(typeof(AffirmStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AffirmStatusCode>))]
#endif
public enum AffirmStatusCode
{
    /// <summary>
    /// Data was successfully matched.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_HDYCEEStEeSTS-T7FO4CUQ")]
    [Description(@"Data was successfully matched.")]
    Compared,

    /// <summary>
    /// Format of upload data was right, and system receives successfully.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_JjXSkEStEeSTS-T7FO4CUQ")]
    [Description(@"Format of upload data was right, and system receives successfully.")]
    Received,

    /// <summary>
    /// Data was mismatched.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_MD9nEEStEeSTS-T7FO4CUQ")]
    [Description(@"Data was mismatched.")]
    MisMatched,

    /// <summary>
    /// Query time was over system service time.
    /// Encoded/decoded by serializers as &quot;OUOS&quot;.
    /// </summary>
    [EnumMember(Value = "OUOS")]
    [IsoId("_O4ngAEStEeSTS-T7FO4CUQ")]
    [Description(@"Query time was over system service time.")]
    OutOfService,

    /// <summary>
    /// Query time was out of range.
    /// Encoded/decoded by serializers as &quot;OUOR&quot;.
    /// </summary>
    [EnumMember(Value = "OUOR")]
    [IsoId("_RA4NAEStEeSTS-T7FO4CUQ")]
    [Description(@"Query time was out of range.")]
    OutOfRange,

    /// <summary>
    /// Notfies that the trade confimation was conpleted.
    /// Encoded/decoded by serializers as &quot;ATCN&quot;.
    /// </summary>
    [EnumMember(Value = "ATCN")]
    [IsoId("_UB5uAEStEeSTS-T7FO4CUQ")]
    [Description(@"Notfies that the trade confimation was conpleted.")]
    AckToConfirmCompleteNotification,

    /// <summary>
    /// Format of upload data was wrong, and system receives unsuccessfully.
    /// Encoded/decoded by serializers as &quot;UNRE&quot;.
    /// </summary>
    [EnumMember(Value = "UNRE")]
    [IsoId("_XgxBkEStEeSTS-T7FO4CUQ")]
    [Description(@"Format of upload data was wrong, and system receives unsuccessfully.")]
    Unreceived,

    /// <summary>
    /// Model has errors.
    /// Encoded/decoded by serializers as &quot;MISE&quot;.
    /// </summary>
    [EnumMember(Value = "MISE")]
    [IsoId("_Y7ViIEStEeSTS-T7FO4CUQ")]
    [Description(@"Model has errors.")]
    ModeError,

    /// <summary>
    /// Notfies the clearing status changed.
    /// Encoded/decoded by serializers as &quot;ATSC&quot;.
    /// </summary>
    [EnumMember(Value = "ATSC")]
    [IsoId("_bC0MAEStEeSTS-T7FO4CUQ")]
    [Description(@"Notfies the clearing status changed.")]
    AckToSettlementStateChanged,

    /// <summary>
    /// Have no trading permissions.
    /// Encoded/decoded by serializers as &quot;NOTP&quot;.
    /// </summary>
    [EnumMember(Value = "NOTP")]
    [IsoId("_duHUoEStEeSTS-T7FO4CUQ")]
    [Description(@"Have no trading permissions.")]
    NoTradingPrivilege,
}
