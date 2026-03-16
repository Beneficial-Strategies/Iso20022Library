// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of settlement instruction query to be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j4AIYO5NEeCisYr99QEiWA_-671204936")]
[Description(@"Specifies the type of settlement instruction query to be executed.")]
[DerivedFrom(typeof(SettlementQueryTypeCode))]
public enum SettlementQueryType1Code
{
    /// <summary>
    /// Queries settlement instructions based on criteria excluding statuses.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_j4AIYe5NEeCisYr99QEiWA_-1731179192")]
    [Description(@"Queries settlement instructions based on criteria excluding statuses.")]
    Instruction = SettlementQueryTypeCode.Instruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Queries settlement instructions based on criteria that includes statuses.
    /// Encoded/decoded by serializers as &quot;STTS&quot;.
    /// </summary>
    [EnumMember(Value = "STTS")]
    [IsoId("_j4AIYu5NEeCisYr99QEiWA_-1742277969")]
    [Description(@"Queries settlement instructions based on criteria that includes statuses.")]
    Status = SettlementQueryTypeCode.Status, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Queries settlement instructions based on criteria that includes statuses during a period.
    /// Encoded/decoded by serializers as &quot;STPD&quot;.
    /// </summary>
    [EnumMember(Value = "STPD")]
    [IsoId("_j4AIY-5NEeCisYr99QEiWA_-820114659")]
    [Description(
        @"Queries settlement instructions based on criteria that includes statuses during a period."
    )]
    StatusPeriod = SettlementQueryTypeCode.StatusPeriod, // same ordinal as derivation source for type conversions
}
