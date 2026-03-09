// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the order in which events are processed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tIL3gCDLEeWPMvNwVtiMsA")]
[Description(@"Specifies the order in which events are processed.")]
[DerivedFrom(typeof(PositionEffectCode))]
public enum PositionEffect3Code
{
    /// <summary>
    /// First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically.
    /// Encoded/decoded by serializers as &quot;FIFO&quot;.
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("_yHm-4SDLEeWPMvNwVtiMsA")]
    [Description(@"First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically.")]
    Fifo = PositionEffectCode.Fifo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Last in, last out. Results in a position obtained after having sold in priority the securities bought chronologically.
    /// Encoded/decoded by serializers as &quot;LIFO&quot;.
    /// </summary>
    [EnumMember(Value = "LIFO")]
    [IsoId("_-qssASDLEeWPMvNwVtiMsA")]
    [Description(@"Last in, last out. Results in a position obtained after having sold in priority the securities bought chronologically.")]
    Lifo = PositionEffectCode.Lifo, // same ordinal as derivation source for type conversions
    
}
