// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOfyV9p-Ed-ak6NoX_4Aeg_-1413993585")]
[Description(
    @"Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc)."
)]
[DerivedFrom(typeof(OffsetTypeCode))]
public enum OffsetType1Code
{
    /// <summary>
    /// Indicates that range of peg order or discretion offset value is a price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_aOo8QNp-Ed-ak6NoX_4Aeg_-1344728954")]
    [Description(@"Indicates that range of peg order or discretion offset value is a price.")]
    Price = OffsetTypeCode.Price, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The range of peg order or discretion offset value is measured in basis points.
    /// Encoded/decoded by serializers as &quot;BAPO&quot;.
    /// </summary>
    [EnumMember(Value = "BAPO")]
    [IsoId("_aOo8Qdp-Ed-ak6NoX_4Aeg_-1344728894")]
    [Description(@"The range of peg order or discretion offset value is measured in basis points.")]
    BasisPoint = OffsetTypeCode.BasisPoint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The range of peg order or discretion offset value is a tick.
    /// Encoded/decoded by serializers as &quot;TICK&quot;.
    /// </summary>
    [EnumMember(Value = "TICK")]
    [IsoId("_aOo8Qtp-Ed-ak6NoX_4Aeg_-1344728859")]
    [Description(@"The range of peg order or discretion offset value is a tick.")]
    Tick = OffsetTypeCode.Tick, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The range of peg order or discretion offset is a price level.
    /// Encoded/decoded by serializers as &quot;PTLE&quot;.
    /// </summary>
    [EnumMember(Value = "PTLE")]
    [IsoId("_aOo8Q9p-Ed-ak6NoX_4Aeg_-1344728568")]
    [Description(@"The range of peg order or discretion offset is a price level.")]
    PriceTierLevel = OffsetTypeCode.PriceTierLevel, // same ordinal as derivation source for type conversions
}
