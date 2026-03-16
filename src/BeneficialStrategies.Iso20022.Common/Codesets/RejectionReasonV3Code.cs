// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__9ywuol5EeavwKddCbm3hg")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[Derivations(
    typeof(RejectionReason71Code),
    typeof(RejectionReason66Code),
    typeof(RejectionReason76Code),
    typeof(RejectionReason79Code),
    typeof(RejectionReason54Code),
    typeof(RejectionReason56Code),
    typeof(RejectionReason46Code),
    typeof(RejectionReason63Code),
    typeof(RejectionReason48Code),
    typeof(RejectionReason69Code),
    typeof(RejectionReason75Code),
    typeof(RejectionReason78Code),
    typeof(PendingCancellationReason6Code),
    typeof(RejectionReason55Code),
    typeof(RejectionReason61Code),
    typeof(RejectionReason77Code),
    typeof(RejectionReason74Code),
    typeof(RejectionReason67Code),
    typeof(RejectionReason64Code),
    typeof(RejectionReason70Code),
    typeof(RejectionReason51Code),
    typeof(RejectionReason73Code),
    typeof(RejectionReason59Code),
    typeof(RejectionReason72Code),
    typeof(RejectionReason68Code),
    typeof(RejectionReason62Code),
    typeof(RejectionReason65Code),
    typeof(PendingCancellationReason5Code),
    typeof(RejectionReason49Code),
    typeof(RejectionReason52Code),
    typeof(RejectionReason50Code),
    typeof(RejectionReason58Code),
    typeof(RejectionReason57Code)
)]
public enum RejectionReasonV3Code
{
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("__98hKYl5EeavwKddCbm3hg")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("__9yw_4l5EeavwKddCbm3hg")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("__98hCIl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("__9yxMIl5EeavwKddCbm3hg")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition,

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("__9yw5Il5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("__9yxDol5EeavwKddCbm3hg")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("__9yw-ol5EeavwKddCbm3hg")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed,

    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("__98hGol5EeavwKddCbm3hg")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed,

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("__98hA4l5EeavwKddCbm3hg")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,

    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("__9yw7Il5EeavwKddCbm3hg")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy,

    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("__98hAol5EeavwKddCbm3hg")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy,

    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("__9ywzol5EeavwKddCbm3hg")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar,

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("__9yw7ol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,

    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("__98hJYl5EeavwKddCbm3hg")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable,

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("__9yxQIl5EeavwKddCbm3hg")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    OptionCancelled,

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("__9yw1Yl5EeavwKddCbm3hg")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option."
    )]
    OptionInactive,

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("__9yxCIl5EeavwKddCbm3hg")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities,

    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as &quot;REFT&quot;.
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("__9yxDIl5EeavwKddCbm3hg")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities,

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("__9ywu4l5EeavwKddCbm3hg")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities,

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("__9ywwol5EeavwKddCbm3hg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("__9ywxYl5EeavwKddCbm3hg")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch,

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("__9yw2Il5EeavwKddCbm3hg")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection,

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("__9yw9Yl5EeavwKddCbm3hg")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("__9yw-Yl5EeavwKddCbm3hg")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled,

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("__9yw_Il5EeavwKddCbm3hg")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress,

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("__9yxPYl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification,

    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("__9yw74l5EeavwKddCbm3hg")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol,

    /// <summary>
    /// Exchange on which the financial instrument is traded is closed.
    /// Encoded/decoded by serializers as &quot;EXCL&quot;.
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("__9yxLol5EeavwKddCbm3hg")]
    [Description(@"Exchange on which the financial instrument is traded is closed.")]
    ClosedExchange,

    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as &quot;EXLI&quot;.
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("__9yw_ol5EeavwKddCbm3hg")]
    [Description(
        @"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit."
    )]
    ExceedsLimit,

    /// <summary>
    /// Request has exceeded the allowed time frame.
    /// Encoded/decoded by serializers as &quot;TOLA&quot;.
    /// </summary>
    [EnumMember(Value = "TOLA")]
    [IsoId("__98hL4l5EeavwKddCbm3hg")]
    [Description(@"Request has exceeded the allowed time frame.")]
    TooLate,

    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("__9yxNYl5EeavwKddCbm3hg")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice,

    /// <summary>
    /// Permission to be processed is not granted.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("__9yw1ol5EeavwKddCbm3hg")]
    [Description(@"Permission to be processed is not granted.")]
    NotAuthorised,

    /// <summary>
    /// No counterparty order has been identified.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("__9yxJYl5EeavwKddCbm3hg")]
    [Description(@"No counterparty order has been identified.")]
    NoMatchInquiry,

    /// <summary>
    /// Referred instrument does not exist in combination with the mentioned market.
    /// Encoded/decoded by serializers as &quot;NINS&quot;.
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("__98hGIl5EeavwKddCbm3hg")]
    [Description(@"Referred instrument does not exist in combination with the mentioned market.")]
    NoInstrumentMarket,

    /// <summary>
    /// Requested financial instrument is not available.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("__9yw54l5EeavwKddCbm3hg")]
    [Description(@"Requested financial instrument is not available.")]
    NoInventory,

    /// <summary>
    /// Counterparty is not interested in the transaction.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("__9yxMYl5EeavwKddCbm3hg")]
    [Description(@"Counterparty is not interested in the transaction.")]
    Pass,

    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("__98hFYl5EeavwKddCbm3hg")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds,

    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("__9yxIYl5EeavwKddCbm3hg")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds,

    /// <summary>
    /// Order is for the wrong side.
    /// Encoded/decoded by serializers as &quot;SIDE&quot;.
    /// </summary>
    [EnumMember(Value = "SIDE")]
    [IsoId("__9ywvol5EeavwKddCbm3hg")]
    [Description(@"Order is for the wrong side.")]
    WrongSide,

    /// <summary>
    /// Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side&apos;s calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("__9yw3ol5EeavwKddCbm3hg")]
    [Description(
        @"Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high."
    )]
    CalculationDifference,

    /// <summary>
    /// Requestor has no insufficient credit to make the trade.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("__9yw8Yl5EeavwKddCbm3hg")]
    [Description(@"Requestor has no insufficient credit to make the trade.")]
    InsufficientCredit,

