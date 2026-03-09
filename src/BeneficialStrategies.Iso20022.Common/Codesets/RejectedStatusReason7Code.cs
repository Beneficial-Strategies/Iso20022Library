// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZdnvBNp-Ed-ak6NoX_4Aeg_1721163152")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum RejectedStatusReason7Code
{
    /// <summary>
    /// Order contains funds that have different valuation points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_ZeXV4Np-Ed-ak6NoX_4Aeg_1763645146")]
    [Description(@"Order contains funds that have different valuation points.")]
    DifferentValuationPoints = RejectedStatusReasonCode.DifferentValuationPoints, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZeXV4dp-Ed-ak6NoX_4Aeg_1763645171")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectedStatusReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Direct debit account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDDB&quot;.
    /// </summary>
    [EnumMember(Value = "IDDB")]
    [IsoId("_Zegf0Np-Ed-ak6NoX_4Aeg_1763645188")]
    [Description(@"Direct debit account identification is not recognised or is invalid.")]
    DirectDebit = RejectedStatusReasonCode.DirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Zegf0dp-Ed-ak6NoX_4Aeg_1763645223")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectedStatusReasonCode.Intermediary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Zegf0tp-Ed-ak6NoX_4Aeg_1763645241")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment card details are incorrect.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_Zegf09p-Ed-ak6NoX_4Aeg_1763645267")]
    [Description(@"Payment card details are incorrect.")]
    PaymentCard = RejectedStatusReasonCode.PaymentCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("_Zegf1Np-Ed-ak6NoX_4Aeg_1763645639")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer = RejectedStatusReasonCode.InvalidCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Zegf1dp-Ed-ak6NoX_4Aeg_1763645656")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace = RejectedStatusReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_Zegf1tp-Ed-ak6NoX_4Aeg_1763645699")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectedStatusReasonCode.ReceivingAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Safekeeping place is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ISAF&quot;.
    /// </summary>
    [EnumMember(Value = "ISAF")]
    [IsoId("_Zegf19p-Ed-ak6NoX_4Aeg_1763645700")]
    [Description(@"Safekeeping place is not recognised or is invalid.")]
    SafekeepingPlace = RejectedStatusReasonCode.SafekeepingPlace, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_Zegf2Np-Ed-ak6NoX_4Aeg_1763645734")]
    [Description(@"Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.")]
    InvalidSecurityForm = RejectedStatusReasonCode.InvalidSecurityForm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Zegf2dp-Ed-ak6NoX_4Aeg_1763645751")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_ZeqQ0Np-Ed-ak6NoX_4Aeg_1763645794")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction = RejectedStatusReasonCode.AccountBlockedForCorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("_ZeqQ0dp-Ed-ak6NoX_4Aeg_1763645811")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer = RejectedStatusReasonCode.AccountBlockedForTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_ZeqQ0tp-Ed-ak6NoX_4Aeg_1763646137")]
    [Description(@"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.")]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is not enough cash in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_ZeqQ09p-Ed-ak6NoX_4Aeg_1763646138")]
    [Description(@"There is not enough cash in the account to process the instruction.")]
    NotEnoughCash = RejectedStatusReasonCode.NotEnoughCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZeqQ1Np-Ed-ak6NoX_4Aeg_1763646154")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_ZeqQ1dp-Ed-ak6NoX_4Aeg_1763646172")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName = RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Percentage of commission waiving exceeds the commission percentage or commission amount.
    /// Encoded/decoded by serializers as &quot;UWAI&quot;.
    /// </summary>
    [EnumMember(Value = "UWAI")]
    [IsoId("_ZeqQ1tp-Ed-ak6NoX_4Aeg_1763646214")]
    [Description(@"Percentage of commission waiving exceeds the commission percentage or commission amount.")]
    UnacceptedCommissionWaiving = RejectedStatusReasonCode.UnacceptedCommissionWaiving, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deal currency is not supported.
    /// Encoded/decoded by serializers as &quot;UDCY&quot;.
    /// </summary>
    [EnumMember(Value = "UDCY")]
    [IsoId("_ZeqQ19p-Ed-ak6NoX_4Aeg_1763646232")]
    [Description(@"Deal currency is not supported.")]
    UnacceptedDealCurrency = RejectedStatusReasonCode.UnacceptedDealCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Net asset value currency is not supported.
    /// Encoded/decoded by serializers as &quot;UNAV&quot;.
    /// </summary>
    [EnumMember(Value = "UNAV")]
    [IsoId("_ZeqQ2Np-Ed-ak6NoX_4Aeg_1763646257")]
    [Description(@"Net asset value currency is not supported.")]
    UnacceptedNAVCurrency = RejectedStatusReasonCode.UnacceptedNAVCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment method, for example, cheque or payment card, is not accepted.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_ZeqQ2dp-Ed-ak6NoX_4Aeg_1763646646")]
    [Description(@"Payment method, for example, cheque or payment card, is not accepted.")]
    UnacceptedPaymentMethod = RejectedStatusReasonCode.UnacceptedPaymentMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("_ZeqQ2tp-Ed-ak6NoX_4Aeg_1763646681")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency = RejectedStatusReasonCode.UnacceptedRequestedSettlementCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of units or amount of money in the order is too high for a subscription.
    /// Encoded/decoded by serializers as &quot;SHIG&quot;.
    /// </summary>
    [EnumMember(Value = "SHIG")]
    [IsoId("_Ze0B0Np-Ed-ak6NoX_4Aeg_1764567005")]
    [Description(@"Quantity of units or amount of money in the order is too high for a subscription.")]
    TooHighUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooHighUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of units or amount of money in the order is too low for a subscription.
    /// Encoded/decoded by serializers as &quot;SLOW&quot;.
    /// </summary>
    [EnumMember(Value = "SLOW")]
    [IsoId("_Ze0B0dp-Ed-ak6NoX_4Aeg_1764567240")]
    [Description(@"Quantity of units or amount of money in the order is too low for a subscription.")]
    TooLowUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooLowUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Ze0B0tp-Ed-ak6NoX_4Aeg_1764567257")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference = RejectedStatusReasonCode.UnknownLinkagesReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_Ze0B09p-Ed-ak6NoX_4Aeg_1764567275")]
    [Description(@"Order contains physical delivery details but the fund can not be physically delivered.")]
    PhysicalDeliveryImpossible = RejectedStatusReasonCode.PhysicalDeliveryImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order reference is a duplicate of a previously received order.
    /// Encoded/decoded by serializers as &quot;ORRF&quot;.
    /// </summary>
    [EnumMember(Value = "ORRF")]
    [IsoId("_Ze0B1Np-Ed-ak6NoX_4Aeg_1764567317")]
    [Description(@"Order reference is a duplicate of a previously received order.")]
    DuplicateOrderReference = RejectedStatusReasonCode.DuplicateOrderReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("_Ze0B1dp-Ed-ak6NoX_4Aeg_1764567335")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount = RejectedStatusReasonCode.InstructingPartyNotAllowedForAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order type is invalid.
    /// Encoded/decoded by serializers as &quot;IOTP&quot;.
    /// </summary>
    [EnumMember(Value = "IOTP")]
    [IsoId("_Ze0B1tp-Ed-ak6NoX_4Aeg_1764567360")]
    [Description(@"Order type is invalid.")]
    InvalidOrderType = RejectedStatusReasonCode.InvalidOrderType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_Ze0B19p-Ed-ak6NoX_4Aeg_1764567377")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_Ze0B2Np-Ed-ak6NoX_4Aeg_1764567412")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Ze0B2dp-Ed-ak6NoX_4Aeg_681273652")]
    [Description(@"Instruction was received after market deadline.")]
    TooLate = RejectedStatusReasonCode.TooLate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after the Receiver&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Ze9LwNp-Ed-ak6NoX_4Aeg_720125613")]
    [Description(@"Instruction was received after the Receiver's deadline.")]
    AfterDeadline = RejectedStatusReasonCode.AfterDeadline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash account is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Ze9Lwdp-Ed-ak6NoX_4Aeg_697244502")]
    [Description(@"Cash account is not recognised or invalid.")]
    InvalidCashAccount = RejectedStatusReasonCode.InvalidCashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Ze9Lwtp-Ed-ak6NoX_4Aeg_728641458")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate = RejectedStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Ze9Lw9p-Ed-ak6NoX_4Aeg_759117527")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity = RejectedStatusReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Ze9LxNp-Ed-ak6NoX_4Aeg_772047457")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate = RejectedStatusReasonCode.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_Ze9Lxdp-Ed-ak6NoX_4Aeg_788672682")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeOrCommission = RejectedStatusReasonCode.FeeOrCommission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid subscriber or redeemer.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Ze9Lxtp-Ed-ak6NoX_4Aeg_811757929")]
    [Description(@"Unrecognised or invalid subscriber or redeemer.")]
    SubscriberOrRedeemer = RejectedStatusReasonCode.SubscriberOrRedeemer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid Settlement Amount Currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Ze9Lx9p-Ed-ak6NoX_4Aeg_818222923")]
    [Description(@"Unrecognised or invalid Settlement Amount Currency.")]
    SettlementAmountCurrency = RejectedStatusReasonCode.SettlementAmountCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical Settlement Impossible.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Ze9LyNp-Ed-ak6NoX_4Aeg_842236884")]
    [Description(@"Physical Settlement Impossible.")]
    PhysicalSettlement = RejectedStatusReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid Place of Trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Ze9Lydp-Ed-ak6NoX_4Aeg_856090167")]
    [Description(@"Unrecognised or invalid Place of Trade.")]
    PlaceOfTrade = RejectedStatusReasonCode.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid Settlement Transaction.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Ze9Lytp-Ed-ak6NoX_4Aeg_1072193204")]
    [Description(@"Unrecognised or invalid Settlement Transaction.")]
    SettlementTransaction = RejectedStatusReasonCode.SettlementTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible to use RTGS System.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZfG8wNp-Ed-ak6NoX_4Aeg_1097127253")]
    [Description(@"Impossible to use RTGS System.")]
    RTGSSystem = RejectedStatusReasonCode.RTGSSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZfG8wdp-Ed-ak6NoX_4Aeg_1104516953")]
    [Description(@"The cancellation request has been rejected since more than one instruction match to the cancellation criteria.")]
    NoCancellationMatch = RejectedStatusReasonCode.NoCancellationMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZfG8wtp-Ed-ak6NoX_4Aeg_-335978620")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    InvalidSettlementAmount = RejectedStatusReasonCode.InvalidSettlementAmount, // same ordinal as derivation source for type conversions
    
}
