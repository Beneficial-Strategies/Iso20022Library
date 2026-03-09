// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nYW2IBUREeOIaq8KyCdIDQ")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(EventFrequencyCode))]
public enum EventFrequency8Code
{
    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_p8wskRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place as necessary.")]
    Adhoc = EventFrequencyCode.Adhoc, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_qEpdQRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every year or once a year.")]
    Annual = EventFrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_qSx_4RUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every day.")]
    Daily = EventFrequencyCode.Daily, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every four months or three times a year.
    /// Encoded/decoded by serializers as &quot;FOMN&quot;.
    /// </summary>
    [EnumMember(Value = "FOMN")]
    [IsoId("_qaE6sRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every four months or three times a year.")]
    EveryFourMonths = EventFrequencyCode.EveryFourMonths, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every two months.
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_qh9rYRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every two months.")]
    EveryTwoMonths = EventFrequencyCode.EveryTwoMonths, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;TOWK&quot;.
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_qrxusRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every two weeks.")]
    EveryTwoWeeks = EventFrequencyCode.EveryTwoWeeks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every two years.
    /// Encoded/decoded by serializers as &quot;TYEA&quot;.
    /// </summary>
    [EnumMember(Value = "TYEA")]
    [IsoId("_q1mZERUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every two years.")]
    EveryTwoYears = EventFrequencyCode.EveryTwoYears, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_rBp4ERUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place several times a day.")]
    IntraDay = EventFrequencyCode.IntraDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_rJY3wRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly = EventFrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ONDE&quot;.
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_rSw2MRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place on demand.")]
    OnDemand = EventFrequencyCode.OnDemand, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_rZTjERUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place overnight.")]
    Overnight = EventFrequencyCode.Overnight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_rhyJoRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly = EventFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_rpOOYRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual = EventFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place two times a month.
    /// Encoded/decoded by serializers as &quot;TWMN&quot;.
    /// </summary>
    [EnumMember(Value = "TWMN")]
    [IsoId("_rwOOQRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place two times a month.")]
    TwiceAMonth = EventFrequencyCode.TwiceAMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_r2nxMRUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place once a week.")]
    Weekly = EventFrequencyCode.Weekly, // same ordinal as derivation source for type conversions
    
}
