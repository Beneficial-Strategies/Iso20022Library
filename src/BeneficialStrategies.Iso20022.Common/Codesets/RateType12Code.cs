// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZJesNp-Ed-ak6NoX_4Aeg_-1551942195")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RateType12Code>))]
#endif
public enum RateType12Code
{
    /// <summary>
    /// Rate has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ZZJesdp-Ed-ak6NoX_4Aeg_-1551942185")]
    [Description(@"Rate has not been established.")]
    Open = RateTypeCode.Open, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZZJestp-Ed-ak6NoX_4Aeg_-1551942164")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate will not be paid.
    /// Encoded/decoded by serializers as &quot;NILP&quot;.
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_ZZJes9p-Ed-ak6NoX_4Aeg_-1551942163")]
    [Description(@"Rate will not be paid.")]
    NilPayment = RateTypeCode.NilPayment, // same ordinal as derivation source for type conversions
}
