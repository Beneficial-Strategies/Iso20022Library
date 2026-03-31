// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation agent, as published in an external calculation agent code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCalculationAgentCode")]
[Description(
    @"Specifies the calculation agent, as published in an external calculation agent code list."
)]
public enum ExternalCalculationAgentCode
{
    /// <summary>
    /// Counterparty side will act.
    /// Encoded/decoded by serializers as &quot;CNTP&quot;.
    /// </summary>
    [EnumMember(Value = "CNTP")]
    [IsoId("_ExternalCalculationAgentCode_CounterpartySide")]
    [Description(@"Counterparty side will act.")]
    CounterpartySide,

    /// <summary>
    /// As defined in the ISDA Master Agreement.
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_ExternalCalculationAgentCode_ISDA")]
    [Description(@"As defined in the ISDA Master Agreement.")]
    ISDA,

    /// <summary>
    /// Trading side and counterparty side will jointly act.
    /// Encoded/decoded by serializers as &quot;JOIN&quot;.
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_ExternalCalculationAgentCode_Joint")]
    [Description(@"Trading side and counterparty side will jointly act.")]
    Joint,

    /// <summary>
    /// Trading side will act.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ExternalCalculationAgentCode_TradingSide")]
    [Description(@"Trading side will act.")]
    TradingSide,
}
