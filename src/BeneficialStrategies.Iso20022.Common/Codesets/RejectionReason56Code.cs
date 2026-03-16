// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ReBJIe6BEeqc-LCjwLsUVg")]
[Description(@"Specifies the reason why the instruction request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason56Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_R3dj4e6BEeqc-LCjwLsUVg")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_R3dj4-6BEeqc-LCjwLsUVg")]
    [Description(
        @"Instruction is rejected since the provided certification is incorrect or incomplete."
    )]
    IncorrectCertification = RejectionReasonV3Code.IncorrectCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_R3dj5e6BEeqc-LCjwLsUVg")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonV3Code.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_R3dj5-6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_R3dj6e6BEeqc-LCjwLsUVg")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_R3dj6-6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_R3dj7e6BEeqc-LCjwLsUVg")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV3Code.LackofSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_R3dj7-6BEeqc-LCjwLsUVg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_R3dj8e6BEeqc-LCjwLsUVg")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonV3Code.Mismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_R3dj8-6BEeqc-LCjwLsUVg")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV3Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_R3dj9e6BEeqc-LCjwLsUVg")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    OptionCancelled = RejectionReasonV3Code.OptionCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_R3dj9-6BEeqc-LCjwLsUVg")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option."
    )]
    OptionInactive = RejectionReasonV3Code.OptionInactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_R3dj-e6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV3Code.OptionNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_R3dj--6BEeqc-LCjwLsUVg")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_R3dj_e6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as &quot;REFT&quot;.
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_R3dj_-6BEeqc-LCjwLsUVg")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities = RejectionReasonV3Code.RefusedByTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_R3dkAe6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_R3dkA-6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as &quot;DQCS&quot;.
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_R3dkBe6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    AmountRejection = RejectionReasonV3Code.AmountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid instructed currency.
    /// Encoded/decoded by serializers as &quot;DQCC&quot;.
    /// </summary>
    [EnumMember(Value = "DQCC")]
    [IsoId("_R3dkB-6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid instructed currency.")]
    CurrencyRejection = RejectionReasonV3Code.CurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.
    /// Encoded/decoded by serializers as &quot;DQAM&quot;.
    /// </summary>
    [EnumMember(Value = "DQAM")]
    [IsoId("_R3dkCe6BEeqc-LCjwLsUVg")]
    [Description(
        @"Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers."
    )]
    InstructionTypeRejection = RejectionReasonV3Code.InstructionTypeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected due to invalid use of the additional round up quantity.
    /// Encoded/decoded by serializers as &quot;IRDQ&quot;.
    /// </summary>
    [EnumMember(Value = "IRDQ")]
    [IsoId("_R3dkC-6BEeqc-LCjwLsUVg")]
    [Description(
        @"Instruction is rejected due to invalid use of the additional round up quantity."
    )]
    InvalidUseRoundUpQuantity = RejectionReasonV3Code.InvalidUseRoundUpQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as &quot;DQBV&quot;.
    /// </summary>
    [EnumMember(Value = "DQBV")]
    [IsoId("_R3dkDe6BEeqc-LCjwLsUVg")]
    [Description(
        @"Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders)."
    )]
    InvalidBidValue = RejectionReasonV3Code.InvalidBidValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as &quot;DQBI&quot;.
    /// </summary>
    [EnumMember(Value = "DQBI")]
    [IsoId("_R3dkD-6BEeqc-LCjwLsUVg")]
    [Description(
        @"Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders)."
    )]
    InvalidBidIncrement = RejectionReasonV3Code.InvalidBidIncrement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, missing or invalid shareholder number.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_R3dkEe6BEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised, missing or invalid shareholder number.")]
    ShareholderNumberRejection = RejectionReasonV3Code.ShareholderNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as &quot;ITAX&quot;.
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("_R3dkE-6BEeqc-LCjwLsUVg")]
    [Description(
        @"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country."
    )]
    IncorrectTaxRate = RejectionReasonV3Code.IncorrectTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_R3dkFe6BEeqc-LCjwLsUVg")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate = RejectionReasonV3Code.InconsistentTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_R3dkF-6BEeqc-LCjwLsUVg")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate = RejectionReasonV3Code.MissingTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid use of solicitation dealer fee indicator.
    /// Encoded/decoded by serializers as &quot;ISOL&quot;.
    /// </summary>
    [EnumMember(Value = "ISOL")]
    [IsoId("_V2wD8e6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid use of solicitation dealer fee indicator.")]
    InvalidSolicitationDealerFeeUse = RejectionReasonV3Code.InvalidSolicitationDealerFeeUse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as &quot;BSTR&quot;.
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("_gKYdoe6GEeqc-LCjwLsUVg")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod = RejectionReasonV3Code.BeforeInstructionPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact information is missing.
    /// Encoded/decoded by serializers as &quot;CTCT&quot;.
    /// </summary>
    [EnumMember(Value = "CTCT")]
    [IsoId("_mgYWYe6GEeqc-LCjwLsUVg")]
    [Description(@"Contact information is missing.")]
    MissingContact = RejectionReasonV3Code.MissingContact, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected due to duplicate business message identifier.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_sCxA4e6GEeqc-LCjwLsUVg")]
    [Description(@"Instruction is rejected due to duplicate business message identifier.")]
    DuplicateInstruction = RejectionReasonV3Code.DuplicateInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect identification is required for cover protect instructions.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_xfyDMe6GEeqc-LCjwLsUVg")]
    [Description(@"Protect identification is required for cover protect instructions.")]
    MissingProtectIdentification = RejectionReasonV3Code.MissingProtectIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No protect privilege for this event.
    /// Encoded/decoded by serializers as &quot;PRON&quot;.
    /// </summary>
    [EnumMember(Value = "PRON")]
    [IsoId("_y-jHQe6GEeqc-LCjwLsUVg")]
    [Description(@"No protect privilege for this event.")]
    NoProtectPrivilege = RejectionReasonV3Code.NoProtectPrivilege, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect date is required for cover protect instructions.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_1C9PAe6GEeqc-LCjwLsUVg")]
    [Description(@"Protect date is required for cover protect instructions.")]
    MissingProtectDate = RejectionReasonV3Code.MissingProtectDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction type is missing or invalid for protect or cover protect instructions.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_4LqFUe6GEeqc-LCjwLsUVg")]
    [Description(
        @"Transaction type is missing or invalid for protect or cover protect instructions."
    )]
    MissingTransactionType = RejectionReasonV3Code.MissingTransactionType, // same ordinal as derivation source for type conversions
}
