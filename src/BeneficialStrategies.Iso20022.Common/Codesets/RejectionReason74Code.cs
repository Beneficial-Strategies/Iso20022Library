// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unrecognised or invalid depository.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5KNFmCtWEeyhipY4f42fZQ")]
[Description(@"Unrecognised or invalid depository.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason74Code>))]
#endif
public enum RejectionReason74Code
{
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_7t3DMStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_7t3DMytYEeyF-PUIGuhxvA")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_7t3DNStYEeyF-PUIGuhxvA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_7t3DNytYEeyF-PUIGuhxvA")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV3Code.NotFoundRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_7t3DOStYEeyF-PUIGuhxvA")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV3Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_7t3DOytYEeyF-PUIGuhxvA")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch = RejectionReasonV3Code.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_7t3DPStYEeyF-PUIGuhxvA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
}
