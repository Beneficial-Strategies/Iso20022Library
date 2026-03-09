// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_akGO4dp-Ed-ak6NoX_4Aeg_1216168726")]
[Description(@"Specifies the regularity of an event.")]
[Derivations(typeof(EventFrequency9Code),typeof(EventFrequency8Code),typeof(EventFrequency7Code),typeof(EventFrequency1Code),typeof(EventFrequency5Code),typeof(EventFrequency10Code),typeof(EventFrequency4Code),typeof(EventFrequency6Code),typeof(EventFrequency2Code),typeof(EventFrequency12Code),typeof(EventFrequency3Code))]
public enum EventFrequencyCode
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_akGO4tp-Ed-ak6NoX_4Aeg_1616054653")]
    [Description(@"Event takes place every year or once a year.")]
    Annual,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_akGO49p-Ed-ak6NoX_4Aeg_1616054748")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_akP_4Np-Ed-ak6NoX_4Aeg_1616054713")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
    /// <summary>
    /// Event takes place every two months.
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_akP_4dp-Ed-ak6NoX_4Aeg_-408295373")]
    [Description(@"Event takes place every two months.")]
    EveryTwoMonths,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_akP_4tp-Ed-ak6NoX_4Aeg_1616054695")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place two times a month.
    /// Encoded/decoded by serializers as &quot;TWMN&quot;.
    /// </summary>
    [EnumMember(Value = "TWMN")]
    [IsoId("_akP_49p-Ed-ak6NoX_4Aeg_-524659604")]
    [Description(@"Event takes place two times a month.")]
    TwiceAMonth,
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;TOWK&quot;.
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_akP_5Np-Ed-ak6NoX_4Aeg_-468324283")]
    [Description(@"Event takes place every two weeks.")]
    EveryTwoWeeks,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_akP_5dp-Ed-ak6NoX_4Aeg_1616054773")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_akP_5tp-Ed-ak6NoX_4Aeg_1616055081")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_akP_59p-Ed-ak6NoX_4Aeg_1616055117")]
    [Description(@"Event takes place several times a day.")]
    IntraDay,
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_akP_6Np-Ed-ak6NoX_4Aeg_1616055152")]
    [Description(@"Event takes place overnight.")]
    Overnight,
    
    /// <summary>
    /// Event takes place as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_akP_6dp-Ed-ak6NoX_4Aeg_1616055116")]
    [Description(@"Event takes place as necessary.")]
    Adhoc,
    
    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ONDE&quot;.
    /// </summary>
    [EnumMember(Value = "ONDE")]
    [IsoId("_akZw4Np-Ed-ak6NoX_4Aeg_1729647252")]
    [Description(@"Event takes place on demand.")]
    OnDemand,
    
    /// <summary>
    /// Event cannot take place, because, for example, the fund is closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_akZw4dp-Ed-ak6NoX_4Aeg_-959050215")]
    [Description(@"Event cannot take place, because, for example, the fund is closed.")]
    Closed,
    
    /// <summary>
    /// Event takes place every four months or three times a year.
    /// Encoded/decoded by serializers as &quot;FOMN&quot;.
    /// </summary>
    [EnumMember(Value = "FOMN")]
    [IsoId("_I3_rIBUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every four months or three times a year.")]
    EveryFourMonths,
    
    /// <summary>
    /// Event takes place every two years.
    /// Encoded/decoded by serializers as &quot;TYEA&quot;.
    /// </summary>
    [EnumMember(Value = "TYEA")]
    [IsoId("_UTZ-gBUREeOIaq8KyCdIDQ")]
    [Description(@"Event takes place every two years.")]
    EveryTwoYears,
    
    /// <summary>
    /// Event does not take place.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_dhDyoCDAEeWPMvNwVtiMsA")]
    [Description(@"Event does not take place.")]
    None,
    
    /// <summary>
    /// Unspecified frequency of event.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_NyR1YCPAEemWJojmIXiyUw")]
    [Description(@"Unspecified frequency of event.")]
    Other,
    
}
