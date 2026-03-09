// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_auYMQdp-Ed-ak6NoX_4Aeg_438323415")]
[Description(@"States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate.")]
[DerivedFrom(typeof(GoodTillBookingInstructionCode))]
public enum GoodTillBookingInstruction1Code
{
    /// <summary>
    /// Book out all trades on day of execution.
    /// Encoded/decoded by serializers as &quot;BOEX&quot;.
    /// </summary>
    [EnumMember(Value = "BOEX")]
    [IsoId("_auYMQtp-Ed-ak6NoX_4Aeg_659969076")]
    [Description(@"Book out all trades on day of execution.")]
    BookOnExecutionDay = GoodTillBookingInstructionCode.BookOnExecutionDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accumulate executions until order is filled or expires.
    /// Encoded/decoded by serializers as &quot;ACTE&quot;.
    /// </summary>
    [EnumMember(Value = "ACTE")]
    [IsoId("_auYMQ9p-Ed-ak6NoX_4Aeg_659969118")]
    [Description(@"Accumulate executions until order is filled or expires.")]
    AccumulateTillEnd = GoodTillBookingInstructionCode.AccumulateTillEnd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accumulate until verbally notified otherwise.
    /// Encoded/decoded by serializers as &quot;ACTT&quot;.
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_auYMRNp-Ed-ak6NoX_4Aeg_659969178")]
    [Description(@"Accumulate until verbally notified otherwise.")]
    AccumulateTillTold = GoodTillBookingInstructionCode.AccumulateTillTold, // same ordinal as derivation source for type conversions
    
}
