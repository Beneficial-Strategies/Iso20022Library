// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a cancellation rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYjKotp-Ed-ak6NoX_4Aeg_-534177110")]
[Description(@"Specifies the reason for a cancellation rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum CancellationRejectedReason1Code
{
    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_bYjKo9p-Ed-ak6NoX_4Aeg_-1041848")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order or transfer has already been executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_bYjKpNp-Ed-ak6NoX_4Aeg_-2116683787")]
    [Description(@"Order or transfer has already been executed and confirmation has been sent.")]
    AlreadyExecuted = RejectedStatusReasonCode.AlreadyExecuted, // same ordinal as derivation source for type conversions
}
