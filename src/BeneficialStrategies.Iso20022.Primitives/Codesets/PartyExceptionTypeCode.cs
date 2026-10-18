// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for not being able to identify a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TCj94GveEe2Re-GccwOX8g")]
[Description(@"Reason for not being able to identify a party.")]
[Derivations(typeof(PartyExceptionType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PartyExceptionTypeCode>))]
public enum PartyExceptionTypeCode
{
    /// <summary>
    /// Aggregated orders.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_Y_OwoGveEe2Re-GccwOX8g")]
    [Description(@"Aggregated orders")]
    AggregatedOrders,

    /// <summary>
    /// Aggregated orders.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_dGlcQP53Ee-OpdG84aFU1Q")]
    [Description(@"Aggregated orders")]
    AggregatedOrder,

    /// <summary>
    /// Not applicable.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_77Gh8EjTEe-IA5v50ZDLhA")]
    [Description(@"Not applicable.")]
    NotApplicable,

    /// <summary>
    /// Pending allocations.
    /// Encoded/decoded by serializers as &quot;PNAL&quot;.
    /// </summary>
    [EnumMember(Value = "PNAL")]
    [IsoId("_cc8NoGveEe2Re-GccwOX8g")]
    [Description(@"Pending allocations ")]
    PendingAllocations,
}
