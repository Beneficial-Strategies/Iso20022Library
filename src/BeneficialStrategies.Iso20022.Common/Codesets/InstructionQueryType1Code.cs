// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of instruction queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jjvIle5NEeCisYr99QEiWA_173504363")]
[Description(@"Specifies the type of instruction queried.")]
[DerivedFrom(typeof(InstructionQueryTypeCode))]
public enum InstructionQueryType1Code
{
    /// <summary>
    /// Query is performed on settlement transactions.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_jjvIlu5NEeCisYr99QEiWA_351623035")]
    [Description(@"Query is performed on settlement transactions.")]
    SettlementInstruction = InstructionQueryTypeCode.SettlementInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Query is performed on intra-position movements.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_jj4SgO5NEeCisYr99QEiWA_1818771798")]
    [Description(@"Query is performed on intra-position movements.")]
    IntraPositionMovement = InstructionQueryTypeCode.IntraPositionMovement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Query is performed on both settlement transactions and intra-position movements.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_jj4Sge5NEeCisYr99QEiWA_-645449318")]
    [Description(
        @"Query is performed on both settlement transactions and intra-position movements."
    )]
    SettlementAndIntraPosition = InstructionQueryTypeCode.SettlementAndIntraPosition, // same ordinal as derivation source for type conversions
}
