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
[IsoId("_ZZmKotp-Ed-ak6NoX_4Aeg_1481923249")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RateType5Code>))]
#endif
public enum RateType5Code
{
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZZmKo9p-Ed-ak6NoX_4Aeg_1553034192")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