    /// <summary>
    /// Agreement start date is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ASTM&quot;.
    /// </summary>
    [EnumMember(Value = "ASTM")]
    [IsoId("__9yxEol5EeavwKddCbm3hg")]
    [Description(@"Agreement start date is missing or invalid.")]
    AgreementStartDate,

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("__9yxA4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("__9yw2Yl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("__9yxO4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("__98hIIl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,

    /// <summary>
    /// Unrecognised or invalid delivering custodian.
    /// Encoded/decoded by serializers as &quot;DCUS&quot;.
    /// </summary>
    [EnumMember(Value = "DCUS")]
    [IsoId("__98hC4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid delivering custodian.")]
    DeliveringCustodian,

    /// <summary>
    /// Unrecognised or invalid receiving agent.
    /// Encoded/decoded by serializers as &quot;RCUS&quot;.
    /// </summary>
    [EnumMember(Value = "RCUS")]
    [IsoId("__9yxAol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid receiving agent.")]
    ReceivingCustodian,

    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("__98hHYl5EeavwKddCbm3hg")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,

    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as &quot;QUNP&quot;.
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("__9yxKYl5EeavwKddCbm3hg")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType,

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("__9yxNIl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("__9yw94l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("__9yw8ol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("__9yw9Il5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("__98hK4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,

    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as &quot;TQNP&quot;.
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("__9yw3Yl5EeavwKddCbm3hg")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity,

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("__9yxLIl5EeavwKddCbm3hg")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate,

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("__9yxI4l5EeavwKddCbm3hg")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent,

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("__98hDYl5EeavwKddCbm3hg")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary,

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("__9yxEIl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("__9yxL4l5EeavwKddCbm3hg")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown,

    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("__9yxBYl5EeavwKddCbm3hg")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("__9ywwYl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,

    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("__9yw04l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicatorRejection,

    /// <summary>
    /// Missing credit authorisation (for pre-release transactions).
    /// Encoded/decoded by serializers as &quot;MCRA&quot;.
    /// </summary>
    [EnumMember(Value = "MCRA")]
    [IsoId("__98hKIl5EeavwKddCbm3hg")]
    [Description(@"Missing credit authorisation (for pre-release transactions).")]
    MissingCreditAuthorisation,

    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as &quot;DADR&quot;.
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("__9yw84l5EeavwKddCbm3hg")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection,

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("__9yxIIl5EeavwKddCbm3hg")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("__9yxGYl5EeavwKddCbm3hg")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection,

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("__98hAYl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,

    /// <summary>
    /// Missing statutes or commercial register or other legal documents.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("__9yw7Yl5EeavwKddCbm3hg")]
    [Description(@"Missing statutes or commercial register or other legal documents.")]
    MissingStatutes,

    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("__9yw64l5EeavwKddCbm3hg")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    NotStampedOrSigned,

    /// <summary>
    /// Registration request does not have a valid signature of the owner of the financial instrument.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("__9yw4Il5EeavwKddCbm3hg")]
    [Description(
        @"Registration request does not have a valid signature of the owner of the financial instrument."
    )]
    InvalidSignature,

    /// <summary>
    /// Unrecognised, missing or invalid shareholder number.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("__9yw0Yl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised, missing or invalid shareholder number.")]
    ShareholderNumberRejection,

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("__9yxD4l5EeavwKddCbm3hg")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity,

    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("__9ywyYl5EeavwKddCbm3hg")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch,

    /// <summary>
    /// Missing legal power for transfer.
    /// Encoded/decoded by serializers as &quot;MLEG&quot;.
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("__9yw1Il5EeavwKddCbm3hg")]
    [Description(@"Missing legal power for transfer.")]
    MissingLegalPower,

    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("__98hB4l5EeavwKddCbm3hg")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch."
    )]
    ProcessingBatchRejection,

    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as &quot;OWNT&quot;.
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("__9yw_Yl5EeavwKddCbm3hg")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection,

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("__9ywxIl5EeavwKddCbm3hg")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity,

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.
    /// Encoded/decoded by serializers as &quot;REQW&quot;.
    /// </summary>
    [EnumMember(Value = "REQW")]
    [IsoId("__98hJIl5EeavwKddCbm3hg")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar."
    )]
    WrongRegistrationRequest,

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("__9yxIol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection,

    /// <summary>
    /// Registration reason indicated is not correct.
    /// Encoded/decoded by serializers as &quot;RREA&quot;.
    /// </summary>
    [EnumMember(Value = "RREA")]
    [IsoId("__9yxJ4l5EeavwKddCbm3hg")]
    [Description(@"Registration reason indicated is not correct.")]
    DisagreementInRegistrationReason,

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is missing.
    /// Encoded/decoded by serializers as &quot;REQM&quot;.
    /// </summary>
    [EnumMember(Value = "REQM")]
    [IsoId("__98hF4l5EeavwKddCbm3hg")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is missing."
    )]
    MissingRegistrationRequest,

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("__9yw0ol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection,

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("__9yxHIl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection,

    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("__98hAIl5EeavwKddCbm3hg")]
    [Description(
        @"Unrecognised or invalid service level agreement pre-agreed narrative information."
    )]
    NarrativeInformationRejection,

    /// <summary>
    /// Invalid or incorrect programme conversion specified.
    /// Encoded/decoded by serializers as &quot;ICOP&quot;.
    /// </summary>
    [EnumMember(Value = "ICOP")]
    [IsoId("__9yw8Il5EeavwKddCbm3hg")]
    [Description(@"Invalid or incorrect programme conversion specified.")]
    IncorrectProgramConversion,

    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as &quot;ICOL&quot;.
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("__9ywzYl5EeavwKddCbm3hg")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral,

    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as &quot;BPAR&quot;.
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("__98hDol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection,

    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as &quot;BREF&quot;.
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("__98hFIl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection,

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("__9yxG4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection,

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("__9yxN4l5EeavwKddCbm3hg")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection,

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("__9yxPol5EeavwKddCbm3hg")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem,

    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("__9yw-4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection,

    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as &quot;CONL&quot;.
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("__9ywwIl5EeavwKddCbm3hg")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded,

    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("__98hH4l5EeavwKddCbm3hg")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure,

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("__9yxK4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,

    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("__9yxFIl5EeavwKddCbm3hg")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount,

    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as &quot;DISE&quot;.
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("__9ywvYl5EeavwKddCbm3hg")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount,

    /// <summary>
    /// Disagreement between the data on the registration request and the order.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("__9yw44l5EeavwKddCbm3hg")]
    [Description(@"Disagreement between the data on the registration request and the order.")]
    RegistrationRequestDataAndOrderRejection,

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("__9yxLYl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection,

    /// <summary>
    /// Incorrect activity type specified, for example, pre-release conversion.
    /// Encoded/decoded by serializers as &quot;IACT&quot;.
    /// </summary>
    [EnumMember(Value = "IACT")]
    [IsoId("__9yw4ol5EeavwKddCbm3hg")]
    [Description(@"Incorrect activity type specified, for example, pre-release conversion.")]
    IncorrectActivityType,

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("__9yxC4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("__9yxOol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection,

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("__9ywyIl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection,

    /// <summary>
    /// Second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("__9yxDYl5EeavwKddCbm3hg")]
    [Description(@"Second option is mandatory.")]
    MissingOption,

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("__98hEYl5EeavwKddCbm3hg")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent,

    /// <summary>
    /// Period ending date or code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("__9yw6Yl5EeavwKddCbm3hg")]
    [Description(@"Period ending date or code is missing.")]
    MissingPeriodEndDate,

    /// <summary>
    /// Period starting date or code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("__98hBol5EeavwKddCbm3hg")]
    [Description(@"Period starting date or code is missing.")]
    MissingPeriodStartDate,

    /// <summary>
    /// Resulting amount must be filled in as exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("__9yw4Yl5EeavwKddCbm3hg")]
    [Description(@"Resulting amount must be filled in as exchange rate is present.")]
    MissingResultingAmount,

    /// <summary>
    /// Security type does not match with the type of corporate action.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("__9yw3Il5EeavwKddCbm3hg")]
    [Description(@"Security type does not match with the type of corporate action.")]
    WrongSecurityType,

    /// <summary>
    /// Disperse security is not eligible in the (ICSD) service provider owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("__9yxOYl5EeavwKddCbm3hg")]
    [Description(@"Disperse security is not eligible in the (ICSD) service provider owner.")]
    NotEligibleDisperseSecurity,

    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("__9yxB4l5EeavwKddCbm3hg")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity,

    /// <summary>
    /// Resulting amount is not allowed without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("__98hJol5EeavwKddCbm3hg")]
    [Description(@"Resulting amount is not allowed without an exchange rate.")]
    MissingExchangeRate,

    /// <summary>
    /// Value date is before payment date.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("__9yxJol5EeavwKddCbm3hg")]
    [Description(@"Value date is before payment date.")]
    ValueDateBeforePaymentDate,

    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("__9yxHYl5EeavwKddCbm3hg")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest,

    /// <summary>
    /// Agent has no access to the service.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("__98hHol5EeavwKddCbm3hg")]
    [Description(@"Agent has no access to the service.")]
    NoAccessToService,

    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("__98hLol5EeavwKddCbm3hg")]
    [Description(
        @"Instruction is rejected since the provided certification is incorrect or incomplete."
    )]
    IncorrectCertification,

    /// <summary>
    /// Date is not a business day for the security market.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("__98hLYl5EeavwKddCbm3hg")]
    [Description(@"Date is not a business day for the security market.")]
    NotBusinessDay,

    /// <summary>
    /// Effective date is after the payment date.
    /// Encoded/decoded by serializers as &quot;PDAY&quot;.
    /// </summary>
    [EnumMember(Value = "PDAY")]
    [IsoId("__98hGYl5EeavwKddCbm3hg")]
    [Description(@"Effective date is after the payment date.")]
    EffectiveDayAfterPaymentDate,

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("__98hE4l5EeavwKddCbm3hg")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount,

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("__9yxCol5EeavwKddCbm3hg")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption,

    /// <summary>
    /// Party is not active.
    /// Encoded/decoded by serializers as &quot;NPAT&quot;.
    /// </summary>
    [EnumMember(Value = "NPAT")]
    [IsoId("__98hDIl5EeavwKddCbm3hg")]
    [Description(@"Party is not active.")]
    NonActiveParty,

    /// <summary>
    /// Period ending date is before period starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("__9yxAYl5EeavwKddCbm3hg")]
    [Description(@"Period ending date is before period starting date.")]
    PeriodEndDateBeforeStartDate,

    /// <summary>
    /// Record date is after payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("__9yw34l5EeavwKddCbm3hg")]
    [Description(@"Record date is after payment date.")]
    RecordDateAfterPaymentDate,

    /// <summary>
    /// Validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("__9yw6Il5EeavwKddCbm3hg")]
    [Description(@"Validation of the advice/instruction/request failed.")]
    FailedValidation,

    /// <summary>
    /// Rejected as the deactivation of the event is already completed.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("__9yxEYl5EeavwKddCbm3hg")]
    [Description(@"Rejected as the deactivation of the event is already completed.")]
    EventAlreadyDeactivated,

    /// <summary>
    /// Cancellation request is rejected as there is no pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PDEA&quot;.
    /// </summary>
    [EnumMember(Value = "PDEA")]
    [IsoId("__9ywxol5EeavwKddCbm3hg")]
    [Description(
        @"Cancellation request is rejected as there is no pending deactivation instruction."
    )]
    NoPendingDeactivationInstruction,

    /// <summary>
    /// Amendment is not allowed.
    /// Encoded/decoded by serializers as &quot;NAMD&quot;.
    /// </summary>
    [EnumMember(Value = "NAMD")]
    [IsoId("__9ywv4l5EeavwKddCbm3hg")]
    [Description(@"Amendment is not allowed.")]
    AmendmentNotAllowed,

    /// <summary>
    /// Cancellation is not allowed.
    /// Encoded/decoded by serializers as &quot;NCAN&quot;.
    /// </summary>
    [EnumMember(Value = "NCAN")]
    [IsoId("__98hFol5EeavwKddCbm3hg")]
    [Description(@"Cancellation is not allowed.")]
    CancellationNotAllowed,

    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("__9yxMol5EeavwKddCbm3hg")]
    [Description(@"Instruction/Request arrives too late.")]
    Late,

    /// <summary>
    /// Election advice is already cancelled.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("__9yxHol5EeavwKddCbm3hg")]
    [Description(@"Election advice is already cancelled.")]
    ElectionAlreadyCancelled,

    /// <summary>
    /// Election advice is already amended.
    /// Encoded/decoded by serializers as &quot;ELEA&quot;.
    /// </summary>
    [EnumMember(Value = "ELEA")]
    [IsoId("__98hHIl5EeavwKddCbm3hg")]
    [Description(@"Election advice is already amended.")]
    ElectionAlreadyAmended,

    /// <summary>
    /// Agent corporate action deactivation instruction with the same identification already exists.
    /// Encoded/decoded by serializers as &quot;SAME&quot;.
    /// </summary>
    [EnumMember(Value = "SAME")]
    [IsoId("__9yw5Yl5EeavwKddCbm3hg")]
    [Description(
        @"Agent corporate action deactivation instruction with the same identification already exists."
    )]
    SameCAIdentification,

    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;REFI&quot;.
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("__9ywzIl5EeavwKddCbm3hg")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification,

    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as &quot;AGIN&quot;.
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("__98hBYl5EeavwKddCbm3hg")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent,

    /// <summary>
    /// Agent identification specified does not correspond to the main agent of the relating event.
    /// Encoded/decoded by serializers as &quot;MAIN&quot;.
    /// </summary>
    [EnumMember(Value = "MAIN")]
    [IsoId("__9yxGIl5EeavwKddCbm3hg")]
    [Description(
        @"Agent identification specified does not correspond to the main agent of the relating event."
    )]
    NotMainAgent,

    /// <summary>
    /// Invalid combination of corporate action option code and corporate action option number.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("__9yxNol5EeavwKddCbm3hg")]
    [Description(
        @"Invalid combination of corporate action option code and corporate action option number."
    )]
    InvalidOption,

    /// <summary>
    /// Specified corporate action option already has a pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("__9ywvIl5EeavwKddCbm3hg")]
    [Description(
        @"Specified corporate action option already has a pending deactivation instruction."
    )]
    PendingDeactivation,

    /// <summary>
    /// Unable to identify cash account.
    /// Encoded/decoded by serializers as &quot;CASA&quot;.
    /// </summary>
    [EnumMember(Value = "CASA")]
    [IsoId("__9yxKol5EeavwKddCbm3hg")]
    [Description(@"Unable to identify cash account.")]
    NotIdentifiedCashAccount,

    /// <summary>
    /// Unable to identify correspondent bank.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("__9ywz4l5EeavwKddCbm3hg")]
    [Description(@"Unable to identify correspondent bank.")]
    NotIdentifiedCorrespondentBank,

    /// <summary>
    /// Invalid standing instruction type for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("__9yxPIl5EeavwKddCbm3hg")]
    [Description(@"Invalid standing instruction type for the specified underlying security.")]
    InvalidStandingInstructionType,

    /// <summary>
    /// No holding for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;NOHO&quot;.
    /// </summary>
    [EnumMember(Value = "NOHO")]
    [IsoId("__9yxFol5EeavwKddCbm3hg")]
    [Description(@"No holding for the specified underlying security.")]
    NoHolding,

    /// <summary>
    /// Insufficient balance.
    /// Encoded/decoded by serializers as &quot;INHO&quot;.
    /// </summary>
    [EnumMember(Value = "INHO")]
    [IsoId("__9yxFYl5EeavwKddCbm3hg")]
    [Description(@"Insufficient balance.")]
    InsufficientBalance,

    /// <summary>
    /// Several messages with the same identification.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("__98hEol5EeavwKddCbm3hg")]
    [Description(@"Several messages with the same identification.")]
    SameIdentification,

    /// <summary>
    /// Rejected as the deactivation of the option is already completed.
    /// Encoded/decoded by serializers as &quot;DEAO&quot;.
    /// </summary>
    [EnumMember(Value = "DEAO")]
    [IsoId("__9yxKIl5EeavwKddCbm3hg")]
    [Description(@"Rejected as the deactivation of the option is already completed.")]
    OptionAlreadyDeactivated,

    /// <summary>
    /// Corporate action event type does not correspond with the relating corporate action.
    /// Encoded/decoded by serializers as &quot;INET&quot;.
    /// </summary>
    [EnumMember(Value = "INET")]
    [IsoId("__9yw24l5EeavwKddCbm3hg")]
    [Description(
        @"Corporate action event type does not correspond with the relating corporate action."
    )]
    InvalidEventType,

    /// <summary>
    /// Underlying security identification does not correspond with the corporate action reference supplied.
    /// Encoded/decoded by serializers as &quot;INUS&quot;.
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("__9yw14l5EeavwKddCbm3hg")]
    [Description(
        @"Underlying security identification does not correspond with the corporate action reference supplied."
    )]
    InvalidUnderlyingSecurity,

    /// <summary>
    /// Event processing type does not correspond with the relating corporate action.
    /// Encoded/decoded by serializers as &quot;INPT&quot;.
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("__9yww4l5EeavwKddCbm3hg")]
    [Description(@"Event processing type does not correspond with the relating corporate action.")]
    InvalidEventProcessingType,

    /// <summary>
    /// Mandatory/voluntary event type does not correspond with the relating corporate action.
    /// Encoded/decoded by serializers as &quot;INMV&quot;.
    /// </summary>
    [EnumMember(Value = "INMV")]
    [IsoId("__9yxH4l5EeavwKddCbm3hg")]
    [Description(
        @"Mandatory/voluntary event type does not correspond with the relating corporate action."
    )]
    InvalidMandatoryVoluntaryEventType,

    /// <summary>
    /// Details specified in the corporate action general information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("__9ywyol5EeavwKddCbm3hg")]
    [Description(
        @"Details specified in the corporate action general information block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidCorporateActionInformation,

    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("__9yxGol5EeavwKddCbm3hg")]
    [Description(
        @"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message."
    )]
    InvalidDetails,

    /// <summary>
    /// Specified corporate action has no remaining option to disable.
    /// Encoded/decoded by serializers as &quot;NORO&quot;.
    /// </summary>
    [EnumMember(Value = "NORO")]
    [IsoId("__98hCol5EeavwKddCbm3hg")]
    [Description(@"Specified corporate action has no remaining option to disable.")]
    NoRemainingOption,

    /// <summary>
    /// Issuer corporate action identification does not correspond with the corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;MICA&quot;.
    /// </summary>
    [EnumMember(Value = "MICA")]
    [IsoId("__98hEIl5EeavwKddCbm3hg")]
    [Description(
        @"Issuer corporate action identification does not correspond with the corporate action identification supplied."
    )]
    MismatchedCAIdentification,

    /// <summary>
    /// Instruction type is not applicable for mandatory events.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("__98hI4l5EeavwKddCbm3hg")]
    [Description(@"Instruction type is not applicable for mandatory events.")]
    NotApplicable,

    /// <summary>
    /// Details specified in the movement general information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INMO&quot;.
    /// </summary>
    [EnumMember(Value = "INMO")]
    [IsoId("__9yxJIl5EeavwKddCbm3hg")]
    [Description(
        @"Details specified in the movement general information block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidMovementInformation,

    /// <summary>
    /// One or more of the underlying movements have already settled.
    /// Encoded/decoded by serializers as &quot;MOSE&quot;.
    /// </summary>
    [EnumMember(Value = "MOSE")]
    [IsoId("__9yw2ol5EeavwKddCbm3hg")]
    [Description(@"One or more of the underlying movements have already settled.")]
    MovementAlreadySettled,

    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__9yxP4l5EeavwKddCbm3hg")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,

    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("__9yxM4l5EeavwKddCbm3hg")]
    [Description(
        @"Instruction contains an invalid message identification, identification is unknown."
    )]
    InvalidIdentification,

    /// <summary>
    /// Certification has not been filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("__9yw5ol5EeavwKddCbm3hg")]
    [Description(@"Certification has not been filled in.")]
    MissingCertification,

    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("__98hCYl5EeavwKddCbm3hg")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty,

    /// <summary>
    /// Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("__98hKol5EeavwKddCbm3hg")]
    [Description(
        @"Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned."
    )]
    InvalidRequest,

    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("__9yxQ4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__9yxAIl5EeavwKddCbm3hg")]
    [Description(@"Other. See Narrative.")]
    Other,

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("__9yxF4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3,

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("__98hJ4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2,

    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("__9yxQol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1,

    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("__9yxCYl5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository,

    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as &quot;INVM&quot;.
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("__9yxOIl5EeavwKddCbm3hg")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest,

    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as &quot;INVL&quot;.
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("__98hBIl5EeavwKddCbm3hg")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink,

    /// <summary>
    /// Instruction aims at using an invalid balance.
    /// Encoded/decoded by serializers as &quot;INVB&quot;.
    /// </summary>
    [EnumMember(Value = "INVB")]
    [IsoId("__9yxBIl5EeavwKddCbm3hg")]
    [Description(@"Instruction aims at using an invalid balance.")]
    InvalidBalance,

    /// <summary>
    /// Invalid or unrecognized lot number.
    /// Encoded/decoded by serializers as &quot;INVN&quot;.
    /// </summary>
    [EnumMember(Value = "INVN")]
    [IsoId("__98hLIl5EeavwKddCbm3hg")]
    [Description(@"Invalid or unrecognized lot number.")]
    InvalidLotNumber,

    /// <summary>
    /// Account servicer validation rule rejection.
    /// Encoded/decoded by serializers as &quot;VALR&quot;.
    /// </summary>
    [EnumMember(Value = "VALR")]
    [IsoId("__9yw0Il5EeavwKddCbm3hg")]
    [Description(@"Account servicer validation rule rejection.")]
    InvalidRule,

    /// <summary>
    /// Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.
    /// Encoded/decoded by serializers as &quot;PLIS&quot;.
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("__9yxQYl5EeavwKddCbm3hg")]
    [Description(
        @"Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied."
    )]
    PlaceOfListing,

    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("__98hIol5EeavwKddCbm3hg")]
    [Description(
        @"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act."
    )]
    InvalidInvestorParty,

    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("__98hIYl5EeavwKddCbm3hg")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails,

    /// <summary>
    /// Unrecognised or invalid closing closing amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("__9yw9ol5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid closing closing amount.")]
    ClosingTransactionAmount,

    /// <summary>
    /// Order entry date is missing.
    /// Encoded/decoded by serializers as &quot;ODNP&quot;.
    /// </summary>
    [EnumMember(Value = "ODNP")]
    [IsoId("__9yw6ol5EeavwKddCbm3hg")]
    [Description(@"Order entry date is missing.")]
    OrderDateNotProvided,

    /// <summary>
    /// Market member executed the order exceeding the requested quantity.
    /// Encoded/decoded by serializers as &quot;TQHI&quot;.
    /// </summary>
    [EnumMember(Value = "TQHI")]
    [IsoId("__9yxBol5EeavwKddCbm3hg")]
    [Description(@"Market member executed the order exceeding the requested quantity.")]
    TradedQuantityHigherThanOriginalOrderQuantity,

    /// <summary>
    /// A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed.
    /// Encoded/decoded by serializers as &quot;TNAR&quot;.
    /// </summary>
    [EnumMember(Value = "TNAR")]
    [IsoId("__9yw-Il5EeavwKddCbm3hg")]
    [Description(
        @"A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed."
    )]
    TransactionNoticeAlreadyAcceptedOrRejected,

    /// <summary>
    /// The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown.
    /// Encoded/decoded by serializers as &quot;TNIU&quot;.
    /// </summary>
    [EnumMember(Value = "TNIU")]
    [IsoId("__98hD4l5EeavwKddCbm3hg")]
    [Description(
        @"The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown."
    )]
    TransactionNoticeIDUnknown,

    /// <summary>
    /// Reason is not available or unknown.
    /// Encoded/decoded by serializers as &quot;NTAV&quot;.
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("__98hG4l5EeavwKddCbm3hg")]
    [Description(@"Reason is not available or unknown.")]
    NotAvailable,

    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as &quot;DQCS&quot;.
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("__9ywx4l5EeavwKddCbm3hg")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    AmountRejection,

    /// <summary>
    /// Invalid instructed currency.
    /// Encoded/decoded by serializers as &quot;DQCC&quot;.
    /// </summary>
    [EnumMember(Value = "DQCC")]
    [IsoId("__9yxE4l5EeavwKddCbm3hg")]
    [Description(@"Invalid instructed currency.")]
    CurrencyRejection,

    /// <summary>
    /// Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers.
    /// Encoded/decoded by serializers as &quot;DQAM&quot;.
    /// </summary>
    [EnumMember(Value = "DQAM")]
    [IsoId("__9ywy4l5EeavwKddCbm3hg")]
    [Description(
        @"Invalid use of instructed amount (QCAS) or of instructed quantity (QINS) qualifiers."
    )]
    InstructionTypeRejection,

    /// <summary>
    /// Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as &quot;DQBI&quot;.
    /// </summary>
    [EnumMember(Value = "DQBI")]
    [IsoId("_1onhALXSEeiTob_PrFFUxA")]
    [Description(
        @"Bid price / basis points / percentage increments rejected due to invalid bid increment for the event (generally used in Dutch Auctions or Bid Tenders)."
    )]
    InvalidBidIncrement,

    /// <summary>
    /// Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders).
    /// Encoded/decoded by serializers as &quot;DQBV&quot;.
    /// </summary>
    [EnumMember(Value = "DQBV")]
    [IsoId("_I9E0QLXTEeiTob_PrFFUxA")]
    [Description(
        @"Bid price / basis points / percentage falls outside of bid range for the event (generally used in Dutch Auctions or Bid Tenders)."
    )]
    InvalidBidValue,

    /// <summary>
    /// Instruction is rejected due to invalid use of the additional round up quantity.
    /// Encoded/decoded by serializers as &quot;IRDQ&quot;.
    /// </summary>
    [EnumMember(Value = "IRDQ")]
    [IsoId("_Q_Os0LXTEeiTob_PrFFUxA")]
    [Description(
        @"Instruction is rejected due to invalid use of the additional round up quantity."
    )]
    InvalidUseRoundUpQuantity,

    /// <summary>
    /// Requested additional documentation is missing.
    /// Encoded/decoded by serializers as &quot;ADDM&quot;.
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("_zyJglbKnEemux5trsZcCpw")]
    [Description(@"Requested additional documentation is missing. ")]
    AdditionalDocumentationMissing,

    /// <summary>
    /// Event has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_zpS7ALKxEemDyeh7tbvg1w")]
    [Description(@"Event has been cancelled.")]
    EventCancelled,

    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as &quot;DREM&quot;.
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("_LoEBQLKyEemDyeh7tbvg1w")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed,

    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as &quot;NPOS&quot;.
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("_5sOhQLLGEemDyeh7tbvg1w")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition,

    /// <summary>
    /// Resolution number provided discrepancy.
    /// Encoded/decoded by serializers as &quot;RESN&quot;.
    /// </summary>
    [EnumMember(Value = "RESN")]
    [IsoId("_UTi-ILLHEemDyeh7tbvg1w")]
    [Description(@"Resolution number provided discrepancy.")]
    ResolutionNumberDiscrepancy,

    /// <summary>
    /// Disclosure request identification is invalid or unknown.
    /// Encoded/decoded by serializers as &quot;IDRI&quot;.
    /// </summary>
    [EnumMember(Value = "IDRI")]
    [IsoId("_XCZJUMAVEembi_x1QDJfxw")]
    [Description(@"Disclosure request identification is invalid or unknown.")]
    InvalidDisclosureRequestIdentification,

    /// <summary>
    /// Disclosure response identification is invalid or unknown.
    /// Encoded/decoded by serializers as &quot;IDRJ&quot;.
    /// </summary>
    [EnumMember(Value = "IDRJ")]
    [IsoId("_vg0nEMAVEembi_x1QDJfxw")]
    [Description(@"Disclosure response identification is invalid or unknown.")]
    InvalidDisclosureResponseIdentification,

    /// <summary>
    /// Service for which the information was sent is not offered.
    /// Encoded/decoded by serializers as &quot;SVNO&quot;.
    /// </summary>
    [EnumMember(Value = "SVNO")]
    [IsoId("__5h64MAVEembi_x1QDJfxw")]
    [Description(@"Service for which the information was sent is not offered.")]
    ServiceNotOffered,

    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as &quot;ITAX&quot;.
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("__B3IAOXxEemEj48jhmlA0Q")]
    [Description(
        @"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country."
    )]
    IncorrectTaxRate,

    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_Gfk2wOXyEemEj48jhmlA0Q")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate,

    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_LzrNoOXyEemEj48jhmlA0Q")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate,

    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_xiamcOkJEemm4qhb2yFPOw")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement,

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_c6r4AOkKEemm4qhb2yFPOw")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate,

    /// <summary>
    /// Standing Settlement Instruction is unknown or invalid.
    /// Encoded/decoded by serializers as &quot;SSID&quot;.
    /// </summary>
    [EnumMember(Value = "SSID")]
    [IsoId("_aPMssOkLEemm4qhb2yFPOw")]
    [Description(@"Standing Settlement Instruction is unknown or invalid.")]
    StandingSettlementInstructionRejection,

    /// <summary>
    /// Invalid use of solicitation dealer fee indicator.
    /// Encoded/decoded by serializers as &quot;ISOL&quot;.
    /// </summary>
    [EnumMember(Value = "ISOL")]
    [IsoId("_GCDcIO6BEeqc-LCjwLsUVg")]
    [Description(@"Invalid use of solicitation dealer fee indicator.")]
    InvalidSolicitationDealerFeeUse,

    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as &quot;BSTR&quot;.
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("_TKbDwO6FEeqc-LCjwLsUVg")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod,

    /// <summary>
    /// Contact information is missing.
    /// Encoded/decoded by serializers as &quot;CTCT&quot;.
    /// </summary>
    [EnumMember(Value = "CTCT")]
    [IsoId("_bSYpYO6FEeqc-LCjwLsUVg")]
    [Description(@"Contact information is missing.")]
    MissingContact,

    /// <summary>
    /// Instruction is rejected due to duplicate business message identifier.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_gLjXwO6FEeqc-LCjwLsUVg")]
    [Description(@"Instruction is rejected due to duplicate business message identifier.")]
    DuplicateInstruction,

    /// <summary>
    /// Protect identification is required for cover protect instructions.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_nmuv4O6FEeqc-LCjwLsUVg")]
    [Description(@"Protect identification is required for cover protect instructions.")]
    MissingProtectIdentification,

    /// <summary>
    /// No protect privilege for this event.
    /// Encoded/decoded by serializers as &quot;PRON&quot;.
    /// </summary>
    [EnumMember(Value = "PRON")]
    [IsoId("_uDR8kO6FEeqc-LCjwLsUVg")]
    [Description(@"No protect privilege for this event.")]
    NoProtectPrivilege,

    /// <summary>
    /// Protect date is required for cover protect instructions.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_1rjVgO6FEeqc-LCjwLsUVg")]
    [Description(@"Protect date is required for cover protect instructions.")]
    MissingProtectDate,

    /// <summary>
    /// Transaction type is missing or invalid for protect or cover protect instructions.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_BjCg4O6GEeqc-LCjwLsUVg")]
    [Description(
        @"Transaction type is missing or invalid for protect or cover protect instructions."
    )]
    MissingTransactionType,

    /// <summary>
    /// Instruction is invalid due to multiple resolutions instructed as vote &quot;For” and belonging to the same listing group resolution label number.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("__S5yoPNZEeqRfth943bvEA")]
    [Description(
        @"Instruction is invalid due to multiple resolutions instructed as vote ""For” and belonging to the same listing group resolution label number."
    )]
    InvalidVoteInFavourInGroupListing,

    /// <summary>
    /// Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book.
    /// Encoded/decoded by serializers as &quot;NOSL&quot;.
    /// </summary>
    [EnumMember(Value = "NOSL")]
    [IsoId("_8NBGIPNhEeqRfth943bvEA")]
    [Description(
        @"Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book."
    )]
    NotRegisteredInInStockLedger,

    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_iMzSoDDEEeunENYTWutRtQ")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled,

    /// <summary>
    /// Unrecognised or invalid client collateral instruction identification.
    /// Encoded/decoded by serializers as &quot;CCIX&quot;.
    /// </summary>
    [EnumMember(Value = "CCIX")]
    [IsoId("_YemuEMnaEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or invalid client collateral instruction identification.")]
    ClientCollateralInstructionIdentification,

    /// <summary>
    /// Unrecognised or invalid Client Collateral Transaction Identification.
    /// Encoded/decoded by serializers as &quot;CCTI&quot;.
    /// </summary>
    [EnumMember(Value = "CCTI")]
    [IsoId("_YenVIMnaEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or invalid Client Collateral Transaction Identification.")]
    ClientCollateralTransactionIdentification,

    /// <summary>
    /// Compound simple accrual calculation is not supported.
    /// Encoded/decoded by serializers as &quot;CSAC&quot;.
    /// </summary>
    [EnumMember(Value = "CSAC")]
    [IsoId("_YenVIcnaEeuaR5rC-LtxeA")]
    [Description(@"Compound simple accrual calculation is not supported.||")]
    CompoundSimpleAccrualCalculationRejection,

    /// <summary>
    /// Day count basis not supported.
    /// Encoded/decoded by serializers as &quot;DCBR&quot;.
    /// </summary>
    [EnumMember(Value = "DCBR")]
    [IsoId("_YenVIsnaEeuaR5rC-LtxeA")]
    [Description(@"Day count basis not supported.|")]
    DayCountBasis,

    /// <summary>
    /// This is an unrecognised or invalid Collateral Transaction Type.
    /// Encoded/decoded by serializers as &quot;ICTT&quot;.
    /// </summary>
    [EnumMember(Value = "ICTT")]
    [IsoId("_54WEhMnbEeuaR5rC-LtxeA")]
    [Description(@"This is an unrecognised or invalid Collateral Transaction Type.")]
    InvalidCollateralTransactionType,

    /// <summary>
    /// Unrecognised or invalid common identification.
    /// Encoded/decoded by serializers as &quot;ICID&quot;.
    /// </summary>
    [EnumMember(Value = "ICID")]
    [IsoId("_54WEhcnbEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or invalid common identification.")]
    InvalidCommonIdentification,

    /// <summary>
    /// This is an unrecognised or invalid Eligibility Set Profile.
    /// Encoded/decoded by serializers as &quot;IESP&quot;.
    /// </summary>
    [EnumMember(Value = "IESP")]
    [IsoId("_54WEhsnbEeuaR5rC-LtxeA")]
    [Description(@"This is an unrecognised or invalid Eligibility Set Profile.")]
    InvalidEligibilitySetProfile,

    /// <summary>
    /// This is an unrecognised or invalid Exposure Type (used when a proprietary code is sent).
    /// Encoded/decoded by serializers as &quot;IEXT&quot;.
    /// </summary>
    [EnumMember(Value = "IEXT")]
    [IsoId("_54WEh8nbEeuaR5rC-LtxeA")]
    [Description(
        @"This is an unrecognised or invalid Exposure Type (used when a proprietary code is sent)."
    )]
    InvalidExposureType,

    /// <summary>
    /// Unrecognised or Invalid Party A.
    /// Encoded/decoded by serializers as &quot;PTYA&quot;.
    /// </summary>
    [EnumMember(Value = "PTYA")]
    [IsoId("_dm7A1MncEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or Invalid Party A.")]
    InvalidPartyA,

    /// <summary>
    /// Unrecognised or Invalid Party B
    /// Encoded/decoded by serializers as &quot;PTYB&quot;.
    /// </summary>
    [EnumMember(Value = "PTYB")]
    [IsoId("_dm7A1cncEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or Invalid Party B")]
    InvalidPartyB,

    /// <summary>
    /// Unrecognised or invalid Preferential Basket identification.
    /// Encoded/decoded by serializers as &quot;IPBI&quot;.
    /// </summary>
    [EnumMember(Value = "IPBI")]
    [IsoId("_dm7A1sncEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or invalid Preferential Basket identification.")]
    InvalidPreferentialBasketIdentification,

    /// <summary>
    /// Unrecognised or invalid Rate Index Type (used when a proprietary code is sent).
    /// Encoded/decoded by serializers as &quot;IRIT&quot;.
    /// </summary>
    [EnumMember(Value = "IRIT")]
    [IsoId("_dm7A18ncEeuaR5rC-LtxeA")]
    [Description(
        @"Unrecognised or invalid Rate Index Type (used when a proprietary code is sent)."
    )]
    InvalidRateIndexType,

    /// <summary>
    /// Unrecognised or Invalid Triparty Agent
    /// Encoded/decoded by serializers as &quot;ITPA&quot;.
    /// </summary>
    [EnumMember(Value = "ITPA")]
    [IsoId("_C2hD8cndEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or Invalid Triparty Agent")]
    InvalidTripartyAgent,

    /// <summary>
    /// Number of lookback days not supported.
    /// Encoded/decoded by serializers as &quot;LBDR&quot;.
    /// </summary>
    [EnumMember(Value = "LBDR")]
    [IsoId("_NnIG0cndEeuaR5rC-LtxeA")]
    [Description(@"Number of lookback days not supported.|")]
    LookbackDaysRejection,

    /// <summary>
    /// Instruction has been rejected as the corresponding allegement was cancelled.
    /// Encoded/decoded by serializers as &quot;NFCA&quot;.
    /// </summary>
    [EnumMember(Value = "NFCA")]
    [IsoId("_XImnpMneEeuaR5rC-LtxeA")]
    [Description(@"Instruction has been rejected as the corresponding allegement was cancelled.")]
    NotFoundCorrespondingAllegement,

    /// <summary>
    /// Cancellation, modification or termination request has been rejected since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRJN&quot;.
    /// </summary>
    [EnumMember(Value = "NRJN")]
    [IsoId("_XImnpcneEeuaR5rC-LtxeA")]
    [Description(
        @"Cancellation, modification or termination request has been rejected since the instruction could not be found."
    )]
    NotFoundRejectionForCancellationModificationOrTermination,

    /// <summary>
    /// Unrecognised or invalid Party A Safekeeping Account
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("_XImnpsneEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or invalid Party A Safekeeping Account")]
    PartyASafekeepingAccount,

    /// <summary>
    /// Unrecognised or Invalid Party B Safekeeping Account.
    /// Encoded/decoded by serializers as &quot;SAFB&quot;.
    /// </summary>
    [EnumMember(Value = "SAFB")]
    [IsoId("_XImnp8neEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or Invalid Party B Safekeeping Account.")]
    PartyBSafekeepingAccount,

    /// <summary>
    /// Cancellation request was rejected because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;RSET&quot;.
    /// </summary>
    [EnumMember(Value = "RSET")]
    [IsoId("_2aNCU8neEeuaR5rC-LtxeA")]
    [Description(@"Cancellation request was rejected because the instruction was already settled.")]
    RejectedSinceAlreadySettled,

    /// <summary>
    /// Cancellation request was rejected because the repurchase was cancelled.
    /// Encoded/decoded by serializers as &quot;RREP&quot;.
    /// </summary>
    [EnumMember(Value = "RREP")]
    [IsoId("_2aNCVMneEeuaR5rC-LtxeA")]
    [Description(@"Cancellation request was rejected because the repurchase was cancelled.")]
    RejectedSinceRepoEnded,

    /// <summary>
    /// Invalid execution date/time
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_2aNCVcneEeuaR5rC-LtxeA")]
    [Description(@"Invalid execution date/time")]
    RequestedExecutionDateTime,

    /// <summary>
    /// Unrecognised or invalid settlement process instructed.
    /// Encoded/decoded by serializers as &quot;SEPR&quot;.
    /// </summary>
    [EnumMember(Value = "SEPR")]
    [IsoId("_eMAjgsnfEeuaR5rC-LtxeA")]
    [Description(@"Unrecognised or invalid settlement process instructed.|")]
    SettlementProcessRejection,

    /// <summary>
    /// Termination amount currency not supported.
    /// Encoded/decoded by serializers as &quot;TMAC&quot;.
    /// </summary>
    [EnumMember(Value = "TMAC")]
    [IsoId("_eMAjg8nfEeuaR5rC-LtxeA")]
    [Description(@"Termination amount currency not supported.")]
    TerminationAmountCurrency,

    /// <summary>
    /// Transaction amount breakdown does not equal the transaction amount.
    /// Encoded/decoded by serializers as &quot;TXAB&quot;.
    /// </summary>
    [EnumMember(Value = "TXAB")]
    [IsoId("_1Cjdc8nfEeuaR5rC-LtxeA")]
    [Description(@"Transaction amount breakdown does not equal the transaction amount.")]
    TransactionAmountBreakdown,

    /// <summary>
    /// Transaction amount breakdown currency differs from transaction amount currency.
    /// Encoded/decoded by serializers as &quot;TABC&quot;.
    /// </summary>
    [EnumMember(Value = "TABC")]
    [IsoId("_1CjddMnfEeuaR5rC-LtxeA")]
    [Description(
        @"Transaction amount breakdown currency differs from transaction amount currency."
    )]
    TransactionAmountBreakdownCurrency,

    /// <summary>
    /// Transaction amount currency not supported.
    /// Encoded/decoded by serializers as &quot;TXAC&quot;.
    /// </summary>
    [EnumMember(Value = "TXAC")]
    [IsoId("_1CjddcnfEeuaR5rC-LtxeA")]
    [Description(@"Transaction amount currency not supported.")]
    TransactionAmountCurrency,

    /// <summary>
    /// Instruction rejected by the issuer agent.
    /// Encoded/decoded by serializers as &quot;REJA&quot;.
    /// </summary>
    [EnumMember(Value = "REJA")]
    [IsoId("_2WxREBnxEeyroI8qKgB7Mg")]
    [Description(@"Instruction rejected by the issuer agent.")]
    RejectedByIssuerAgent,

    /// <summary>
    /// Required paperwork is invalid, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;IPAW&quot;.
    /// </summary>
    [EnumMember(Value = "IPAW")]
    [IsoId("_DV0hcBnyEeyroI8qKgB7Mg")]
    [Description(@"Required paperwork is invalid, incomplete or missing.")]
    InvalidPaperwork,

    /// <summary>
    /// Instruction rejected due to the method of participation not supported by the account servicer.
    /// Encoded/decoded by serializers as &quot;PMNS&quot;.
    /// </summary>
    [EnumMember(Value = "PMNS")]
    [IsoId("_KNuFIBrpEeyhRdHRjakS2w")]
    [Description(
        @"Instruction rejected due to the method of participation not supported by the account servicer."
    )]
    ParticipationMethodNotSupported,

    /// <summary>
    /// Payout type is missing.
    /// Encoded/decoded by serializers as &quot;PTYP&quot;.
    /// </summary>
    [EnumMember(Value = "PTYP")]
    [IsoId("")]
    [Description(@"Payout type is missing.")]
    MissingPayoutType,

    /// <summary>
    /// Rights transferrable flag is missing.
    /// Encoded/decoded by serializers as &quot;RITR&quot;.
    /// </summary>
    [EnumMember(Value = "RITR")]
    [IsoId("")]
    [Description(@"Rights transferrable flag is missing.")]
    MissingRightsTransferrableFlag,

    /// <summary>
    /// Rounding factor is missing.
    /// Encoded/decoded by serializers as &quot;ROUN&quot;.
    /// </summary>
    [EnumMember(Value = "ROUN")]
    [IsoId("")]
    [Description(@"Rounding factor is missing.")]
    MissingRoudingFactor,

    /// <summary>
    /// Securities rate is missing.
    /// Encoded/decoded by serializers as &quot;SERT&quot;.
    /// </summary>
    [EnumMember(Value = "SERT")]
    [IsoId("")]
    [Description(@"Securities rate is missing.")]
    MissingSecuritiesRate,

    /// <summary>
    /// Solicitation dealer fee flag is missing.
    /// Encoded/decoded by serializers as &quot;SFEE&quot;.
    /// </summary>
    [EnumMember(Value = "SFEE")]
    [IsoId("")]
    [Description(@"Solicitation dealer fee flag is missing.")]
    MissingSolicitationDealerFeeFlag,

    /// <summary>
    /// Subscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;SUCH&quot;.
    /// </summary>
    [EnumMember(Value = "SUCH")]
    [IsoId("")]
    [Description(@"Subscription charge flag is missing.")]
    MissingSubscriptionChargeFlag,

    /// <summary>
    /// Subscription price is missing.
    /// Encoded/decoded by serializers as &quot;SUPR&quot;.
    /// </summary>
    [EnumMember(Value = "SUPR")]
    [IsoId("")]
    [Description(@"Subscription price is missing.")]
    MissingSubscriptionPrice,

    /// <summary>
    /// Unspecified price allowed is missing.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("")]
    [Description(@"Unspecified price allowed is missing.")]
    MissingUnspecifiedPriceAllowed,

    /// <summary>
    /// Instruction was received prior to entitlement date.
    /// Encoded/decoded by serializers as &quot;IPED&quot;.
    /// </summary>
    [EnumMember(Value = "IPED")]
    [IsoId("")]
    [Description(@"Instruction was received prior to entitlement date.")]
    InstructionPriorToEntitlementDate,

    /// <summary>
    /// Back end odd lot quantity is missing.
    /// Encoded/decoded by serializers as &quot;BACK&quot;.
    /// </summary>
    [EnumMember(Value = "BACK")]
    [IsoId("")]
    [Description(@"Back end odd lot quantity is missing.")]
    MissingBackEndOddLotQuantity,

    /// <summary>
    /// Bid interval is missing.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("")]
    [Description(@"Bid interval is missing.")]
    MissingBidInterval,

    /// <summary>
    /// Cash in lieu price is missing.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("")]
    [Description(@"Cash in lieu price is missing.")]
    MissingCashInLieuPrice,

    /// <summary>
    /// Conditional tenders accepted flag is missing.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("")]
    [Description(@"Conditional tenders accepted flag is missing.")]
    MissingConditionalTendersAcceptedFlag,

    /// <summary>
    /// Cash rate is missing.
    /// Encoded/decoded by serializers as &quot;CSRT&quot;.
    /// </summary>
    [EnumMember(Value = "CSRT")]
    [IsoId("")]
    [Description(@"Cash rate is missing.")]
    MissingCashRate,

    /// <summary>
    /// First bid increment is missing.
    /// Encoded/decoded by serializers as &quot;FIRS&quot;.
    /// </summary>
    [EnumMember(Value = "FIRS")]
    [IsoId("")]
    [Description(@"First bid increment is missing.")]
    MissingFirstBidIncrement,

    /// <summary>
    /// Fractional disposition is missing.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("")]
    [Description(@"Fractional disposition is missing.")]
    MissingFractionalDisposition,

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;IDIS&quot;.
    /// </summary>
    [EnumMember(Value = "IDIS")]
    [IsoId("")]
    [Description(@"Disbursed security identification is missing.")]
    InvalidDisbursedSecurityIdentification,

    /// <summary>
    /// Issuer agent contact information is invalid or missing.
    /// Encoded/decoded by serializers as &quot;ISSC&quot;.
    /// </summary>
    [EnumMember(Value = "ISSC")]
    [IsoId("")]
    [Description(@"Issuer agent contact information is invalid or missing.")]
    InvalidOrMissingIssuerAgentContactInformation,

    /// <summary>
    /// Issuer agent is missing.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("")]
    [Description(@"Issuer agent is missing.")]
    MissingIssuerAgent,

    /// <summary>
    /// Last bid increment is missing.
    /// Encoded/decoded by serializers as &quot;LAST&quot;.
    /// </summary>
    [EnumMember(Value = "LAST")]
    [IsoId("")]
    [Description(@"Last bid increment is missing.")]
    MissingLastBidIncrement,

    /// <summary>
    /// Maximum price is missing.
    /// Encoded/decoded by serializers as &quot;MAXP&quot;.
    /// </summary>
    [EnumMember(Value = "MAXP")]
    [IsoId("")]
    [Description(@"Maximum price is missing.")]
    MissingMaximumPrice,

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;MDIS&quot;.
    /// </summary>
    [EnumMember(Value = "MDIS")]
    [IsoId("")]
    [Description(@"Disbursed security identification is missing.")]
    MissingDisbursedSecurityIdentification,

    /// <summary>
    /// Full conditional flag is missing.
    /// Encoded/decoded by serializers as &quot;MFCF&quot;.
    /// </summary>
    [EnumMember(Value = "MFCF")]
    [IsoId("")]
    [Description(@"Full conditional flag is missing.")]
    MissingFullConditionalFlag,

    /// <summary>
    /// Minimum price is missing.
    /// Encoded/decoded by serializers as &quot;MINP&quot;.
    /// </summary>
    [EnumMember(Value = "MINP")]
    [IsoId("")]
    [Description(@"Minimum price is missing.")]
    MissingMinimumPrice,

    /// <summary>
    /// Proration rounding indicator is missing.
    /// Encoded/decoded by serializers as &quot;MPRI&quot;.
    /// </summary>
    [EnumMember(Value = "MPRI")]
    [IsoId("")]
    [Description(@"Proration rounding indicator is missing.")]
    MissingProrationRoundingIndicator,

    /// <summary>
    /// Odd lot priority flag is missing.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("")]
    [Description(@"Odd lot priority flag is missing.")]
    MissingOddLotPriorityFlag,

    /// <summary>
    /// Oversubscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;OVCH&quot;.
    /// </summary>
    [EnumMember(Value = "OVCH")]
    [IsoId("")]
    [Description(@"Oversubscription charge flag is missing.")]
    MissingOversubscriptionChargeFlag,

    /// <summary>
    /// Oversubscription flag is missing.
    /// Encoded/decoded by serializers as &quot;OVFL&quot;.
    /// </summary>
    [EnumMember(Value = "OVFL")]
    [IsoId("")]
    [Description(@"Oversubscription flag is missing.")]
    MissingOversubscriptionFlag,

    /// <summary>
    /// Oversubscription price is missing.
    /// Encoded/decoded by serializers as &quot;OVPR&quot;.
    /// </summary>
    [EnumMember(Value = "OVPR")]
    [IsoId("")]
    [Description(@"Oversubscription price is missing.")]
    MissingOversubscriptionPrice,

    /// <summary>
    /// Price basis is missing.
    /// Encoded/decoded by serializers as &quot;PBAS&quot;.
    /// </summary>
    [EnumMember(Value = "PBAS")]
    [IsoId("")]
    [Description(@"Price basis is missing.")]
    MissingPriceBasis,

    /// <summary>
    /// Protect charge indicator is missing.
    /// Encoded/decoded by serializers as &quot;PRCH&quot;.
    /// </summary>
    [EnumMember(Value = "PRCH")]
    [IsoId("")]
    [Description(@"Protect charge indicator is missing.")]
    MissingProtectChargeIndicator,

    /// <summary>
    /// Proration rate is missing.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("")]
    [Description(@"Proration rate is missing.")]
    MissingProrationRate,
}
