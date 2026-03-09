// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the resulting position after a trade should be an opening position or closing position.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHfLYtp-Ed-ak6NoX_4Aeg_336257728")]
[Description(@"Indicates whether the resulting position after a trade should be an opening position or closing position.")]
[Derivations(typeof(PositionEffect1Code),typeof(PositionEffect3Code))]
public enum PositionEffectCode
{
    /// <summary>
    /// Position after the trade should be open.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aHfLY9p-Ed-ak6NoX_4Aeg_336257729")]
    [Description(@"Position after the trade should be open.")]
    Open,
    
    /// <summary>
    /// Position after the trade should be closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_aHo8YNp-Ed-ak6NoX_4Aeg_336257730")]
    [Description(@"Position after the trade should be closed.")]
    Close,
    
    /// <summary>
    /// Results in a position obtained in a security previously held, sold and repurchased.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_aHo8Ydp-Ed-ak6NoX_4Aeg_336257731")]
    [Description(@"Results in a position obtained in a security previously held, sold and repurchased.")]
    Rolled,
    
    /// <summary>
    /// First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically.
    /// Encoded/decoded by serializers as &quot;FIFO&quot;.
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("_aHo8Ytp-Ed-ak6NoX_4Aeg_336257732")]
    [Description(@"First in, first out. Results in a position obtained after having sold in priority the securities bought chronologically.")]
    Fifo,
    
    /// <summary>
    /// Last in, last out. Results in a position obtained after having sold in priority the securities bought chronologically.
    /// Encoded/decoded by serializers as &quot;LIFO&quot;.
    /// </summary>
    [EnumMember(Value = "LIFO")]
    [IsoId("_4IotMCDLEeWPMvNwVtiMsA")]
    [Description(@"Last in, last out. Results in a position obtained after having sold in priority the securities bought chronologically.")]
    Lifo,
    
}
