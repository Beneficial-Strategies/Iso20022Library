// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Recovered Paper.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9KJJkVryEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Recovered Paper.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType38Code
{
    /// <summary>
    /// Commodity of type recovered paper.
    /// Encoded/decoded by serializers as &quot;RCVP&quot;.
    /// </summary>
    [EnumMember(Value = "RCVP")]
    [IsoId("_9VZXV1ryEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type recovered paper.")]
    RecoveredPaper = AssetClassSubProductTypeCode.RecoveredPaper, // same ordinal as derivation source for type conversions
    
}
