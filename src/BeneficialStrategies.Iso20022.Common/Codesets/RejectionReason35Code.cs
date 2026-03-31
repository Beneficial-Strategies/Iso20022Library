// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jWeIoe5NEeCisYr99QEiWA_668020019")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason35Code>))]
#endif
public enum RejectionReason35Code
{
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_jWeIou5NEeCisYr99QEiWA_732299625")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_jWeIo-5NEeCisYr99QEiWA_-329052334")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_jWeIpO5NEeCisYr99QEiWA_-150933662")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_jWnSkO5NEeCisYr99QEiWA_-442891400")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_jWnSke5NEeCisYr99QEiWA_-264772728")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV2Code.SettlementDateRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_jWnSku5NEeCisYr99QEiWA_1213359397")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV2Code.NotFoundRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jWnSk-5NEeCisYr99QEiWA_-1326124687")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as &quot;INVM&quot;.
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_AzkQYnglEeGqN5NokjUPnw_-1651616515")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest = RejectionReasonV2Code.InvalidModificationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as &quot;INVL&quot;.
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_AzkQY3glEeGqN5NokjUPnw_-2048316852")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink = RejectionReasonV2Code.InvalidLink, // same ordinal as derivation source for type conversions
}
