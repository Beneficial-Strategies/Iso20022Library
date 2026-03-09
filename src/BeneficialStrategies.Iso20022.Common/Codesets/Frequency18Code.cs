// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0vb7cR1VEey8XKHwKquEQw")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency18Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_01vXwR1VEey8XKHwKquEQw")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_01vXzx1VEey8XKHwKquEQw")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;FRTN&quot;.
    /// </summary>
    [EnumMember(Value = "FRTN")]
    [IsoId("_01v-0R1VEey8XKHwKquEQw")]
    [Description(@"Event takes place every two weeks.")]
    Fortnightly = FrequencyCode.Fortnightly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_01v-0x1VEey8XKHwKquEQw")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_01v-4R1VEey8XKHwKquEQw")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_01v-7x1VEey8XKHwKquEQw")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_01v-9x1VEey8XKHwKquEQw")]
    [Description(@"Event takes place every ten business days.")]
    TenDays = FrequencyCode.TenDays, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_01v--R1VEey8XKHwKquEQw")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Two times a week
    /// Encoded/decoded by serializers as &quot;TWWK&quot;.
    /// </summary>
    [EnumMember(Value = "TWWK")]
    [IsoId("_Dk4swR1WEey8XKHwKquEQw")]
    [Description(@"Two times a week")]
    TwiceAWeek = FrequencyCode.TwiceAWeek, // same ordinal as derivation source for type conversions
    
}
