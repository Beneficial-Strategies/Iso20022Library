// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the risk level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v_E8ExdwEeKYM7Bc71nDlA")]
[Description(@"Specifies the risk level.")]
[Derivations(typeof(RiskLevel1Code))]
public enum RiskLevelCode
{
    /// <summary>
    /// High.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_1Fus0BdwEeKYM7Bc71nDlA")]
    [Description(@"High.")]
    High,

    /// <summary>
    /// Medium.
    /// Encoded/decoded by serializers as &quot;MEDM&quot;.
    /// </summary>
    [EnumMember(Value = "MEDM")]
    [IsoId("_1R8j4BdwEeKYM7Bc71nDlA")]
    [Description(@"Medium.")]
    Medium,

    /// <summary>
    /// Low.
    /// Encoded/decoded by serializers as &quot;LOWW&quot;.
    /// </summary>
    [EnumMember(Value = "LOWW")]
    [IsoId("_1Z17oBdwEeKYM7Bc71nDlA")]
    [Description(@"Low.")]
    Low,
}
