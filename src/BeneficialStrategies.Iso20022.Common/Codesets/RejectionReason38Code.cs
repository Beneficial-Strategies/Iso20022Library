// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the securities financing instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2K2fwSwrEeOEV5XHD-BKpw")]
[Description(
    @"Specifies the reason why the securities financing instruction has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason38Code
{
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_2kJJgSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_2kJJgywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV2Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_2kJJhSwrEeOEV5XHD-BKpw")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_2kJJhywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV2Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_2kJJiSwrEeOEV5XHD-BKpw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_2kJJiywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_2kJJjSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_2kJJjywrEeOEV5XHD-BKpw")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectionReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_2kJJkSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_2kJJkywrEeOEV5XHD-BKpw")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed =
        RejectionReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_2kJJlSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV2Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_2kJJlywrEeOEV5XHD-BKpw")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RejectionReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_2kJJmSwrEeOEV5XHD-BKpw")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_2kJJmywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonV2Code.SettlementAmountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_2kJJnSwrEeOEV5XHD-BKpw")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity = RejectionReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_2kJJnywrEeOEV5XHD-BKpw")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch."
    )]
    ProcessingBatchRejection = RejectionReasonV2Code.ProcessingBatchRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_2kJJoSwrEeOEV5XHD-BKpw")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity = RejectionReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_2kJJoywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection = RejectionReasonV2Code.TaxStatusRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_2kJJpSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection = RejectionReasonV2Code.SettlementSystemMethodRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_2kJJpywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV2Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_2kJJqSwrEeOEV5XHD-BKpw")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV2Code.CorporateActionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_2kJJqywrEeOEV5XHD-BKpw")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem = RejectionReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_2kJJrSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV2Code.SettlementDateRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_2kJJrywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonV2Code.SettlementTransactionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_2kJJsSwrEeOEV5XHD-BKpw")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty = RejectionReasonV2Code.LackOfStampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_2kJJsywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RejectionReasonV2Code.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_2kJJtSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RejectionReasonV2Code.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_2kJJtywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonV2Code.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_2kJJuSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection = RejectionReasonV2Code.VariableRateSupportRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_2kJJuywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RejectionReasonV2Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_2kJJvSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RejectionReasonV2Code.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_2kJJvywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RejectionReasonV2Code.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_2kJJwSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RejectionReasonV2Code.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_2kJJwywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RejectionReasonV2Code.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_2kJJxSwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1 = RejectionReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_2kJJxywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping = RejectionReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_2kJJySwrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2 = RejectionReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_2kJJyywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository = RejectionReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2kJJzSwrEeOEV5XHD-BKpw")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_2kJJzywrEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3 = RejectionReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_iis_ASwsEeOEV5XHD-BKpw")]
    [Description(
        @"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act."
    )]
    InvalidInvestorParty = RejectionReasonV2Code.InvalidInvestorParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.
    /// Encoded/decoded by serializers as &quot;PLIS&quot;.
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_jubyUSwsEeOEV5XHD-BKpw")]
    [Description(
        @"Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied."
    )]
    PlaceOfListing = RejectionReasonV2Code.PlaceOfListing, // same ordinal as derivation source for type conversions
}
