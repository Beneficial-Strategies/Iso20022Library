// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZiY6RNp-Ed-ak6NoX_4Aeg_-1381519795")]
[Description(
    @"Standard code to specify the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason17Code
{
    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZiY6Rdp-Ed-ak6NoX_4Aeg_-1119238853")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_ZiY6Rtp-Ed-ak6NoX_4Aeg_-1075834220")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    OptionCancelled = RejectionReasonCode.OptionCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_ZiY6R9p-Ed-ak6NoX_4Aeg_-1008417248")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled = RejectionReasonCode.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_ZiY6SNp-Ed-ak6NoX_4Aeg_-1054709018")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress = RejectionReasonCode.RejectedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZiY6Sdp-Ed-ak6NoX_4Aeg_-1033467088")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonCode.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZiiEMNp-Ed-ak6NoX_4Aeg_-1006685257")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonCode.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised event number or identification (eg corporate action event number, a meeting identification).
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_ZiiEMdp-Ed-ak6NoX_4Aeg_-635430822")]
    [Description(
        @"Unrecognised event number or identification (eg corporate action event number, a meeting identification)."
    )]
    UnrecognizedIdentification = RejectionReasonCode.UnrecognizedIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_ZiiEMtp-Ed-ak6NoX_4Aeg_-606802064")]
    [Description(@"The instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonCode.InstructionIrrevocable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_ZiiEM9p-Ed-ak6NoX_4Aeg_-509830463")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option."
    )]
    OptionInactive = RejectionReasonCode.OptionInactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_ZiiENNp-Ed-ak6NoX_4Aeg_-250320260")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonCode.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_ZiiENdp-Ed-ak6NoX_4Aeg_-219845877")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonCode.LackofSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZiiENtp-Ed-ak6NoX_4Aeg_-193984901")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZiiEN9p-Ed-ak6NoX_4Aeg_-165357767")]
    [Description(@"Other reason.")]
    Other = RejectionReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_ZiiEONp-Ed-ak6NoX_4Aeg_-105329727")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonCode.Mismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_ZiiEOdp-Ed-ak6NoX_4Aeg_-80393311")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonCode.OptionNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_Zir1MNp-Ed-ak6NoX_4Aeg_-51764992")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonCode.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as &quot;REFT&quot;.
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_Zir1Mdp-Ed-ak6NoX_4Aeg_-20364322")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities = RejectionReasonCode.RefusedByTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid or unrecognised safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Zir1Mtp-Ed-ak6NoX_4Aeg_278857830")]
    [Description(@"Instruction contains an invalid or unrecognised safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonCode.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zir1M9p-Ed-ak6NoX_4Aeg_306561127")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference = RejectionReasonCode.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_Zir1NNp-Ed-ak6NoX_4Aeg_-1228012100")]
    [Description(
        @"Instruction is rejected since the provided certification is incorrect or incomplete."
    )]
    IncorrectCertification = RejectionReasonCode.IncorrectCertification, // same ordinal as derivation source for type conversions
}
