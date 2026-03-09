// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOo8RNp-Ed-ak6NoX_4Aeg_1061425595")]
[Description(@"Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).")]
[Derivations(typeof(OffsetType1Code))]
public enum OffsetTypeCode
{
    /// <summary>
    /// Indicates that range of peg order or discretion offset value is a price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_aOo8Rdp-Ed-ak6NoX_4Aeg_1091901412")]
    [Description(@"Indicates that range of peg order or discretion offset value is a price.")]
    Price,
    
    /// <summary>
    /// The range of peg order or discretion offset value is measured in basis points.
    /// Encoded/decoded by serializers as &quot;BAPO&quot;.
    /// </summary>
    [EnumMember(Value = "BAPO")]
    [IsoId("_aOo8Rtp-Ed-ak6NoX_4Aeg_1303388657")]
    [Description(@"The range of peg order or discretion offset value is measured in basis points.")]
    BasisPoint,
    
    /// <summary>
    /// The range of peg order or discretion offset value is a tick.
    /// Encoded/decoded by serializers as &quot;TICK&quot;.
    /// </summary>
    [EnumMember(Value = "TICK")]
    [IsoId("_aOo8R9p-Ed-ak6NoX_4Aeg_1308930135")]
    [Description(@"The range of peg order or discretion offset value is a tick.")]
    Tick,
    
    /// <summary>
    /// The range of peg order or discretion offset is a price level.
    /// Encoded/decoded by serializers as &quot;PTLE&quot;.
    /// </summary>
    [EnumMember(Value = "PTLE")]
    [IsoId("_aOo8SNp-Ed-ak6NoX_4Aeg_1319087950")]
    [Description(@"The range of peg order or discretion offset is a price level.")]
    PriceTierLevel,
    
}
