// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YdP3Kdp-Ed-ak6NoX_4Aeg_-169908687")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[Derivations(
    typeof(RejectionReason29Code),
    typeof(RejectionReason42Code),
    typeof(RejectionReason38Code),
    typeof(HoldingRejectionReason41Code),
    typeof(RejectionReason23Code),
    typeof(RejectionReasonV021Code),
    typeof(RejectionReason35Code),
    typeof(RejectionReason34Code),
    typeof(RejectionReason37Code),
    typeof(RejectionReason26Code),
    typeof(RejectionReason24Code),
    typeof(RejectionReason43Code),
    typeof(RejectionReason31Code),
    typeof(RejectionReason32Code),
    typeof(RejectionReason27Code),
    typeof(RejectionReason25Code),
    typeof(RejectionReason39Code),
    typeof(RejectionReason16Code),
    typeof(RejectionReason21Code),
    typeof(RejectionReason22Code),
    typeof(RejectionReason30Code),
    typeof(RejectionReason33Code),
    typeof(RejectionReason40Code)
)]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum RejectionReasonV2Code
{
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_n6aZcbc5EeGCF88YGZghEA_798959065")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_YdZBENp-Ed-ak6NoX_4Aeg_-283747753")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_YdZBEdp-Ed-ak6NoX_4Aeg_-1458938778")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_YdZBEtp-Ed-ak6NoX_4Aeg_-2087014692")]
    [Description(@"Position is less than required threshold.")]
    InsufficientTresholdPosition,

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_YdZBE9p-Ed-ak6NoX_4Aeg_-441747257")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_YdZBFNp-Ed-ak6NoX_4Aeg_-514863856")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_YdZBFdp-Ed-ak6NoX_4Aeg_-1690054881")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed,

    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_YdZBFtp-Ed-ak6NoX_4Aeg_1899797800")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed,

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_YdZBF9p-Ed-ak6NoX_4Aeg_-749902061")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,

    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_YdZBGNp-Ed-ak6NoX_4Aeg_788886381")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy,

    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_YdZBGdp-Ed-ak6NoX_4Aeg_-386304644")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy,

    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_YdiyENp-Ed-ak6NoX_4Aeg_-1091419259")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar,

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_YdiyEdp-Ed-ak6NoX_4Aeg_553848176")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,

    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_YdiyEtp-Ed-ak6NoX_4Aeg_2092636618")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable,

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YdiyE9p-Ed-ak6NoX_4Aeg_917445593")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    OptionCancelled,

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_YdiyFNp-Ed-ak6NoX_4Aeg_212330978")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option."
    )]
    OptionInactive,

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_YdiyFdp-Ed-ak6NoX_4Aeg_1857598413")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities,

    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as &quot;REFT&quot;.
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_YdiyFtp-Ed-ak6NoX_4Aeg_-898580441")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities,

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_YdiyF9p-Ed-ak6NoX_4Aeg_-2073771466")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities,

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_YdsjENp-Ed-ak6NoX_4Aeg_1516081215")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_YdsjEdp-Ed-ak6NoX_4Aeg_-1133618646")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch,

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_YdsjEtp-Ed-ak6NoX_4Aeg_405169796")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection,

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_YdsjE9p-Ed-ak6NoX_4Aeg_-770021229")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_YdsjFNp-Ed-ak6NoX_4Aeg_-1475135844")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled,

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_YdsjFdp-Ed-ak6NoX_4Aeg_170131591")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress,

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_YdsjFtp-Ed-ak6NoX_4Aeg_1708920033")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification,

    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_YdsjF9p-Ed-ak6NoX_4Aeg_533729008")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol,

    /// <summary>
    /// Exchange on which the financial instrument is traded is closed.
    /// Encoded/decoded by serializers as &quot;EXCL&quot;.
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("_YdsjGNp-Ed-ak6NoX_4Aeg_-171385607")]
    [Description(@"Exchange on which the financial instrument is traded is closed.")]
    ClosedExchange,

    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as &quot;EXLI&quot;.
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("_YdsjGdp-Ed-ak6NoX_4Aeg_1473881828")]
    [Description(
        @"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit."
    )]
    ExceedsLimit,

    /// <summary>
    /// Request has exceeded the allowed time frame.
    /// Encoded/decoded by serializers as &quot;TOLA&quot;.
    /// </summary>
    [EnumMember(Value = "TOLA")]
    [IsoId("_YdsjGtp-Ed-ak6NoX_4Aeg_-1282297026")]
    [Description(@"Request has exceeded the allowed time frame.")]
    TooLate,

    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_Yd1tANp-Ed-ak6NoX_4Aeg_1837479245")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice,

    /// <summary>
    /// Permission to be processed is not granted.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_Yd1tAdp-Ed-ak6NoX_4Aeg_1132364630")]
    [Description(@"Permission to be processed is not granted.")]
    NotAuthorised,

    /// <summary>
    /// No counterparty order has been identified.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_Yd1tAtp-Ed-ak6NoX_4Aeg_-1517335231")]
    [Description(@"No counterparty order has been identified.")]
    NoMatchInquiry,

    /// <summary>
    /// Referred instrument does not exist in combination with the mentioned market.
    /// Encoded/decoded by serializers as &quot;NINS&quot;.
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("_Yd1tA9p-Ed-ak6NoX_4Aeg_21453211")]
    [Description(@"Referred instrument does not exist in combination with the mentioned market.")]
    NoInstrumentMarket,

    /// <summary>
    /// Requested financial instrument is not available.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_Yd1tBNp-Ed-ak6NoX_4Aeg_-1153737814")]
    [Description(@"Requested financial instrument is not available.")]
    NoInventory,

    /// <summary>
    /// Counterparty is not interested in the transaction.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_Yd1tBdp-Ed-ak6NoX_4Aeg_-1858852429")]
    [Description(@"Counterparty is not interested in the transaction.")]
    Pass,

    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_Yd1tBtp-Ed-ak6NoX_4Aeg_-213584994")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds,

    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_Yd1tB9p-Ed-ak6NoX_4Aeg_1325203448")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds,

    /// <summary>
    /// Order is for the wrong side.
    /// Encoded/decoded by serializers as &quot;SIDE&quot;.
    /// </summary>
    [EnumMember(Value = "SIDE")]
    [IsoId("_Yd1tCNp-Ed-ak6NoX_4Aeg_150012423")]
    [Description(@"Order is for the wrong side.")]
    WrongSide,

    /// <summary>
    /// Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side&apos;s calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("_Yd1tCdp-Ed-ak6NoX_4Aeg_-555102192")]
    [Description(
        @"Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high."
    )]
    CalculationDifference,

    /// <summary>
    /// Requestor has no insufficient credit to make the trade.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_Yd_eANp-Ed-ak6NoX_4Aeg_1090165243")]
    [Description(@"Requestor has no insufficient credit to make the trade.")]
    InsufficientCredit,

    /// <summary>
    /// Agreement start date is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ASTM&quot;.
    /// </summary>
    [EnumMember(Value = "ASTM")]
    [IsoId("_Yd_eAdp-Ed-ak6NoX_4Aeg_941486863")]
    [Description(@"Agreement start date is missing or invalid.")]
    AgreementStartDate,

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Yd_eAtp-Ed-ak6NoX_4Aeg_-233704162")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Yd_eA9p-Ed-ak6NoX_4Aeg_-938818777")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Yd_eBNp-Ed-ak6NoX_4Aeg_706448658")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Yd_eBdp-Ed-ak6NoX_4Aeg_-2049730196")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,

    /// <summary>
    /// Unrecognised or invalid delivering custodian.
    /// Encoded/decoded by serializers as &quot;DCUS&quot;.
    /// </summary>
    [EnumMember(Value = "DCUS")]
    [IsoId("_Yd_eBtp-Ed-ak6NoX_4Aeg_1070046075")]
    [Description(@"Unrecognised or invalid delivering custodian.")]
    DeliveringCustodian,

    /// <summary>
    /// Unrecognised or invalid receiving agent.
    /// Encoded/decoded by serializers as &quot;RCUS&quot;.
    /// </summary>
    [EnumMember(Value = "RCUS")]
    [IsoId("_Yd_eB9p-Ed-ak6NoX_4Aeg_364931460")]
    [Description(@"Unrecognised or invalid receiving agent.")]
    ReceivingCustodian,

    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_YeIn8Np-Ed-ak6NoX_4Aeg_2010198895")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,

    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as &quot;QUNP&quot;.
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("_YeIn8dp-Ed-ak6NoX_4Aeg_-745979959")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType,

    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as &quot;REPA&quot;.
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_YeIn8tp-Ed-ak6NoX_4Aeg_-1921170984")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_YeIn89p-Ed-ak6NoX_4Aeg_1668681697")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_YeIn9Np-Ed-ak6NoX_4Aeg_-981018164")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_YeSY8Np-Ed-ak6NoX_4Aeg_557770278")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_YeSY8dp-Ed-ak6NoX_4Aeg_-617420747")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,

    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as &quot;TQNP&quot;.
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("_YeSY8tp-Ed-ak6NoX_4Aeg_-1322535362")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity,

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_YeSY89p-Ed-ak6NoX_4Aeg_322732073")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate,

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_YeSY9Np-Ed-ak6NoX_4Aeg_1861520515")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent,

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_YeSY9dp-Ed-ak6NoX_4Aeg_686329490")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary,

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_YeSY9tp-Ed-ak6NoX_4Aeg_1626482310")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_YeSY99p-Ed-ak6NoX_4Aeg_-1129696544")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown,

    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_YeSY-Np-Ed-ak6NoX_4Aeg_1990079727")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_YeSY-dp-Ed-ak6NoX_4Aeg_1284965112")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,

    /// <summary>
    /// Unrecognised or invalid letter of guarantee indicator instructed.
    /// Encoded/decoded by serializers as &quot;LEOG&quot;.
    /// </summary>
    [EnumMember(Value = "LEOG")]
    [IsoId("_YeSY-tp-Ed-ak6NoX_4Aeg_-1364734749")]
    [Description(@"Unrecognised or invalid letter of guarantee indicator instructed.")]
    LetterOfGuaranteeIndicatorRejection,

    /// <summary>
    /// Missing credit authorisation (for pre-release transactions).
    /// Encoded/decoded by serializers as &quot;MCRA&quot;.
    /// </summary>
    [EnumMember(Value = "MCRA")]
    [IsoId("_YecJ8Np-Ed-ak6NoX_4Aeg_174053693")]
    [Description(@"Missing credit authorisation (for pre-release transactions).")]
    MissingCreditAuthorisation,

    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as &quot;DADR&quot;.
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_YecJ8dp-Ed-ak6NoX_4Aeg_-1001137332")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection,

    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_YecJ8tp-Ed-ak6NoX_4Aeg_1477803930")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_YecJ89p-Ed-ak6NoX_4Aeg_302612905")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection,

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_YecJ9Np-Ed-ak6NoX_4Aeg_-402501710")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,

    /// <summary>
    /// Missing statutes or commercial register or other legal documents.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_YecJ9dp-Ed-ak6NoX_4Aeg_1242765725")]
    [Description(@"Missing statutes or commercial register or other legal documents.")]
    MissingStatutes,

    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_YecJ9tp-Ed-ak6NoX_4Aeg_-1513413129")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    NotStampedOrSigned,

    /// <summary>
    /// Registration request does not have a valid signature of the owner of the financial instrument.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_YecJ99p-Ed-ak6NoX_4Aeg_1606363142")]
    [Description(
        @"Registration request does not have a valid signature of the owner of the financial instrument."
    )]
    InvalidSignature,

    /// <summary>
    /// Unrecognised or invalid shareholder number.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_YecJ-Np-Ed-ak6NoX_4Aeg_-1627736326")]
    [Description(@"Unrecognised or invalid shareholder number.")]
    ShareholderNumberRejection,

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_YecJ-dp-Ed-ak6NoX_4Aeg_17531109")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity,

    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_YelT4Np-Ed-ak6NoX_4Aeg_1556319551")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch,

    /// <summary>
    /// Missing legal power for transfer.
    /// Encoded/decoded by serializers as &quot;MLEG&quot;.
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("_YelT4dp-Ed-ak6NoX_4Aeg_381128526")]
    [Description(@"Missing legal power for transfer.")]
    MissingLegalPower,

    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_YelT4tp-Ed-ak6NoX_4Aeg_-323986089")]
    [Description(
        @"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch."
    )]
    ProcessingBatchRejection,

    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as &quot;OWNT&quot;.
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_YelT49p-Ed-ak6NoX_4Aeg_1321281346")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection,

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_YelT5Np-Ed-ak6NoX_4Aeg_-1434897508")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity,

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.
    /// Encoded/decoded by serializers as &quot;REQW&quot;.
    /// </summary>
    [EnumMember(Value = "REQW")]
    [IsoId("_YelT5dp-Ed-ak6NoX_4Aeg_1684878763")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar."
    )]
    WrongRegistrationRequest,

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_YelT5tp-Ed-ak6NoX_4Aeg_979764148")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection,

    /// <summary>
    /// Registration reason indicated is not correct.
    /// Encoded/decoded by serializers as &quot;RREA&quot;.
    /// </summary>
    [EnumMember(Value = "RREA")]
    [IsoId("_YelT59p-Ed-ak6NoX_4Aeg_-1669935713")]
    [Description(@"Registration reason indicated is not correct.")]
    DisagreementInRegistrationReason,

    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is missing.
    /// Encoded/decoded by serializers as &quot;REQM&quot;.
    /// </summary>
    [EnumMember(Value = "REQM")]
    [IsoId("_YelT6Np-Ed-ak6NoX_4Aeg_-131147271")]
    [Description(
        @"Registration request to be completed by the buyer and to be forwarded to the issuer is missing."
    )]
    MissingRegistrationRequest,

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_YelT6dp-Ed-ak6NoX_4Aeg_-1306338296")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection,

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_YelT6tp-Ed-ak6NoX_4Aeg_-2011452911")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection,

    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_YevE4Np-Ed-ak6NoX_4Aeg_-366185476")]
    [Description(
        @"Unrecognised or invalid service level agreement pre-agreed narrative information."
    )]
    NarrativeInformationRejection,

    /// <summary>
    /// Invalid or incorrect programme conversion specified.
    /// Encoded/decoded by serializers as &quot;ICOP&quot;.
    /// </summary>
    [EnumMember(Value = "ICOP")]
    [IsoId("_YevE4dp-Ed-ak6NoX_4Aeg_1249641667")]
    [Description(@"Invalid or incorrect programme conversion specified.")]
    IncorrectProgramConversion,

    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as &quot;ICOL&quot;.
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_YevE4tp-Ed-ak6NoX_4Aeg_-1537454399")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral,

    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as &quot;BPAR&quot;.
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_YevE49p-Ed-ak6NoX_4Aeg_2052398282")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection,

    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as &quot;BREF&quot;.
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_YevE5Np-Ed-ak6NoX_4Aeg_-597301579")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection,

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_YevE5dp-Ed-ak6NoX_4Aeg_941486863")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection,

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_YevE5tp-Ed-ak6NoX_4Aeg_-233704162")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection,

    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as &quot;CASY&quot;.
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_YevE59p-Ed-ak6NoX_4Aeg_-938818777")]
    [Description(
        @"Impossible standing arrangements override instruction for the cash settlement system."
    )]
    ImpossibleCashSettlementSystem,

    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_YevE6Np-Ed-ak6NoX_4Aeg_706448658")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection,

    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as &quot;CONL&quot;.
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_YevE6dp-Ed-ak6NoX_4Aeg_-2049730196")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded,

    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_Ye414Np-Ed-ak6NoX_4Aeg_1070046075")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure,

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Ye414dp-Ed-ak6NoX_4Aeg_364931460")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,

    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_Ye414tp-Ed-ak6NoX_4Aeg_-745979959")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount,

    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as &quot;DISE&quot;.
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_Ye4149p-Ed-ak6NoX_4Aeg_-1921170984")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount,

    /// <summary>
    /// Disagreement between the data on the registration request and the order.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_Ye415Np-Ed-ak6NoX_4Aeg_1668681697")]
    [Description(@"Disagreement between the data on the registration request and the order.")]
    RegistrationRequestDataAndOrderRejection,

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_Ye415dp-Ed-ak6NoX_4Aeg_-981018164")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection,

    /// <summary>
    /// Incorrect activity type specified, for example, pre-release conversion.
    /// Encoded/decoded by serializers as &quot;IACT&quot;.
    /// </summary>
    [EnumMember(Value = "IACT")]
    [IsoId("_Ye415tp-Ed-ak6NoX_4Aeg_557770278")]
    [Description(@"Incorrect activity type specified, for example, pre-release conversion.")]
    IncorrectActivityType,

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Ye4159p-Ed-ak6NoX_4Aeg_-617420747")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Ye416Np-Ed-ak6NoX_4Aeg_-1322535362")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection,

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Ye416dp-Ed-ak6NoX_4Aeg_322732073")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection,

    /// <summary>
    /// Second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_YfB_0Np-Ed-ak6NoX_4Aeg_1861520515")]
    [Description(@"Second option is mandatory.")]
    MissingOption,

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("_YfB_0dp-Ed-ak6NoX_4Aeg_686329490")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent,

    /// <summary>
    /// Period ending date or code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("_YfB_0tp-Ed-ak6NoX_4Aeg_-18785125")]
    [Description(@"Period ending date or code is missing.")]
    MissingPeriodEndDate,

    /// <summary>
    /// Period starting date or code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_YfB_09p-Ed-ak6NoX_4Aeg_1626482310")]
    [Description(@"Period starting date or code is missing.")]
    MissingPeriodStartDate,

    /// <summary>
    /// Resulting amount must be filled in as exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_YfB_1Np-Ed-ak6NoX_4Aeg_-1129696544")]
    [Description(@"Resulting amount must be filled in as exchange rate is present.")]
    MissingResultingAmount,

    /// <summary>
    /// Security type does not match with the type of corporate action.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_YfB_1dp-Ed-ak6NoX_4Aeg_1990079727")]
    [Description(@"Security type does not match with the type of corporate action.")]
    WrongSecurityType,

    /// <summary>
    /// Disperse security is not eligible in the (ICSD) service provider owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_YfB_1tp-Ed-ak6NoX_4Aeg_1284965112")]
    [Description(@"Disperse security is not eligible in the (ICSD) service provider owner.")]
    NotEligibleDisperseSecurity,

    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_YfB_19p-Ed-ak6NoX_4Aeg_-1364734749")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity,

    /// <summary>
    /// Resulting amount is not allowed without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("_YfB_2Np-Ed-ak6NoX_4Aeg_174053693")]
    [Description(@"Resulting amount is not allowed without an exchange rate.")]
    MissingExchangeRate,

    /// <summary>
    /// Value date is before payment date.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_YfB_2dp-Ed-ak6NoX_4Aeg_-1001137332")]
    [Description(@"Value date is before payment date.")]
    ValueDateBeforePaymentDate,

    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_YfLw0Np-Ed-ak6NoX_4Aeg_-1706251947")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest,

    /// <summary>
    /// Agent has no access to the service.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_YfLw0dp-Ed-ak6NoX_4Aeg_-60984512")]
    [Description(@"Agent has no access to the service.")]
    NoAccessToService,

    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_YfLw0tp-Ed-ak6NoX_4Aeg_1477803930")]
    [Description(
        @"Instruction is rejected since the provided certification is incorrect or incomplete."
    )]
    IncorrectCertification,

    /// <summary>
    /// Date is not a business day for the security market.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_YfLw09p-Ed-ak6NoX_4Aeg_-2055129218")]
    [Description(@"Date is not a business day for the security market.")]
    NotBusinessDay,

    /// <summary>
    /// Effective date is after the payment date.
    /// Encoded/decoded by serializers as &quot;PDAY&quot;.
    /// </summary>
    [EnumMember(Value = "PDAY")]
    [IsoId("_YfLw1Np-Ed-ak6NoX_4Aeg_-516340776")]
    [Description(@"Effective date is after the payment date.")]
    EffectiveDayAfterPaymentDate,

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("_YfLw1dp-Ed-ak6NoX_4Aeg_-1691531801")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount,

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_YfLw1tp-Ed-ak6NoX_4Aeg_210854058")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption,

    /// <summary>
    /// Party is not active.
    /// Encoded/decoded by serializers as &quot;NPAT&quot;.
    /// </summary>
    [EnumMember(Value = "NPAT")]
    [IsoId("_YfLw19p-Ed-ak6NoX_4Aeg_1856121493")]
    [Description(@"Party is not active.")]
    NonActiveParty,

    /// <summary>
    /// Period ending date is before period starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_YfLw2Np-Ed-ak6NoX_4Aeg_-900057361")]
    [Description(@"Period ending date is before period starting date.")]
    PeriodEndDateBeforeStartDate,

    /// <summary>
    /// Record date is after payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_YfLw2dp-Ed-ak6NoX_4Aeg_-2075248386")]
    [Description(@"Record date is after payment date.")]
    RecordDateAfterPaymentDate,

    /// <summary>
    /// Validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_YfU6wNp-Ed-ak6NoX_4Aeg_1514604295")]
    [Description(@"Validation of the advice/instruction/request failed.")]
    FailedValidation,

    /// <summary>
    /// Rejected as the deactivation of the event is already completed.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_YfU6wdp-Ed-ak6NoX_4Aeg_-1135095566")]
    [Description(@"Rejected as the deactivation of the event is already completed.")]
    EventAlreadyDeactivated,

    /// <summary>
    /// Cancellation request is rejected as there is no pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PDEA&quot;.
    /// </summary>
    [EnumMember(Value = "PDEA")]
    [IsoId("_YfU6wtp-Ed-ak6NoX_4Aeg_403692876")]
    [Description(
        @"Cancellation request is rejected as there is no pending deactivation instruction."
    )]
    NoPendingDeactivationInstruction,

    /// <summary>
    /// Amendment is not allowed.
    /// Encoded/decoded by serializers as &quot;NAMD&quot;.
    /// </summary>
    [EnumMember(Value = "NAMD")]
    [IsoId("_YfU6w9p-Ed-ak6NoX_4Aeg_-771498149")]
    [Description(@"Amendment is not allowed.")]
    AmendmentNotAllowed,

    /// <summary>
    /// Cancellation is not allowed.
    /// Encoded/decoded by serializers as &quot;NCAN&quot;.
    /// </summary>
    [EnumMember(Value = "NCAN")]
    [IsoId("_YfU6xNp-Ed-ak6NoX_4Aeg_-1476612764")]
    [Description(@"Cancellation is not allowed.")]
    CancellationNotAllowed,

    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_YfU6xdp-Ed-ak6NoX_4Aeg_168654671")]
    [Description(@"Instruction/Request arrives too late.")]
    Late,

    /// <summary>
    /// Election advice is already cancelled.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_YfU6xtp-Ed-ak6NoX_4Aeg_1707443113")]
    [Description(@"Election advice is already cancelled.")]
    ElectionAlreadyCancelled,

    /// <summary>
    /// Election advice is already amended.
    /// Encoded/decoded by serializers as &quot;ELEA&quot;.
    /// </summary>
    [EnumMember(Value = "ELEA")]
    [IsoId("_YfU6x9p-Ed-ak6NoX_4Aeg_532252088")]
    [Description(@"Election advice is already amended.")]
    ElectionAlreadyAmended,

    /// <summary>
    /// Agent corporate action deactivation instruction with the same identification already exists.
    /// Encoded/decoded by serializers as &quot;SAME&quot;.
    /// </summary>
    [EnumMember(Value = "SAME")]
    [IsoId("_YfU6yNp-Ed-ak6NoX_4Aeg_-172862527")]
    [Description(
        @"Agent corporate action deactivation instruction with the same identification already exists."
    )]
    SameCAIdentification,

    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;REFI&quot;.
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_YfU6ydp-Ed-ak6NoX_4Aeg_1472404908")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification,

    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as &quot;AGIN&quot;.
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_YferwNp-Ed-ak6NoX_4Aeg_-1283773946")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent,

    /// <summary>
    /// Agent identification specified does not correspond to the main agent of the relating event.
    /// Encoded/decoded by serializers as &quot;MAIN&quot;.
    /// </summary>
    [EnumMember(Value = "MAIN")]
    [IsoId("_Yferwdp-Ed-ak6NoX_4Aeg_1836002325")]
    [Description(
        @"Agent identification specified does not correspond to the main agent of the relating event."
    )]
    NotMainAgent,

    /// <summary>
    /// Invalid combination of corporate action option code and corporate action option number.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_Yferwtp-Ed-ak6NoX_4Aeg_1130887710")]
    [Description(
        @"Invalid combination of corporate action option code and corporate action option number."
    )]
    InvalidOption,

    /// <summary>
    /// Specified corporate action option already has a pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_Yferw9p-Ed-ak6NoX_4Aeg_-1518812151")]
    [Description(
        @"Specified corporate action option already has a pending deactivation instruction."
    )]
    PendingDeactivation,

    /// <summary>
    /// Unable to identify cash account.
    /// Encoded/decoded by serializers as &quot;CASA&quot;.
    /// </summary>
    [EnumMember(Value = "CASA")]
    [IsoId("_YferxNp-Ed-ak6NoX_4Aeg_19976291")]
    [Description(@"Unable to identify cash account.")]
    NotIdentifiedCashAccount,

    /// <summary>
    /// Unable to identify correspondent bank.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_Yferxdp-Ed-ak6NoX_4Aeg_-1155214734")]
    [Description(@"Unable to identify correspondent bank.")]
    NotIdentifiedCorrespondentBank,

    /// <summary>
    /// Invalid standing instruction type for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_Yferxtp-Ed-ak6NoX_4Aeg_-1860329349")]
    [Description(@"Invalid standing instruction type for the specified underlying security.")]
    InvalidStandingInstructionType,

    /// <summary>
    /// No holding for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;NOHO&quot;.
    /// </summary>
    [EnumMember(Value = "NOHO")]
    [IsoId("_Yferx9p-Ed-ak6NoX_4Aeg_-215061914")]
    [Description(@"No holding for the specified underlying security.")]
    NoHolding,

    /// <summary>
    /// Insufficient balance.
    /// Encoded/decoded by serializers as &quot;INHO&quot;.
    /// </summary>
    [EnumMember(Value = "INHO")]
    [IsoId("_YferyNp-Ed-ak6NoX_4Aeg_1323726528")]
    [Description(@"Insufficient balance.")]
    InsufficientBalance,

    /// <summary>
    /// Several messages with the same identification.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_Yferydp-Ed-ak6NoX_4Aeg_148535503")]
    [Description(@"Several messages with the same identification.")]
    SameIdentification,

    /// <summary>
    /// Rejected as the deactivation of the option is already completed.
    /// Encoded/decoded by serializers as &quot;DEAO&quot;.
    /// </summary>
    [EnumMember(Value = "DEAO")]
    [IsoId("_YfocwNp-Ed-ak6NoX_4Aeg_-556579112")]
    [Description(@"Rejected as the deactivation of the option is already completed.")]
    OptionAlreadyDeactivated,

    /// <summary>
    /// Corporate action event type does not correspond with the relating corporate action.
    /// Encoded/decoded by serializers as &quot;INET&quot;.
    /// </summary>
    [EnumMember(Value = "INET")]
    [IsoId("_Yfocwdp-Ed-ak6NoX_4Aeg_1088688323")]
    [Description(
        @"Corporate action event type does not correspond with the relating corporate action."
    )]
    InvalidEventType,

    /// <summary>
    /// Underlying security identification does not correspond with the corporate action reference supplied.
    /// Encoded/decoded by serializers as &quot;INUS&quot;.
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_Yfocwtp-Ed-ak6NoX_4Aeg_-1667490531")]
    [Description(
        @"Underlying security identification does not correspond with the corporate action reference supplied."
    )]
    InvalidUnderlyingSecurity,

    /// <summary>
    /// Event processing type does not correspond with the relating corporate action.
    /// Encoded/decoded by serializers as &quot;INPT&quot;.
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_Yfocw9p-Ed-ak6NoX_4Aeg_1452285740")]
    [Description(@"Event processing type does not correspond with the relating corporate action.")]
    InvalidEventProcessingType,

    /// <summary>
    /// Mandatory/voluntary event type does not correspond with the relating corporate action.
    /// Encoded/decoded by serializers as &quot;INMV&quot;.
    /// </summary>
    [EnumMember(Value = "INMV")]
    [IsoId("_YfocxNp-Ed-ak6NoX_4Aeg_747171125")]
    [Description(
        @"Mandatory/voluntary event type does not correspond with the relating corporate action."
    )]
    InvalidMandatoryVoluntaryEventType,

    /// <summary>
    /// Details specified in the corporate action general information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_Yfocxdp-Ed-ak6NoX_4Aeg_-1902528736")]
    [Description(
        @"Details specified in the corporate action general information block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidCorporateActionInformation,

    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_Yfocxtp-Ed-ak6NoX_4Aeg_-363740294")]
    [Description(
        @"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message."
    )]
    InvalidDetails,

    /// <summary>
    /// Specified corporate action has no remaining option to disable.
    /// Encoded/decoded by serializers as &quot;NORO&quot;.
    /// </summary>
    [EnumMember(Value = "NORO")]
    [IsoId("_Yfocx9p-Ed-ak6NoX_4Aeg_-1538931319")]
    [Description(@"Specified corporate action has no remaining option to disable.")]
    NoRemainingOption,

    /// <summary>
    /// Issuer corporate action identification does not correspond with the corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;MICA&quot;.
    /// </summary>
    [EnumMember(Value = "MICA")]
    [IsoId("_YfocyNp-Ed-ak6NoX_4Aeg_2050921362")]
    [Description(
        @"Issuer corporate action identification does not correspond with the corporate action identification supplied."
    )]
    MismatchedCAIdentification,

    /// <summary>
    /// Instruction type is not applicable for mandatory events.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_Yfocydp-Ed-ak6NoX_4Aeg_-598778499")]
    [Description(@"Instruction type is not applicable for mandatory events.")]
    NotApplicable,

    /// <summary>
    /// Details specified in the movement general information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INMO&quot;.
    /// </summary>
    [EnumMember(Value = "INMO")]
    [IsoId("_YfxmsNp-Ed-ak6NoX_4Aeg_940009943")]
    [Description(
        @"Details specified in the movement general information block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidMovementInformation,

    /// <summary>
    /// One or more of the underlying movements have already settled.
    /// Encoded/decoded by serializers as &quot;MOSE&quot;.
    /// </summary>
    [EnumMember(Value = "MOSE")]
    [IsoId("_Yfxmsdp-Ed-ak6NoX_4Aeg_1530801361")]
    [Description(@"One or more of the underlying movements have already settled.")]
    MovementAlreadySettled,

    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_Yfxmstp-Ed-ak6NoX_4Aeg_825686746")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,

    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_Yfxms9p-Ed-ak6NoX_4Aeg_-1824013115")]
    [Description(
        @"Instruction contains an invalid message identification, identification is unknown."
    )]
    InvalidIdentification,

    /// <summary>
    /// Certification has not been filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_YfxmtNp-Ed-ak6NoX_4Aeg_-285224673")]
    [Description(@"Certification has not been filled in.")]
    MissingCertification,

    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_Yfxmtdp-Ed-ak6NoX_4Aeg_-1460415698")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty,

    /// <summary>
    /// Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_Yfxmttp-Ed-ak6NoX_4Aeg_2129436983")]
    [Description(
        @"Statement/status advice request cannot be executed. The message type requested is not valid for the message reference or statement period concerned."
    )]
    InvalidRequest,

    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_Yfxmt9p-Ed-ak6NoX_4Aeg_906722666")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YfxmuNp-Ed-ak6NoX_4Aeg_-1217447222")]
    [Description(@"Other. See Narrative.")]
    Other,

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Yfxmudp-Ed-ak6NoX_4Aeg_-1260813235")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3,

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Yfxmutp-Ed-ak6NoX_4Aeg_384454200")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2,

    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Yf7XsNp-Ed-ak6NoX_4Aeg_1923242642")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1,

    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Yf7Xsdp-Ed-ak6NoX_4Aeg_748051617")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository,

    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as &quot;INVM&quot;.
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_1oyJR_4uEeClUvPNHKL9Zw")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest,

    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as &quot;INVL&quot;.
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_68_05_4uEeClUvPNHKL9Zw")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink,

    /// <summary>
    /// Instruction aims at using an invalid balance.
    /// Encoded/decoded by serializers as &quot;INVB&quot;.
    /// </summary>
    [EnumMember(Value = "INVB")]
    [IsoId("_5tT5N_4vEeClUvPNHKL9Zw")]
    [Description(@"Instruction aims at using an invalid balance.")]
    InvalidBalance,

    /// <summary>
    /// Invalid or unrecognized lot number.
    /// Encoded/decoded by serializers as &quot;INVN&quot;.
    /// </summary>
    [EnumMember(Value = "INVN")]
    [IsoId("__DALh_4vEeClUvPNHKL9Zw")]
    [Description(@"Invalid or unrecognized lot number.")]
    InvalidLotNumber,

    /// <summary>
    /// Account servicer validation rule rejection.
    /// Encoded/decoded by serializers as &quot;VALR&quot;.
    /// </summary>
    [EnumMember(Value = "VALR")]
    [IsoId("_ECpVV_4wEeClUvPNHKL9Zw")]
    [Description(@"Account servicer validation rule rejection.")]
    InvalidRule,

    /// <summary>
    /// Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.
    /// Encoded/decoded by serializers as &quot;PLIS&quot;.
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_8-l54CwqEeOEV5XHD-BKpw")]
    [Description(
        @"Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied."
    )]
    PlaceOfListing,

    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_HCXE4CwrEeOEV5XHD-BKpw")]
    [Description(
        @"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act."
    )]
    InvalidInvestorParty,

    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_WqzRUTcLEeO3kN9FenmyTQ")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails,

    /// <summary>
    /// Unrecognised or invalid closing closing amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("_rkxw5TcLEeO3kN9FenmyTQ")]
    [Description(@"Unrecognised or invalid closing closing amount.")]
    ClosingTransactionAmount,

    /// <summary>
    /// Order entry date is missing.
    /// Encoded/decoded by serializers as &quot;ODNP&quot;.
    /// </summary>
    [EnumMember(Value = "ODNP")]
    [IsoId("_rkxw5jcLEeO3kN9FenmyTQ")]
    [Description(@"Order entry date is missing.")]
    OrderDateNotProvided,

    /// <summary>
    /// Market member executed the order exceeding the requested quantity.
    /// Encoded/decoded by serializers as &quot;TQHI&quot;.
    /// </summary>
    [EnumMember(Value = "TQHI")]
    [IsoId("_rkxw5zcLEeO3kN9FenmyTQ")]
    [Description(@"Market member executed the order exceeding the requested quantity.")]
    TradedQuantityHigherThanOriginalOrderQuantity,

    /// <summary>
    /// A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed.
    /// Encoded/decoded by serializers as &quot;TNAR&quot;.
    /// </summary>
    [EnumMember(Value = "TNAR")]
    [IsoId("_rkxw6DcLEeO3kN9FenmyTQ")]
    [Description(
        @"A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed."
    )]
    TransactionNoticeAlreadyAcceptedOrRejected,

    /// <summary>
    /// The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown.
    /// Encoded/decoded by serializers as &quot;TNIU&quot;.
    /// </summary>
    [EnumMember(Value = "TNIU")]
    [IsoId("_rkxw6TcLEeO3kN9FenmyTQ")]
    [Description(
        @"The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown."
    )]
    TransactionNoticeIDUnknown,

    /// <summary>
    /// Reason is not available or unknown.
    /// Encoded/decoded by serializers as &quot;NTAV&quot;.
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_gfhIUClGEeWwYv6HydV_vw")]
    [Description(@"Reason is not available or unknown.")]
    NotAvailable,
}
