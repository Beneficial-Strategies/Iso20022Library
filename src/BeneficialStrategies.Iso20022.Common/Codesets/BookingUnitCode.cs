// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Description of the method used to book single or grouped executions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bU-SNtp-Ed-ak6NoX_4Aeg_335335556")]
[Description(@"Description of the method used to book single or grouped executions.")]
[Derivations(typeof(BookingUnit1Code))]
public enum BookingUnitCode
{
    /// <summary>
    /// Each partial execution is a bookable unit.
    /// Encoded/decoded by serializers as &quot;EACP&quot;.
    /// </summary>
    [EnumMember(Value = "EACP")]
    [IsoId("_bU-SN9p-Ed-ak6NoX_4Aeg_335335557")]
    [Description(@"Each partial execution is a bookable unit.")]
    EachPartial,

    /// <summary>
    /// Aggregate partial executions on this order, and book one trade per order.
    /// Encoded/decoded by serializers as &quot;AGGP&quot;.
    /// </summary>
    [EnumMember(Value = "AGGP")]
    [IsoId("_bVIDMNp-Ed-ak6NoX_4Aeg_335335558")]
    [Description(@"Aggregate partial executions on this order, and book one trade per order.")]
    AggregatePartial,

    /// <summary>
    /// Aggregate executions for this symbol, side and settlement date.
    /// Encoded/decoded by serializers as &quot;AGGE&quot;.
    /// </summary>
    [EnumMember(Value = "AGGE")]
    [IsoId("_bVIDMdp-Ed-ak6NoX_4Aeg_335335559")]
    [Description(@"Aggregate executions for this symbol, side and settlement date.")]
    AggregateExecutions,
}
