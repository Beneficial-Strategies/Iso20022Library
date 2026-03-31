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
[IsoId("_SHCXkd3iEd-KAqAOGQOnnw")]
[Description(@"Specifies the frequency of a CA event.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionFrequencyType2Code>))]
#endif
public enum CorporateActionFrequencyType2Code
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_q3oUdWtdEeCY4-KZ9JEyUQ_680513451")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    Final = CorporateActionFrequencyTypeCode.Final, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_q3oUdmtdEeCY4-KZ9JEyUQ_387893484")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    Interim = CorporateActionFrequencyTypeCode.Interim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_q3oUd2tdEeCY4-KZ9JEyUQ_-1882435262")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    Regular = CorporateActionFrequencyTypeCode.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_q3yFcGtdEeCY4-KZ9JEyUQ_1415459681")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    Special = CorporateActionFrequencyTypeCode.Special, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Automatic Reinvestment of Cash distributed by accumulating funds.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_q3yFcWtdEeCY4-KZ9JEyUQ_-960271952")]
    [Description(@"Automatic Reinvestment of Cash distributed by accumulating funds.")]
    FundCashDistributionReinvestment =
        CorporateActionFrequencyTypeCode.FundCashDistributionReinvestment, // same ordinal as derivation source for type conversions
}
