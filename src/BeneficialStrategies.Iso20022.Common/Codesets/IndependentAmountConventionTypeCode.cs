// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Determines how the independent amount was applied in the margin calculation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yc8VItp-Ed-ak6NoX_4Aeg_-469659155")]
[Description(@"Determines how the independent amount was applied in the margin calculation.")]
[Derivations(typeof(IndependentAmountConventionType1Code))]
public enum IndependentAmountConventionTypeCode
{
    /// <summary>
    /// Independent amount is an add on to exposure.
    /// Encoded/decoded by serializers as &quot;NBTR&quot;.
    /// </summary>
    [EnumMember(Value = "NBTR")]
    [IsoId("_Yc8VI9p-Ed-ak6NoX_4Aeg_-1298205045")]
    [Description(@"Independent amount is an add on to exposure.")]
    NettedBeforeThreshold,
    
    /// <summary>
    /// Independent amount is an add on to the credit support amount and forms part of the variation margin requirement.
    /// Encoded/decoded by serializers as &quot;NATR&quot;.
    /// </summary>
    [EnumMember(Value = "NATR")]
    [IsoId("_Yc8VJNp-Ed-ak6NoX_4Aeg_913571949")]
    [Description(@"Independent amount is an add on to the credit support amount and forms part of the variation margin requirement.")]
    NettedAfterThreshold,
    
    /// <summary>
    /// Independent amount is treated independently of variation margin for segregation purposes.
    /// Encoded/decoded by serializers as &quot;SEGR&quot;.
    /// </summary>
    [EnumMember(Value = "SEGR")]
    [IsoId("_Yc8VJdp-Ed-ak6NoX_4Aeg_-532240480")]
    [Description(@"Independent amount is treated independently of variation margin for segregation purposes.")]
    Segregated,
    
}
