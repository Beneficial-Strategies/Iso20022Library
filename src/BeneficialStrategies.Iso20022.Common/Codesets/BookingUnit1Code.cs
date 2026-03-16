// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Description of the method used to book single or grouped executions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VuwQktp-Ed-ak6NoX_4Aeg_-2003409419")]
[Description(@"Description of the method used to book single or grouped executions.")]
[DerivedFrom(typeof(BookingUnitCode))]
public enum BookingUnit1Code
{
    /// <summary>
    /// Each partial execution is a bookable unit.
    /// Encoded/decoded by serializers as &quot;EACP&quot;.
    /// </summary>
    [EnumMember(Value = "EACP")]
    [IsoId("_VuwQk9p-Ed-ak6NoX_4Aeg_-1874118380")]
    [Description(@"Each partial execution is a bookable unit.")]
    EachPartial = BookingUnitCode.EachPartial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Aggregate partial executions on this order, and book one trade per order.
    /// Encoded/decoded by serializers as &quot;AGGP&quot;.
    /// </summary>
    [EnumMember(Value = "AGGP")]
    [IsoId("_VuwQlNp-Ed-ak6NoX_4Aeg_-1871346287")]
    [Description(@"Aggregate partial executions on this order, and book one trade per order.")]
    AggregatePartial = BookingUnitCode.AggregatePartial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Aggregate executions for this symbol, side and settlement date.
    /// Encoded/decoded by serializers as &quot;AGGE&quot;.
    /// </summary>
    [EnumMember(Value = "AGGE")]
    [IsoId("_VuwQldp-Ed-ak6NoX_4Aeg_-1861189086")]
    [Description(@"Aggregate executions for this symbol, side and settlement date.")]
    AggregateExecutions = BookingUnitCode.AggregateExecutions, // same ordinal as derivation source for type conversions
}
