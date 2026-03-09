// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_asTIqdp-Ed-ak6NoX_4Aeg_-2101415313")]
[Description(@"Specifies the regularity of an event.")]
[Derivations(typeof(Frequency19Code),typeof(Frequency3Code),typeof(Frequency1Code),typeof(Frequency7Code),typeof(Frequency5Code),typeof(Frequency17Code),typeof(Frequency10Code),typeof(Frequency12Code),typeof(Frequency14Code),typeof(Frequency6Code),typeof(Frequency8Code),typeof(Frequency11Code),typeof(Frequency13Code),typeof(Frequency4Code),typeof(Frequency18Code),typeof(Frequency2Code))]
public enum FrequencyCode
{
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_ascSkNp-Ed-ak6NoX_4Aeg_1955128933")]
    [Description(@"Event takes place every year or once a year.")]
    Annual,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ascSkdp-Ed-ak6NoX_4Aeg_-1999057333")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_ascSktp-Ed-ak6NoX_4Aeg_-1972278110")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_ascSk9p-Ed-ak6NoX_4Aeg_-1941802024")]
    [Description(@"Event takes place every six months or two times a year.")]
    SemiAnnual,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_ascSlNp-Ed-ak6NoX_4Aeg_-1913171921")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_ascSldp-Ed-ak6NoX_4Aeg_-1541103412")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place on request or as necessary.
    /// Encoded/decoded by serializers as &quot;ADHO&quot;.
    /// </summary>
    [EnumMember(Value = "ADHO")]
    [IsoId("_ascSltp-Ed-ak6NoX_4Aeg_18718985")]
    [Description(@"Event takes place on request or as necessary.")]
    Adhoc,
    
    /// <summary>
    /// Event takes place several times a day.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_ascSl9p-Ed-ak6NoX_4Aeg_18718986")]
    [Description(@"Event takes place several times a day.")]
    IntraDay,
    
    /// <summary>
    /// Event takes place overnight.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_ascSmNp-Ed-ak6NoX_4Aeg_1507193436")]
    [Description(@"Event takes place overnight.")]
    Overnight,
    
    /// <summary>
    /// Event takes place every ten business days.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_ascSmdp-Ed-ak6NoX_4Aeg_-2122538311")]
    [Description(@"Event takes place every ten business days.")]
    TenDays,
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;FRTN&quot;.
    /// </summary>
    [EnumMember(Value = "FRTN")]
    [IsoId("_t74UdFkyEeGeoaLUQk__nA_329470843")]
    [Description(@"Event takes place every two weeks.")]
    Fortnightly,
    
    /// <summary>
    /// Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day.
    /// Encoded/decoded by serializers as &quot;MOVE&quot;.
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_24tC4BztEeKjsOi3S79ecQ_349226249")]
    [Description(@"Event takes place at the end of the day if there was a movement on the account, otherwise nothing is sent that day.")]
    TriggeredByMovement,
    
    /// <summary>
    /// Event does never take place.
    /// Encoded/decoded by serializers as &quot;NEVR&quot;.
    /// </summary>
    [EnumMember(Value = "NEVR")]
    [IsoId("_bAnk4GoEEearR-CA7eRZXQ")]
    [Description(@"Event does never take place.")]
    Never,
    
    /// <summary>
    /// Event takes place based on a change of a rate.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_wrYBIGoEEearR-CA7eRZXQ")]
    [Description(@"Event takes place based on a change of a rate.")]
    Rate,
    
    /// <summary>
    /// Event occurs due to a credit event occurring for an issuer.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_pL-KAMhvEeadgvwNGwK05w")]
    [Description(@"Event occurs due to a credit event occurring for an issuer.")]
    OnCreditEvent,
    
    /// <summary>
    /// Event that takes place at the initiation of a trade or agreement.
    /// Encoded/decoded by serializers as &quot;UPFR&quot;.
    /// </summary>
    [EnumMember(Value = "UPFR")]
    [IsoId("_sHTSsMhvEeadgvwNGwK05w")]
    [Description(@"Event that takes place at the initiation of a trade or agreement.")]
    Upfront,
    
    /// <summary>
    /// Event occurs on expiry of a financial contract.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_yICGEMhvEeadgvwNGwK05w")]
    [Description(@"Event occurs on expiry of a financial contract.")]
    OnExpiry,
    
    /// <summary>
    /// Event takes place every hours.
    /// Encoded/decoded by serializers as &quot;HOUL&quot;.
    /// </summary>
    [EnumMember(Value = "HOUL")]
    [IsoId("_--514IcEEeu4rpsqTt37Pg")]
    [Description(@"Event takes place every hours.")]
    Hourly,
    
    /// <summary>
    /// Event takes place every four months or three times a year.
    /// Encoded/decoded by serializers as &quot;TRIL&quot;.
    /// </summary>
    [EnumMember(Value = "TRIL")]
    [IsoId("_MH1EENW3EeyVKLlq2-NhyA")]
    [Description(@"Event takes place every four months or three times a year.")]
    TriAnnual,
    
    /// <summary>
    /// Event takes place every two months or six times a year.
    /// Encoded/decoded by serializers as &quot;BIMN&quot;.
    /// </summary>
    [EnumMember(Value = "BIMN")]
    [IsoId("_MaBAQNW3EeyVKLlq2-NhyA")]
    [Description(@"Event takes place every two months or six times a year.")]
    Bimonthly,
    
    /// <summary>
    /// Event takes place on demand.
    /// Encoded/decoded by serializers as &quot;ODMD&quot;.
    /// </summary>
    [EnumMember(Value = "ODMD")]
    [IsoId("_13-sAMlPEeuJ35KoBRZFOg")]
    [Description(@"Event takes place on demand.")]
    OnDemand,
    
    /// <summary>
    /// Event associated with a shift.
    /// Encoded/decoded by serializers as &quot;SHFT&quot;.
    /// </summary>
    [EnumMember(Value = "SHFT")]
    [IsoId("_PBtwkMlQEeuJ35KoBRZFOg")]
    [Description(@"Event associated with a shift.")]
    Shift,
    
    /// <summary>
    /// Two times a week
    /// Encoded/decoded by serializers as &quot;TWWK&quot;.
    /// </summary>
    [EnumMember(Value = "TWWK")]
    [IsoId("_Ss5qMB1VEey8XKHwKquEQw")]
    [Description(@"Two times a week")]
    TwiceAWeek,
    
}
