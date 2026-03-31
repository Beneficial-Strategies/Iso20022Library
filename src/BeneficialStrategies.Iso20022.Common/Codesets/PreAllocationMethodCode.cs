// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the method of preallocation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aH73WNp-Ed-ak6NoX_4Aeg_616932935")]
[Description(@"Indicates the method of preallocation.")]
[Derivations(typeof(PreAllocationMethod1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PreAllocationMethodCode>))]
#endif
public enum PreAllocationMethodCode
{
    /// <summary>
    /// Preallocation is proratised.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_aIFoUNp-Ed-ak6NoX_4Aeg_643714948")]
    [Description(@"Preallocation is proratised.")]
    Prorata,

    /// <summary>
    /// No prorata, discuss first.
    /// Encoded/decoded by serializers as &quot;TALK&quot;.
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_aIFoUdp-Ed-ak6NoX_4Aeg_1099009423")]
    [Description(@"No prorata, discuss first.")]
    SpeakFirst,
}
