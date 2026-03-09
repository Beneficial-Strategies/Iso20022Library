// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_avkfGdp-Ed-ak6NoX_4Aeg_-135680371")]
[Description(@"Specifies the denied reason.")]
[Derivations(typeof(DeniedReason3Code),typeof(DeniedReason4Code),typeof(DeniedReason2Code),typeof(DeniedReason5Code),typeof(DeniedReason1Code))]
public enum DeniedReasonCode
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_avuQENp-Ed-ak6NoX_4Aeg_-249519437")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as &quot;DCAL&quot;.
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_avuQEdp-Ed-ak6NoX_4Aeg_-1424710462")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied,
    
    /// <summary>
    /// Cancellation request was denied since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_avuQEtp-Ed-ak6NoX_4Aeg_-2129825077")]
    [Description(@"Cancellation request was denied since the instruction has already been cancelled.")]
    DeniedSinceAlreadyCancelled,
    
    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_avuQE9p-Ed-ak6NoX_4Aeg_-484557642")]
    [Description(@"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.")]
    DeniedSinceNotAllowed,
    
    /// <summary>
    /// Cancellation request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_avuQFNp-Ed-ak6NoX_4Aeg_1054230800")]
    [Description(@"Cancellation request was denied because the process of settlement is in progress.")]
    DeniedSinceInProgress,
    
    /// <summary>
    /// Cancellation request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as &quot;DREP&quot;.
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_avuQFdp-Ed-ak6NoX_4Aeg_-120960225")]
    [Description(@"Cancellation request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded,
    
    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_avuQFtp-Ed-ak6NoX_4Aeg_-826074840")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled,
    
    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_avuQF9p-Ed-ak6NoX_4Aeg_819192595")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    InstructionProcessed,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_avuQGNp-Ed-ak6NoX_4Aeg_-1936986259")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_av4BENp-Ed-ak6NoX_4Aeg_867114818")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Execution is denied due to a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_av4BEdp-Ed-ak6NoX_4Aeg_1439058584")]
    [Description(@"Execution is denied due to a process linked to the currency of the transaction.")]
    ConditionalCurrency,
    
    /// <summary>
    /// Execution is denied due to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_av4BEtp-Ed-ak6NoX_4Aeg_150028493")]
    [Description(@"Execution is denied due to the execution of a process of realignment at the issuer CSD.")]
    ConditionalRealignement,
    
    /// <summary>
    /// Execution is denied due to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_av4BE9p-Ed-ak6NoX_4Aeg_-668925188")]
    [Description(@"Execution is denied due to the execution of a process at the registrar.")]
    ConditionalRegistrar,
    
}
