// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation agent, as published in an external calculation agent code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCalculationAgent1Code")]
[Description(
    @"Specifies the calculation agent, as published in an external calculation agent code list."
)]
[DerivedFrom(typeof(ExternalCalculationAgentCode))]
public enum ExternalCalculationAgent1Code
{
    /// <summary>
    /// Counterparty side will act.
    /// Encoded/decoded by serializers as &quot;CNTP&quot;.
    /// </summary>
    [EnumMember(Value = "CNTP")]
    [IsoId("_ExternalCalculationAgent1Code_CounterpartySide")]
    [Description(@"Counterparty side will act.")]
    CounterpartySide = ExternalCalculationAgentCode.CounterpartySide,

    /// <summary>
    /// As defined in the ISDA Master Agreement.
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_ExternalCalculationAgent1Code_ISDA")]
    [Description(@"As defined in the ISDA Master Agreement.")]
    ISDA = ExternalCalculationAgentCode.ISDA,

    /// <summary>
    /// Trading side and counterparty side will jointly act.
    /// Encoded/decoded by serializers as &quot;JOIN&quot;.
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_ExternalCalculationAgent1Code_Joint")]
    [Description(@"Trading side and counterparty side will jointly act.")]
    Joint = ExternalCalculationAgentCode.Joint,

    /// <summary>
    /// Trading side will act.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ExternalCalculationAgent1Code_TradingSide")]
    [Description(@"Trading side will act.")]
    TradingSide = ExternalCalculationAgentCode.TradingSide,
}
