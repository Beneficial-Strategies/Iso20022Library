// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Go2JQf41EeClUvPNHKL9Zw")]
[Description(@"Specifies the reason why a cancellation request sent for the related instruction is pending.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingReason9Code
{
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Go_6Rf41EeClUvPNHKL9Zw")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_Go_6Sf41EeClUvPNHKL9Zw")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonCode.AwaitingConfirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Go_6Tf41EeClUvPNHKL9Zw")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_Go_6Uf41EeClUvPNHKL9Zw")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar = PendingFailingReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_Go_6Vf41EeClUvPNHKL9Zw")]
    [Description(@"Execution is conditional to the execution of a process linked to the currency of the transaction.")]
    ConditionalCurrency = PendingFailingReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_Go_6Wf41EeClUvPNHKL9Zw")]
    [Description(@"Execution is conditional to the execution of a process of realignment at the issuer CSD.")]
    ConditionalRealignement = PendingFailingReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting cancellation of one of the party.
    /// Encoded/decoded by serializers as &quot;CDAC&quot;.
    /// </summary>
    [EnumMember(Value = "CDAC")]
    [IsoId("_PMeU4hqJEeG38P9Gj2JZJw")]
    [Description(@"Awaiting cancellation of one of the party.")]
    ConditionalDeliveryAwaitingCancellation = PendingFailingReasonCode.ConditionalDeliveryAwaitingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as &quot;INBC&quot;.
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("_RjugIhqJEeG38P9Gj2JZJw")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount = PendingFailingReasonCode.IncompleteNumberCount, // same ordinal as derivation source for type conversions
    
}
