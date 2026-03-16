// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ajgZAtp-Ed-ak6NoX_4Aeg_-443553362")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
public enum EventFrequency2Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_ajgZA9p-Ed-ak6NoX_4Aeg_-443553352")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = EventFrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_ajgZBNp-Ed-ak6NoX_4Aeg_-443553332")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = EventFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_ajgZBdp-Ed-ak6NoX_4Aeg_-443553331")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = EventFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ajgZBtp-Ed-ak6NoX_4Aeg_-443553301")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = EventFrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_ajgZB9p-Ed-ak6NoX_4Aeg_-443553270")]
    [Description(@"Event takes place once a week.")]
    Weekly = EventFrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_ajgZCNp-Ed-ak6NoX_4Aeg_-443553269")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event cannot take place, because, for example, the fund is closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_ajpi8Np-Ed-ak6NoX_4Aeg_-339540172")]
    [Description(@"Event cannot take place, because, for example, the fund is closed.")]
    Closed = EventFrequencyCode.Closed, // same ordinal as derivation source for type conversions
}
