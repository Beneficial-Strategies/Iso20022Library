// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the frequency rate fixing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HAxU4I9PEeqMo4JxiuZGSw")]
[Description(@"Defines the frequency rate fixing.")]
[DerivedFrom(typeof(FrequencyRateFixingCode))]
public enum FrequencyRateFixing1Code
{
    /// <summary>
    /// No update of  the rate for the duration of the trade.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_Iq2REY9PEeqMo4JxiuZGSw")]
    [Description(@"No update of  the rate for the duration of the trade.")]
    None = FrequencyRateFixingCode.None, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Daily fixing according to the tenor of the index.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_IwpXEo9PEeqMo4JxiuZGSw")]
    [Description(@"Daily fixing according to the tenor of the index.")]
    Overnight = FrequencyRateFixingCode.Overnight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Periodic fixing of the rate in line with   (according to) the Tenor of the rate.
    /// Encoded/decoded by serializers as &quot;PRDC&quot;.
    /// </summary>
    [EnumMember(Value = "PRDC")]
    [IsoId("_I4Fb0o9PEeqMo4JxiuZGSw")]
    [Description(@"Periodic fixing of the rate in line with   (according to) the Tenor of the rate.")]
    Periodic = FrequencyRateFixingCode.Periodic, // same ordinal as derivation source for type conversions
    
}
