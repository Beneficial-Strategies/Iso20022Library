// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type as either recovered paper or other.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JDSnceFeEe64Zfh-zMOIZQ")]
[Description(@"Defines the sub-product of type as either recovered paper or other.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType50Code
{
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type recovered paper.
    /// Encoded/decoded by serializers as &quot;RCVP&quot;.
    /// </summary>
    [EnumMember(Value = "RCVP")]
    [IsoId("")]
    [Description(@"Commodity of type recovered paper.")]
    RecoveredPaper = AssetClassSubProductTypeCode.RecoveredPaper, // same ordinal as derivation source for type conversions

}
