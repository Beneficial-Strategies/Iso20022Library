// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_auYMRdp-Ed-ak6NoX_4Aeg_336256115")]
[Description(
    @"States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate."
)]
[Derivations(typeof(GoodTillBookingInstruction1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GoodTillBookingInstructionCode>))]
#endif
public enum GoodTillBookingInstructionCode
{
    /// <summary>
    /// Book out all trades on day of execution.
    /// Encoded/decoded by serializers as &quot;BOEX&quot;.
    /// </summary>
    [EnumMember(Value = "BOEX")]
    [IsoId("_auYMRtp-Ed-ak6NoX_4Aeg_336256132")]
    [Description(@"Book out all trades on day of execution.")]
    BookOnExecutionDay,

    /// <summary>
    /// Accumulate executions until order is filled or expires.
    /// Encoded/decoded by serializers as &quot;ACTE&quot;.
    /// </summary>
    [EnumMember(Value = "ACTE")]
    [IsoId("_auYMR9p-Ed-ak6NoX_4Aeg_336256133")]
    [Description(@"Accumulate executions until order is filled or expires.")]
    AccumulateTillEnd,

    /// <summary>
    /// Accumulate until verbally notified otherwise.
    /// Encoded/decoded by serializers as &quot;ACTT&quot;.
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_auYMSNp-Ed-ak6NoX_4Aeg_336256134")]
    [Description(@"Accumulate until verbally notified otherwise.")]
    AccumulateTillTold,
}
