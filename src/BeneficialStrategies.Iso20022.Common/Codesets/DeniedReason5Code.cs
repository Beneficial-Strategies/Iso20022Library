// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_avbVJdp-Ed-ak6NoX_4Aeg_279829805")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(DeniedReasonCode))]
public enum DeniedReason5Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_avbVJtp-Ed-ak6NoX_4Aeg_255864089")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed = DeniedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as &quot;DCAL&quot;.
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_avbVJ9p-Ed-ak6NoX_4Aeg_1813994353")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied = DeniedReasonCode.CallDeniedSinceAlreadyApplied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_avbVKNp-Ed-ak6NoX_4Aeg_1802895576")]
    [Description(
        @"Cancellation request was denied since the instruction has already been cancelled."
    )]
    DeniedSinceAlreadyCancelled = DeniedReasonCode.DeniedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_avbVKdp-Ed-ak6NoX_4Aeg_-554846547")]
    [Description(
        @"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay."
    )]
    DeniedSinceNotAllowed = DeniedReasonCode.DeniedSinceNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_avkfENp-Ed-ak6NoX_4Aeg_421112740")]
    [Description(
        @"Cancellation request was denied because the process of settlement is in progress."
    )]
    DeniedSinceInProgress = DeniedReasonCode.DeniedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as &quot;DREP&quot;.
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_avkfEdp-Ed-ak6NoX_4Aeg_307273674")]
    [Description(@"Cancellation request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded = DeniedReasonCode.DeniedSinceRepoEnded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_avkfEtp-Ed-ak6NoX_4Aeg_247025987")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled = DeniedReasonCode.DeniedSinceAlreadySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_avkfE9p-Ed-ak6NoX_4Aeg_-2110716136")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    InstructionProcessed = DeniedReasonCode.InstructionProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_avkfFNp-Ed-ak6NoX_4Aeg_1169189297")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = DeniedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_avkfFdp-Ed-ak6NoX_4Aeg_-1188552826")]
    [Description(@"Other. See Narrative.")]
    Other = DeniedReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is denied due to a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_avkfFtp-Ed-ak6NoX_4Aeg_-1028010032")]
    [Description(
        @"Execution is denied due to a process linked to the currency of the transaction."
    )]
    ConditionalCurrency = DeniedReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is denied due to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_avkfF9p-Ed-ak6NoX_4Aeg_868526692")]
    [Description(
        @"Execution is denied due to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement = DeniedReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is denied due to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_avkfGNp-Ed-ak6NoX_4Aeg_-1489215431")]
    [Description(@"Execution is denied due to the execution of a process at the registrar.")]
    ConditionalRegistrar = DeniedReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions
}
