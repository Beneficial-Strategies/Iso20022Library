// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the period related to the tax payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yim4RNp-Ed-ak6NoX_4Aeg_463735994")]
[Description(@"Specifies the period related to the tax payment.")]
[Derivations(typeof(TaxRecordPeriod1Code))]
public enum TaxRecordPeriodCode
{
    /// <summary>
    /// Tax is related to the second month of the period.
    /// Encoded/decoded by serializers as &quot;MM01&quot;.
    /// </summary>
    [EnumMember(Value = "MM01")]
    [IsoId("_Yim4Rdp-Ed-ak6NoX_4Aeg_738019644")]
    [Description(@"Tax is related to the second month of the period.")]
    FirstMonth,

    /// <summary>
    /// Tax is related to the first month of the period.
    /// Encoded/decoded by serializers as &quot;MM02&quot;.
    /// </summary>
    [EnumMember(Value = "MM02")]
    [IsoId("_Yim4Rtp-Ed-ak6NoX_4Aeg_1177616225")]
    [Description(@"Tax is related to the first month of the period.")]
    SecondMonth,

    /// <summary>
    /// Tax is related to the third month of the period.
    /// Encoded/decoded by serializers as &quot;MM03&quot;.
    /// </summary>
    [EnumMember(Value = "MM03")]
    [IsoId("_Yim4R9p-Ed-ak6NoX_4Aeg_1178541702")]
    [Description(@"Tax is related to the third month of the period.")]
    ThirdMonth,

    /// <summary>
    /// Tax is related to the fourth month of the period.
    /// Encoded/decoded by serializers as &quot;MM04&quot;.
    /// </summary>
    [EnumMember(Value = "MM04")]
    [IsoId("_Yim4SNp-Ed-ak6NoX_4Aeg_1180387090")]
    [Description(@"Tax is related to the fourth month of the period.")]
    FourthMonth,

    /// <summary>
    /// Tax is related to the fifth month of the period.
    /// Encoded/decoded by serializers as &quot;MM05&quot;.
    /// </summary>
    [EnumMember(Value = "MM05")]
    [IsoId("_Yim4Sdp-Ed-ak6NoX_4Aeg_1181312605")]
    [Description(@"Tax is related to the fifth month of the period.")]
    FifthMonth,

    /// <summary>
    /// Tax is related to the sixth month of the period.
    /// Encoded/decoded by serializers as &quot;MM06&quot;.
    /// </summary>
    [EnumMember(Value = "MM06")]
    [IsoId("_YiwpQNp-Ed-ak6NoX_4Aeg_1190546807")]
    [Description(@"Tax is related to the sixth month of the period.")]
    SixthMonth,

    /// <summary>
    /// Tax is related to the seventh month of the period.
    /// Encoded/decoded by serializers as &quot;MM07&quot;.
    /// </summary>
    [EnumMember(Value = "MM07")]
    [IsoId("_YiwpQdp-Ed-ak6NoX_4Aeg_1192392007")]
    [Description(@"Tax is related to the seventh month of the period.")]
    SeventhMonth,

    /// <summary>
    /// Tax is related to the eighth month of the period.
    /// Encoded/decoded by serializers as &quot;MM08&quot;.
    /// </summary>
    [EnumMember(Value = "MM08")]
    [IsoId("_YiwpQtp-Ed-ak6NoX_4Aeg_1193318347")]
    [Description(@"Tax is related to the eighth month of the period.")]
    EighthMonth,

    /// <summary>
    /// Tax is related to the ninth month of the period.
    /// Encoded/decoded by serializers as &quot;MM09&quot;.
    /// </summary>
    [EnumMember(Value = "MM09")]
    [IsoId("_YiwpQ9p-Ed-ak6NoX_4Aeg_1198858033")]
    [Description(@"Tax is related to the ninth month of the period.")]
    NinthMonth,

    /// <summary>
    /// Tax is related to the tenth month of the period.
    /// Encoded/decoded by serializers as &quot;MM10&quot;.
    /// </summary>
    [EnumMember(Value = "MM10")]
    [IsoId("_YiwpRNp-Ed-ak6NoX_4Aeg_1206247879")]
    [Description(@"Tax is related to the tenth month of the period.")]
    TenthMonth,

    /// <summary>
    /// Tax is related to the eleventh month of the period.
    /// Encoded/decoded by serializers as &quot;MM11&quot;.
    /// </summary>
    [EnumMember(Value = "MM11")]
    [IsoId("_YiwpRdp-Ed-ak6NoX_4Aeg_1208092935")]
    [Description(@"Tax is related to the eleventh month of the period.")]
    EleventhMonth,

    /// <summary>
    /// Tax is related to the twelfth month of the period.
    /// Encoded/decoded by serializers as &quot;MM12&quot;.
    /// </summary>
    [EnumMember(Value = "MM12")]
    [IsoId("_YiwpRtp-Ed-ak6NoX_4Aeg_1209939823")]
    [Description(@"Tax is related to the twelfth month of the period.")]
    TwelfthMonth,

    /// <summary>
    /// Tax is related to the first quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR1&quot;.
    /// </summary>
    [EnumMember(Value = "QTR1")]
    [IsoId("_YiwpR9p-Ed-ak6NoX_4Aeg_1220098160")]
    [Description(@"Tax is related to the first quarter of the period.")]
    FirstQuarter,

    /// <summary>
    /// Tax is related to the second quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR2&quot;.
    /// </summary>
    [EnumMember(Value = "QTR2")]
    [IsoId("_YiwpSNp-Ed-ak6NoX_4Aeg_-2123641897")]
    [Description(@"Tax is related to the second quarter of the period.")]
    SecondQuarter,

    /// <summary>
    /// Tax is related to the third quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR3&quot;.
    /// </summary>
    [EnumMember(Value = "QTR3")]
    [IsoId("_YiwpSdp-Ed-ak6NoX_4Aeg_-2086701696")]
    [Description(@"Tax is related to the third quarter of the period.")]
    ThirdQuarter,

    /// <summary>
    /// Tax is related to the forth quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR4&quot;.
    /// </summary>
    [EnumMember(Value = "QTR4")]
    [IsoId("_Yi5zMNp-Ed-ak6NoX_4Aeg_-2027593448")]
    [Description(@"Tax is related to the forth quarter of the period.")]
    FourthQuarter,

    /// <summary>
    /// Tax is related to the first half of the period.
    /// Encoded/decoded by serializers as &quot;HLF1&quot;.
    /// </summary>
    [EnumMember(Value = "HLF1")]
    [IsoId("_Yi5zMdp-Ed-ak6NoX_4Aeg_-1783786292")]
    [Description(@"Tax is related to the first half of the period.")]
    FirstHalf,

    /// <summary>
    /// Tax is related to the second half of the period.
    /// Encoded/decoded by serializers as &quot;HLF2&quot;.
    /// </summary>
    [EnumMember(Value = "HLF2")]
    [IsoId("_Yi5zMtp-Ed-ak6NoX_4Aeg_-1750538188")]
    [Description(@"Tax is related to the second half of the period.")]
    SecondHalf,
}
