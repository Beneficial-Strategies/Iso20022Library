// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Automatic Reinvestment of Cash distributed by accumulating funds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r1AnQCXeEeO4bIO_HtGo9Q")]
[Description(@"Automatic Reinvestment of Cash distributed by accumulating funds.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeV2Code))]
public enum CorporateActionFrequencyType3Code
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_FXLZ8SXfEeO4bIO_HtGo9Q")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    Final = CorporateActionFrequencyTypeV2Code.Final, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_FeT8sSXfEeO4bIO_HtGo9Q")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    Interim = CorporateActionFrequencyTypeV2Code.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reinvestment of cash distributed.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_FmDjcSXfEeO4bIO_HtGo9Q")]
    [Description(@"Reinvestment of cash distributed.")]
    Reinvestment = CorporateActionFrequencyTypeV2Code.Reinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_Fu-18SXfEeO4bIO_HtGo9Q")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    Regular = CorporateActionFrequencyTypeV2Code.Regular, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_F2t1oSXfEeO4bIO_HtGo9Q")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    Special = CorporateActionFrequencyTypeV2Code.Special, // same ordinal as derivation source for type conversions
    
}
