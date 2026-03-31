// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of other amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mutCoK53Eee6Q7mFsDuJBA")]
[Description(@"Type of other amount.")]
[Derivations(typeof(OtherAmountType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OtherAmountTypeCode>))]
#endif
public enum OtherAmountTypeCode
{
    /// <summary>
    /// Interest on the interest.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_r-7mIK53Eee6Q7mFsDuJBA")]
    [Description(@"Interest on the interest.")]
    SettlementInterest,

    /// <summary>
    /// Interest that was pre-paid.
    /// Encoded/decoded by serializers as &quot;PINT&quot;.
    /// </summary>
    [EnumMember(Value = "PINT")]
    [IsoId("_sD17UK53Eee6Q7mFsDuJBA")]
    [Description(@"Interest that was pre-paid.")]
    PrepaidInterest,
}
