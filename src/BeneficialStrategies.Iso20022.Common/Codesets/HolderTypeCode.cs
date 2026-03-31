// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of holder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KdDVkE4SEeiQHa-q1Uephw")]
[Description(@"Specifies a type of holder.")]
[Derivations(typeof(HolderType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<HolderTypeCode>))]
#endif
public enum HolderTypeCode
{
    /// <summary>
    /// Holder is the transferee party. The transferee party may also be known as the acquiring party.
    /// Encoded/decoded by serializers as &quot;TFEE&quot;.
    /// </summary>
    [EnumMember(Value = "TFEE")]
    [IsoId("_Ni66UE4SEeiQHa-q1Uephw")]
    [Description(
        @"Holder is the transferee party. The transferee party may also be known as the acquiring party."
    )]
    Transferee,

    /// <summary>
    /// Holder is the transferor party. The transferee party may also be known as the ceding party.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_SpoVcE4SEeiQHa-q1Uephw")]
    [Description(
        @"Holder is the transferor party. The transferee party may also be known as the ceding party."
    )]
    Transferor,
}
