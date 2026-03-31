// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jsRFAyjnEeK1Sbo8NpBROA")]
[Description(
    @"Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated."
)]
[Derivations(typeof(AllocationIndicator1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AllocationIndicatorCode>))]
#endif
public enum AllocationIndicatorCode
{
    /// <summary>
    /// Trade is a post-allocation trade.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_wb0g0CjnEeK1Sbo8NpBROA")]
    [Description(@"Trade is a post-allocation trade.")]
    Post_allocation,

    /// <summary>
    /// Trade is a pre-allocation trade.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_EewDoCjoEeK1Sbo8NpBROA")]
    [Description(@"Trade is a pre-allocation trade.")]
    Pre_allocation,

    /// <summary>
    /// Trade is unallocated.
    /// Encoded/decoded by serializers as &quot;UNAL&quot;.
    /// </summary>
    [EnumMember(Value = "UNAL")]
    [IsoId("_Fl21oCjoEeK1Sbo8NpBROA")]
    [Description(@"Trade is unallocated.")]
    Unallocated,
}
