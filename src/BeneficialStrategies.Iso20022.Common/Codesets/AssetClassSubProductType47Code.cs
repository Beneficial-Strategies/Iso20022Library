// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product types for specific asset classes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iTsYoPwhEeW4Wthd0Ze_kA")]
[Description(@"Defines the sub-product types for specific asset classes.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType47Code
{
    /// <summary>
    /// Commodity of type deliverable.
    /// Encoded/decoded by serializers as &quot;DLVR&quot;.
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_kPWNAfwhEeW4Wthd0Ze_kA")]
    [Description(@"Commodity of type deliverable.")]
    Deliverable = AssetClassSubProductTypeCode.Deliverable, // same ordinal as derivation source for type conversions
}
