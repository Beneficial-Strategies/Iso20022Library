// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Frequency of the cash distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OR5utiXeEeO8J8_akw9vuw")]
[Description(@"Frequency of the cash distribution.")]
[Derivations(
    typeof(CorporateActionFrequencyType3Code),
    typeof(CorporateActionFrequencyType4Code),
    typeof(CorporateActionFrequencyType5Code)
)]
public enum CorporateActionFrequencyTypeV2Code
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_OR5uuCXeEeO8J8_akw9vuw")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    Final,

    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_OR5utyXeEeO8J8_akw9vuw")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    Interim,

    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_OR5uuSXeEeO8J8_akw9vuw")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    Regular,

    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_OR5uuiXeEeO8J8_akw9vuw")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    Special,

    /// <summary>
    /// Reinvestment of cash distributed.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_OR5uuyXeEeO8J8_akw9vuw")]
    [Description(@"Reinvestment of cash distributed.")]
    Reinvestment,

    /// <summary>
    /// Special Dividend with reinvestment component.
    /// Encoded/decoded by serializers as &quot;SPRE&quot;.
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_N5sKsaFUEeSK_vfd3NHBGg")]
    [Description(@"Special Dividend with reinvestment component.")]
    SpecialDividendWithReinvestment,
}
