// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Other C10.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_R3EAsA3oEeWc7_0KPiuk6w")]
[Description(@"Defines the sub-product of type Other C10.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType19Code
{
    /// <summary>
    /// Commodity of type deliverable.
    /// Encoded/decoded by serializers as &quot;DLVR&quot;.
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_TB5cIQ3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of type deliverable.")]
    Deliverable = AssetClassSubProductTypeCode.Deliverable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type non deliverable.
    /// Encoded/decoded by serializers as &quot;NDLV&quot;.
    /// </summary>
    [EnumMember(Value = "NDLV")]
    [IsoId("_T0xqkQ3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of type non deliverable.")]
    NonDeliverable = AssetClassSubProductTypeCode.NonDeliverable, // same ordinal as derivation source for type conversions
    
}
