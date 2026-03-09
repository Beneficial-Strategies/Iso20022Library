// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Location category of the place where the transaction is actually performed. 
/// It correspond partially to the ISO 8583: 1993, field number 22-4.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H30HwHsIEeSR68OJvMfxJQ")]
[Description(@"Location category of the place where the transaction is actually performed. |It correspond partially to the ISO 8583: 1993, field number 22-4.")]
[DerivedFrom(typeof(LocationCategoryCode))]
public enum LocationCategory2Code
{
    /// <summary>
    /// Customer home.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_KdgXoXsIEeSR68OJvMfxJQ")]
    [Description(@"Customer home.")]
    Home = LocationCategoryCode.Home, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Aboard a bus, train, ship, airplane, taxi, etc.
    /// Encoded/decoded by serializers as &quot;ABRD&quot;.
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_w3820VDhEeuJG-g6zrGRtg")]
    [Description(@"Aboard a bus, train, ship, airplane, taxi, etc.")]
    Aboard = LocationCategoryCode.Aboard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fixed location, for example in a shop.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_w-zswVDhEeuJG-g6zrGRtg")]
    [Description(@"Fixed location, for example in a shop.")]
    Fixed = LocationCategoryCode.Fixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Nomadic location.
    /// Encoded/decoded by serializers as &quot;NMDC&quot;.
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_0crh0VDhEeuJG-g6zrGRtg")]
    [Description(@"Nomadic location.")]
    Nomadic = LocationCategoryCode.Nomadic, // same ordinal as derivation source for type conversions
    
}
