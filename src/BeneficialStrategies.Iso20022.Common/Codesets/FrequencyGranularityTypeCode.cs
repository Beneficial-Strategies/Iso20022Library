// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the granularity of the frequency used for the reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jK9qADy5EeS4E7Ac8_OV3g")]
[Description(@"Specifies the granularity of the frequency used for the reporting.")]
[Derivations(typeof(FrequencyGranularityType1Code))]
public enum FrequencyGranularityTypeCode
{
    /// <summary>
    /// Event takes place every day.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_wdB9ADy5EeS4E7Ac8_OV3g")]
    [Description(@"Event takes place every day.")]
    Daily,
    
    /// <summary>
    /// Event takes place at the end of each month or period of one month.
    /// Encoded/decoded by serializers as &quot;EMON&quot;.
    /// </summary>
    [EnumMember(Value = "EMON")]
    [IsoId("_zkoAEDy5EeS4E7Ac8_OV3g")]
    [Description(@"Event takes place at the end of each month or period of one month.")]
    EndOfMonth,
    
    /// <summary>
    /// Event takes place once a week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_3QM58Dy5EeS4E7Ac8_OV3g")]
    [Description(@"Event takes place once a week.")]
    Weekly,
    
    /// <summary>
    /// Event takes place at the end of each week.
    /// Encoded/decoded by serializers as &quot;EWEK&quot;.
    /// </summary>
    [EnumMember(Value = "EWEK")]
    [IsoId("_DXBh0Dy6EeS4E7Ac8_OV3g")]
    [Description(@"Event takes place at the end of each week.")]
    EndOfWeek,
    
    /// <summary>
    /// Event takes place at the end of each day.
    /// Encoded/decoded by serializers as &quot;EDAY&quot;.
    /// </summary>
    [EnumMember(Value = "EDAY")]
    [IsoId("_GuKcwDy6EeS4E7Ac8_OV3g")]
    [Description(@"Event takes place at the end of each day.")]
    EndOfDay,
    
    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_I4xTIDy6EeS4E7Ac8_OV3g")]
    [Description(@"Event takes place every month or once a month.")]
    Monthly,
    
    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_rT_w0EilEeSlHoYg_EudVQ")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarterly,
    
    /// <summary>
    /// Event takes place at the end of each period of three months (or four times a year).
    /// Encoded/decoded by serializers as &quot;EQRT&quot;.
    /// </summary>
    [EnumMember(Value = "EQRT")]
    [IsoId("_rd0bMEilEeSlHoYg_EudVQ")]
    [Description(@"Event takes place at the end of each period of three months (or four times a year).")]
    EndOfQuarter,
    
    /// <summary>
    /// Event takes place every year or once a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_rjBrUEilEeSlHoYg_EudVQ")]
    [Description(@"Event takes place every year or once a year.")]
    Yearly,
    
    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;MIAN&quot;.
    /// </summary>
    [EnumMember(Value = "MIAN")]
    [IsoId("_7KE4sEilEeSlHoYg_EudVQ")]
    [Description(@"Event takes place every six months or two times a year.")]
    Semiannually,
    
    /// <summary>
    /// Event takes place at the end of each six months (or two times a year).
    /// Encoded/decoded by serializers as &quot;ESEM&quot;.
    /// </summary>
    [EnumMember(Value = "ESEM")]
    [IsoId("_7Ny7EEilEeSlHoYg_EudVQ")]
    [Description(@"Event takes place at the end of each six months (or two times a year).")]
    EndOfSemester,
    
    /// <summary>
    /// Event takes place at the end of each two weeks.
    /// Encoded/decoded by serializers as &quot;EFRT&quot;.
    /// </summary>
    [EnumMember(Value = "EFRT")]
    [IsoId("_atIPwEimEeSlHoYg_EudVQ")]
    [Description(@"Event takes place at the end of each two weeks.")]
    EndOfFortnight,
    
    /// <summary>
    /// Event takes place every two weeks.
    /// Encoded/decoded by serializers as &quot;FRTN&quot;.
    /// </summary>
    [EnumMember(Value = "FRTN")]
    [IsoId("_d0aJwEimEeSlHoYg_EudVQ")]
    [Description(@"Event takes place every two weeks.")]
    Fortnightly,
    
    /// <summary>
    /// Event takes place at the end of each year.
    /// Encoded/decoded by serializers as &quot;ENDY&quot;.
    /// </summary>
    [EnumMember(Value = "ENDY")]
    [IsoId("_e9KBsErvEeSHP9pzU4nIpA")]
    [Description(@"Event takes place at the end of each year.")]
    EndOfYear,
    
}
