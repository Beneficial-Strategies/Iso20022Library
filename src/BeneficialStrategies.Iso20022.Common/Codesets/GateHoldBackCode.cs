// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of hold back on redemption proceeds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ygvPwDwvEeaFzejt0Yw_3A")]
[Description(@"Specifies the type of hold back on redemption proceeds.")]
[Derivations(typeof(GateHoldBack1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GateHoldBackCode>))]
#endif
public enum GateHoldBackCode
{
    /// <summary>
    /// Hold back of redemption proceeds.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_AmK5YDwwEeaFzejt0Yw_3A")]
    [Description(@"Hold back of redemption proceeds.")]
    HoldBack,

    /// <summary>
    /// Gating of redemption proceeds.
    /// Encoded/decoded by serializers as &quot;GATE&quot;.
    /// </summary>
    [EnumMember(Value = "GATE")]
    [IsoId("_F7KoIDwwEeaFzejt0Yw_3A")]
    [Description(@"Gating of redemption proceeds.")]
    Gating,
}
