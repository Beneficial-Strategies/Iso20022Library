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
[IsoId("_ajpi8dp-Ed-ak6NoX_4Aeg_1482517785")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventFrequency3Code>))]
#endif
public enum EventFrequency3Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_ajpi8tp-Ed-ak6NoX_4Aeg_1482517787")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = EventFrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ajpi89p-Ed-ak6NoX_4Aeg_1482517810")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = EventFrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_ajpi9Np-Ed-ak6NoX_4Aeg_1482517811")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = EventFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_ajpi9dp-Ed-ak6NoX_4Aeg_1482517827")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = EventFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_ajzT8Np-Ed-ak6NoX_4Aeg_1482517828")]
    [Description(@"Event takes place once a week.")]
    Weekly = EventFrequencyCode.Weekly, // same ordinal as derivation source for type conversions
}
