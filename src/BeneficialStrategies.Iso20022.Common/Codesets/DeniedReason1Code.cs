// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azv0eNp-Ed-ak6NoX_4Aeg_1343217133")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(DeniedReasonCode))]
public enum DeniedReason1Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_az5lcNp-Ed-ak6NoX_4Aeg_1343217135")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed = DeniedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as &quot;DCAL&quot;.
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_az5lcdp-Ed-ak6NoX_4Aeg_1343217164")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied = DeniedReasonCode.CallDeniedSinceAlreadyApplied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_az5lctp-Ed-ak6NoX_4Aeg_1343217165")]
    [Description(
        @"Cancellation request was denied since the instruction has already been cancelled."
    )]
    DeniedSinceAlreadyCancelled = DeniedReasonCode.DeniedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_az5lc9p-Ed-ak6NoX_4Aeg_1343217195")]
    [Description(
        @"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay."
    )]
    DeniedSinceNotAllowed = DeniedReasonCode.DeniedSinceNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_az5ldNp-Ed-ak6NoX_4Aeg_1343217196")]
    [Description(
        @"Cancellation request was denied because the process of settlement is in progress."
    )]
    DeniedSinceInProgress = DeniedReasonCode.DeniedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as &quot;DREP&quot;.
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_az5lddp-Ed-ak6NoX_4Aeg_1343217197")]
    [Description(@"Cancellation request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded = DeniedReasonCode.DeniedSinceRepoEnded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_az5ldtp-Ed-ak6NoX_4Aeg_1343217225")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled = DeniedReasonCode.DeniedSinceAlreadySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_az5ld9p-Ed-ak6NoX_4Aeg_1343217226")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    InstructionProcessed = DeniedReasonCode.InstructionProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_az5leNp-Ed-ak6NoX_4Aeg_1343217227")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = DeniedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
}
