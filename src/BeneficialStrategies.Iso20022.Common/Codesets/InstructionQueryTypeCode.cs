// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of instruction queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jj4Sgu5NEeCisYr99QEiWA_1468427888")]
[Description(@"Specifies the type of instruction queried.")]
[Derivations(typeof(InstructionQueryType1Code))]
public enum InstructionQueryTypeCode
{
    /// <summary>
    /// Query is performed on settlement transactions.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_jj4Sg-5NEeCisYr99QEiWA_-977223942")]
    [Description(@"Query is performed on settlement transactions.")]
    SettlementInstruction,

    /// <summary>
    /// Query is performed on intra-position movements.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_jj4ShO5NEeCisYr99QEiWA_-1633617554")]
    [Description(@"Query is performed on intra-position movements.")]
    IntraPositionMovement,

    /// <summary>
    /// Query is performed on both settlement transactions and intra-position movements.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_jkCDgO5NEeCisYr99QEiWA_298522406")]
    [Description(
        @"Query is performed on both settlement transactions and intra-position movements."
    )]
    SettlementAndIntraPosition,
}
