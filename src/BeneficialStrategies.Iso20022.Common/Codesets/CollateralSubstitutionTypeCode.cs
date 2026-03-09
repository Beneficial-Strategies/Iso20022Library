// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcDkV9p-Ed-ak6NoX_4Aeg_-2087044580")]
[Description(@"Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.")]
[Derivations(typeof(CollateralSubstitutionType1Code))]
public enum CollateralSubstitutionTypeCode
{
    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin.
    /// Encoded/decoded by serializers as &quot;AVMG&quot;.
    /// </summary>
    [EnumMember(Value = "AVMG")]
    [IsoId("_YcMuQNp-Ed-ak6NoX_4Aeg_-1906779964")]
    [Description(@"Specifies if the collateral that is substituted was posted against the variation margin.")]
    AgainstVariationMargin,
    
    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the independent amount.
    /// Encoded/decoded by serializers as &quot;ASIA&quot;.
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_YcMuQdp-Ed-ak6NoX_4Aeg_1381960519")]
    [Description(@"Specifies if the collateral that is substituted was posted against the independent amount.")]
    AgainstSegregatedIndependentAmount,
    
}
