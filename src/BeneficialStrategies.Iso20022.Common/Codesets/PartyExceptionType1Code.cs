// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type used for the reason for not being able to identify a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_paPUEGvqEe2Re-GccwOX8g")]
[Description(
    @"Specifies the type used for the reason for not being able to identify a party."
)]
[DerivedFrom(typeof(PartyExceptionTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PartyExceptionType1Code>))]
public enum PartyExceptionType1Code
{
    /// <summary>
    /// Aggregated orders.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_qTCkUWvqEe2Re-GccwOX8g")]
    [Description(@"Aggregated orders")]
    AggregatedOrders = PartyExceptionTypeCode.AggregatedOrders, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending allocations.
    /// Encoded/decoded by serializers as &quot;PNAL&quot;.
    /// </summary>
    [EnumMember(Value = "PNAL")]
    [IsoId("_qYYXUWvqEe2Re-GccwOX8g")]
    [Description(@"Pending allocations ")]
    PendingAllocations = PartyExceptionTypeCode.PendingAllocations, // same ordinal as derivation source for type conversions
}
