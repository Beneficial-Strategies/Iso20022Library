// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sPnN4H03EeGlwNeVP9egyg")]
[Description(@"Specifies the amount type.")]
[DerivedFrom(typeof(AmountTypeCode))]
public enum AmountType2Code
{
    /// <summary>
    /// The amount represents a fixed value.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_aISmtn04EeGlwNeVP9egyg")]
    [Description(@"The amount represents a fixed value.")]
    FixedAmount = AmountTypeCode.FixedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The amount represents the maximum value.
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_aXoqRn04EeGlwNeVP9egyg")]
    [Description(@"The amount represents the maximum value.")]
    MaximumAmount = AmountTypeCode.MaximumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The amount represents the minimum value.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_ahLAxn04EeGlwNeVP9egyg")]
    [Description(@"The amount represents the minimum value.")]
    MinimumAmount = AmountTypeCode.MinimumAmount, // same ordinal as derivation source for type conversions
}
