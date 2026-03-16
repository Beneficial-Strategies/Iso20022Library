// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__oFrwNojEeC60axPepSq7g_-241533173")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason28Code
{
    /// <summary>
    /// Agreement start date is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ASTM&quot;.
    /// </summary>
    [EnumMember(Value = "ASTM")]
    [IsoId("__oFrwdojEeC60axPepSq7g_1092343003")]
    [Description(@"Agreement start date is missing or invalid.")]
    AgreementStartDate = RejectionReasonCode.AgreementStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as &quot;BUSE&quot;.
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("__oFrwtojEeC60axPepSq7g_1081244226")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection = RejectionReasonCode.TypeOfOrderRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as &quot;CADE&quot;.
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("__oO1sNojEeC60axPepSq7g_374860616")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RejectionReasonCode.TransactionCallDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognized or invalid commercialization contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("__oO1sdojEeC60axPepSq7g_-417875301")]
    [Description(@"Unrecognized or invalid commercialization contract.")]
    CommercializationContractRejection = RejectionReasonCode.CommercializationContractRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("__oO1stojEeC60axPepSq7g_1049273462")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonCode.SettlementDateRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("__oO1s9ojEeC60axPepSq7g_-92757794")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonCode.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of settlement.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("__oYmsNojEeC60axPepSq7g_-2102714652")]
    [Description(@"Unrecognised or invalid place of settlement.")]
    PlaceOfSettlementRejection = RejectionReasonCode.PlaceOfSettlementRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("__oYmsdojEeC60axPepSq7g_561453676")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonCode.SettlementAmountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("__oYmstojEeC60axPepSq7g_447614610")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonCode.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("__oYms9ojEeC60axPepSq7g_-570607045")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonCode.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("__ohwoNojEeC60axPepSq7g_896541718")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectionReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognized or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("__ohwodojEeC60axPepSq7g_15339981")]
    [Description(@"Unrecognized or invalid fee or commission.")]
    FeeCommissionRejection = RejectionReasonCode.FeeCommissionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("__ohwotojEeC60axPepSq7g_-1363342962")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RejectionReasonCode.ForfeitAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("__ohwo9ojEeC60axPepSq7g_103805801")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectionReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid receiving or delivering custodian.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("__ohwpNojEeC60axPepSq7g_-1374441739")]
    [Description(@"Unrecognised or invalid receiving or delivering custodian.")]
    ReceivingOrDeliveringCustodianRejection =
        RejectionReasonCode.ReceivingOrDeliveringCustodianRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid buyer or seller.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("__ohwpdojEeC60axPepSq7g_92707024")]
    [Description(@"Unrecognised or invalid buyer or seller.")]
    ReceivingDeliveringParty3 = RejectionReasonCode.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("__orhoNojEeC60axPepSq7g_-613676586")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonCode.CommonReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid service level agreement preagreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("__orhodojEeC60axPepSq7g_1682432629")]
    [Description(
        @"Unrecognised or invalid service level agreement preagreed narrative information."
    )]
    NarrativeInformationRejection = RejectionReasonCode.NarrativeInformationRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A narrative reason is provided.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__orhotojEeC60axPepSq7g_2125421121")]
    [Description(@"A narrative reason is provided.")]
    NarrativeReason = RejectionReasonCode.NarrativeReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("__orho9ojEeC60axPepSq7g_-702397412")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonCode.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order entry date is missing.
    /// Encoded/decoded by serializers as &quot;ODNP&quot;.
    /// </summary>
    [EnumMember(Value = "ODNP")]
    [IsoId("__orhpNojEeC60axPepSq7g_-534983976")]
    [Description(@"Order entry date is missing.")]
    OrderDateNotProvided = RejectionReasonCode.OrderDateNotProvided, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("__o1SoNojEeC60axPepSq7g_364850518")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as &quot;QUNP&quot;.
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("__o1SodojEeC60axPepSq7g_-24277907")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType = RejectionReasonCode.QuantityUnitType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("__o1SotojEeC60axPepSq7g_1182712193")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonCode.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing closing amount.
    /// Encoded/decoded by serializers as &quot;CTRA&quot;.
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("__o1So9ojEeC60axPepSq7g_-1645106340")]
    [Description(@"Unrecognised or invalid closing closing amount.")]
    ClosingTransactionAmount = RejectionReasonCode.ClosingTransactionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("__o1SpNojEeC60axPepSq7g_-2034234765")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RejectionReasonCode.RepurchaseRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as &quot;REPP&quot;.
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("__o-ckNojEeC60axPepSq7g_-676423809")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RejectionReasonCode.PremiumAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as &quot;RERT&quot;.
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("__o-ckdojEeC60axPepSq7g_790724954")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RejectionReasonCode.RepurchaseRateType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as &quot;RSPR&quot;.
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("__o-cktojEeC60axPepSq7g_1467996614")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RejectionReasonCode.SpreadRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid or unrecognised safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("__o-ck9ojEeC60axPepSq7g_-2066205529")]
    [Description(@"Instruction contains an invalid or unrecognised safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonCode.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("__o-clNojEeC60axPepSq7g_-2077304306")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonCode.SettlementTransactionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("__pINkNojEeC60axPepSq7g_-610155543")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection = RejectionReasonCode.SettlementSystemMethodRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("__pINkdojEeC60axPepSq7g_-1547177534")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonCode.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed.
    /// Encoded/decoded by serializers as &quot;TNAR&quot;.
    /// </summary>
    [EnumMember(Value = "TNAR")]
    [IsoId("__pINktojEeC60axPepSq7g_-1558276311")]
    [Description(
        @"A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed."
    )]
    TransactionNoticeAlreadyAcceptedOrRejected =
        RejectionReasonCode.TransactionNoticeAlreadyAcceptedOrRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown.
    /// Encoded/decoded by serializers as &quot;TNIU&quot;.
    /// </summary>
    [EnumMember(Value = "TNIU")]
    [IsoId("__pINk9ojEeC60axPepSq7g_-91127548")]
    [Description(
        @"The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown."
    )]
    TransactionNoticeIDUnknown = RejectionReasonCode.TransactionNoticeIDUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market member executed the order exceeding the requested quantity.
    /// Encoded/decoded by serializers as &quot;TQHI&quot;.
    /// </summary>
    [EnumMember(Value = "TQHI")]
    [IsoId("__pINlNojEeC60axPepSq7g_-1104189042")]
    [Description(@"Market member executed the order exceeding the requested quantity.")]
    TradedQuantityHigherThanOriginalOrderQuantity =
        RejectionReasonCode.TradedQuantityHigherThanOriginalOrderQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as &quot;TQNP&quot;.
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("__pINldojEeC60axPepSq7g_362959721")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity = RejectionReasonCode.TradedSecuritiesQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as &quot;TXST&quot;.
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("__pR-kNojEeC60axPepSq7g_-182025732")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection = RejectionReasonCode.TaxStatusRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("__pR-kdojEeC60axPepSq7g_-936775606")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference = RejectionReasonCode.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as &quot;VASU&quot;.
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("__pR-ktojEeC60axPepSq7g_530373157")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection = RejectionReasonCode.VariableRateSupportRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("__pR-k9ojEeC60axPepSq7g_1759252560")]
    [Description(@"The instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonCode.InstructionIrrevocable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("__pR-lNojEeC60axPepSq7g_1152433547")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonCode.OptionNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("__pR-ldojEeC60axPepSq7g_-1493052970")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonCode.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("__pbIgNojEeC60axPepSq7g_-1793715575")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol = RejectionReasonCode.UnknownSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as &quot;EXLI&quot;.
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("__pbIgdojEeC60axPepSq7g_-337665589")]
    [Description(
        @"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit."
    )]
    ExceedsLimit = RejectionReasonCode.ExceedsLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("__pbIgtojEeC60axPepSq7g_480196086")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice = RejectionReasonCode.InvalidPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("__pbIg9ojEeC60axPepSq7g_773342829")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds = RejectionReasonCode.PriceExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("__pbIhNojEeC60axPepSq7g_-2054475704")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds = RejectionReasonCode.QuantityExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is for the wrong side.
    /// Encoded/decoded by serializers as &quot;SIDE&quot;.
    /// </summary>
    [EnumMember(Value = "SIDE")]
    [IsoId("__pbIhdojEeC60axPepSq7g_891213814")]
    [Description(@"Order is for the wrong side.")]
    WrongSide = RejectionReasonCode.WrongSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This is primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side&apos;s calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("__pk5gNojEeC60axPepSq7g_-1414732701")]
    [Description(
        @"This is primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high."
    )]
    CalculationDifference = RejectionReasonCode.CalculationDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as &quot;CPTY&quot;.
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("__pk5gdojEeC60axPepSq7g_-109156866")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure = RejectionReasonCode.UnknownDealExposure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party A does not agree with the call amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("__pk5gtojEeC60axPepSq7g_874792678")]
    [Description(@"Party A does not agree with the call amount.")]
    DisagreeWithCallAmount = RejectionReasonCode.DisagreeWithCallAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party A does not agree with the exposure amount.
    /// Encoded/decoded by serializers as &quot;DISE&quot;.
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("__pk5g9ojEeC60axPepSq7g_1328879947")]
    [Description(@"Party A does not agree with the exposure amount.")]
    DisagreeWithExposureAmount = RejectionReasonCode.DisagreeWithExposureAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount must be filled in as Exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("__pk5hNojEeC60axPepSq7g_722060934")]
    [Description(@"Resulting amount must be filled in as Exchange rate is present.")]
    MissingResultingAmount = RejectionReasonCode.MissingResultingAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There cannot be a resulting amount without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("__pk5hdojEeC60axPepSq7g_372313509")]
    [Description(@"There cannot be a resulting amount without an exchange rate.")]
    MissingExchangeRate = RejectionReasonCode.MissingExchangeRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("__puDcNojEeC60axPepSq7g_-1319866688")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest = RejectionReasonCode.UnexpectedAccruedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("__puDcdojEeC60axPepSq7g_1176217593")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount = RejectionReasonCode.GrossAmountLessThanNetAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("__puDctojEeC60axPepSq7g_17852709")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption = RejectionReasonCode.MissingDefaultOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("__puDc9ojEeC60axPepSq7g_-1666986642")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("__puDdNojEeC60axPepSq7g_-1012559729")]
    [Description(
        @"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message."
    )]
    InvalidDetails = RejectionReasonCode.InvalidDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__puDddojEeC60axPepSq7g_1992711920")]
    [Description(@"Other reason.")]
    Other = RejectionReasonCode.Other, // same ordinal as derivation source for type conversions
}
