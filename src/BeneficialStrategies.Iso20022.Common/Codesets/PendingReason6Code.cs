// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aDBiINp-Ed-ak6NoX_4Aeg_649445219")]
[Description(
    @"Specifies the reason why a cancellation request sent for the related instruction is pending."
)]
[DerivedFrom(typeof(PendingFailingReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PendingReason6Code>))]
#endif
public enum PendingReason6Code
{
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_aDBiIdp-Ed-ak6NoX_4Aeg_-2000254642")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_aDBiItp-Ed-ak6NoX_4Aeg_-347627134")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonCode.AwaitingConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aDBiI9p-Ed-ak6NoX_4Aeg_1188062474")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_aDBiJNp-Ed-ak6NoX_4Aeg_-251565728")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar = PendingFailingReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_aDBiJdp-Ed-ak6NoX_4Aeg_-543523466")]
    [Description(
        @"Execution is conditional to the execution of a process linked to the currency of the transaction."
    )]
    ConditionalCurrency = PendingFailingReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_aDBiJtp-Ed-ak6NoX_4Aeg_-365404794")]
    [Description(
        @"Execution is conditional to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement = PendingFailingReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions
}
