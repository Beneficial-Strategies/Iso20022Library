// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the frequency of an interest payment with a time unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xvGg0c2FEeq8rujJR5QTKA")]
[Description(@"Specifies the frequency of an interest payment with a time unit.")]
[DerivedFrom(typeof(FrequencyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Frequency14Code>))]
#endif
public enum Frequency14Code
{
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_xwMF8c2FEeq8rujJR5QTKA")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_xwMF-c2FEeq8rujJR5QTKA")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_xwMGB82FEeq8rujJR5QTKA")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_xwMGI82FEeq8rujJR5QTKA")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc = FrequencyCode.Adhoc, // same ordinal as derivation source for type conversions
}
