// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the request has a rejected or repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZjbcF9p-Ed-ak6NoX_4Aeg_-1383112473")]
[Description(@"Specifies the reason why the request has a rejected or repair status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason24Code>))]
#endif
public enum RejectionReason24Code
{
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZjbcGNp-Ed-ak6NoX_4Aeg_1066393063")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZjlNENp-Ed-ak6NoX_4Aeg_1066393115")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV2Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZjlNEdp-Ed-ak6NoX_4Aeg_1066393158")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZjlNEtp-Ed-ak6NoX_4Aeg_1481977131")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZjlNE9p-Ed-ak6NoX_4Aeg_-1967966501")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZjlNFNp-Ed-ak6NoX_4Aeg_-1184235378")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_ZjlNFdp-Ed-ak6NoX_4Aeg_-66977480")]
    [Description(
        @"Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned."
    )]
    InvalidRequest = RejectionReasonV2Code.InvalidRequest, // same ordinal as derivation source for type conversions
}
