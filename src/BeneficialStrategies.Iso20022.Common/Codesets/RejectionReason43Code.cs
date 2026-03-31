// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gNlkwFhWEeSewsfsZR0hxA")]
[Description(@"Specifies the reason why the instruction request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason43Code>))]
#endif
public enum RejectionReason43Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_DX1sAVhXEeSewsfsZR0hxA")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_JQPp01hXEeSewsfsZR0hxA")]
    [Description(
        @"Instruction is rejected since the provided certification is incorrect or incomplete."
    )]
    IncorrectCertification = RejectionReasonV2Code.IncorrectCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_MA_TI1hXEeSewsfsZR0hxA")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonV2Code.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_TdYMM1hXEeSewsfsZR0hxA")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV2Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_V54q41hXEeSewsfsZR0hxA")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV2Code.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_bYtEA1hXEeSewsfsZR0hxA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV2Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_cnQh01hXEeSewsfsZR0hxA")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV2Code.LackofSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_dmo7M1hXEeSewsfsZR0hxA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_fMQOI1hXEeSewsfsZR0hxA")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonV2Code.Mismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_h0Xf41hXEeSewsfsZR0hxA")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV2Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_lJ3cE1hXEeSewsfsZR0hxA")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    OptionCancelled = RejectionReasonV2Code.OptionCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_lf4vY1hXEeSewsfsZR0hxA")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option."
    )]
    OptionInactive = RejectionReasonV2Code.OptionInactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_mWMFQ1hXEeSewsfsZR0hxA")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV2Code.OptionNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_m7FiE1hXEeSewsfsZR0hxA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_pFJl41hXEeSewsfsZR0hxA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV2Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as &quot;REFT&quot;.
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_qCv2k1hXEeSewsfsZR0hxA")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities = RejectionReasonV2Code.RefusedByTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_th6FE1hXEeSewsfsZR0hxA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_wDep81hXEeSewsfsZR0hxA")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV2Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
}
