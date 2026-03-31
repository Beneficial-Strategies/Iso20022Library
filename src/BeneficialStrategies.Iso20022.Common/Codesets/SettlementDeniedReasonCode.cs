// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SKYhDlhcEeS8HfHHd4stCA")]
[Description(@"Specifies the denied reason.")]
[Derivations(typeof(DeniedReason7Code), typeof(DeniedReason6Code))]
public enum SettlementDeniedReasonCode
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_SKYhE1hcEeS8HfHHd4stCA")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as &quot;DCAL&quot;.
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_SKYhFlhcEeS8HfHHd4stCA")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied,

    /// <summary>
    /// Request was denied since the instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_SKYhGFhcEeS8HfHHd4stCA")]
    [Description(@"Request was denied since the instruction has been cancelled.")]
    DeniedSinceCancelled,

    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_SKYhD1hcEeS8HfHHd4stCA")]
    [Description(
        @"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay."
    )]
    DeniedSinceNotAllowed,

    /// <summary>
    /// Request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_SKYhFVhcEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the process of settlement is in progress.")]
    DeniedSinceInProgress,

    /// <summary>
    /// Request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as &quot;DREP&quot;.
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_SKYhGVhcEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded,

    /// <summary>
    /// Request was denied because the instruction was settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_SKYhF1hcEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the instruction was settled.")]
    DeniedSinceSettled,

    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_SKYhG1hcEeS8HfHHd4stCA")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    InstructionProcessed,

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_SKYhEVhcEeS8HfHHd4stCA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_SKYhElhcEeS8HfHHd4stCA")]
    [Description(@"Other. See Narrative.")]
    Other,

    /// <summary>
    /// Execution is denied due to a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_SKYhFFhcEeS8HfHHd4stCA")]
    [Description(
        @"Execution is denied due to a process linked to the currency of the transaction."
    )]
    ConditionalCurrency,

    /// <summary>
    /// Execution is denied due to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_SKYhEFhcEeS8HfHHd4stCA")]
    [Description(
        @"Execution is denied due to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement,

    /// <summary>
    /// Execution is denied due to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_SKYhGlhcEeS8HfHHd4stCA")]
    [Description(@"Execution is denied due to the execution of a process at the registrar.")]
    ConditionalRegistrar,
}
