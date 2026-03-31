// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G1StsEgbEea9YuSvQGoi-w")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectedStatusReason11Code>))]
#endif
public enum RejectedStatusReason11Code
{
    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_u-RmgUggEea9YuSvQGoi-w")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction = RejectedStatusReasonCode.AccountBlockedForCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("_zZ1y4UggEea9YuSvQGoi-w")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer = RejectedStatusReasonCode.AccountBlockedForTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_0_dF0UggEea9YuSvQGoi-w")]
    [Description(
        @"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy."
    )]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after the Receiver&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_1Qt08UggEea9YuSvQGoi-w")]
    [Description(@"Instruction was received after the Receiver's deadline.")]
    AfterDeadline = RejectedStatusReasonCode.AfterDeadline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Assets are illiquid.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("_1kqEoUggEea9YuSvQGoi-w")]
    [Description(@"Assets are illiquid.")]
    AssetsIlliquid = RejectedStatusReasonCode.AssetsIlliquid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of subscription is below the minimum initial investment amount.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_19DWgUggEea9YuSvQGoi-w")]
    [Description(@"Amount of subscription is below the minimum initial investment amount.")]
    BelowMinimumInitialInvestmentAmount =
        RejectedStatusReasonCode.BelowMinimumInitialInvestmentAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount is below the minimum redemption amount.
    /// Encoded/decoded by serializers as &quot;BMRA&quot;.
    /// </summary>
    [EnumMember(Value = "BMRA")]
    [IsoId("_2UQ8oUggEea9YuSvQGoi-w")]
    [Description(@"Amount is below the minimum redemption amount.")]
    BelowMinimumRedemptionAmount = RejectedStatusReasonCode.BelowMinimumRedemptionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding will be below the minimum retained value.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("_2ozCMUggEea9YuSvQGoi-w")]
    [Description(@"Holding will be below the minimum retained value.")]
    BelowMinimumRetainedAmount = RejectedStatusReasonCode.BelowMinimumRetainedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_35uekUggEea9YuSvQGoi-w")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_5v25wUggEea9YuSvQGoi-w")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectedStatusReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDDB&quot;.
    /// </summary>
    [EnumMember(Value = "IDDB")]
    [IsoId("_6LiJIUggEea9YuSvQGoi-w")]
    [Description(@"Direct debit account identification is not recognised or is invalid.")]
    DirectDebit = RejectedStatusReasonCode.DirectDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order reference is a duplicate of a previously received order.
    /// Encoded/decoded by serializers as &quot;ORRF&quot;.
    /// </summary>
    [EnumMember(Value = "ORRF")]
    [IsoId("_6fniwUggEea9YuSvQGoi-w")]
    [Description(@"Order reference is a duplicate of a previously received order.")]
    DuplicateOrderReference = RejectedStatusReasonCode.DuplicateOrderReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_7NlcAUggEea9YuSvQGoi-w")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeOrCommission = RejectedStatusReasonCode.FeeOrCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_7j5qQUggEea9YuSvQGoi-w")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_7ye40UggEea9YuSvQGoi-w")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName =
        RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_79f2AUggEea9YuSvQGoi-w")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity = RejectedStatusReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fund is closed and will not take in any more investments.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("__A_cMUggEea9YuSvQGoi-w")]
    [Description(@"Fund is closed and will not take in any more investments.")]
    FundClosed = RejectedStatusReasonCode.FundClosed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("__OYX8UggEea9YuSvQGoi-w")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount =
        RejectedStatusReasonCode.InstructingPartyNotAllowedForAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient capacity.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("__gro4UggEea9YuSvQGoi-w")]
    [Description(@"Insufficient capacity.")]
    InsufficientCapacity = RejectedStatusReasonCode.InsufficientCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("__4VT4UggEea9YuSvQGoi-w")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectedStatusReasonCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash account is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ARn9oUghEea9YuSvQGoi-w")]
    [Description(@"Cash account is not recognised or invalid.")]
    InvalidCashAccount = RejectedStatusReasonCode.InvalidCashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("_ArXTUUghEea9YuSvQGoi-w")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer = RejectedStatusReasonCode.InvalidCreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order type is invalid.
    /// Encoded/decoded by serializers as &quot;IOTP&quot;.
    /// </summary>
    [EnumMember(Value = "IOTP")]
    [IsoId("_BLDgAUghEea9YuSvQGoi-w")]
    [Description(@"Order type is invalid.")]
    InvalidOrderType = RejectedStatusReasonCode.InvalidOrderType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_CIpwsUghEea9YuSvQGoi-w")]
    [Description(
        @"Form of the security is wrong, eg, the form of security is registered not bearer or vice versa."
    )]
    InvalidSecurityForm = RejectedStatusReasonCode.InvalidSecurityForm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_CcSeYUghEea9YuSvQGoi-w")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    InvalidSettlementAmount = RejectedStatusReasonCode.InvalidSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Coo4UUghEea9YuSvQGoi-w")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lock-up period is in place.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_C-zVkUghEea9YuSvQGoi-w")]
    [Description(@"Lock-up period is in place.")]
    LockUp = RejectedStatusReasonCode.LockUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_D1GrcUghEea9YuSvQGoi-w")]
    [Description(
        @"The cancellation request has been rejected since more than one instruction match to the cancellation criteria."
    )]
    NoCancellationMatch = RejectedStatusReasonCode.NoCancellationMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_Fv_q0UghEea9YuSvQGoi-w")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is not enough cash in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_GLFEUUghEea9YuSvQGoi-w")]
    [Description(@"There is not enough cash in the account to process the instruction.")]
    NotEnoughCash = RejectedStatusReasonCode.NotEnoughCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_Gd-LIUghEea9YuSvQGoi-w")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment card details are incorrect.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_G8BZEUghEea9YuSvQGoi-w")]
    [Description(@"Payment card details are incorrect.")]
    PaymentCard = RejectedStatusReasonCode.PaymentCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage holding breach, for example, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_IZmxYUghEea9YuSvQGoi-w")]
    [Description(@"Percentage holding breach, for example, PPM rules; taxation rules (ERISA).")]
    PercentageHoldingBreach = RejectedStatusReasonCode.PercentageHoldingBreach, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_IxtIUUghEea9YuSvQGoi-w")]
    [Description(
        @"Order contains physical delivery details but the fund can not be physically delivered."
    )]
    PhysicalDeliveryImpossible = RejectedStatusReasonCode.PhysicalDeliveryImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical Settlement Impossible.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_JEAZQUghEea9YuSvQGoi-w")]
    [Description(@"Physical Settlement Impossible.")]
    PhysicalSettlement = RejectedStatusReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Place of Trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_JRQLEUghEea9YuSvQGoi-w")]
    [Description(@"Unrecognised or invalid Place of Trade.")]
    PlaceOfTrade = RejectedStatusReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_JhK2YUghEea9YuSvQGoi-w")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectedStatusReasonCode.ReceivingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible to use RTGS System.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_J7DWAUghEea9YuSvQGoi-w")]
    [Description(@"Impossible to use RTGS System.")]
    RTGSSystem = RejectedStatusReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping place is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ISAF&quot;.
    /// </summary>
    [EnumMember(Value = "ISAF")]
    [IsoId("_KZtA4UghEea9YuSvQGoi-w")]
    [Description(@"Safekeeping place is not recognised or is invalid.")]
    SafekeepingPlace = RejectedStatusReasonCode.SafekeepingPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Settlement Amount Currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_KtyagUghEea9YuSvQGoi-w")]
    [Description(@"Unrecognised or invalid Settlement Amount Currency.")]
    SettlementAmountCurrency = RejectedStatusReasonCode.SettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_LCnbAUghEea9YuSvQGoi-w")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate = RejectedStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_LrFwQUghEea9YuSvQGoi-w")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace = RejectedStatusReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Settlement Transaction.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_MBs5cUghEea9YuSvQGoi-w")]
    [Description(@"Unrecognised or invalid Settlement Transaction.")]
    SettlementTransaction = RejectedStatusReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid subscriber or redeemer.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_MdrDwUghEea9YuSvQGoi-w")]
    [Description(@"Unrecognised or invalid subscriber or redeemer.")]
    SubscriberOrRedeemer = RejectedStatusReasonCode.SubscriberOrRedeemer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of units or amount of money in the order is too high for a subscription.
    /// Encoded/decoded by serializers as &quot;SHIG&quot;.
    /// </summary>
    [EnumMember(Value = "SHIG")]
    [IsoId("_N1S-AUghEea9YuSvQGoi-w")]
    [Description(
        @"Quantity of units or amount of money in the order is too high for a subscription."
    )]
    TooHighUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooHighUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_N_3PQUghEea9YuSvQGoi-w")]
    [Description(@"Instruction was received after market deadline.")]
    TooLate = RejectedStatusReasonCode.TooLate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of units or amount of money in the order is too low for a subscription.
    /// Encoded/decoded by serializers as &quot;SLOW&quot;.
    /// </summary>
    [EnumMember(Value = "SLOW")]
    [IsoId("_ORa5UUghEea9YuSvQGoi-w")]
    [Description(
        @"Quantity of units or amount of money in the order is too low for a subscription."
    )]
    TooLowUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooLowUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_OcuxcUghEea9YuSvQGoi-w")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectedStatusReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage of commission waiving exceeds the commission percentage or commission amount.
    /// Encoded/decoded by serializers as &quot;UWAI&quot;.
    /// </summary>
    [EnumMember(Value = "UWAI")]
    [IsoId("_O5lskUghEea9YuSvQGoi-w")]
    [Description(
        @"Percentage of commission waiving exceeds the commission percentage or commission amount."
    )]
    UnacceptedCommissionWaiving = RejectedStatusReasonCode.UnacceptedCommissionWaiving, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal currency is not supported.
    /// Encoded/decoded by serializers as &quot;UDCY&quot;.
    /// </summary>
    [EnumMember(Value = "UDCY")]
    [IsoId("_PLmCkUghEea9YuSvQGoi-w")]
    [Description(@"Deal currency is not supported.")]
    UnacceptedDealCurrency = RejectedStatusReasonCode.UnacceptedDealCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net asset value currency is not supported.
    /// Encoded/decoded by serializers as &quot;UNAV&quot;.
    /// </summary>
    [EnumMember(Value = "UNAV")]
    [IsoId("_PjZekUghEea9YuSvQGoi-w")]
    [Description(@"Net asset value currency is not supported.")]
    UnacceptedNAVCurrency = RejectedStatusReasonCode.UnacceptedNAVCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment method, for example, cheque or payment card, is not accepted.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_PwopUUghEea9YuSvQGoi-w")]
    [Description(@"Payment method, for example, cheque or payment card, is not accepted.")]
    UnacceptedPaymentMethod = RejectedStatusReasonCode.UnacceptedPaymentMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("_QAaKsUghEea9YuSvQGoi-w")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency =
        RejectedStatusReasonCode.UnacceptedRequestedSettlementCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_QP4KEUghEea9YuSvQGoi-w")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference = RejectedStatusReasonCode.UnknownLinkagesReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction specifies an unacceptable combination for the financial instruments in the switch order.
    /// Encoded/decoded by serializers as &quot;UNSC&quot;.
    /// </summary>
    [EnumMember(Value = "UNSC")]
    [IsoId("_QGIfQVNFEeaOrcVOcDJQkA")]
    [Description(
        @"Instruction specifies an unacceptable combination for the financial instruments in the switch order."
    )]
    UnacceptableSwitchCombination = RejectedStatusReasonCode.UnacceptableSwitchCombination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order contains funds that have different valuation points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_8JBRsb0dEeagCZkbeM8gxw")]
    [Description(@"Order contains funds that have different valuation points.")]
    DifferentValuationPoints = RejectedStatusReasonCode.DifferentValuationPoints, // same ordinal as derivation source for type conversions
}
