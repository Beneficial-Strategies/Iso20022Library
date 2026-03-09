// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZdBSFNp-Ed-ak6NoX_4Aeg_-344862454")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum RejectedStatusReason10Code
{
    /// <summary>
    /// Instruction was received after the Receiver&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZdBSFdp-Ed-ak6NoX_4Aeg_-275597383")]
    [Description(@"Instruction was received after the Receiver's deadline.")]
    AfterDeadline = RejectedStatusReasonCode.AfterDeadline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("_ZdBSFtp-Ed-ak6NoX_4Aeg_-275598546")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer = RejectedStatusReasonCode.AccountBlockedForTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_ZdBSF9p-Ed-ak6NoX_4Aeg_-275597461")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZdBSGNp-Ed-ak6NoX_4Aeg_-275597306")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate = RejectedStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_ZdBSGdp-Ed-ak6NoX_4Aeg_-275598528")]
    [Description(@"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.")]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZdLDENp-Ed-ak6NoX_4Aeg_-275597046")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity = RejectedStatusReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZdLDEdp-Ed-ak6NoX_4Aeg_-276518578")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZdLDEtp-Ed-ak6NoX_4Aeg_-275597011")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate = RejectedStatusReasonCode.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_ZdLDE9p-Ed-ak6NoX_4Aeg_-275598408")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName = RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid subscriber or redeemer.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZdLDFNp-Ed-ak6NoX_4Aeg_-275596934")]
    [Description(@"Unrecognised or invalid subscriber or redeemer.")]
    SubscriberOrRedeemer = RejectedStatusReasonCode.SubscriberOrRedeemer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZdLDFdp-Ed-ak6NoX_4Aeg_-276519526")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectedStatusReasonCode.Intermediary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order type is invalid.
    /// Encoded/decoded by serializers as &quot;IOTP&quot;.
    /// </summary>
    [EnumMember(Value = "IOTP")]
    [IsoId("_ZdLDFtp-Ed-ak6NoX_4Aeg_-275597538")]
    [Description(@"Order type is invalid.")]
    InvalidOrderType = RejectedStatusReasonCode.InvalidOrderType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("_ZdLDF9p-Ed-ak6NoX_4Aeg_-275597573")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount = RejectedStatusReasonCode.InstructingPartyNotAllowedForAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZdLDGNp-Ed-ak6NoX_4Aeg_-275597418")]
    [Description(@"Instruction was received after market deadline.")]
    TooLate = RejectedStatusReasonCode.TooLate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is not enough cash in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_ZdLDGdp-Ed-ak6NoX_4Aeg_-275598451")]
    [Description(@"There is not enough cash in the account to process the instruction.")]
    NotEnoughCash = RejectedStatusReasonCode.NotEnoughCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZdUNANp-Ed-ak6NoX_4Aeg_-275596418")]
    [Description(@"The cancellation request has been rejected since more than one instruction match to the cancellation criteria.")]
    NoCancellationMatch = RejectedStatusReasonCode.NoCancellationMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_ZdUNAdp-Ed-ak6NoX_4Aeg_-275597503")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order reference is a duplicate of a previously received order.
    /// Encoded/decoded by serializers as &quot;ORRF&quot;.
    /// </summary>
    [EnumMember(Value = "ORRF")]
    [IsoId("_ZdUNAtp-Ed-ak6NoX_4Aeg_-275597864")]
    [Description(@"Order reference is a duplicate of a previously received order.")]
    DuplicateOrderReference = RejectedStatusReasonCode.DuplicateOrderReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZdUNA9p-Ed-ak6NoX_4Aeg_-276519466")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZdUNBNp-Ed-ak6NoX_4Aeg_-275598433")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of units or amount of money in the order is too high for a subscription.
    /// Encoded/decoded by serializers as &quot;SHIG&quot;.
    /// </summary>
    [EnumMember(Value = "SHIG")]
    [IsoId("_ZdUNBdp-Ed-ak6NoX_4Aeg_-275598001")]
    [Description(@"Quantity of units or amount of money in the order is too high for a subscription.")]
    TooHighUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooHighUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of units or amount of money in the order is too low for a subscription.
    /// Encoded/decoded by serializers as &quot;SLOW&quot;.
    /// </summary>
    [EnumMember(Value = "SLOW")]
    [IsoId("_ZdUNBtp-Ed-ak6NoX_4Aeg_-275597959")]
    [Description(@"Quantity of units or amount of money in the order is too low for a subscription.")]
    TooLowUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooLowUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deal currency is not supported.
    /// Encoded/decoded by serializers as &quot;UDCY&quot;.
    /// </summary>
    [EnumMember(Value = "UDCY")]
    [IsoId("_ZdUNB9p-Ed-ak6NoX_4Aeg_-275598331")]
    [Description(@"Deal currency is not supported.")]
    UnacceptedDealCurrency = RejectedStatusReasonCode.UnacceptedDealCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ZdUNCNp-Ed-ak6NoX_4Aeg_686179464")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference = RejectedStatusReasonCode.UnknownLinkagesReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("_ZdUNCdp-Ed-ak6NoX_4Aeg_-275598019")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency = RejectedStatusReasonCode.UnacceptedRequestedSettlementCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid ordered amount.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_Zdd-ANp-Ed-ak6NoX_4Aeg_1927127679")]
    [Description(@"Unrecognised or invalid ordered amount.")]
    InvalidOrderedAmount = RejectedStatusReasonCode.InvalidOrderedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of subscription is below the minimum initial investment amount.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_Zdd-Adp-Ed-ak6NoX_4Aeg_1927127756")]
    [Description(@"Amount of subscription is below the minimum initial investment amount.")]
    BelowMinimumInitialInvestmentAmount = RejectedStatusReasonCode.BelowMinimumInitialInvestmentAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of subscription is below the minimum top-up investment.
    /// Encoded/decoded by serializers as &quot;BMTO&quot;.
    /// </summary>
    [EnumMember(Value = "BMTO")]
    [IsoId("_Zdd-Atp-Ed-ak6NoX_4Aeg_1927127851")]
    [Description(@"Amount of subscription is below the minimum top-up investment.")]
    BelowMinimumTopUpAmount = RejectedStatusReasonCode.BelowMinimumTopUpAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient capacity.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_Zdd-A9p-Ed-ak6NoX_4Aeg_1927128177")]
    [Description(@"Insufficient capacity.")]
    InsufficientCapacity = RejectedStatusReasonCode.InsufficientCapacity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Percentage holding breach, for example, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_Zdd-BNp-Ed-ak6NoX_4Aeg_1927128273")]
    [Description(@"Percentage holding breach, for example, PPM rules; taxation rules (ERISA).")]
    PercentageHoldingBreach = RejectedStatusReasonCode.PercentageHoldingBreach, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount is below the minimum redemption amount.
    /// Encoded/decoded by serializers as &quot;BMRA&quot;.
    /// </summary>
    [EnumMember(Value = "BMRA")]
    [IsoId("_Zdd-Bdp-Ed-ak6NoX_4Aeg_1927128375")]
    [Description(@"Amount is below the minimum redemption amount.")]
    BelowMinimumRedemptionAmount = RejectedStatusReasonCode.BelowMinimumRedemptionAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding will be below the minimum retained value.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("_Zdd-Btp-Ed-ak6NoX_4Aeg_1927128410")]
    [Description(@"Holding will be below the minimum retained value.")]
    BelowMinimumRetainedAmount = RejectedStatusReasonCode.BelowMinimumRetainedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Lock-up period is in place.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_Zdd-B9p-Ed-ak6NoX_4Aeg_1927128670")]
    [Description(@"Lock-up period is in place.")]
    LockUp = RejectedStatusReasonCode.LockUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Assets are illiquid.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("_Zdd-CNp-Ed-ak6NoX_4Aeg_1927128687")]
    [Description(@"Assets are illiquid.")]
    AssetsIlliquid = RejectedStatusReasonCode.AssetsIlliquid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data in the order or transfer instruction is invalid.
    /// Encoded/decoded by serializers as &quot;DINV&quot;.
    /// </summary>
    [EnumMember(Value = "DINV")]
    [IsoId("_Zdd-Cdp-Ed-ak6NoX_4Aeg_1927128730")]
    [Description(@"Data in the order or transfer instruction is invalid.")]
    DataInvalid = RejectedStatusReasonCode.DataInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fund is closed and will not take in any more investments.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_ZdnvANp-Ed-ak6NoX_4Aeg_1927128765")]
    [Description(@"Fund is closed and will not take in any more investments.")]
    FundClosed = RejectedStatusReasonCode.FundClosed, // same ordinal as derivation source for type conversions
    
}
