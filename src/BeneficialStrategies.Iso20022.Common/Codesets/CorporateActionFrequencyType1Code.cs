// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the frequency of a CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bJ8t99p-Ed-ak6NoX_4Aeg_1457749701")]
[Description(@"Specifies the frequency of a CA event.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionFrequencyType1Code>))]
#endif
public enum CorporateActionFrequencyType1Code
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_bJ8t-Np-Ed-ak6NoX_4Aeg_1457749703")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    Final = CorporateActionFrequencyTypeCode.Final, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_bKGe8Np-Ed-ak6NoX_4Aeg_1457749980")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    Interim = CorporateActionFrequencyTypeCode.Interim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_bKGe8dp-Ed-ak6NoX_4Aeg_1457749981")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    Regular = CorporateActionFrequencyTypeCode.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_bKGe8tp-Ed-ak6NoX_4Aeg_1457749982")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    Special = CorporateActionFrequencyTypeCode.Special, // same ordinal as derivation source for type conversions
}
