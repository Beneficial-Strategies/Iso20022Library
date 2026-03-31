// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of settlement instruction query to be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j4AIZO5NEeCisYr99QEiWA_1321527549")]
[Description(@"Specifies the type of settlement instruction query to be executed.")]
[Derivations(typeof(SettlementQueryType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementQueryTypeCode>))]
#endif
public enum SettlementQueryTypeCode
{
    /// <summary>
    /// Queries settlement instructions based on criteria excluding statuses.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_j4JSUO5NEeCisYr99QEiWA_-2074590614")]
    [Description(@"Queries settlement instructions based on criteria excluding statuses.")]
    Instruction,

    /// <summary>
    /// Queries settlement instructions based on criteria that includes statuses.
    /// Encoded/decoded by serializers as &quot;STTS&quot;.
    /// </summary>
    [EnumMember(Value = "STTS")]
    [IsoId("_j4JSUe5NEeCisYr99QEiWA_965427297")]
    [Description(@"Queries settlement instructions based on criteria that includes statuses.")]
    Status,

    /// <summary>
    /// Queries settlement instructions based on criteria that includes statuses during a period.
    /// Encoded/decoded by serializers as &quot;STPD&quot;.
    /// </summary>
    [EnumMember(Value = "STPD")]
    [IsoId("_j4JSUu5NEeCisYr99QEiWA_-206849825")]
    [Description(
        @"Queries settlement instructions based on criteria that includes statuses during a period."
    )]
    StatusPeriod,
}
