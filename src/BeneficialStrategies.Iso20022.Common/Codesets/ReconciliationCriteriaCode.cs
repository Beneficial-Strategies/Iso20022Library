// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Available criterion to group transactions when a reconliation is made.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7DGFoCpUEeuUucRY0yCMTA")]
[Description(@"Available criterion to group transactions when a reconliation is made.")]
[Derivations(typeof(ReconciliationCriteria1Code))]
public enum ReconciliationCriteriaCode
{
    /// <summary>
    /// The set is defined by transactions processed by POIs identified with the same POIGroup.
    /// Encoded/decoded by serializers as &quot;GRUP&quot;.
    /// </summary>
    [EnumMember(Value = "GRUP")]
    [IsoId("_ZNckYCpVEeuUucRY0yCMTA")]
    [Description(
        @"The set is defined by transactions processed by POIs identified with the same POIGroup."
    )]
    PoiGroup,

    /// <summary>
    /// The set is defined by transactions made with cards sharing the same CardProductProfile.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_t62AgCpVEeuUucRY0yCMTA")]
    [Description(
        @"The set is defined by transactions made with cards sharing the same CardProductProfile."
    )]
    CardProductProfile,

    /// <summary>
    /// The set is defined by transactions made with cards belonging  to the same brand.
    /// Encoded/decoded by serializers as &quot;BRND&quot;.
    /// </summary>
    [EnumMember(Value = "BRND")]
    [IsoId("_7_6dwCpVEeuUucRY0yCMTA")]
    [Description(
        @"The set is defined by transactions made with cards belonging  to the same brand."
    )]
    CardBrand,
}
