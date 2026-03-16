// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ar_mp9p-Ed-ak6NoX_4Aeg_1946817553")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency1Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_asJXoNp-Ed-ak6NoX_4Aeg_-1659048040")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_asJXodp-Ed-ak6NoX_4Aeg_-1659048023")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_asJXotp-Ed-ak6NoX_4Aeg_-1659047763")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_asJXo9p-Ed-ak6NoX_4Aeg_-1659047728")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_asJXpNp-Ed-ak6NoX_4Aeg_-1659047711")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_asJXpdp-Ed-ak6NoX_4Aeg_-1659047650")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_asJXptp-Ed-ak6NoX_4Aeg_-1659047632")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc = FrequencyCode.Adhoc, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_asJXp9p-Ed-ak6NoX_4Aeg_-1659047324")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = FrequencyCode.IntraDay, // same ordinal as derivation source for type conversions
}
