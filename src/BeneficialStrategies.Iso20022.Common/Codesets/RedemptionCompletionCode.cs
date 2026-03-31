// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the redemption status of the redemption order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yPkKwDwwEeaFzejt0Yw_3A")]
[Description(@"Specifies the redemption status of the redemption order.")]
[Derivations(typeof(RedemptionCompletion1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RedemptionCompletionCode>))]
#endif
public enum RedemptionCompletionCode
{
    /// <summary>
    /// Additional redemption order instructions must be sent to the executing party order to have the rest of the redemption executed.
    /// Encoded/decoded by serializers as &quot;RED1&quot;.
    /// </summary>
    [EnumMember(Value = "RED1")]
    [IsoId("_41Ma8DwwEeaFzejt0Yw_3A")]
    [Description(
        @"Additional redemption order instructions must be sent to the executing party order to have the rest of the redemption executed."
    )]
    RedemptionYes,

    /// <summary>
    /// It is not necessary to send more redemption order instructions to the executing party to complete the redemption, the executing will generate redemption confirmations automatically.
    /// Encoded/decoded by serializers as &quot;RED0&quot;.
    /// </summary>
    [EnumMember(Value = "RED0")]
    [IsoId("_76Bd4DwwEeaFzejt0Yw_3A")]
    [Description(
        @"It is not necessary to send more redemption order instructions to the executing party to complete the redemption, the executing will generate redemption confirmations automatically."
    )]
    RedemptionNo,
}
