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
[IsoId("_kNl8ESDAEeWPMvNwVtiMsA")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventFrequency9Code>))]
#endif
public enum EventFrequency9Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_kqAyUSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = EventFrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_kqAyUyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = EventFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_kqAyVSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = EventFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two months.
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_kqAyVyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every two months.")]
    EveryTwoMonths = EventFrequencyCode.EveryTwoMonths, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_kqAyWSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = EventFrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place two times a month.
    /// Encoded/decoded by serializers as &quot;TWMN&quot;.
    /// </summary>
    [EnumMember(Value = "TWMN")]
    [IsoId("_kqAyWyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place two times a month.")]
    TwiceAMonth = EventFrequencyCode.TwiceAMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;TOWK&quot;.
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_kqAyXSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every two weeks.")]
    EveryTwoWeeks = EventFrequencyCode.EveryTwoWeeks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_kqAyXyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place once a week.")]
    Weekly = EventFrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_kqAyYSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_kqAyYyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place as necessary.")]
    Adhoc = EventFrequencyCode.Adhoc, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_kqAyZSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = EventFrequencyCode.IntraDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_kqAyZyDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place overnight.")]
    Overnight = EventFrequencyCode.Overnight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ONDE&quot;.
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_kqAyaSDAEeWPMvNwVtiMsA")]
    [Description(@"Event takes place on demand.")]
    OnDemand = EventFrequencyCode.OnDemand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event does not take place.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_mJOiUSDAEeWPMvNwVtiMsA")]
    [Description(@"Event does not take place.")]
    None = EventFrequencyCode.None, // same ordinal as derivation source for type conversions
}
