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
[IsoId("_KLWOcDwxEeaFzejt0Yw_3A")]
[Description(@"Specifies the redemption status of the redemption order.")]
[DerivedFrom(typeof(RedemptionCompletionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RedemptionCompletion1Code>))]
#endif
public enum RedemptionCompletion1Code
{
    /// <summary>
    /// It is not necessary to send more redemption order instructions to the executing party to complete the redemption, the executing will generate redemption confirmations automatically.
    /// Encoded/decoded by serializers as &quot;RED0&quot;.
    /// </summary>
    [EnumMember(Value = "RED0")]
    [IsoId("_MMME0TwxEeaFzejt0Yw_3A")]
    [Description(
        @"It is not necessary to send more redemption order instructions to the executing party to complete the redemption, the executing will generate redemption confirmations automatically."
    )]
    RedemptionNo = RedemptionCompletionCode.RedemptionNo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional redemption order instructions must be sent to the executing party order to have the rest of the redemption executed.
    /// Encoded/decoded by serializers as &quot;RED1&quot;.
    /// </summary>
    [EnumMember(Value = "RED1")]
    [IsoId("_MWTqITwxEeaFzejt0Yw_3A")]
    [Description(
        @"Additional redemption order instructions must be sent to the executing party order to have the rest of the redemption executed."
    )]
    RedemptionYes = RedemptionCompletionCode.RedemptionYes, // same ordinal as derivation source for type conversions
}
