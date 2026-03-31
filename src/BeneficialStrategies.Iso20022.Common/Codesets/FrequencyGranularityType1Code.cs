// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the granularity of the frequency used for the reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1CBwDy5EeS4E7Ac8_OV3g")]
[Description(@"Defines the granularity of the frequency used for the reporting.")]
[DerivedFrom(typeof(FrequencyGranularityTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FrequencyGranularityType1Code>))]
#endif
public enum FrequencyGranularityType1Code
{
    /// <summary>
    /// Event takes place at the end of each month or period of one month.
    /// Encoded/decoded by serializers as &quot;EMON&quot;.
    /// </summary>
    [EnumMember(Value = "EMON")]
    [IsoId("_Bh82kTy6EeS4E7Ac8_OV3g")]
    [Description(@"Event takes place at the end of each month or period of one month.")]
    EndOfMonth = FrequencyGranularityTypeCode.EndOfMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place at the end of each week.
    /// Encoded/decoded by serializers as &quot;EWEK&quot;.
    /// </summary>
    [EnumMember(Value = "EWEK")]
    [IsoId("_iKUaEUimEeSlHoYg_EudVQ")]
    [Description(@"Event takes place at the end of each week.")]
    EndOfWeek = FrequencyGranularityTypeCode.EndOfWeek, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place at the end of each six months (or two times a year).
    /// Encoded/decoded by serializers as &quot;ESEM&quot;.
    /// </summary>
    [EnumMember(Value = "ESEM")]
    [IsoId("_iRnU4UimEeSlHoYg_EudVQ")]
    [Description(@"Event takes place at the end of each six months (or two times a year).")]
    EndOfSemester = FrequencyGranularityTypeCode.EndOfSemester, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place at the end of each period of three months (or four times a year).
    /// Encoded/decoded by serializers as &quot;EQRT&quot;.
    /// </summary>
    [EnumMember(Value = "EQRT")]
    [IsoId("_iZzAgUimEeSlHoYg_EudVQ")]
    [Description(
        @"Event takes place at the end of each period of three months (or four times a year)."
    )]
    EndOfQuarter = FrequencyGranularityTypeCode.EndOfQuarter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place at the end of each two weeks.
    /// Encoded/decoded by serializers as &quot;EFRT&quot;.
    /// </summary>
    [EnumMember(Value = "EFRT")]
    [IsoId("_ih07IUimEeSlHoYg_EudVQ")]
    [Description(@"Event takes place at the end of each two weeks.")]
    EndOfFortnight = FrequencyGranularityTypeCode.EndOfFortnight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place at the end of each day.
    /// Encoded/decoded by serializers as &quot;EDAY&quot;.
    /// </summary>
    [EnumMember(Value = "EDAY")]
    [IsoId("_iqnDsUimEeSlHoYg_EudVQ")]
    [Description(@"Event takes place at the end of each day.")]
    EndOfDay = FrequencyGranularityTypeCode.EndOfDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place at the end of each year.
    /// Encoded/decoded by serializers as &quot;ENDY&quot;.
    /// </summary>
    [EnumMember(Value = "ENDY")]
    [IsoId("_qoAfQUrvEeSHP9pzU4nIpA")]
    [Description(@"Event takes place at the end of each year.")]
    EndOfYear = FrequencyGranularityTypeCode.EndOfYear, // same ordinal as derivation source for type conversions
}
