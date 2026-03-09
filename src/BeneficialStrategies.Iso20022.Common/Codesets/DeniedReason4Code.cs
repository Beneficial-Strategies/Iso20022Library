// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_avRkI9p-Ed-ak6NoX_4Aeg_1049194931")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(DeniedReasonCode))]
public enum DeniedReason4Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_avRkJNp-Ed-ak6NoX_4Aeg_271179160")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed = DeniedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_avRkJdp-Ed-ak6NoX_4Aeg_714167652")]
    [Description(@"Cancellation request was denied since the instruction has already been cancelled.")]
    DeniedSinceAlreadyCancelled = DeniedReasonCode.DeniedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_avRkJtp-Ed-ak6NoX_4Aeg_-1295789206")]
    [Description(@"Cancellation request was denied because the process of settlement is in progress.")]
    DeniedSinceInProgress = DeniedReasonCode.DeniedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as &quot;DREP&quot;.
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_avRkJ9p-Ed-ak6NoX_4Aeg_118447416")]
    [Description(@"Cancellation request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded = DeniedReasonCode.DeniedSinceRepoEnded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_avRkKNp-Ed-ak6NoX_4Aeg_1767928195")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled = DeniedReasonCode.DeniedSinceAlreadySettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_avbVINp-Ed-ak6NoX_4Aeg_1013178321")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = DeniedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_avbVIdp-Ed-ak6NoX_4Aeg_1002079544")]
    [Description(@"Other. See Narrative.")]
    Other = DeniedReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is denied due to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_avbVItp-Ed-ak6NoX_4Aeg_675012735")]
    [Description(@"Execution is denied due to the execution of a process at the registrar.")]
    ConditionalRegistrar = DeniedReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is denied due to a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_avbVI9p-Ed-ak6NoX_4Aeg_383054997")]
    [Description(@"Execution is denied due to a process linked to the currency of the transaction.")]
    ConditionalCurrency = DeniedReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is denied due to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_avbVJNp-Ed-ak6NoX_4Aeg_561173669")]
    [Description(@"Execution is denied due to the execution of a process of realignment at the issuer CSD.")]
    ConditionalRealignement = DeniedReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions
    
}
