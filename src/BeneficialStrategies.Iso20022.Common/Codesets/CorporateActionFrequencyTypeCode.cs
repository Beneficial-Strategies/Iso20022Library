// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Automatic Reinvestment of Cash distributed by accumulating funds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKGe89p-Ed-ak6NoX_4Aeg_1953823274")]
[Description(@"Automatic Reinvestment of Cash distributed by accumulating funds.")]
[Derivations(typeof(CorporateActionFrequencyType1Code),typeof(CorporateActionFrequencyType2Code))]
[Obsolete("Formally obsoleted in the ISO 20022 specification. No removal date recorded.")]
public enum CorporateActionFrequencyTypeCode
{
    /// <summary>
    /// Payment of a dividend, less amounts already paid through interim dividends.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_bKGe9Np-Ed-ak6NoX_4Aeg_2012927874")]
    [Description(@"Payment of a dividend, less amounts already paid through interim dividends.")]
    Final,
    
    /// <summary>
    /// Dividend declared and paid before annual earnings have been determined.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_bKGe9dp-Ed-ak6NoX_4Aeg_2042480051")]
    [Description(@"Dividend declared and paid before annual earnings have been determined.")]
    Interim,
    
    /// <summary>
    /// Dividend paid at regular interval, for example, quarterly.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_bKGe9tp-Ed-ak6NoX_4Aeg_2079421332")]
    [Description(@"Dividend paid at regular interval, for example, quarterly.")]
    Regular,
    
    /// <summary>
    /// Dividend in addition to the regular dividend being paid by the company.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_bKGe99p-Ed-ak6NoX_4Aeg_2111744098")]
    [Description(@"Dividend in addition to the regular dividend being paid by the company.")]
    Special,
    
    /// <summary>
    /// Automatic Reinvestment of Cash distributed by accumulating funds.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_UcMREN3iEd-KAqAOGQOnnw")]
    [Description(@"Automatic Reinvestment of Cash distributed by accumulating funds.")]
    FundCashDistributionReinvestment,
    
}
