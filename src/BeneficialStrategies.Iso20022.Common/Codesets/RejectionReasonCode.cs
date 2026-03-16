// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZmQtp9p-Ed-ak6NoX_4Aeg_1726381602")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[Derivations(
    typeof(RejectionReason9Code),
    typeof(RejectionReason12Code),
    typeof(RejectionReason4Code),
    typeof(RejectionReason7Code),
    typeof(RejectionReason15Code),
    typeof(PendingCancellationReason4Code),
    typeof(RejectionReason8Code),
    typeof(RejectionReason19Code),
    typeof(RejectionReason11Code),
    typeof(RejectionReason14Code),
    typeof(RejectionReason1Code),
    typeof(RejectionReason28Code),
    typeof(RejectionReason18Code),
    typeof(RejectionReason20Code),
    typeof(RejectionReason3Code),
    typeof(RejectionReason10Code),
    typeof(RejectionReason45Code),
    typeof(RejectionReason13Code),
    typeof(RejectionReason5Code),
    typeof(RejectionReason17Code),
    typeof(RejectionReason2Code),
    typeof(RejectionReason6Code)
)]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum RejectionReasonCode
{
    /// <summary>
    /// Unrecognised or invalid closing closing amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("__7wOoNojEeC60axPepSq7g_1546871580")]
    [Description(@"Unrecognised or invalid closing closing amount.")]
    ClosingTransactionAmount,

    /// <summary>
    /// Market member executed the order exceeding the requested quantity.
    /// Encoded/decoded by serializers as &quot;TQHI&quot;.
    /// </summary>
    [EnumMember(Value = "TQHI")]
    [IsoId("__75_oNojEeC60axPepSq7g_-646023337")]
    [Description(@"Market member executed the order exceeding the requested quantity.")]
    TradedQuantityHigherThanOriginalOrderQuantity,

    /// <summary>
    /// The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown.
    /// Encoded/decoded by serializers as &quot;TNIU&quot;.
    /// </summary>
    [EnumMember(Value = "TNIU")]
    [IsoId("__75_odojEeC60axPepSq7g_-1383228781")]
    [Description(
        @"The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown."
    )]
    TransactionNoticeIDUnknown,

    /// <summary>
    /// A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed.
    /// Encoded/decoded by serializers as &quot;TNAR&quot;.
    /// </summary>
    [EnumMember(Value = "TNAR")]
    [IsoId("__75_otojEeC60axPepSq7g_-1066645130")]
    [Description(
        @"A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed."
    )]
    TransactionNoticeAlreadyAcceptedOrRejected,

    /// <summary>
    /// Order entry date is missing.
    /// Encoded/decoded by serializers as &quot;ODNP&quot;.
    /// </summary>
    [EnumMember(Value = "ODNP")]
    [IsoId("__75_o9ojEeC60axPepSq7g_1992320456")]
    [Description(@"Order entry date is missing.")]
    OrderDateNotProvided,

    /// <summary>
    /// Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_ZmQtqNp-Ed-ak6NoX_4Aeg_2022390206")]
    [Description(
        @"Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned."
    )]
    InvalidRequest,

    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_ZmaeoNp-Ed-ak6NoX_4Aeg_-1367552789")]
    [Description(
        @"Instruction is rejected since the provided certification is incorrect or incomplete."
    )]
    IncorrectCertification,

    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zmaeodp-Ed-ak6NoX_4Aeg_-1742036382")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference,

    /// <summary>
    /// Instruction contains an invalid or unrecognised safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Zmaeotp-Ed-ak6NoX_4Aeg_-1742036364")]
    [Description(@"Instruction contains an invalid or unrecognised safekeeping account.")]
    SafekeepingAccountRejection,

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_Zmaeo9p-Ed-ak6NoX_4Aeg_-1742036363")]
    [Description(@"Position is less than required threshold.")]
    InsufficientTresholdPosition,

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZmaepNp-Ed-ak6NoX_4Aeg_-1742036339")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,

    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Zmaepdp-Ed-ak6NoX_4Aeg_-1742036322")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_Zmaeptp-Ed-ak6NoX_4Aeg_-1742036321")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed,

    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Zmaep9p-Ed-ak6NoX_4Aeg_-1742036303")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed,

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_ZmaeqNp-Ed-ak6NoX_4Aeg_-1742036061")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,

    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_ZmjokNp-Ed-ak6NoX_4Aeg_-1742036060")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy,

    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_Zmjokdp-Ed-ak6NoX_4Aeg_-1742036044")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy,

    /// <summary>
    /// Issuer or Registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_Zmjoktp-Ed-ak6NoX_4Aeg_-1742036026")]
    [Description(@"Issuer or Registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar,

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Zmjok9p-Ed-ak6NoX_4Aeg_-854532682")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,

    /// <summary>
    /// The instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_ZmjolNp-Ed-ak6NoX_4Aeg_1213230648")]
    [Description(@"The instruction is irrevocable.")]
    InstructionIrrevocable,

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_Zmjoldp-Ed-ak6NoX_4Aeg_705953431")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    OptionCancelled,

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_Zmjoltp-Ed-ak6NoX_4Aeg_1091061095")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option."
    )]
    OptionInactive,

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_Zmjol9p-Ed-ak6NoX_4Aeg_1152014923")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities,

    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as &quot;REFT&quot;.
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_ZmjomNp-Ed-ak6NoX_4Aeg_-1886965034")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities,

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_Zmjomdp-Ed-ak6NoX_4Aeg_1268378150")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities,

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZmtZkNp-Ed-ak6NoX_4Aeg_1556517660")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_ZmtZkdp-Ed-ak6NoX_4Aeg_1938855805")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch,

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_ZmtZktp-Ed-ak6NoX_4Aeg_2015505838")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection,

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_ZmtZk9p-Ed-ak6NoX_4Aeg_2095850925")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_ZmtZlNp-Ed-ak6NoX_4Aeg_-1322692369")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled,

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_ZmtZldp-Ed-ak6NoX_4Aeg_-1236806254")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress,

    /// <summary>
    /// Unrecognised event number or identification (eg corporate action event number, a meeting identification).
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_ZmtZltp-Ed-ak6NoX_4Aeg_-597728995")]
    [Description(
        @"Unrecognised event number or identification (eg corporate action event number, a meeting identification)."
    )]
    UnrecognizedIdentification,

    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZmtZl9p-Ed-ak6NoX_4Aeg_951355846")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol,

    /// <summary>
    /// Exchange on which the financial instrument is traded is closed.
    /// Encoded/decoded by serializers as &quot;EXCL&quot;.
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("_ZmtZmNp-Ed-ak6NoX_4Aeg_951355941")]
    [Description(@"Exchange on which the financial instrument is traded is closed.")]
    ClosedExchange,

    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as &quot;EXLI&quot;.
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("_Zm2jgNp-Ed-ak6NoX_4Aeg_951356292")]
    [Description(
        @"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit."
    )]
    ExceedsLimit,

    /// <summary>
    /// Request has exceeded the allowed time frame.
    /// Encoded/decoded by serializers as &quot;TOLA&quot;.
    /// </summary>
    [EnumMember(Value = "TOLA")]
    [IsoId("_Zm2jgdp-Ed-ak6NoX_4Aeg_951356404")]
    [Description(@"Request has exceeded the allowed time frame.")]
    TooLate,

    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_Zm2jgtp-Ed-ak6NoX_4Aeg_951356499")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice,

    /// <summary>
    /// Permission to be processed is not granted.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_Zm2jg9p-Ed-ak6NoX_4Aeg_951356820")]
    [Description(@"Permission to be processed is not granted.")]
    NotAuthorised,

    /// <summary>
    /// No counterparty order has been identified.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_Zm2jhNp-Ed-ak6NoX_4Aeg_951357198")]
    [Description(@"No counterparty order has been identified.")]
    NoMatchInquiry,

    /// <summary>
    /// Referred instrument does not exist in combination with the mentioned market.
    /// Encoded/decoded by serializers as &quot;NINS&quot;.
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("_Zm2jhdp-Ed-ak6NoX_4Aeg_951357318")]
    [Description(@"Referred instrument does not exist in combination with the mentioned market.")]
    NoInstrumentMarket,

    /// <summary>
    /// Requested financial instrument is not available.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_Zm2jhtp-Ed-ak6NoX_4Aeg_951357378")]
    [Description(@"Requested financial instrument is not available.")]
    NoInventory,

    /// <summary>
    /// Counterparty is not interested in the transaction.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_Zm2jh9p-Ed-ak6NoX_4Aeg_951357413")]
    [Description(@"Counterparty is not interested in the transaction.")]
    Pass,

    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_Zm2jiNp-Ed-ak6NoX_4Aeg_951357455")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds,

    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_ZnAUgNp-Ed-ak6NoX_4Aeg_951357707")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds,

    /// <summary>
    /// Order is for the wrong side.
    /// Encoded/decoded by serializers as &quot;SIDE&quot;.
    /// </summary>
    [EnumMember(Value = "SIDE")]
    [IsoId("_ZnAUgdp-Ed-ak6NoX_4Aeg_951357750")]
    [Description(@"Order is for the wrong side.")]
    WrongSide,

    /// <summary>
    /// This is primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side&apos;s calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("_ZnAUgtp-Ed-ak6NoX_4Aeg_805174296")]
    [Description(
        @"This is primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high."
    )]
    CalculationDifference,

    /// <summary>
    /// Requestor has no insufficient credit to make the trade.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_ZnAUg9p-Ed-ak6NoX_4Aeg_1307569106")]
    [Description(@"Requestor has no insufficient credit to make the trade.")]
    InsufficientCredit,

    /// <summary>
    /// Agreement start date is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ASTM&quot;.
    /// </summary>
    [EnumMember(Value = "ASTM")]
    [IsoId("_ZnAUhNp-Ed-ak6NoX_4Aeg_-1662359608")]
    [Description(@"Agreement start date is missing or invalid.")]
    AgreementStartDate,

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZnAUhdp-Ed-ak6NoX_4Aeg_-1662359471")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZnAUhtp-Ed-ak6NoX_4Aeg_-1662359358")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZnAUh9p-Ed-ak6NoX_4Aeg_-1662359003")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZnAUiNp-Ed-ak6NoX_4Aeg_-1661438799")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,

    /// <summary>
    /// Unrecognised or invalid delivering custodian.
    /// Encoded/decoded by serializers as &quot;DCUS&quot;.
    /// </summary>
    [EnumMember(Value = "DCUS")]
    [IsoId("_ZnAUidp-Ed-ak6NoX_4Aeg_-1661438739")]
    [Description(@"Unrecognised or invalid delivering custodian.")]
    DeliveringCustodian,

    /// <summary>
    /// Unrecognised or invalid receiving agent.
    /// Encoded/decoded by serializers as &quot;RCUS&quot;.
    /// </summary>
    [EnumMember(Value = "RCUS")]
    [IsoId("_ZnKFgNp-Ed-ak6NoX_4Aeg_-1661438696")]
    [Description(@"Unrecognised or invalid receiving agent.")]
    ReceivingCustodian,

    /// <summary>
    /// Cancellation request has been rejected since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_ZnKFgdp-Ed-ak6NoX_4Aeg_-1661438427")]
    [Description(
        @"Cancellation request has been rejected since the instruction could not be found."
    )]
    NotFoundRejection,

    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as &quot;QUNP&quot;.
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("_ZnKFgtp-Ed-ak6NoX_4Aeg_-1661438367")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType,

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZnKFg9p-Ed-ak6NoX_4Aeg_-1661438324")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ZnKFhNp-Ed-ak6NoX_4Aeg_-1661438272")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_ZnKFhdp-Ed-ak6NoX_4Aeg_-1661437964")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_ZnKFhtp-Ed-ak6NoX_4Aeg_-1661437904")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_ZnKFh9p-Ed-ak6NoX_4Aeg_-1661437869")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,

    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as &quot;TQNP&quot;.
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("_ZnKFiNp-Ed-ak6NoX_4Aeg_-1661437809")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity,

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZnTPcNp-Ed-ak6NoX_4Aeg_-118234173")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate,

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_ZnTPcdp-Ed-ak6NoX_4Aeg_-87755656")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent,

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZnTPctp-Ed-ak6NoX_4Aeg_-86835512")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary,

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZnTPc9p-Ed-ak6NoX_4Aeg_-86835028")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent,

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZnTPdNp-Ed-ak6NoX_4Aeg_36919142")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_ZnTPddp-Ed-ak6NoX_4Aeg_51694592")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown,

    /// <summary>
    /// It is not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZnTPdtp-Ed-ak6NoX_4Aeg_2144796551")]
    [Description(@"It is not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZnTPd9p-Ed-ak6NoX_4Aeg_2144796788")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,

    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_ZnTPeNp-Ed-ak6NoX_4Aeg_2144797158")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicatorRejection,

    /// <summary>
    /// Missing credit authorisation (for pre-release transactions).
    /// Encoded/decoded by serializers as &quot;MCRA&quot;.
    /// </summary>
    [EnumMember(Value = "MCRA")]
    [IsoId("_ZndAcNp-Ed-ak6NoX_4Aeg_2144797529")]
    [Description(@"Missing credit authorisation (for pre-release transactions).")]
    MissingCreditAuthorisation,

    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as &quot;DADR&quot;.
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_ZndAcdp-Ed-ak6NoX_4Aeg_2144797736")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection,

    /// <summary>
    /// Unrecognised or invalid receiving or delivering custodian.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZndActp-Ed-ak6NoX_4Aeg_2144798076")]
    [Description(@"Unrecognised or invalid receiving or delivering custodian.")]
    ReceivingOrDeliveringCustodianRejection,

    /// <summary>
    /// Unrecognised or invalid buyer or seller.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZndAc9p-Ed-ak6NoX_4Aeg_2144798446")]
    [Description(@"Unrecognised or invalid buyer or seller.")]
    ReceivingDeliveringParty3,

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZndAdNp-Ed-ak6NoX_4Aeg_2144798569")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZndAddp-Ed-ak6NoX_4Aeg_2144798691")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection,

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZndAdtp-Ed-ak6NoX_4Aeg_2144799061")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,

    /// <summary>
    /// Missing statutes or commercial register or other legal documents.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_ZndAd9p-Ed-ak6NoX_4Aeg_2145719148")]
    [Description(@"Missing statutes or commercial register or other legal documents.")]
    MissingStatutes,

    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_ZndAeNp-Ed-ak6NoX_4Aeg_2145719362")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    NotStampedOrSigned,

    /// <summary>
    /// Registration request does not have a valid signature of the owner of the financial instrument.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_ZnmxcNp-Ed-ak6NoX_4Aeg_2145719732")]
    [Description(
        @"Registration request does not have a valid signature of the owner of the financial instrument."
    )]
    InvalidSignature,

    /// <summary>
    /// Unrecognised or invalid shareholder number.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_Znmxcdp-Ed-ak6NoX_4Aeg_2145720103")]
    [Description(@"Unrecognised or invalid shareholder number.")]
    ShareholderNumberRejection,

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_Znmxctp-Ed-ak6NoX_4Aeg_2145720248")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity,

    /// <summary>
    /// Cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_Znmxc9p-Ed-ak6NoX_4Aeg_2145720618")]
    [Description(
        @"Cancellation request has been rejected since more than one instruction match to the cancellation criteria."
    )]
    NoMatch,

    /// <summary>
    /// Missing legal power for transfer.
    /// Encoded/decoded by serializers as &quot;MLEG&quot;.
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("_ZnmxdNp-Ed-ak6NoX_4Aeg_2145721019")]
    [Description(@"Missing legal power for transfer.")]
    MissingLegalPower,

    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_Znmxddp-Ed-ak6NoX_4Aeg_2145721165")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch."
    )]
    ProcessingBatchRejection,

    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as &quot;OWNT&quot;.
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_Znmxdtp-Ed-ak6NoX_4Aeg_2145721597")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection,

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_Znmxd9p-Ed-ak6NoX_4Aeg_2145721998")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity,

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.
    /// Encoded/decoded by serializers as &quot;REQW&quot;.
    /// </summary>
    [EnumMember(Value = "REQW")]
    [IsoId("_ZnmxeNp-Ed-ak6NoX_4Aeg_2145722151")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar."
    )]
    WrongRegistrationRequest,

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_Znmxedp-Ed-ak6NoX_4Aeg_2145722552")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection,

    /// <summary>
    /// Registration reason indicated is not correct.
    /// Encoded/decoded by serializers as &quot;RREA&quot;.
    /// </summary>
    [EnumMember(Value = "RREA")]
    [IsoId("_Znv7YNp-Ed-ak6NoX_4Aeg_2146642669")]
    [Description(@"Registration reason indicated is not correct.")]
    DisagreementInRegistrationReason,

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is missing.
    /// Encoded/decoded by serializers as &quot;REQM&quot;.
    /// </summary>
    [EnumMember(Value = "REQM")]
    [IsoId("_Znv7Ydp-Ed-ak6NoX_4Aeg_2146642822")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is missing."
    )]
    MissingRegistrationRequest,

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Znv7Ytp-Ed-ak6NoX_4Aeg_2146643284")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection,

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Znv7Y9p-Ed-ak6NoX_4Aeg_2146643685")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection,

    /// <summary>
    /// Unrecognised or invalid service level agreement preagreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_Znv7ZNp-Ed-ak6NoX_4Aeg_2146643861")]
    [Description(
        @"Unrecognised or invalid service level agreement preagreed narrative information."
    )]
    NarrativeInformationRejection,

    /// <summary>
    /// Invalid or incorrect program conversion specified.
    /// Encoded/decoded by serializers as &quot;ICOP&quot;.
    /// </summary>
    [EnumMember(Value = "ICOP")]
    [IsoId("_Znv7Zdp-Ed-ak6NoX_4Aeg_2146644262")]
    [Description(@"Invalid or incorrect program conversion specified.")]
    IncorrectProgramConversion,

    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as &quot;ICOL&quot;.
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_Znv7Ztp-Ed-ak6NoX_4Aeg_2146644663")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral,

    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as &quot;BPAR&quot;.
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_Znv7Z9p-Ed-ak6NoX_4Aeg_2146645056")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection,

    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as &quot;BREF&quot;.
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_Znv7aNp-Ed-ak6NoX_4Aeg_2146645549")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection,

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_Zn5sYNp-Ed-ak6NoX_4Aeg_2146646042")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection,

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZrB44Np-Ed-ak6NoX_4Aeg_-2147401106")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection,

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZrB44dp-Ed-ak6NoX_4Aeg_-2147400922")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem,

    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_ZrLp4Np-Ed-ak6NoX_4Aeg_-2147400522")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRejection,

    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as &quot;CONL&quot;.
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_ZrLp4dp-Ed-ak6NoX_4Aeg_-2147400006")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded,

    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_ZrLp4tp-Ed-ak6NoX_4Aeg_-2147399605")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure,

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZrLp49p-Ed-ak6NoX_4Aeg_-2147399174")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,

    /// <summary>
    /// Unrecognised or invalid place of settlement.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZrLp5Np-Ed-ak6NoX_4Aeg_-2147398997")]
    [Description(@"Unrecognised or invalid place of settlement.")]
    PlaceOfSettlementRejection,

    /// <summary>
    /// Party A does not agree with the call amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ZrLp5dp-Ed-ak6NoX_4Aeg_-2147398565")]
    [Description(@"Party A does not agree with the call amount.")]
    DisagreeWithCallAmount,

    /// <summary>
    /// Party A does not agree with the exposure amount.
    /// Encoded/decoded by serializers as &quot;DISE&quot;.
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_ZrLp5tp-Ed-ak6NoX_4Aeg_-2147398042")]
    [Description(@"Party A does not agree with the exposure amount.")]
    DisagreeWithExposureAmount,

    /// <summary>
    /// Disagreement between the data on the registration request and the order.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_ZrLp59p-Ed-ak6NoX_4Aeg_-2147397641")]
    [Description(@"Disagreement between the data on the registration request and the order.")]
    RegistrationRequestDataAndOrderRejection,

    /// <summary>
    /// Unrecognized or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_ZrLp6Np-Ed-ak6NoX_4Aeg_-2140012816")]
    [Description(@"Unrecognized or invalid fee or commission.")]
    FeeCommissionRejection,

    /// <summary>
    /// Incorrect activity type specified, for example, pre-release conversion.
    /// Encoded/decoded by serializers as &quot;IACT&quot;.
    /// </summary>
    [EnumMember(Value = "IACT")]
    [IsoId("_ZrLp6dp-Ed-ak6NoX_4Aeg_-2140012415")]
    [Description(@"Incorrect activity type specified, for example, pre-release conversion.")]
    IncorrectActivityType,

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZrLp6tp-Ed-ak6NoX_4Aeg_-2140011953")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ZrUz0Np-Ed-ak6NoX_4Aeg_-2140011468")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection,

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ZrUz0dp-Ed-ak6NoX_4Aeg_-2140011006")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection,

    /// <summary>
    /// A second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_ZrUz0tp-Ed-ak6NoX_4Aeg_770020323")]
    [Description(@"A second option is mandatory.")]
    MissingOption,

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("_ZrUz09p-Ed-ak6NoX_4Aeg_840210586")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent,

    /// <summary>
    /// Period Ending Date or Code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("_ZrUz1Np-Ed-ak6NoX_4Aeg_1296429140")]
    [Description(@"Period Ending Date or Code is missing.")]
    MissingPeriodEndDate,

    /// <summary>
    /// Period Starting Date or Code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_ZrUz1dp-Ed-ak6NoX_4Aeg_1628896216")]
    [Description(@"Period Starting Date or Code is missing.")]
    MissingPeriodStartDate,

    /// <summary>
    /// Resulting amount must be filled in as Exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_ZrUz1tp-Ed-ak6NoX_4Aeg_1732330848")]
    [Description(@"Resulting amount must be filled in as Exchange rate is present.")]
    MissingResultingAmount,

    /// <summary>
    /// Security type does not match with the type of corporate action.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_ZrUz19p-Ed-ak6NoX_4Aeg_908081354")]
    [Description(@"Security type does not match with the type of corporate action.")]
    WrongSecurityType,

    /// <summary>
    /// The disperse security is not eligible in the I(CSD) Service Provider Owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_Zrek0Np-Ed-ak6NoX_4Aeg_1041990409")]
    [Description(@"The disperse security is not eligible in the I(CSD) Service Provider Owner.")]
    NotEligibleDisperseSecurity,

    /// <summary>
    /// The security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_Zrek0dp-Ed-ak6NoX_4Aeg_1711543664")]
    [Description(@"The security is not eligible.")]
    NonEligibleSecurity,

    /// <summary>
    /// There cannot be a resulting amount without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("_Zrek0tp-Ed-ak6NoX_4Aeg_1893477675")]
    [Description(@"There cannot be a resulting amount without an exchange rate.")]
    MissingExchangeRate,

    /// <summary>
    /// Value date is before payment date.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_Zrek09p-Ed-ak6NoX_4Aeg_-1999758406")]
    [Description(@"Value date is before payment date.")]
    ValueDateBeforePaymentDate,

    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_Zrek1Np-Ed-ak6NoX_4Aeg_252115254")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest,

    /// <summary>
    /// Agent has no access to the service.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_Zrek1dp-Ed-ak6NoX_4Aeg_707411459")]
    [Description(@"Agent has no access to the service.")]
    NoAccessToService,

    /// <summary>
    /// Certification Indicator is not filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_Zrek1tp-Ed-ak6NoX_4Aeg_834857831")]
    [Description(@"Certification Indicator is not filled in.")]
    MissingCertification,

    /// <summary>
    /// Date is not a business day for the security market.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_Zrek19p-Ed-ak6NoX_4Aeg_1997570800")]
    [Description(@"Date is not a business day for the security market.")]
    NotBusinessDay,

    /// <summary>
    /// Effective date is after the payment date.
    /// Encoded/decoded by serializers as &quot;PDAY&quot;.
    /// </summary>
    [EnumMember(Value = "PDAY")]
    [IsoId("_Zrek2Np-Ed-ak6NoX_4Aeg_-2059127927")]
    [Description(@"Effective date is after the payment date.")]
    EffectiveDayAfterPaymentDate,

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("_Zrek2dp-Ed-ak6NoX_4Aeg_-1724814034")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount,

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_Zrek2tp-Ed-ak6NoX_4Aeg_-1209490574")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption,

    /// <summary>
    /// Party is not active.
    /// Encoded/decoded by serializers as &quot;NPAT&quot;.
    /// </summary>
    [EnumMember(Value = "NPAT")]
    [IsoId("_ZrnuwNp-Ed-ak6NoX_4Aeg_-823457016")]
    [Description(@"Party is not active.")]
    NonActiveParty,

    /// <summary>
    /// Period Ending date is before Period Starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_Zrnuwdp-Ed-ak6NoX_4Aeg_1680865685")]
    [Description(@"Period Ending date is before Period Starting date.")]
    PeriodEndDateBeforeStartDate,

    /// <summary>
    /// Record date is after payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_Zrnuwtp-Ed-ak6NoX_4Aeg_2053043117")]
    [Description(@"Record date is after payment date.")]
    RecordDateAfterPaymentDate,

    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zrnuw9p-Ed-ak6NoX_4Aeg_372564732")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation,

    /// <summary>
    /// Rejected as the deactivation of the event is already completed.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_ZrnuxNp-Ed-ak6NoX_4Aeg_-1713340722")]
    [Description(@"Rejected as the deactivation of the event is already completed.")]
    EventAlreadyDeactivated,

    /// <summary>
    /// The cancellation request is rejected as there is no pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PDEA&quot;.
    /// </summary>
    [EnumMember(Value = "PDEA")]
    [IsoId("_Zrnuxdp-Ed-ak6NoX_4Aeg_-1713340661")]
    [Description(
        @"The cancellation request is rejected as there is no pending deactivation instruction."
    )]
    NoPendingDeactivationInstruction,

    /// <summary>
    /// Amendment is not allowed.
    /// Encoded/decoded by serializers as &quot;NAMD&quot;.
    /// </summary>
    [EnumMember(Value = "NAMD")]
    [IsoId("_Zrnuxtp-Ed-ak6NoX_4Aeg_-1829967678")]
    [Description(@"Amendment is not allowed.")]
    AmendmentNotAllowed,

    /// <summary>
    /// Cancellation is not allowed.
    /// Encoded/decoded by serializers as &quot;NCAN&quot;.
    /// </summary>
    [EnumMember(Value = "NCAN")]
    [IsoId("_Zrnux9p-Ed-ak6NoX_4Aeg_1294302006")]
    [Description(@"Cancellation is not allowed.")]
    CancellationNotAllowed,

    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_ZrnuyNp-Ed-ak6NoX_4Aeg_-1829967625")]
    [Description(@"Instruction/Request arrives too late.")]
    Late,

    /// <summary>
    /// The election advice is already cancelled.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_Zrnuydp-Ed-ak6NoX_4Aeg_-1829967533")]
    [Description(@"The election advice is already cancelled.")]
    ElectionAlreadyCancelled,

    /// <summary>
    /// The election advice is already amended.
    /// Encoded/decoded by serializers as &quot;ELEA&quot;.
    /// </summary>
    [EnumMember(Value = "ELEA")]
    [IsoId("_ZrxfwNp-Ed-ak6NoX_4Aeg_-1829967255")]
    [Description(@"The election advice is already amended.")]
    ElectionAlreadyAmended,

    /// <summary>
    /// An Agent Corporate Action Deactivation Instruction with the same identification already exists.
    /// Encoded/decoded by serializers as &quot;SAME&quot;.
    /// </summary>
    [EnumMember(Value = "SAME")]
    [IsoId("_Zrxfwdp-Ed-ak6NoX_4Aeg_-419595100")]
    [Description(
        @"An Agent Corporate Action Deactivation Instruction with the same identification already exists."
    )]
    SameCAIdentification,

    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;REFI&quot;.
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_Zrxfwtp-Ed-ak6NoX_4Aeg_-33562768")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification,

    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as &quot;AGIN&quot;.
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_Zrxfw9p-Ed-ak6NoX_4Aeg_443897219")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent,

    /// <summary>
    /// Agent Identification specified does not correspond to the main Agent of the relating event.
    /// Encoded/decoded by serializers as &quot;MAIN&quot;.
    /// </summary>
    [EnumMember(Value = "MAIN")]
    [IsoId("_ZrxfxNp-Ed-ak6NoX_4Aeg_894575528")]
    [Description(
        @"Agent Identification specified does not correspond to the main Agent of the relating event."
    )]
    NotMainAgent,

    /// <summary>
    /// Invalid combination of CA option code and CA option number.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_Zrxfxdp-Ed-ak6NoX_4Aeg_1269525941")]
    [Description(@"Invalid combination of CA option code and CA option number.")]
    InvalidOption,

    /// <summary>
    /// The specified Corporate Action option already has a pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_Zrxfxtp-Ed-ak6NoX_4Aeg_1712817460")]
    [Description(
        @"The specified Corporate Action option already has a pending deactivation instruction."
    )]
    PendingDeactivation,

    /// <summary>
    /// Unable to identify cash account.
    /// Encoded/decoded by serializers as &quot;CASA&quot;.
    /// </summary>
    [EnumMember(Value = "CASA")]
    [IsoId("_Zrxfx9p-Ed-ak6NoX_4Aeg_1262464248")]
    [Description(@"Unable to identify cash account.")]
    NotIdentifiedCashAccount,

    /// <summary>
    /// Unable to identify correspondent bank.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_ZrxfyNp-Ed-ak6NoX_4Aeg_1262464401")]
    [Description(@"Unable to identify correspondent bank.")]
    NotIdentifiedCorrespondentBank,

    /// <summary>
    /// Invalid standing instruction type for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_Zrxfydp-Ed-ak6NoX_4Aeg_1262464741")]
    [Description(@"Invalid standing instruction type for the specified underlying security.")]
    InvalidStandingInstructionType,

    /// <summary>
    /// No holding for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;NOHO&quot;.
    /// </summary>
    [EnumMember(Value = "NOHO")]
    [IsoId("_Zrxfytp-Ed-ak6NoX_4Aeg_1262465135")]
    [Description(@"No holding for the specified underlying security.")]
    NoHolding,

    /// <summary>
    /// Insufficient balance.
    /// Encoded/decoded by serializers as &quot;INHO&quot;.
    /// </summary>
    [EnumMember(Value = "INHO")]
    [IsoId("_Zr7QwNp-Ed-ak6NoX_4Aeg_-329557268")]
    [Description(@"Insufficient balance.")]
    InsufficientBalance,

    /// <summary>
    /// Several message with the same identification.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_Zr7Qwdp-Ed-ak6NoX_4Aeg_-242898728")]
    [Description(@"Several message with the same identification.")]
    SameIdentification,

    /// <summary>
    /// Rejected as the deactivation of the option is already completed.
    /// Encoded/decoded by serializers as &quot;DEAO&quot;.
    /// </summary>
    [EnumMember(Value = "DEAO")]
    [IsoId("_Zr7Qwtp-Ed-ak6NoX_4Aeg_-1326457537")]
    [Description(@"Rejected as the deactivation of the option is already completed.")]
    OptionAlreadyDeactivated,

    /// <summary>
    /// CA Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INET&quot;.
    /// </summary>
    [EnumMember(Value = "INET")]
    [IsoId("_Zr7Qw9p-Ed-ak6NoX_4Aeg_-788045317")]
    [Description(@"CA Event Type does not correspond with the relating Corporate Action.")]
    InvalidEventType,

    /// <summary>
    /// Underlying Security Identification does not correspond with the Corporate Action Reference supplied.
    /// Encoded/decoded by serializers as &quot;INUS&quot;.
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_Zr7QxNp-Ed-ak6NoX_4Aeg_-256095997")]
    [Description(
        @"Underlying Security Identification does not correspond with the Corporate Action Reference supplied."
    )]
    InvalidUnderlyingSecurity,

    /// <summary>
    /// Event Processing Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INPT&quot;.
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_Zr7Qxdp-Ed-ak6NoX_4Aeg_-256095287")]
    [Description(@"Event Processing Type does not correspond with the relating Corporate Action.")]
    InvalidEventProcessingType,

    /// <summary>
    /// Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INMV&quot;.
    /// </summary>
    [EnumMember(Value = "INMV")]
    [IsoId("_Zr7Qxtp-Ed-ak6NoX_4Aeg_531669341")]
    [Description(
        @"Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action."
    )]
    InvalidMandatoryVoluntaryEventType,

    /// <summary>
    /// Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_Zr7Qx9p-Ed-ak6NoX_4Aeg_706213194")]
    [Description(
        @"Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidCorporateActionInformation,

    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_Zr7QyNp-Ed-ak6NoX_4Aeg_1546618713")]
    [Description(
        @"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message."
    )]
    InvalidDetails,

    /// <summary>
    /// Specified Corporate Action has no remaining options to disable.
    /// Encoded/decoded by serializers as &quot;NORO&quot;.
    /// </summary>
    [EnumMember(Value = "NORO")]
    [IsoId("_Zr7Qydp-Ed-ak6NoX_4Aeg_-1590519761")]
    [Description(@"Specified Corporate Action has no remaining options to disable.")]
    NoRemainingOption,

    /// <summary>
    /// Issuer CA Identification does not correspond with the Corporate Action Identification supplied.
    /// Encoded/decoded by serializers as &quot;MICA&quot;.
    /// </summary>
    [EnumMember(Value = "MICA")]
    [IsoId("_ZsEasNp-Ed-ak6NoX_4Aeg_113375908")]
    [Description(
        @"Issuer CA Identification does not correspond with the Corporate Action Identification supplied."
    )]
    MismatchedCAIdentification,

    /// <summary>
    /// This instruction type is not applicable for mandatory events.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_ZsEasdp-Ed-ak6NoX_4Aeg_482785255")]
    [Description(@"This instruction type is not applicable for mandatory events.")]
    NotApplicable,

    /// <summary>
    /// Details specified in the MOVEMENT GENERAL INFORMATION block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INMO&quot;.
    /// </summary>
    [EnumMember(Value = "INMO")]
    [IsoId("_ZsEastp-Ed-ak6NoX_4Aeg_-1932818763")]
    [Description(
        @"Details specified in the MOVEMENT GENERAL INFORMATION block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidMovementInformation,

    /// <summary>
    /// One or more of the underlying movements have already settled.
    /// Encoded/decoded by serializers as &quot;MOSE&quot;.
    /// </summary>
    [EnumMember(Value = "MOSE")]
    [IsoId("_ZsEas9p-Ed-ak6NoX_4Aeg_-758100543")]
    [Description(@"One or more of the underlying movements have already settled.")]
    MovementAlreadySettled,

    /// <summary>
    /// A narrative reason is provided.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_ZsEatNp-Ed-ak6NoX_4Aeg_1059052760")]
    [Description(@"A narrative reason is provided.")]
    NarrativeReason,

    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_ZsEatdp-Ed-ak6NoX_4Aeg_-1025063105")]
    [Description(
        @"Instruction contains an invalid message identification, identification is unknown."
    )]
    InvalidIdentification,

    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZsEattp-Ed-ak6NoX_4Aeg_-921083680")]
    [Description(@"Other reason.")]
    Other,

    /// <summary>
    /// Instruction has been rejected as the corresponding allegement was cancelled.
    /// Encoded/decoded by serializers as &quot;NFCA&quot;.
    /// </summary>
    [EnumMember(Value = "NFCA")]
    [IsoId("_hCZ-AEv0EeqsYJJSZey7Rw")]
    [Description(@"Instruction has been rejected as the corresponding allegement was cancelled.")]
    NotFoundCorrespondingAllegement,

    /// <summary>
    /// Unrecognised or invalid Rate Index Type (used when a proprietary code is sent).
    /// Encoded/decoded by serializers as &quot;IRIT&quot;.
    /// </summary>
    [EnumMember(Value = "IRIT")]
    [IsoId("_IGNvkM-xEeqtr8G87szcqw")]
    [Description(
        @"Unrecognised or invalid Rate Index Type (used when a proprietary code is sent)."
    )]
    InvalidRateIndexType,

    /// <summary>
    /// Unrecognised or invalid Preferential Basket identification.
    /// Encoded/decoded by serializers as &quot;IPBI&quot;.
    /// </summary>
    [EnumMember(Value = "IPBI")]
    [IsoId("_MDbMAM-xEeqtr8G87szcqw")]
    [Description(@"Unrecognised or invalid Preferential Basket identification.")]
    InvalidPreferentialBasketIdentification,

    /// <summary>
    /// Invalid execution date/time
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_Q-s9wM-yEeqtr8G87szcqw")]
    [Description(@"Invalid execution date/time")]
    RequestedExecutionDateTime,

    /// <summary>
    /// Unrecognised or Invalid Party A.
    /// Encoded/decoded by serializers as &quot;PTYA&quot;.
    /// </summary>
    [EnumMember(Value = "PTYA")]
    [IsoId("_sR5CIM-yEeqtr8G87szcqw")]
    [Description(@"Unrecognised or Invalid Party A.")]
    InvalidPartyA,

    /// <summary>
    /// Unrecognised or Invalid Party B
    /// Encoded/decoded by serializers as &quot;PTYB&quot;.
    /// </summary>
    [EnumMember(Value = "PTYB")]
    [IsoId("_zzBRQM-yEeqtr8G87szcqw")]
    [Description(@"Unrecognised or Invalid Party B")]
    InvalidPartyB,

    /// <summary>
    /// Unrecognised or invalid Party A Safekeeping Account
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("_8FGcMM-yEeqtr8G87szcqw")]
    [Description(@"Unrecognised or invalid Party A Safekeeping Account")]
    PartyASafekeepingAccount,

    /// <summary>
    /// Unrecognised or Invalid Party B Safekeeping Account.
    /// Encoded/decoded by serializers as &quot;SAFB&quot;.
    /// </summary>
    [EnumMember(Value = "SAFB")]
    [IsoId("_Mz-NQM-zEeqtr8G87szcqw")]
    [Description(@"Unrecognised or Invalid Party B Safekeeping Account.")]
    PartyBSafekeepingAccount,

    /// <summary>
    /// Unrecognised or Invalid Triparty Agent
    /// Encoded/decoded by serializers as &quot;ITPA&quot;.
    /// </summary>
    [EnumMember(Value = "ITPA")]
    [IsoId("_c5opQM-zEeqtr8G87szcqw")]
    [Description(@"Unrecognised or Invalid Triparty Agent")]
    InvalidTripartyAgent,

    /// <summary>
    /// This is an unrecognised or invalid Eligibility Set Profile.
    /// Encoded/decoded by serializers as &quot;IESP&quot;.
    /// </summary>
    [EnumMember(Value = "IESP")]
    [IsoId("_kzwnMM-zEeqtr8G87szcqw")]
    [Description(@"This is an unrecognised or invalid Eligibility Set Profile.")]
    InvalidEligibilitySetProfile,

    /// <summary>
    /// This is an unrecognised or invalid Exposure Type (used when a proprietary code is sent).
    /// Encoded/decoded by serializers as &quot;IEXT&quot;.
    /// </summary>
    [EnumMember(Value = "IEXT")]
    [IsoId("_50hEMM-zEeqtr8G87szcqw")]
    [Description(
        @"This is an unrecognised or invalid Exposure Type (used when a proprietary code is sent)."
    )]
    InvalidExposureType,

    /// <summary>
    /// Unrecognised or invalid client collateral instruction identification.
    /// Encoded/decoded by serializers as &quot;CCIX&quot;.
    /// </summary>
    [EnumMember(Value = "CCIX")]
    [IsoId("_VZ3PkM-0Eeqtr8G87szcqw")]
    [Description(@"Unrecognised or invalid client collateral instruction identification.")]
    ClientCollateralInstructionIdentification,

    /// <summary>
    /// Unrecognised or invalid Client Collateral Transaction Identification.
    /// Encoded/decoded by serializers as &quot;CCTI&quot;.
    /// </summary>
    [EnumMember(Value = "CCTI")]
    [IsoId("_swSjcM-0Eeqtr8G87szcqw")]
    [Description(@"Unrecognised or invalid Client Collateral Transaction Identification.")]
    ClientCollateralTransactionIdentification,

    /// <summary>
    /// Termination amount currency not supported.
    /// Encoded/decoded by serializers as &quot;TMAC&quot;.
    /// </summary>
    [EnumMember(Value = "TMAC")]
    [IsoId("__I7usM-0Eeqtr8G87szcqw")]
    [Description(@"Termination amount currency not supported.")]
    TerminationAmountCurrency,

    /// <summary>
    /// Unrecognised or invalid common identification.
    /// Encoded/decoded by serializers as &quot;ICID&quot;.
    /// </summary>
    [EnumMember(Value = "ICID")]
    [IsoId("_ACEWIM-1Eeqtr8G87szcqw")]
    [Description(@"Unrecognised or invalid common identification.")]
    InvalidCommonIdentification,

    /// <summary>
    /// Transaction amount currency not supported.
    /// Encoded/decoded by serializers as &quot;TXAC&quot;.
    /// </summary>
    [EnumMember(Value = "TXAC")]
    [IsoId("_UJZQwM-1Eeqtr8G87szcqw")]
    [Description(@"Transaction amount currency not supported.")]
    TransactionAmountCurrency,

    /// <summary>
    /// Transaction amount breakdown does not equal the transaction amount.
    /// Encoded/decoded by serializers as &quot;TXAB&quot;.
    /// </summary>
    [EnumMember(Value = "TXAB")]
    [IsoId("_0zERoM-1Eeqtr8G87szcqw")]
    [Description(@"Transaction amount breakdown does not equal the transaction amount.")]
    TransactionAmountBreakdown,

    /// <summary>
    /// Unrecognised or invalid settlement process instructed.
    /// Encoded/decoded by serializers as &quot;SEPR&quot;.
    /// </summary>
    [EnumMember(Value = "SEPR")]
    [IsoId("_76z8gOiEEeqspItL-MF5VQ")]
    [Description(@"Unrecognised or invalid settlement process instructed.|")]
    SettlementProcessRejection,

    /// <summary>
    /// Number of lookback days not supported.
    /// Encoded/decoded by serializers as &quot;LBDR&quot;.
    /// </summary>
    [EnumMember(Value = "LBDR")]
    [IsoId("_QX99MOiFEeqspItL-MF5VQ")]
    [Description(@"Number of lookback days not supported.|")]
    LookbackDaysRejection,

    /// <summary>
    /// Day count basis not supported.
    /// Encoded/decoded by serializers as &quot;DCBR&quot;.
    /// </summary>
    [EnumMember(Value = "DCBR")]
    [IsoId("_XVP4YOiFEeqspItL-MF5VQ")]
    [Description(@"Day count basis not supported.|")]
    DayCountBasis,

    /// <summary>
    /// Compound simple accrual calculation is not supported.
    /// Encoded/decoded by serializers as &quot;CSAC&quot;.
    /// </summary>
    [EnumMember(Value = "CSAC")]
    [IsoId("_fYTI0OiFEeqspItL-MF5VQ")]
    [Description(@"Compound simple accrual calculation is not supported.||")]
    CompoundSimpleAccrualCalculationRejection,

    /// <summary>
    /// Cancellation request was rejected because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;RSET&quot;.
    /// </summary>
    [EnumMember(Value = "RSET")]
    [IsoId("_PB7R8P5rEeqzyss40vrJTg")]
    [Description(@"Cancellation request was rejected because the instruction was already settled.")]
    RejectedSinceAlreadySettled,

    /// <summary>
    /// Cancellation request was rejected because the repo was cancelled.
    /// ***check definition see DCAN...***
    /// Encoded/decoded by serializers as &quot;RREP&quot;.
    /// </summary>
    [EnumMember(Value = "RREP")]
    [IsoId("_pDn5QP5rEeqzyss40vrJTg")]
    [Description(
        @"Cancellation request was rejected because the repo was cancelled.|***check definition see DCAN...***"
    )]
    RejectedSinceRepoEnded,

    /// <summary>
    /// Cancellation, modification or termination request has been rejected since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRJN&quot;.
    /// </summary>
    [EnumMember(Value = "NRJN")]
    [IsoId("_Qz5TUP7CEeqzyss40vrJTg")]
    [Description(
        @"Cancellation, modification or termination request has been rejected since the instruction could not be found."
    )]
    NotFoundRejectionForCancellationModificationOrTermination,

    /// <summary>
    /// Transaction amount breakdown currency differs from transaction amount currency.
    /// Encoded/decoded by serializers as &quot;TABC&quot;.
    /// </summary>
    [EnumMember(Value = "TABC")]
    [IsoId("_2tQIUP7GEeqzyss40vrJTg")]
    [Description(
        @"Transaction amount breakdown currency differs from transaction amount currency."
    )]
    TransactionAmountBreakdownCurrency,

    /// <summary>
    /// This is an unrecognised or invalid Collateral Transaction Type.
    /// Encoded/decoded by serializers as &quot;ICTT&quot;.
    /// </summary>
    [EnumMember(Value = "ICTT")]
    [IsoId("_pysAICAUEeu0P6yLvKBt0w")]
    [Description(@"This is an unrecognised or invalid Collateral Transaction Type.")]
    InvalidCollateralTransactionType,
}
