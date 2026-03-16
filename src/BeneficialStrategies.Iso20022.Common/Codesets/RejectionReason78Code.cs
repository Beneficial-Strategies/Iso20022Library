// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5q004QaYEe2-DuDrUXkg2w")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason78Code
{
    /// <summary>
    /// Agreement start date is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ASTM&quot;.
    /// </summary>
    [EnumMember(Value = "ASTM")]
    [IsoId("_0JI4gQaZEe2u7bd67K_0bA")]
    [Description(@"Agreement start date is missing or invalid.")]
    AgreementStartDate = RejectionReasonV3Code.AgreementStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_0JI4gwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection = RejectionReasonV3Code.TypeOfOrderRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_0JI4hQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RejectionReasonV3Code.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_0JI4hwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection = RejectionReasonV3Code.CommercializationContractRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_0JI4iQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV3Code.SettlementDateRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_0JI4iwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonV3Code.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_0JI4jQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonV3Code.SettlementAmountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_0JI4jwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_0JI4kQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_0JI4kwaZEe2u7bd67K_0bA")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectionReasonV3Code.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_0JI4lQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection = RejectionReasonV3Code.FeeCommissionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_0JI4lwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RejectionReasonV3Code.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_0JI4mQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3 = RejectionReasonV3Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_0JI4mwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV3Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_0JI4nQaZEe2u7bd67K_0bA")]
    [Description(
        @"Unrecognised or invalid service level agreement pre-agreed narrative information."
    )]
    NarrativeInformationRejection = RejectionReasonV3Code.NarrativeInformationRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_0JI4nwaZEe2u7bd67K_0bA")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason = RejectionReasonV3Code.NarrativeReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_0JI4oQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV3Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order entry date is missing.
    /// Encoded/decoded by serializers as &quot;ODNP&quot;.
    /// </summary>
    [EnumMember(Value = "ODNP")]
    [IsoId("_0JI4owaZEe2u7bd67K_0bA")]
    [Description(@"Order entry date is missing.")]
    OrderDateNotProvided = RejectionReasonV3Code.OrderDateNotProvided, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_0JI4pQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonV3Code.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as &quot;QUNP&quot;.
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("_0JI4pwaZEe2u7bd67K_0bA")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType = RejectionReasonV3Code.QuantityUnitType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_0JI4qQaZEe2u7bd67K_0bA")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV3Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing closing amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("_0JI4qwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid closing closing amount.")]
    ClosingTransactionAmount = RejectionReasonV3Code.ClosingTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_0JI4rQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RejectionReasonV3Code.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_0JI4rwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RejectionReasonV3Code.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_0JI4sQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RejectionReasonV3Code.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_0JI4swaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RejectionReasonV3Code.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_0JI4tQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_0JI4twaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonV3Code.SettlementTransactionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_0JI4uQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection = RejectionReasonV3Code.SettlementSystemMethodRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_0JI4uwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonV3Code.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed.
    /// Encoded/decoded by serializers as &quot;TNAR&quot;.
    /// </summary>
    [EnumMember(Value = "TNAR")]
    [IsoId("_0JI4vQaZEe2u7bd67K_0bA")]
    [Description(
        @"A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed."
    )]
    TransactionNoticeAlreadyAcceptedOrRejected =
        RejectionReasonV3Code.TransactionNoticeAlreadyAcceptedOrRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown.
    /// Encoded/decoded by serializers as &quot;TNIU&quot;.
    /// </summary>
    [EnumMember(Value = "TNIU")]
    [IsoId("_0JI4vwaZEe2u7bd67K_0bA")]
    [Description(
        @"The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown."
    )]
    TransactionNoticeIDUnknown = RejectionReasonV3Code.TransactionNoticeIDUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market member executed the order exceeding the requested quantity.
    /// Encoded/decoded by serializers as &quot;TQHI&quot;.
    /// </summary>
    [EnumMember(Value = "TQHI")]
    [IsoId("_0JI4wQaZEe2u7bd67K_0bA")]
    [Description(@"Market member executed the order exceeding the requested quantity.")]
    TradedQuantityHigherThanOriginalOrderQuantity =
        RejectionReasonV3Code.TradedQuantityHigherThanOriginalOrderQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as &quot;TQNP&quot;.
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("_0JI4wwaZEe2u7bd67K_0bA")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity = RejectionReasonV3Code.TradedSecuritiesQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_0JI4xQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection = RejectionReasonV3Code.TaxStatusRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_0JI4xwaZEe2u7bd67K_0bA")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_0JI4yQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection = RejectionReasonV3Code.VariableRateSupportRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_0JI4ywaZEe2u7bd67K_0bA")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonV3Code.InstructionIrrevocable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_0JI4zQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV3Code.OptionNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_0JI4zwaZEe2u7bd67K_0bA")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_0JI40QaZEe2u7bd67K_0bA")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol = RejectionReasonV3Code.UnknownSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as &quot;EXLI&quot;.
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("_0JI40waZEe2u7bd67K_0bA")]
    [Description(
        @"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit."
    )]
    ExceedsLimit = RejectionReasonV3Code.ExceedsLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_0JI41QaZEe2u7bd67K_0bA")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice = RejectionReasonV3Code.InvalidPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_0JI41waZEe2u7bd67K_0bA")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds = RejectionReasonV3Code.PriceExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_0JI42QaZEe2u7bd67K_0bA")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds = RejectionReasonV3Code.QuantityExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is for the wrong side.
    /// Encoded/decoded by serializers as &quot;SIDE&quot;.
    /// </summary>
    [EnumMember(Value = "SIDE")]
    [IsoId("_0JI42waZEe2u7bd67K_0bA")]
    [Description(@"Order is for the wrong side.")]
    WrongSide = RejectionReasonV3Code.WrongSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side&apos;s calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("_0JI43QaZEe2u7bd67K_0bA")]
    [Description(
        @"Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high."
    )]
    CalculationDifference = RejectionReasonV3Code.CalculationDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_0JI43waZEe2u7bd67K_0bA")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure = RejectionReasonV3Code.UnknownDealExposure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_0JI44QaZEe2u7bd67K_0bA")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount = RejectionReasonV3Code.DisagreeWithCallAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as &quot;DISE&quot;.
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_0JI44waZEe2u7bd67K_0bA")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount = RejectionReasonV3Code.DisagreeWithExposureAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount must be filled in as exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_0JI45QaZEe2u7bd67K_0bA")]
    [Description(@"Resulting amount must be filled in as exchange rate is present.")]
    MissingResultingAmount = RejectionReasonV3Code.MissingResultingAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount is not allowed without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("_0JI45waZEe2u7bd67K_0bA")]
    [Description(@"Resulting amount is not allowed without an exchange rate.")]
    MissingExchangeRate = RejectionReasonV3Code.MissingExchangeRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_0JI46QaZEe2u7bd67K_0bA")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest = RejectionReasonV3Code.UnexpectedAccruedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("_0JI46waZEe2u7bd67K_0bA")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount = RejectionReasonV3Code.GrossAmountLessThanNetAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_0JI47QaZEe2u7bd67K_0bA")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption = RejectionReasonV3Code.MissingDefaultOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_0JI47waZEe2u7bd67K_0bA")]
    [Description(@"Validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonV3Code.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_0JI48QaZEe2u7bd67K_0bA")]
    [Description(
        @"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message."
    )]
    InvalidDetails = RejectionReasonV3Code.InvalidDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0JI48waZEe2u7bd67K_0bA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_kuiDUQanEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository = RejectionReasonV3Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_RtJAkQaoEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2 = RejectionReasonV3Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_aAjBMQaoEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1 = RejectionReasonV3Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
}
