// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1UEkQMhvEeadgvwNGwK05w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency11Code
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_3AYVEchvEeadgvwNGwK05w")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = FrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_3I1GcchvEeadgvwNGwK05w")]
    [Description(@"Event takes place every day.")]
    Daily = FrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_36qzEchvEeadgvwNGwK05w")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = FrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event occurs on expiry of a financial contract.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_42kaochvEeadgvwNGwK05w")]
    [Description(@"Event occurs on expiry of a financial contract.")]
    OnExpiry = FrequencyCode.OnExpiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_5PZxYchvEeadgvwNGwK05w")]
    [Description(@"Event takes place overnight.")]
    Overnight = FrequencyCode.Overnight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_5WEaEchvEeadgvwNGwK05w")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = FrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_5y8jUchvEeadgvwNGwK05w")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = FrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event that takes place at the initiation of a trade or agreement.
    /// Encoded/decoded by serializers as &quot;UPFR&quot;.
    /// </summary>
    [EnumMember(Value = "UPFR")]
    [IsoId("_6EIZ8chvEeadgvwNGwK05w")]
    [Description(@"Event that takes place at the initiation of a trade or agreement.")]
    Upfront = FrequencyCode.Upfront, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_6Nd8IchvEeadgvwNGwK05w")]
    [Description(@"Event takes place once a week.")]
    Weekly = FrequencyCode.Weekly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event occurs due to a credit event occurring for an issuer.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_6uQ8EchvEeadgvwNGwK05w")]
    [Description(@"Event occurs due to a credit event occurring for an issuer.")]
    OnCreditEvent = FrequencyCode.OnCreditEvent, // same ordinal as derivation source for type conversions
    
}
