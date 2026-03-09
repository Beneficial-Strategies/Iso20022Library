// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classification of the methodology used to derive a stress testing scenario.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UgCXYKssEeayv9XxdmMwKQ")]
[Description(@"Classification of the methodology used to derive a stress testing scenario.")]
[DerivedFrom(typeof(ScenarioTypeCode))]
public enum ScenarioType1Code
{
    /// <summary>
    /// Scenario that replays an event that occurred in the past, including antithetic historical scenarios.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_WJzxkassEeayv9XxdmMwKQ")]
    [Description(@"Scenario that replays an event that occurred in the past, including antithetic historical scenarios.")]
    Historical = ScenarioTypeCode.Historical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scenario that is defined by a hypothetical or theoretical event that may happen in the future.
    /// Encoded/decoded by serializers as &quot;HYPT&quot;.
    /// </summary>
    [EnumMember(Value = "HYPT")]
    [IsoId("_WN-f4assEeayv9XxdmMwKQ")]
    [Description(@"Scenario that is defined by a hypothetical or theoretical event that may happen in the future.")]
    Hypothetical = ScenarioTypeCode.Hypothetical, // same ordinal as derivation source for type conversions
    
}
