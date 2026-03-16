// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of scenario based on how the risk factors moves for that scenario were conceived.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bd4VEKssEeayv9XxdmMwKQ")]
[Description(
    @"Type of scenario based on how the risk factors moves for that scenario were conceived."
)]
[Derivations(typeof(ScenarioType1Code))]
public enum ScenarioTypeCode
{
    /// <summary>
    /// Scenario that replays an event that occurred in the past, including antithetic historical scenarios.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_FdeXIKssEeayv9XxdmMwKQ")]
    [Description(
        @"Scenario that replays an event that occurred in the past, including antithetic historical scenarios."
    )]
    Historical,

    /// <summary>
    /// Scenario that is defined by a hypothetical or theoretical event that may happen in the future.
    /// Encoded/decoded by serializers as &quot;HYPT&quot;.
    /// </summary>
    [EnumMember(Value = "HYPT")]
    [IsoId("_Hp6ZgKssEeayv9XxdmMwKQ")]
    [Description(
        @"Scenario that is defined by a hypothetical or theoretical event that may happen in the future."
    )]
    Hypothetical,
}
