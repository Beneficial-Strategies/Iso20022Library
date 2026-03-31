// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies unrealised parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m50OY_NBEeCuA5Tr22BnwA_1824968417")]
[Description(@"Specifies unrealised parameter.")]
[Derivations(typeof(Unrealised1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnrealisedCode>))]
#endif
public enum UnrealisedCode
{
    /// <summary>
    /// Unrealised gain.
    /// Encoded/decoded by serializers as &quot;GAIN&quot;.
    /// </summary>
    [EnumMember(Value = "GAIN")]
    [IsoId("_m50OZPNBEeCuA5Tr22BnwA_667402002")]
    [Description(@"Unrealised gain.")]
    Gain,

    /// <summary>
    /// Unrealised loss.
    /// Encoded/decoded by serializers as &quot;LOSS&quot;.
    /// </summary>
    [EnumMember(Value = "LOSS")]
    [IsoId("_m50OZfNBEeCuA5Tr22BnwA_-1644430516")]
    [Description(@"Unrealised loss.")]
    Loss,
}
