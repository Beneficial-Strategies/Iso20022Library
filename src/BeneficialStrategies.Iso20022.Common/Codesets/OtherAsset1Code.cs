// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of asset
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qavIYEyMEeiepssxrmRw1A")]
[Description(@"Specifies a type of asset")]
[DerivedFrom(typeof(OtherAssetCode))]
public enum OtherAsset1Code
{
    /// <summary>
    /// Property that is not real estate. Also known as &apos;movable chattels&apos;.
    /// Encoded/decoded by serializers as &quot;MOVE&quot;.
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_rkYRAUyMEeiepssxrmRw1A")]
    [Description(@"Property that is not real estate. Also known as 'movable chattels'.")]
    MovableProperty = OtherAssetCode.MovableProperty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Property that is real estate.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_rqe5AUyMEeiepssxrmRw1A")]
    [Description(@"Property that is real estate.")]
    Property = OtherAssetCode.Property, // same ordinal as derivation source for type conversions
}
