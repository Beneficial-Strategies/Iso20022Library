// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Standard code to specify.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z-QW4Np-Ed-ak6NoX_4Aeg_2142368384")]
[Description(@"Standard code to specify.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum PendingCancellationReason4Code
{
    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Z-QW4dp-Ed-ak6NoX_4Aeg_-2080565714")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Z-QW4tp-Ed-ak6NoX_4Aeg_-2052858643")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonCode.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Z-QW49p-Ed-ak6NoX_4Aeg_-1791501706")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Z-QW5Np-Ed-ak6NoX_4Aeg_-1763795962")]
    [Description(@"Other reason.")]
    Other = RejectionReasonCode.Other, // same ordinal as derivation source for type conversions
}
