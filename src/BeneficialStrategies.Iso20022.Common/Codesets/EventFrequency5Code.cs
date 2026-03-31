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
[IsoId("_ajzT-Np-Ed-ak6NoX_4Aeg_-1261201154")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventFrequency5Code>))]
#endif
public enum EventFrequency5Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_aj9E8Np-Ed-ak6NoX_4Aeg_-1198401173")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = EventFrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_aj9E8dp-Ed-ak6NoX_4Aeg_-1187318899")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = EventFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_aj9E8tp-Ed-ak6NoX_4Aeg_-1174391500")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = EventFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_aj9E89p-Ed-ak6NoX_4Aeg_-1155920594")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = EventFrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_aj9E9Np-Ed-ak6NoX_4Aeg_-1144837819")]
    [Description(@"Event takes place once a week.")]
    Weekly = EventFrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_aj9E9dp-Ed-ak6NoX_4Aeg_-1141143334")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event cannot take place, because, for example, the fund is closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_aj9E9tp-Ed-ak6NoX_4Aeg_-1130984419")]
    [Description(@"Event cannot take place, because, for example, the fund is closed.")]
    Closed = EventFrequencyCode.Closed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two months.
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_aj9E99p-Ed-ak6NoX_4Aeg_-1128214132")]
    [Description(@"Event takes place every two months.")]
    EveryTwoMonths = EventFrequencyCode.EveryTwoMonths, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;TOWK&quot;.
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_aj9E-Np-Ed-ak6NoX_4Aeg_-1087578540")]
    [Description(@"Event takes place every two weeks.")]
    EveryTwoWeeks = EventFrequencyCode.EveryTwoWeeks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place two times a month.
    /// Encoded/decoded by serializers as &quot;TWMN&quot;.
    /// </summary>
    [EnumMember(Value = "TWMN")]
    [IsoId("_akGO4Np-Ed-ak6NoX_4Aeg_-828995232")]
    [Description(@"Event takes place two times a month.")]
    TwiceAMonth = EventFrequencyCode.TwiceAMonth, // same ordinal as derivation source for type conversions
}
