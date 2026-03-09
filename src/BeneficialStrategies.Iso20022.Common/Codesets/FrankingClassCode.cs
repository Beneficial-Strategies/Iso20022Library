// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code defining the dvidend / distribution class where this franking information applies to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WlzwAVfuEeOuDtoQo1qilA")]
[Description(@"Code defining the dvidend / distribution class where this franking information applies to.")]
[Derivations(typeof(FrankingClass1Code))]
public enum FrankingClassCode
{
    /// <summary>
    /// Franking information applies to ordinary cash dividend.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_cSBE4FfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to ordinary cash dividend.")]
    CashDividend,
    
    /// <summary>
    /// Franking information applies to interest payment.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_hSMaMFfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to interest payment.")]
    Interest,
    
    /// <summary>
    /// Franking information applies to NZD Declared dividend/distributions - supplementary dividend/distribution.
    /// Encoded/decoded by serializers as &quot;NZDD&quot;.
    /// </summary>
    [EnumMember(Value = "NZDD")]
    [IsoId("_k5sFUFfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to NZD Declared dividend/distributions - supplementary dividend/distribution.")]
    NZDDeclared,
    
    /// <summary>
    /// Franking information applies to scrip dividend.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_pFpIYFfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to scrip dividend.")]
    ScripDividend,
    
    /// <summary>
    /// Franking information applies to special dividend.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_sgWUsFfuEeOuDtoQo1qilA")]
    [Description(@"Franking information applies to special dividend.")]
    SpecialDividend,
    
}
