// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the interest request is rejected due a value date or an interest amount difference.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbKMdNp-Ed-ak6NoX_4Aeg_-1204468675")]
[Description(
    @"Indicates whether the interest request is rejected due a value date or an interest amount difference."
)]
[Derivations(typeof(InterestRejectionReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InterestRejectionReasonCode>))]
#endif
public enum InterestRejectionReasonCode
{
    /// <summary>
    /// Indicates whether the interest request is rejected due a value date difference.
    /// Encoded/decoded by serializers as &quot;VADA&quot;.
    /// </summary>
    [EnumMember(Value = "VADA")]
    [IsoId("_YbKMddp-Ed-ak6NoX_4Aeg_1161500013")]
    [Description(
        @"Indicates whether the interest request is rejected due a value date difference."
    )]
    ValueDate,

    /// <summary>
    /// Indicates whether the interest request is rejected due an interest amount difference.
    /// Encoded/decoded by serializers as &quot;DIAM&quot;.
    /// </summary>
    [EnumMember(Value = "DIAM")]
    [IsoId("_YbKMdtp-Ed-ak6NoX_4Aeg_1346924017")]
    [Description(
        @"Indicates whether the interest request is rejected due an interest amount difference."
    )]
    DisputeAmount,
}
