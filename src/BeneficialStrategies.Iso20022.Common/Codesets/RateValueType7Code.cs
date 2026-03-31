// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jWIcIeGYEd-1Ktb5rVaajw")]
[Description(@"Specifies the value of a rate.")]
[DerivedFrom(typeof(RateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RateValueType7Code>))]
#endif
public enum RateValueType7Code
{
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5kOI2tdEeCY4-KZ9JEyUQ_-1063133934")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
