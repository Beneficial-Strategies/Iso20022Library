// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q5d88A3iEeWc7_0KPiuk6w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Frequency8Code>))]
#endif
public enum Frequency8Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_sPwacQ3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_socnQQ3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_uYoLcQ3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_uz_40Q3iEeWc7_0KPiuk6w")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
}
