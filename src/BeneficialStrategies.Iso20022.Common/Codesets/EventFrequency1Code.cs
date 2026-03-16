// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajNeF9p-Ed-ak6NoX_4Aeg_899403009")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
public enum EventFrequency1Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_ajWoANp-Ed-ak6NoX_4Aeg_959431341")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = EventFrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_ajWoAdp-Ed-ak6NoX_4Aeg_960353363")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = EventFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_ajWoAtp-Ed-ak6NoX_4Aeg_960353346")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = EventFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two months.
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_ajWoA9p-Ed-ak6NoX_4Aeg_152343910")]
    [Description(@"Event takes place every two months.")]
    EveryTwoMonths = EventFrequencyCode.EveryTwoMonths, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ajWoBNp-Ed-ak6NoX_4Aeg_960353268")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = EventFrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place two times a month.
    /// Encoded/decoded by serializers as &quot;TWMN&quot;.
    /// </summary>
    [EnumMember(Value = "TWMN")]
    [IsoId("_ajWoBdp-Ed-ak6NoX_4Aeg_420164021")]
    [Description(@"Event takes place two times a month.")]
    TwiceAMonth = EventFrequencyCode.TwiceAMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;TOWK&quot;.
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_ajWoBtp-Ed-ak6NoX_4Aeg_459876051")]
    [Description(@"Event takes place every two weeks.")]
    EveryTwoWeeks = EventFrequencyCode.EveryTwoWeeks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_ajWoB9p-Ed-ak6NoX_4Aeg_960353364")]
    [Description(@"Event takes place once a week.")]
    Weekly = EventFrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_ajWoCNp-Ed-ak6NoX_4Aeg_960353381")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_ajWoCdp-Ed-ak6NoX_4Aeg_960353466")]
    [Description(@"Event takes place as necessary.")]
    Adhoc = EventFrequencyCode.Adhoc, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_ajWoCtp-Ed-ak6NoX_4Aeg_960353813")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = EventFrequencyCode.IntraDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_ajgZANp-Ed-ak6NoX_4Aeg_960353873")]
    [Description(@"Event takes place overnight.")]
    Overnight = EventFrequencyCode.Overnight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ONDE&quot;.
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_ajgZAdp-Ed-ak6NoX_4Aeg_977902077")]
    [Description(@"Event takes place on demand.")]
    OnDemand = EventFrequencyCode.OnDemand, // same ordinal as derivation source for type conversions
}
