// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_28LGcFhfEeS8HfHHd4stCA")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(SettlementDeniedReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DeniedReason7Code>))]
#endif
public enum DeniedReason7Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_89fvsVhfEeS8HfHHd4stCA")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed = SettlementDeniedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as &quot;DCAL&quot;.
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_9KvhgVhfEeS8HfHHd4stCA")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied = SettlementDeniedReasonCode.CallDeniedSinceAlreadyApplied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is denied due to a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_-CYUIVhfEeS8HfHHd4stCA")]
    [Description(
        @"Execution is denied due to a process linked to the currency of the transaction."
    )]
    ConditionalCurrency = SettlementDeniedReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is denied due to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_-lV3QVhfEeS8HfHHd4stCA")]
    [Description(
        @"Execution is denied due to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement = SettlementDeniedReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is denied due to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_-zoK4VhfEeS8HfHHd4stCA")]
    [Description(@"Execution is denied due to the execution of a process at the registrar.")]
    ConditionalRegistrar = SettlementDeniedReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request was denied since the instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("__DGKQVhfEeS8HfHHd4stCA")]
    [Description(@"Request was denied since the instruction has been cancelled.")]
    DeniedSinceCancelled = SettlementDeniedReasonCode.DeniedSinceCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("__iyW8VhfEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the process of settlement is in progress.")]
    DeniedSinceInProgress = SettlementDeniedReasonCode.DeniedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("__0WBAVhfEeS8HfHHd4stCA")]
    [Description(
        @"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay."
    )]
    DeniedSinceNotAllowed = SettlementDeniedReasonCode.DeniedSinceNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as &quot;DREP&quot;.
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_AH-usVhgEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded = SettlementDeniedReasonCode.DeniedSinceRepoEnded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request was denied because the instruction was settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_Atw8UVhgEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the instruction was settled.")]
    DeniedSinceSettled = SettlementDeniedReasonCode.DeniedSinceSettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_BRxoUVhgEeS8HfHHd4stCA")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    InstructionProcessed = SettlementDeniedReasonCode.InstructionProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_BblroVhgEeS8HfHHd4stCA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = SettlementDeniedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Bj7IQVhgEeS8HfHHd4stCA")]
    [Description(@"Other. See Narrative.")]
    Other = SettlementDeniedReasonCode.Other, // same ordinal as derivation source for type conversions
}
