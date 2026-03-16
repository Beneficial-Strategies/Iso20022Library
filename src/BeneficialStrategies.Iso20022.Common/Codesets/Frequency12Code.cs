// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FLwRoOkXEemeDPHh-U9b6w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency12Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_Ll31YekXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_L6HAAukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;FRTN&quot;.
    /// </summary>
    [EnumMember(Value = "FRTN")]
    [IsoId("_Mky7wukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every two weeks.")]
    Fortnightly = FrequencyCode.Fortnightly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_M1KTAukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_NUZzwukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_NrAV4ukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_OCN8AukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place every ten business days.")]
    TenDays = FrequencyCode.TenDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_OV_zoukXEemeDPHh-U9b6w")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions
}
