// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fppBkclPEeuJ35KoBRZFOg")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency17Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_fusgsclPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_futHx8lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;FRTN&quot;.
    /// </summary>
    [EnumMember(Value = "FRTN")]
    [IsoId("_futHz8lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every two weeks.")]
    Fortnightly = FrequencyCode.Fortnightly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_futH0clPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_futH38lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_futH7clPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_futH9clPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place every ten business days.")]
    TenDays = FrequencyCode.TenDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_futH98lPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_pdb24MlPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc = FrequencyCode.Adhoc, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event associated with a shift.
    /// Encoded/decoded by serializers as &quot;SHFT&quot;.
    /// </summary>
    [EnumMember(Value = "SHFT")]
    [IsoId("_1TaJ4clQEeuJ35KoBRZFOg")]
    [Description(@"Event associated with a shift.")]
    Shift = FrequencyCode.Shift, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ODMD&quot;.
    /// </summary>
    [EnumMember(Value = "ODMD")]
    [IsoId("_1uI-EclQEeuJ35KoBRZFOg")]
    [Description(@"Event takes place on demand.")]
    OnDemand = FrequencyCode.OnDemand, // same ordinal as derivation source for type conversions
}
