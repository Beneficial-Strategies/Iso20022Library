// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rW2RTL3EeKU9IrkkToqcw_118506485")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types."
)]
[DerivedFrom(typeof(DTCCPayoutTypeCode))]
public enum DTCCPayoutType2Code
{
    /// <summary>
    /// Payout consisting of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_1rW2RjL3EeKU9IrkkToqcw_-1192138921")]
    [Description(@"Payout consisting of securities.")]
    Securities = DTCCPayoutTypeCode.Securities, // same ordinal as derivation source for type conversions
}
