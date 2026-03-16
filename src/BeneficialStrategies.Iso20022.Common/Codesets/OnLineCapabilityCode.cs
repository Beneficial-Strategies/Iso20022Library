// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// On-line and off-line capabilities of the POI (Point Of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TU5kHAEcEeCQm6a_G2yO_w_1796414491")]
[Description(@"On-line and off-line capabilities of the POI (Point Of Interaction).")]
[Derivations(typeof(OnLineCapability1Code), typeof(OnLineCapability2Code))]
public enum OnLineCapabilityCode
{
    /// <summary>
    /// Off-line only capable.
    /// Encoded/decoded by serializers as &quot;OFLN&quot;.
    /// </summary>
    [EnumMember(Value = "OFLN")]
    [IsoId("_TU5kHQEcEeCQm6a_G2yO_w_-1739377471")]
    [Description(@"Off-line only capable.")]
    OffLine,

    /// <summary>
    /// On-line only capable.
    /// Encoded/decoded by serializers as &quot;ONLN&quot;.
    /// </summary>
    [EnumMember(Value = "ONLN")]
    [IsoId("_TU5kHgEcEeCQm6a_G2yO_w_-1554375829")]
    [Description(@"On-line only capable.")]
    OnLine,

    /// <summary>
    /// Off-line capable with possible on-line requests to the acquirer.
    /// Encoded/decoded by serializers as &quot;SMON&quot;.
    /// </summary>
    [EnumMember(Value = "SMON")]
    [IsoId("_TU5kHwEcEeCQm6a_G2yO_w_-337286150")]
    [Description(@"Off-line capable with possible on-line requests to the acquirer.")]
    SemiOffLine,

    /// <summary>
    /// Both online and offline
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_83t5MXyJEemHsOqJOzMVfg")]
    [Description(@"Both online and offline")]
    BothOnLineAndOffLine,
}
