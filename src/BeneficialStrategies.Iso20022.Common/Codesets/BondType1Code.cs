// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of bonds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d6LiAM4mEeSc85GUbgBycw")]
[Description(@"Specifies the type of bonds.")]
[DerivedFrom(typeof(BondTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BondType1Code>))]
#endif
public enum BondType1Code
{
    /// <summary>
    /// Bond of type sovereign bond.
    /// Encoded/decoded by serializers as &quot;EUSB&quot;.
    /// </summary>
    [EnumMember(Value = "EUSB")]
    [IsoId("_z95C0XwXEeWa36CuR-uOCw")]
    [Description(@"Bond of type sovereign bond.|")]
    SovereignBond = BondTypeCode.SovereignBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bond of type other public bond.
    /// Encoded/decoded by serializers as &quot;OEPB&quot;.
    /// </summary>
    [EnumMember(Value = "OEPB")]
    [IsoId("_0jKTEXwXEeWa36CuR-uOCw")]
    [Description(@"Bond of type other public bond.")]
    OtherPublicBond = BondTypeCode.OtherPublicBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bond of type convertible bond.
    /// Encoded/decoded by serializers as &quot;CVTB&quot;.
    /// </summary>
    [EnumMember(Value = "CVTB")]
    [IsoId("_1H1tcXwXEeWa36CuR-uOCw")]
    [Description(@"Bond of type convertible bond.")]
    ConvertibleBond = BondTypeCode.ConvertibleBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bond of type corporate Bond.
    /// Encoded/decoded by serializers as &quot;CRPB&quot;.
    /// </summary>
    [EnumMember(Value = "CRPB")]
    [IsoId("_1huNEXwXEeWa36CuR-uOCw")]
    [Description(@"Bond of type corporate Bond.|")]
    CorporateBond = BondTypeCode.CorporateBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bond of type covered Bond.
    /// Encoded/decoded by serializers as &quot;CVDB&quot;.
    /// </summary>
    [EnumMember(Value = "CVDB")]
    [IsoId("_15wSkXwXEeWa36CuR-uOCw")]
    [Description(@"Bond of type covered Bond.")]
    CoveredBond = BondTypeCode.CoveredBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other bond type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2V1KkXwXEeWa36CuR-uOCw")]
    [Description(@"Other bond type.")]
    Other = BondTypeCode.Other, // same ordinal as derivation source for type conversions
}
