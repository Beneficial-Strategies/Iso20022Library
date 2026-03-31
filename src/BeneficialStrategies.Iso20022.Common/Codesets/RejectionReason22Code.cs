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
[IsoId("_ZjRrEtp-Ed-ak6NoX_4Aeg_-626563856")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason22Code>))]
#endif
public enum RejectionReason22Code
{
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZjRrE9p-Ed-ak6NoX_4Aeg_1018703579")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZjRrFNp-Ed-ak6NoX_4Aeg_-1623636209")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZjRrFdp-Ed-ak6NoX_4Aeg_-1915593947")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZjRrFtp-Ed-ak6NoX_4Aeg_-1737475275")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV2Code.CorporateActionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZjRrF9p-Ed-ak6NoX_4Aeg_21631226")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV2Code.SettlementDateRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZjRrGNp-Ed-ak6NoX_4Aeg_1751297435")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZjRrGdp-Ed-ak6NoX_4Aeg_-610985664")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions
}
