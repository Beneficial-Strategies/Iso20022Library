// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the period related to the tax payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YiT9VNp-Ed-ak6NoX_4Aeg_-1322025669")]
[Description(@"Specifies the period related to the tax payment.")]
[DerivedFrom(typeof(TaxRecordPeriodCode))]
public enum TaxRecordPeriod1Code
{
    /// <summary>
    /// Tax is related to the second month of the period.
    /// Encoded/decoded by serializers as &quot;MM01&quot;.
    /// </summary>
    [EnumMember(Value = "MM01")]
    [IsoId("_YiT9Vdp-Ed-ak6NoX_4Aeg_-1322025421")]
    [Description(@"Tax is related to the second month of the period.")]
    FirstMonth = TaxRecordPeriodCode.FirstMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the first month of the period.
    /// Encoded/decoded by serializers as &quot;MM02&quot;.
    /// </summary>
    [EnumMember(Value = "MM02")]
    [IsoId("_YiT9Vtp-Ed-ak6NoX_4Aeg_-1322025391")]
    [Description(@"Tax is related to the first month of the period.")]
    SecondMonth = TaxRecordPeriodCode.SecondMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the third month of the period.
    /// Encoded/decoded by serializers as &quot;MM03&quot;.
    /// </summary>
    [EnumMember(Value = "MM03")]
    [IsoId("_YiT9V9p-Ed-ak6NoX_4Aeg_-1322025390")]
    [Description(@"Tax is related to the third month of the period.")]
    ThirdMonth = TaxRecordPeriodCode.ThirdMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the fourth month of the period.
    /// Encoded/decoded by serializers as &quot;MM04&quot;.
    /// </summary>
    [EnumMember(Value = "MM04")]
    [IsoId("_YiT9WNp-Ed-ak6NoX_4Aeg_-1322025360")]
    [Description(@"Tax is related to the fourth month of the period.")]
    FourthMonth = TaxRecordPeriodCode.FourthMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the fifth month of the period.
    /// Encoded/decoded by serializers as &quot;MM05&quot;.
    /// </summary>
    [EnumMember(Value = "MM05")]
    [IsoId("_YiduUNp-Ed-ak6NoX_4Aeg_-1322025330")]
    [Description(@"Tax is related to the fifth month of the period.")]
    FifthMonth = TaxRecordPeriodCode.FifthMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the sixth month of the period.
    /// Encoded/decoded by serializers as &quot;MM06&quot;.
    /// </summary>
    [EnumMember(Value = "MM06")]
    [IsoId("_YiduUdp-Ed-ak6NoX_4Aeg_-1322025329")]
    [Description(@"Tax is related to the sixth month of the period.")]
    SixthMonth = TaxRecordPeriodCode.SixthMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the seventh month of the period.
    /// Encoded/decoded by serializers as &quot;MM07&quot;.
    /// </summary>
    [EnumMember(Value = "MM07")]
    [IsoId("_YiduUtp-Ed-ak6NoX_4Aeg_-1322025299")]
    [Description(@"Tax is related to the seventh month of the period.")]
    SeventhMonth = TaxRecordPeriodCode.SeventhMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the eighth month of the period.
    /// Encoded/decoded by serializers as &quot;MM08&quot;.
    /// </summary>
    [EnumMember(Value = "MM08")]
    [IsoId("_YiduU9p-Ed-ak6NoX_4Aeg_-1322025268")]
    [Description(@"Tax is related to the eighth month of the period.")]
    EighthMonth = TaxRecordPeriodCode.EighthMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the ninth month of the period.
    /// Encoded/decoded by serializers as &quot;MM09&quot;.
    /// </summary>
    [EnumMember(Value = "MM09")]
    [IsoId("_YiduVNp-Ed-ak6NoX_4Aeg_-1322024990")]
    [Description(@"Tax is related to the ninth month of the period.")]
    NinthMonth = TaxRecordPeriodCode.NinthMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the tenth month of the period.
    /// Encoded/decoded by serializers as &quot;MM10&quot;.
    /// </summary>
    [EnumMember(Value = "MM10")]
    [IsoId("_YiduVdp-Ed-ak6NoX_4Aeg_-1322024989")]
    [Description(@"Tax is related to the tenth month of the period.")]
    TenthMonth = TaxRecordPeriodCode.TenthMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the eleventh month of the period.
    /// Encoded/decoded by serializers as &quot;MM11&quot;.
    /// </summary>
    [EnumMember(Value = "MM11")]
    [IsoId("_YiduVtp-Ed-ak6NoX_4Aeg_-1322024959")]
    [Description(@"Tax is related to the eleventh month of the period.")]
    EleventhMonth = TaxRecordPeriodCode.EleventhMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the twelfth month of the period.
    /// Encoded/decoded by serializers as &quot;MM12&quot;.
    /// </summary>
    [EnumMember(Value = "MM12")]
    [IsoId("_YiduV9p-Ed-ak6NoX_4Aeg_-1322024929")]
    [Description(@"Tax is related to the twelfth month of the period.")]
    TwelfthMonth = TaxRecordPeriodCode.TwelfthMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the first quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR1&quot;.
    /// </summary>
    [EnumMember(Value = "QTR1")]
    [IsoId("_YiduWNp-Ed-ak6NoX_4Aeg_-1322024928")]
    [Description(@"Tax is related to the first quarter of the period.")]
    FirstQuarter = TaxRecordPeriodCode.FirstQuarter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the second quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR2&quot;.
    /// </summary>
    [EnumMember(Value = "QTR2")]
    [IsoId("_YiduWdp-Ed-ak6NoX_4Aeg_-1322024898")]
    [Description(@"Tax is related to the second quarter of the period.")]
    SecondQuarter = TaxRecordPeriodCode.SecondQuarter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the third quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR3&quot;.
    /// </summary>
    [EnumMember(Value = "QTR3")]
    [IsoId("_Yim4QNp-Ed-ak6NoX_4Aeg_-1322024867")]
    [Description(@"Tax is related to the third quarter of the period.")]
    ThirdQuarter = TaxRecordPeriodCode.ThirdQuarter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the forth quarter of the period.
    /// Encoded/decoded by serializers as &quot;QTR4&quot;.
    /// </summary>
    [EnumMember(Value = "QTR4")]
    [IsoId("_Yim4Qdp-Ed-ak6NoX_4Aeg_-1322024866")]
    [Description(@"Tax is related to the forth quarter of the period.")]
    FourthQuarter = TaxRecordPeriodCode.FourthQuarter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the first half of the period.
    /// Encoded/decoded by serializers as &quot;HLF1&quot;.
    /// </summary>
    [EnumMember(Value = "HLF1")]
    [IsoId("_Yim4Qtp-Ed-ak6NoX_4Aeg_-1322024837")]
    [Description(@"Tax is related to the first half of the period.")]
    FirstHalf = TaxRecordPeriodCode.FirstHalf, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is related to the second half of the period.
    /// Encoded/decoded by serializers as &quot;HLF2&quot;.
    /// </summary>
    [EnumMember(Value = "HLF2")]
    [IsoId("_Yim4Q9p-Ed-ak6NoX_4Aeg_-1322024806")]
    [Description(@"Tax is related to the second half of the period.")]
    SecondHalf = TaxRecordPeriodCode.SecondHalf, // same ordinal as derivation source for type conversions
    
}
