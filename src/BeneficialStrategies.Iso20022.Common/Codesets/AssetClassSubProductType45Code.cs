// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Potato.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HouHoPwdEeW4Wthd0Ze_kA")]
[Description(@"Defines the sub-product of type Potato.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType45Code
{
    /// <summary>
    /// Commodity of type potato.
    /// Encoded/decoded by serializers as &quot;POTA&quot;.
    /// </summary>
    [EnumMember(Value = "POTA")]
    [IsoId("_Kl9U0fwdEeW4Wthd0Ze_kA")]
    [Description(@"Commodity of type potato.")]
    Potato = AssetClassSubProductTypeCode.Potato, // same ordinal as derivation source for type conversions
    
}
