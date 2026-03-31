// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Available criterion to group transactions when a reconliation is made.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_InBvQCpWEeuUucRY0yCMTA")]
[Description(@"Available criterion to group transactions when a reconliation is made.")]
[DerivedFrom(typeof(ReconciliationCriteriaCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReconciliationCriteria1Code>))]
#endif
public enum ReconciliationCriteria1Code
{
    /// <summary>
    /// The set is defined by transactions made with cards belonging  to the same brand.
    /// Encoded/decoded by serializers as &quot;BRND&quot;.
    /// </summary>
    [EnumMember(Value = "BRND")]
    [IsoId("_T3JYoSpWEeuUucRY0yCMTA")]
    [Description(
        @"The set is defined by transactions made with cards belonging  to the same brand."
    )]
    CardBrand = ReconciliationCriteriaCode.CardBrand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The set is defined by transactions made with cards sharing the same CardProductProfile.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_UHVwwSpWEeuUucRY0yCMTA")]
    [Description(
        @"The set is defined by transactions made with cards sharing the same CardProductProfile."
    )]
    CardProductProfile = ReconciliationCriteriaCode.CardProductProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The set is defined by transactions processed by POIs identified with the same POIGroup.
    /// Encoded/decoded by serializers as &quot;GRUP&quot;.
    /// </summary>
    [EnumMember(Value = "GRUP")]
    [IsoId("_UJQcUSpWEeuUucRY0yCMTA")]
    [Description(
        @"The set is defined by transactions processed by POIs identified with the same POIGroup."
    )]
    PoiGroup = ReconciliationCriteriaCode.PoiGroup, // same ordinal as derivation source for type conversions
}
