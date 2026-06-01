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
[IsoId("3dcd67fd-8179-4b82-ae17-a3250ce6c8f8")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RejectedStatusReason15Code>))]
public enum RejectedStatusReason15Code
{
    /// <summary>
    /// Instruction was received after the Receiver's deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("78dc61df-464b-478a-82e0-beea3064fdbe")]
    [Description(@"Instruction was received after the Receiver's deadline.")]
    AfterDeadline = RejectedStatusReasonCode.AfterDeadline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("0de01b2e-ada8-46d1-be06-667700697149")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction = RejectedStatusReasonCode.AccountBlockedForCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("306140c2-05a0-428e-a64b-0d25d5a5d498")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer = RejectedStatusReasonCode.AccountBlockedForTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of subscription is below the minimum initial investment amount.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("6bfcbe8c-5bae-435c-9828-797e80f0a71a")]
    [Description(@"Amount of subscription is below the minimum initial investment amount.")]
    BelowMinimumInitialInvestmentAmount = RejectedStatusReasonCode.BelowMinimumInitialInvestmentAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount is below the minimum redemption amount.
    /// Encoded/decoded by serializers as &quot;BMRA&quot;.
    /// </summary>
    [EnumMember(Value = "BMRA")]
    [IsoId("f2298585-0602-4ae1-a842-6b1bfe2eb5f8")]
    [Description(@"Amount is below the minimum redemption amount.")]
    BelowMinimumRedemptionAmount = RejectedStatusReasonCode.BelowMinimumRedemptionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding will be below the minimum retained value.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("4cb8d509-0edf-41a4-98e4-89d8289b610c")]
    [Description(@"Holding will be below the minimum retained value.")]
    BelowMinimumRetainedAmount = RejectedStatusReasonCode.BelowMinimumRetainedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash account is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("a65210f6-c0ac-464c-be86-79fc51bccd81")]
    [Description(@"Cash account is not recognised or invalid.")]
    InvalidCashAccount = RejectedStatusReasonCode.InvalidCashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fund is closed and will not take in any more investments.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("883dc6ec-2da8-4c07-b0c8-2e7be166ab15")]
    [Description(@"Fund is closed and will not take in any more investments.")]
    FundClosed = RejectedStatusReasonCode.FundClosed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("c4aab698-cc5b-429a-8eee-52b8d390e3bf")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("f437a560-91b1-4493-8925-ba2455e3d11f")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate = RejectedStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("1be0a226-b8af-4852-922f-09e2652739b1")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace = RejectedStatusReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("a8aed42b-1792-420a-9584-688f8aad54dd")]
    [Description(@"Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.")]
    InvalidSecurityForm = RejectedStatusReasonCode.InvalidSecurityForm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("4563f856-65a7-40db-9957-10130bfeba8f")]
    [Description(@"Order contains physical delivery details but the fund can not be physically delivered.")]
    PhysicalDeliveryImpossible = RejectedStatusReasonCode.PhysicalDeliveryImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("880691b1-9b94-467e-bf71-bde0ca97a61f")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    InvalidSettlementAmount = RejectedStatusReasonCode.InvalidSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("ed6aca7d-a33c-4ca3-ad3d-7613557a186f")]
    [Description(@"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.")]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("42ae538f-236b-47eb-96ee-8eac39a3b0c3")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity = RejectedStatusReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("5443b570-1943-4f91-9264-abadebe6255c")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("dde8a223-be03-4306-8baf-8ab9a9318090")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate = RejectedStatusReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("2b9d5b1b-ca3d-4a1a-896d-f6d8c3946071")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeOrCommission = RejectedStatusReasonCode.FeeOrCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("09f43fc3-8c7c-447c-9819-7634e33eac87")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectedStatusReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("c3decd2c-7f77-4181-b42a-953926c0b507")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer = RejectedStatusReasonCode.InvalidCreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDDB&quot;.
    /// </summary>
    [EnumMember(Value = "IDDB")]
    [IsoId("49830e84-e0a6-44d8-b660-d36604f5364e")]
    [Description(@"Direct debit account identification is not recognised or is invalid.")]
    DirectDebit = RejectedStatusReasonCode.DirectDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("c2380b29-be0b-4cb5-bb1f-d5cc0b9dd0c4")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName = RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid subscriber or redeemer.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("acfb394d-bd8f-4ab2-8044-c716c902f4fc")]
    [Description(@"Unrecognised or invalid subscriber or redeemer.")]
    SubscriberOrRedeemer = RejectedStatusReasonCode.SubscriberOrRedeemer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Assets are illiquid.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("86a4cbd6-609f-46ed-9c5b-6161192ad64e")]
    [Description(@"Assets are illiquid.")]
    AssetsIlliquid = RejectedStatusReasonCode.AssetsIlliquid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient capacity.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("66eda7ed-6eb6-41e0-91ba-266e9bfae4c0")]
    [Description(@"Insufficient capacity.")]
    InsufficientCapacity = RejectedStatusReasonCode.InsufficientCapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("183f9214-9e93-441f-b226-9181255dcedd")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectedStatusReasonCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order type is invalid.
    /// Encoded/decoded by serializers as &quot;IOTP&quot;.
    /// </summary>
    [EnumMember(Value = "IOTP")]
    [IsoId("b968f3c6-aec2-4722-9a71-f83cba1bf83f")]
    [Description(@"Order type is invalid.")]
    InvalidOrderType = RejectedStatusReasonCode.InvalidOrderType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("290824ad-d356-49be-80dd-ff948be77a68")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount = RejectedStatusReasonCode.InstructingPartyNotAllowedForAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment card details are incorrect.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("03a050bb-ef17-4c94-a625-355771d343c2")]
    [Description(@"Payment card details are incorrect.")]
    PaymentCard = RejectedStatusReasonCode.PaymentCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping place is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ISAF&quot;.
    /// </summary>
    [EnumMember(Value = "ISAF")]
    [IsoId("f0e296de-9460-4431-8070-644a54601a36")]
    [Description(@"Safekeeping place is not recognised or is invalid.")]
    SafekeepingPlace = RejectedStatusReasonCode.SafekeepingPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("5b018391-4a94-4ae7-b4a3-57d8945c8170")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectedStatusReasonCode.ReceivingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("55380b52-705e-4027-a2d6-ae5ce6a0abb5")]
    [Description(@"Instruction was received after market deadline.")]
    TooLate = RejectedStatusReasonCode.TooLate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lock-up period is in place.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("c08ac026-445a-4c49-a799-00ed591dd349")]
    [Description(@"Lock-up period is in place.")]
    LockUp = RejectedStatusReasonCode.LockUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is not enough cash in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("dc0481ad-580a-4a7a-a93e-e2aa72943cfe")]
    [Description(@"There is not enough cash in the account to process the instruction.")]
    NotEnoughCash = RejectedStatusReasonCode.NotEnoughCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Settlement Amount Currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("a28fc4db-feab-459e-a13f-654525cc6b9d")]
    [Description(@"Unrecognised or invalid Settlement Amount Currency.")]
    SettlementAmountCurrency = RejectedStatusReasonCode.SettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("3716b6b8-3967-4e72-8c8c-1ab11fcbd20f")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order reference is a duplicate of a previously received order.
    /// Encoded/decoded by serializers as &quot;ORRF&quot;.
    /// </summary>
    [EnumMember(Value = "ORRF")]
    [IsoId("00a74c66-0145-44d0-8dcb-5f15a5a37f0b")]
    [Description(@"Order reference is a duplicate of a previously received order.")]
    DuplicateOrderReference = RejectedStatusReasonCode.DuplicateOrderReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical Settlement Impossible.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("ac9a5bfd-7c45-472e-87b9-b17f4f81939e")]
    [Description(@"Physical Settlement Impossible.")]
    PhysicalSettlement = RejectedStatusReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Place of Trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("6a1421be-dad2-477b-805b-bb82d34e40d1")]
    [Description(@"Unrecognised or invalid Place of Trade.")]
    PlaceOfTrade = RejectedStatusReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order contains funds that have different valuation points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("642db887-b40f-49f9-933a-8944158b92fc")]
    [Description(@"Order contains funds that have different valuation points.")]
    DifferentValuationPoints = RejectedStatusReasonCode.DifferentValuationPoints, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage holding breach, for example, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("d2af8e87-470f-4acd-9412-935ebbcbcec5")]
    [Description(@"Percentage holding breach, for example, PPM rules; taxation rules (ERISA).")]
    PercentageHoldingBreach = RejectedStatusReasonCode.PercentageHoldingBreach, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Impossible to use RTGS System.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("13e0ff91-f980-4f23-b99f-90be5287b0ea")]
    [Description(@"Impossible to use RTGS System.")]
    RTGSSystem = RejectedStatusReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("4c17eb10-237c-4a48-b575-7b648cc8245f")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("c7051ff9-0686-4797-9c84-f4050585f656")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Settlement Transaction.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("fcaf9b24-0fea-4b00-a93a-67ed54906cfa")]
    [Description(@"Unrecognised or invalid Settlement Transaction.")]
    SettlementTransaction = RejectedStatusReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of units or amount of money in the order is too high for a subscription.
    /// Encoded/decoded by serializers as &quot;SHIG&quot;.
    /// </summary>
    [EnumMember(Value = "SHIG")]
    [IsoId("663df218-5f05-4979-884a-52c4e4236a9f")]
    [Description(@"Quantity of units or amount of money in the order is too high for a subscription.")]
    TooHighUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooHighUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of units or amount of money in the order is too low for a subscription.
    /// Encoded/decoded by serializers as &quot;SLOW&quot;.
    /// </summary>
    [EnumMember(Value = "SLOW")]
    [IsoId("f8cf5c69-aa7d-4585-adae-d2acb66ad71d")]
    [Description(@"Quantity of units or amount of money in the order is too low for a subscription.")]
    TooLowUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooLowUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal currency is not supported.
    /// Encoded/decoded by serializers as &quot;UDCY&quot;.
    /// </summary>
    [EnumMember(Value = "UDCY")]
    [IsoId("0a68fc30-3156-48ba-9562-f18577a79e4f")]
    [Description(@"Deal currency is not supported.")]
    UnacceptedDealCurrency = RejectedStatusReasonCode.UnacceptedDealCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("b9fbeba3-6ba8-4072-afba-d23abff5aee3")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference = RejectedStatusReasonCode.UnknownLinkagesReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net asset value currency is not supported.
    /// Encoded/decoded by serializers as &quot;UNAV&quot;.
    /// </summary>
    [EnumMember(Value = "UNAV")]
    [IsoId("5255fccf-a47a-4ebc-9ddf-7afe2ac76a27")]
    [Description(@"Net asset value currency is not supported.")]
    UnacceptedNAVCurrency = RejectedStatusReasonCode.UnacceptedNAVCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction specifies an unacceptable combination for the financial instruments in the switch order.
    /// Encoded/decoded by serializers as &quot;UNSC&quot;.
    /// </summary>
    [EnumMember(Value = "UNSC")]
    [IsoId("63391e95-941d-4ac3-aaec-59973932d84b")]
    [Description(@"Instruction specifies an unacceptable combination for the financial instruments in the switch order.")]
    UnacceptableSwitchCombination = RejectedStatusReasonCode.UnacceptableSwitchCombination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment method, for example, cheque or payment card, is not accepted.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("e15ac67f-dba6-41ff-9d9a-07f88b541012")]
    [Description(@"Payment method, for example, cheque or payment card, is not accepted.")]
    UnacceptedPaymentMethod = RejectedStatusReasonCode.UnacceptedPaymentMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("f03287e0-e25c-4680-b3e5-a8f2646b8176")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency = RejectedStatusReasonCode.UnacceptedRequestedSettlementCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage of commission waiving exceeds the commission percentage or commission amount.
    /// Encoded/decoded by serializers as &quot;UWAI&quot;.
    /// </summary>
    [EnumMember(Value = "UWAI")]
    [IsoId("1ac639af-4141-484b-a518-18c4165b763b")]
    [Description(@"Percentage of commission waiving exceeds the commission percentage or commission amount.")]
    UnacceptedCommissionWaiving = RejectedStatusReasonCode.UnacceptedCommissionWaiving, // same ordinal as derivation source for type conversions
}
