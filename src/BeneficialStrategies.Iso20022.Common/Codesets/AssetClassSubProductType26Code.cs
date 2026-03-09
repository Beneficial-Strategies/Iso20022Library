// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Inter Energy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kVSQAVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Inter Energy.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType26Code
{
    /// <summary>
    /// Commodity of type inter energy.
    /// Encoded/decoded by serializers as &quot;INRG&quot;.
    /// </summary>
    [EnumMember(Value = "INRG")]
    [IsoId("_kgdlQ1rKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type inter energy.")]
    InterEnergy = AssetClassSubProductTypeCode.InterEnergy, // same ordinal as derivation source for type conversions
    
}
