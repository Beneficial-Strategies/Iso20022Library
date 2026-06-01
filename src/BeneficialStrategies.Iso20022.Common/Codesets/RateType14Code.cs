// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Any and all rate is sought.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cIQo4KkHEfCG_LQaXOxwew")]
[Description(@"Any and all rate is sought.")]
[DerivedFrom(typeof(RateTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RateType14Code>))]
public enum RateType14Code
{
    /// <summary>
    /// Rate is at issuer discretion.
    /// Encoded/decoded by serializers as &quot;JLID&quot;.
    /// </summary>
    [EnumMember(Value = "JLID")]
    [IsoId("_h5scAakHEfCG_LQaXOxwew")]
    [Description(@"Rate is at issuer discretion.")]
    IssuerDiscretion = RateTypeCode.IssuerDiscretion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_hqEEkakHEfCG_LQaXOxwew")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
