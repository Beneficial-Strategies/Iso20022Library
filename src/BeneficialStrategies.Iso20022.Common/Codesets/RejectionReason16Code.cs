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
[IsoId("_ZhMndNp-Ed-ak6NoX_4Aeg_-1511478406")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason16Code>))]
#endif
public enum RejectionReason16Code
{
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ZhMnddp-Ed-ak6NoX_4Aeg_133789029")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV2Code.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZhMndtp-Ed-ak6NoX_4Aeg_1786416537")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZhMnd9p-Ed-ak6NoX_4Aeg_1494458799")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV2Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZhMneNp-Ed-ak6NoX_4Aeg_1672577471")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZhMnedp-Ed-ak6NoX_4Aeg_-863283324")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed =
        RejectionReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZhVxYNp-Ed-ak6NoX_4Aeg_789344184")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV2Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZhVxYdp-Ed-ak6NoX_4Aeg_-1860355677")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV2Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as &quot;DADR&quot;.
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_ZhVxYtp-Ed-ak6NoX_4Aeg_-207728169")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection = RejectionReasonV2Code.AddressDetailsRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_ZhVxY9p-Ed-ak6NoX_4Aeg_-499685907")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonV2Code.InstructionIrrevocable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_ZhVxZNp-Ed-ak6NoX_4Aeg_-321567235")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    OptionCancelled = RejectionReasonV2Code.OptionCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_ZhVxZdp-Ed-ak6NoX_4Aeg_1437539266")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option."
    )]
    OptionInactive = RejectionReasonV2Code.OptionInactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_ZhfiYNp-Ed-ak6NoX_4Aeg_-1496758260")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonV2Code.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as &quot;REFT&quot;.
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_ZhfiYdp-Ed-ak6NoX_4Aeg_440466913")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities = RejectionReasonV2Code.RefusedByTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZhfiYtp-Ed-ak6NoX_4Aeg_2093094421")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RejectionReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZhfiY9p-Ed-ak6NoX_4Aeg_1801136683")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_ZhfiZNp-Ed-ak6NoX_4Aeg_1979255355")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV2Code.LackofSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZhfiZdp-Ed-ak6NoX_4Aeg_-556605440")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_ZhfiZtp-Ed-ak6NoX_4Aeg_1173060769")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonV2Code.Mismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_ZhfiZ9p-Ed-ak6NoX_4Aeg_881103031")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV2Code.OptionNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZhfiaNp-Ed-ak6NoX_4Aeg_1059221703")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonV2Code.SettlementAmountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_Zhfiadp-Ed-ak6NoX_4Aeg_-1476639092")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV2Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_ZhpTYNp-Ed-ak6NoX_4Aeg_-1435916625")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled = RejectionReasonV2Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_ZhpTYdp-Ed-ak6NoX_4Aeg_-1727874363")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress = RejectionReasonV2Code.RejectedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_ZhpTYtp-Ed-ak6NoX_4Aeg_-1549755691")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV2Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing statutes or commercial register or other legal documents.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_ZhpTY9p-Ed-ak6NoX_4Aeg_209350810")]
    [Description(@"Missing statutes or commercial register or other legal documents.")]
    MissingStatutes = RejectionReasonV2Code.MissingStatutes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_ZhpTZNp-Ed-ak6NoX_4Aeg_1861978318")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    NotStampedOrSigned = RejectionReasonV2Code.NotStampedOrSigned, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration request does not have a valid signature of the owner of the financial instrument.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_ZhpTZdp-Ed-ak6NoX_4Aeg_1570020580")]
    [Description(
        @"Registration request does not have a valid signature of the owner of the financial instrument."
    )]
    InvalidSignature = RejectionReasonV2Code.InvalidSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid shareholder number.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_ZhpTZtp-Ed-ak6NoX_4Aeg_1748139252")]
    [Description(@"Unrecognised or invalid shareholder number.")]
    ShareholderNumberRejection = RejectionReasonV2Code.ShareholderNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZhpTZ9p-Ed-ak6NoX_4Aeg_-787721543")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity = RejectionReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZhpTaNp-Ed-ak6NoX_4Aeg_864905965")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch = RejectionReasonV2Code.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing legal power for transfer.
    /// Encoded/decoded by serializers as &quot;MLEG&quot;.
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("_ZhpTadp-Ed-ak6NoX_4Aeg_572948227")]
    [Description(@"Missing legal power for transfer.")]
    MissingLegalPower = RejectionReasonV2Code.MissingLegalPower, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ZhpTatp-Ed-ak6NoX_4Aeg_751066899")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch."
    )]
    ProcessingBatchRejection = RejectionReasonV2Code.ProcessingBatchRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZhydUNp-Ed-ak6NoX_4Aeg_-1784793896")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RejectionReasonV2Code.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZhydUdp-Ed-ak6NoX_4Aeg_-132166388")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZhydUtp-Ed-ak6NoX_4Aeg_-424124126")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as &quot;OWNT&quot;.
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_ZhydU9p-Ed-ak6NoX_4Aeg_1513101047")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection = RejectionReasonV2Code.TypeOfOwnershipRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_ZhydVNp-Ed-ak6NoX_4Aeg_-1129238741")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV2Code.NotFoundRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZhydVdp-Ed-ak6NoX_4Aeg_-1421196479")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity = RejectionReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.
    /// Encoded/decoded by serializers as &quot;REQW&quot;.
    /// </summary>
    [EnumMember(Value = "REQW")]
    [IsoId("_ZhydVtp-Ed-ak6NoX_4Aeg_-1243077807")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar."
    )]
    WrongRegistrationRequest = RejectionReasonV2Code.WrongRegistrationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZhydV9p-Ed-ak6NoX_4Aeg_516028694")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection = RejectionReasonV2Code.TaxStatusRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZhydWNp-Ed-ak6NoX_4Aeg_-2126311094")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RejectionReasonV2Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ZhydWdp-Ed-ak6NoX_4Aeg_1876698464")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RejectionReasonV2Code.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Zh8OUNp-Ed-ak6NoX_4Aeg_2054817136")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RejectionReasonV2Code.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration reason indicated is not correct.
    /// Encoded/decoded by serializers as &quot;RREA&quot;.
    /// </summary>
    [EnumMember(Value = "RREA")]
    [IsoId("_Zh8OUdp-Ed-ak6NoX_4Aeg_-481043659")]
    [Description(@"Registration reason indicated is not correct.")]
    DisagreementInRegistrationReason = RejectionReasonV2Code.DisagreementInRegistrationReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is missing.
    /// Encoded/decoded by serializers as &quot;REQM&quot;.
    /// </summary>
    [EnumMember(Value = "REQM")]
    [IsoId("_Zh8OUtp-Ed-ak6NoX_4Aeg_1171583849")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is missing."
    )]
    MissingRegistrationRequest = RejectionReasonV2Code.MissingRegistrationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Zh8OU9p-Ed-ak6NoX_4Aeg_879626111")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RejectionReasonV2Code.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Zh8OVNp-Ed-ak6NoX_4Aeg_1057744783")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RejectionReasonV2Code.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Zh8OVdp-Ed-ak6NoX_4Aeg_-1478116012")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection = RejectionReasonV2Code.SettlementSystemMethodRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Zh8OVtp-Ed-ak6NoX_4Aeg_174511496")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectionReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Zh8OV9p-Ed-ak6NoX_4Aeg_-117446242")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV2Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Zh8OWNp-Ed-ak6NoX_4Aeg_1819778931")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_Zh8OWdp-Ed-ak6NoX_4Aeg_-822560857")]
    [Description(
        @"Unrecognised or invalid service level agreement pre-agreed narrative information."
    )]
    NarrativeInformationRejection = RejectionReasonV2Code.NarrativeInformationRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as &quot;ICOL&quot;.
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_Zh8OWtp-Ed-ak6NoX_4Aeg_-936399923")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral = RejectionReasonV2Code.InsufficientCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as &quot;BPAR&quot;.
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_ZiFYQNp-Ed-ak6NoX_4Aeg_822706578")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection = RejectionReasonV2Code.BusinessPartnerNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as &quot;BREF&quot;.
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_ZiFYQdp-Ed-ak6NoX_4Aeg_-1819633210")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection = RejectionReasonV2Code.BankReferenceNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_ZiFYQtp-Ed-ak6NoX_4Aeg_-2111590948")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection = RejectionReasonV2Code.TypeOfOrderRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZiFYQ9p-Ed-ak6NoX_4Aeg_-1933472276")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV2Code.CorporateActionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZiFYRNp-Ed-ak6NoX_4Aeg_-174365775")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem = RejectionReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_ZiFYRdp-Ed-ak6NoX_4Aeg_1478261733")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection = RejectionReasonV2Code.CommercializationContractRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as &quot;CONL&quot;.
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_ZiFYRtp-Ed-ak6NoX_4Aeg_1186303995")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded = RejectionReasonV2Code.ConcentrationLimitExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_ZiFYR9p-Ed-ak6NoX_4Aeg_1364422667")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure = RejectionReasonV2Code.UnknownDealExposure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZiFYSNp-Ed-ak6NoX_4Aeg_-1171438128")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV2Code.SettlementDateRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ZiFYSdp-Ed-ak6NoX_4Aeg_189231642")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount = RejectionReasonV2Code.DisagreeWithCallAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as &quot;DISE&quot;.
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_ZiPJQNp-Ed-ak6NoX_4Aeg_367350314")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount = RejectionReasonV2Code.DisagreeWithExposureAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disagreement between the data on the registration request and the order.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_ZiPJQdp-Ed-ak6NoX_4Aeg_2126456815")]
    [Description(@"Disagreement between the data on the registration request and the order.")]
    RegistrationRequestDataAndOrderRejection =
        RejectionReasonV2Code.RegistrationRequestDataAndOrderRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_ZiPJQtp-Ed-ak6NoX_4Aeg_-515882973")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection = RejectionReasonV2Code.FeeCommissionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZiPJQ9p-Ed-ak6NoX_4Aeg_-629722039")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonV2Code.SettlementTransactionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ZiPJRNp-Ed-ak6NoX_4Aeg_1129384462")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonV2Code.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ZiPJRdp-Ed-ak6NoX_4Aeg_-1512955326")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection = RejectionReasonV2Code.VariableRateSupportRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ZiPJRtp-Ed-ak6NoX_4Aeg_2046998221")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping = RejectionReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ZiPJR9p-Ed-ak6NoX_4Aeg_1299808841")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty = RejectionReasonV2Code.LackOfStampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZiPJSNp-Ed-ak6NoX_4Aeg_306486824")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RejectionReasonV2Code.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZiPJSdp-Ed-ak6NoX_4Aeg_617520497")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2 = RejectionReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZiY6QNp-Ed-ak6NoX_4Aeg_-336051919")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1 = RejectionReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZiY6Qdp-Ed-ak6NoX_4Aeg_-449890985")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository = RejectionReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZiY6Qtp-Ed-ak6NoX_4Aeg_-1725833639")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZiY6Q9p-Ed-ak6NoX_4Aeg_-1400716132")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3 = RejectionReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
}
