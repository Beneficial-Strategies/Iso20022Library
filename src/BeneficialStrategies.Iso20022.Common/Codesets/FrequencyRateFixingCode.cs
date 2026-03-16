// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Frequencies for a floating rate transaction.
/// *** if an overnight frequency  rate fixing should be applied.  If not present, a periodic fixing frequency will be applied.****
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3_6sMI9LEeqMo4JxiuZGSw")]
[Description(
    @"Frequencies for a floating rate transaction.||*** if an overnight frequency  rate fixing should be applied.  If not present, a periodic fixing frequency will be applied.****|"
)]
[Derivations(typeof(FrequencyRateFixing1Code))]
public enum FrequencyRateFixingCode
{
    /// <summary>
    /// Daily fixing according to the tenor of the index.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_IeNDkI9MEeqMo4JxiuZGSw")]
    [Description(@"Daily fixing according to the tenor of the index.")]
    Overnight,

    /// <summary>
    /// Periodic fixing of the rate in line with   (according to) the Tenor of the rate.
    /// Encoded/decoded by serializers as &quot;PRDC&quot;.
    /// </summary>
    [EnumMember(Value = "PRDC")]
    [IsoId("_cOAPAI9MEeqMo4JxiuZGSw")]
    [Description(
        @"Periodic fixing of the rate in line with   (according to) the Tenor of the rate."
    )]
    Periodic,

    /// <summary>
    /// No update of  the rate for the duration of the trade.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_mSKmII9NEeqMo4JxiuZGSw")]
    [Description(@"No update of  the rate for the duration of the trade.")]
    None,
}
