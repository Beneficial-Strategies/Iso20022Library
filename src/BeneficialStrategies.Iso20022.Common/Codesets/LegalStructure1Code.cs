// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Legal structure for assigning an identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xHme4FzPEeeDqe2giKl0eQ")]
[Description(@"Legal structure for assigning an identification.")]
[DerivedFrom(typeof(LegalStructureCode))]
public enum LegalStructure1Code
{
    /// <summary>
    /// Legal structure is a state.
    /// Encoded/decoded by serializers as &quot;STAE&quot;.
    /// </summary>
    [EnumMember(Value = "STAE")]
    [IsoId("_VbY_4X0lEemfrNOe0zHQyg")]
    [Description(@"Legal structure is a state.")]
    State = LegalStructureCode.State, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is a province.
    /// Encoded/decoded by serializers as &quot;PVIN&quot;.
    /// </summary>
    [EnumMember(Value = "PVIN")]
    [IsoId("_VbY_430lEemfrNOe0zHQyg")]
    [Description(@"Legal structure is a province.")]
    Province = LegalStructureCode.Province, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is a municipal.
    /// Encoded/decoded by serializers as &quot;MUNI&quot;.
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_VbY_5X0lEemfrNOe0zHQyg")]
    [Description(@"Legal structure is a municipal.")]
    Municipal = LegalStructureCode.Municipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is a county.
    /// Encoded/decoded by serializers as &quot;CNTY&quot;.
    /// </summary>
    [EnumMember(Value = "CNTY")]
    [IsoId("_VbY_530lEemfrNOe0zHQyg")]
    [Description(@"Legal structure is a county.")]
    County = LegalStructureCode.County, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is a state.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_VbY_6X0lEemfrNOe0zHQyg")]
    [Description(@"Legal structure is a state.")]
    National = LegalStructureCode.National, // same ordinal as derivation source for type conversions
}
