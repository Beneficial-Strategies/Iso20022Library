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
[IsoId("_0W9oEK53Eee6Q7mFsDuJBA")]
[Description(@"Type of other amount.")]
[DerivedFrom(typeof(OtherAmountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OtherAmountType1Code>))]
#endif
public enum OtherAmountType1Code
{
    /// <summary>
    /// Interest that was pre-paid.
    /// Encoded/decoded by serializers as &quot;PINT&quot;.
    /// </summary>
    [EnumMember(Value = "PINT")]
    [IsoId("_19nc0a53Eee6Q7mFsDuJBA")]
    [Description(@"Interest that was pre-paid.")]
    PrepaidInterest = OtherAmountTypeCode.PrepaidInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest on the interest.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_2CFGEa53Eee6Q7mFsDuJBA")]
    [Description(@"Interest on the interest.")]
    SettlementInterest = OtherAmountTypeCode.SettlementInterest, // same ordinal as derivation source for type conversions
}
