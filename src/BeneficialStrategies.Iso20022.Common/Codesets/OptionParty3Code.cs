// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if a trade party is a taker or a maker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X6E8sDzzEeWLuazO9XdCTg")]
[Description(@"Specifies if a trade party is a taker or a maker.")]
[DerivedFrom(typeof(OptionPartyCode))]
public enum OptionParty3Code
{
    /// <summary>
    /// Indicates the receiver of the trade.
    /// Encoded/decoded by serializers as &quot;MAKE&quot;.
    /// </summary>
    [EnumMember(Value = "MAKE")]
    [IsoId("_g2qdMTzzEeWLuazO9XdCTg")]
    [Description(@"Indicates the receiver of the trade.")]
    Maker = OptionPartyCode.Maker, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the initiator of the trade.
    /// Encoded/decoded by serializers as &quot;TAKE&quot;.
    /// </summary>
    [EnumMember(Value = "TAKE")]
    [IsoId("_g9k9gTzzEeWLuazO9XdCTg")]
    [Description(@"Indicates the initiator of the trade.")]
    Taker = OptionPartyCode.Taker, // same ordinal as derivation source for type conversions
    
}
