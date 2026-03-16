// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cash settlement date is not recognised or is invalid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SOEqKkpIEe2Kv_AXFg3f7A")]
[Description(@"Cash settlement date is not recognised or is invalid.")]
[Derivations(typeof(MessageRejectedReason2Code))]
public enum RejectedStatusReasonV2Code
{
    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_SOEqOUpIEe2Kv_AXFg3f7A")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate,

    /// <summary>
    /// Acquisition date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IAQD&quot;.
    /// </summary>
    [EnumMember(Value = "IAQD")]
    [IsoId("_SOEqQkpIEe2Kv_AXFg3f7A")]
    [Description(@"Acquisition date is not recognised or is invalid.")]
    AcquisitionDate,

    /// <summary>
    /// Order contains funds that have different valuation points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_SOEqaUpIEe2Kv_AXFg3f7A")]
    [Description(@"Order contains funds that have different valuation points.")]
    DifferentValuationPoints,

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_SOEqSEpIEe2Kv_AXFg3f7A")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent,

    /// <summary>
    /// Direct debit account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDDB&quot;.
    /// </summary>
    [EnumMember(Value = "IDDB")]
    [IsoId("_SOEqLUpIEe2Kv_AXFg3f7A")]
    [Description(@"Direct debit account identification is not recognised or is invalid.")]
    DirectDebit,

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_SOEqPUpIEe2Kv_AXFg3f7A")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary,

    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_SOEqQEpIEe2Kv_AXFg3f7A")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount,

    /// <summary>
    /// Payment card details are incorrect.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_SOEqL0pIEe2Kv_AXFg3f7A")]
    [Description(@"Payment card details are incorrect.")]
    PaymentCard,

    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("_SOEqWEpIEe2Kv_AXFg3f7A")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer,

    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_SOEqX0pIEe2Kv_AXFg3f7A")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace,

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_SOEqN0pIEe2Kv_AXFg3f7A")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent,

    /// <summary>
    /// Safekeeping place is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ISAF&quot;.
    /// </summary>
    [EnumMember(Value = "ISAF")]
    [IsoId("_SOEqVkpIEe2Kv_AXFg3f7A")]
    [Description(@"Safekeeping place is not recognised or is invalid.")]
    SafekeepingPlace,

    /// <summary>
    /// Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_SOEqOkpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Form of the security is wrong, eg, the form of security is registered not bearer or vice versa."
    )]
    InvalidSecurityForm,

    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_SOEqXEpIEe2Kv_AXFg3f7A")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification,

    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_SOEqY0pIEe2Kv_AXFg3f7A")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction,

    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("_SOEqZUpIEe2Kv_AXFg3f7A")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer,

    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_SOEqNkpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy."
    )]
    AccountBlockedMissingDocuments,

    /// <summary>
    /// There is not enough cash in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_SOEqfEpIEe2Kv_AXFg3f7A")]
    [Description(@"There is not enough cash in the account to process the instruction.")]
    NotEnoughCash,

    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_SOEqO0pIEe2Kv_AXFg3f7A")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument,

    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_SOEqLkpIEe2Kv_AXFg3f7A")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName,

    /// <summary>
    /// Percentage of commission waiving exceeds the commission percentage or commission amount.
    /// Encoded/decoded by serializers as &quot;UWAI&quot;.
    /// </summary>
    [EnumMember(Value = "UWAI")]
    [IsoId("_SOEqS0pIEe2Kv_AXFg3f7A")]
    [Description(
        @"Percentage of commission waiving exceeds the commission percentage or commission amount."
    )]
    UnacceptedCommissionWaiving,

    /// <summary>
    /// Deal currency is not supported.
    /// Encoded/decoded by serializers as &quot;UDCY&quot;.
    /// </summary>
    [EnumMember(Value = "UDCY")]
    [IsoId("_SOEqc0pIEe2Kv_AXFg3f7A")]
    [Description(@"Deal currency is not supported.")]
    UnacceptedDealCurrency,

    /// <summary>
    /// Net asset value currency is not supported.
    /// Encoded/decoded by serializers as &quot;UNAV&quot;.
    /// </summary>
    [EnumMember(Value = "UNAV")]
    [IsoId("_SOEqU0pIEe2Kv_AXFg3f7A")]
    [Description(@"Net asset value currency is not supported.")]
    UnacceptedNAVCurrency,

    /// <summary>
    /// Payment method, for example, cheque or payment card, is not accepted.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_SOEqNEpIEe2Kv_AXFg3f7A")]
    [Description(@"Payment method, for example, cheque or payment card, is not accepted.")]
    UnacceptedPaymentMethod,

    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("_SOEqZEpIEe2Kv_AXFg3f7A")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency,

    /// <summary>
    /// Quantity of units or amount of money in the order is too high for a subscription.
    /// Encoded/decoded by serializers as &quot;SHIG&quot;.
    /// </summary>
    [EnumMember(Value = "SHIG")]
    [IsoId("_SOEqfUpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Quantity of units or amount of money in the order is too high for a subscription."
    )]
    TooHighUnitsOrAmountToSubscribe,

    /// <summary>
    /// Quantity of units or amount of money in the order is too low for a subscription.
    /// Encoded/decoded by serializers as &quot;SLOW&quot;.
    /// </summary>
    [EnumMember(Value = "SLOW")]
    [IsoId("_SOEqTkpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Quantity of units or amount of money in the order is too low for a subscription."
    )]
    TooLowUnitsOrAmountToSubscribe,

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_SOEqMkpIEe2Kv_AXFg3f7A")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference,

    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_SOEqeEpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Order contains physical delivery details but the fund can not be physically delivered."
    )]
    PhysicalDeliveryImpossible,

    /// <summary>
    /// Order reference is a duplicate of a previously received order.
    /// Encoded/decoded by serializers as &quot;ORRF&quot;.
    /// </summary>
    [EnumMember(Value = "ORRF")]
    [IsoId("_SOEqdEpIEe2Kv_AXFg3f7A")]
    [Description(@"Order reference is a duplicate of a previously received order.")]
    DuplicateOrderReference,

    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("_SOEqPkpIEe2Kv_AXFg3f7A")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount,

    /// <summary>
    /// Order type is invalid.
    /// Encoded/decoded by serializers as &quot;IOTP&quot;.
    /// </summary>
    [EnumMember(Value = "IOTP")]
    [IsoId("_SOEqcEpIEe2Kv_AXFg3f7A")]
    [Description(@"Order type is invalid.")]
    InvalidOrderType,

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_SOEqcUpIEe2Kv_AXFg3f7A")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA,

    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_SOEqYUpIEe2Kv_AXFg3f7A")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime,

    /// <summary>
    /// Request contains an invalid or unrecognised business reference.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_SOEqVEpIEe2Kv_AXFg3f7A")]
    [Description(@"Request contains an invalid or unrecognised business reference.")]
    InvalidOrUnrecognisedReference,

    /// <summary>
    /// Sending party is not allowed to send this request.
    /// Encoded/decoded by serializers as &quot;NALO&quot;.
    /// </summary>
    [EnumMember(Value = "NALO")]
    [IsoId("_SOEqRUpIEe2Kv_AXFg3f7A")]
    [Description(@"Sending party is not allowed to send this request.")]
    NotAllowedRequest,

    /// <summary>
    /// Order or transfer has already been executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_SOEqUEpIEe2Kv_AXFg3f7A")]
    [Description(@"Order or transfer has already been executed and confirmation has been sent.")]
    AlreadyExecuted,

    /// <summary>
    /// Instructing party is not allowed to request a cancellation.
    /// Encoded/decoded by serializers as &quot;NALC&quot;.
    /// </summary>
    [EnumMember(Value = "NALC")]
    [IsoId("_SOEqekpIEe2Kv_AXFg3f7A")]
    [Description(@"Instructing party is not allowed to request a cancellation.")]
    NotAllowedToCancel,

    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_SOEqT0pIEe2Kv_AXFg3f7A")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible,

    /// <summary>
    /// Another reason for the status rejected.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_SOEqOEpIEe2Kv_AXFg3f7A")]
    [Description(@"Another reason for the status rejected.")]
    Other,

    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_SOEqLEpIEe2Kv_AXFg3f7A")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity,

    /// <summary>
    /// Certificate number is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICTN&quot;.
    /// </summary>
    [EnumMember(Value = "ICTN")]
    [IsoId("_SOEqV0pIEe2Kv_AXFg3f7A")]
    [Description(@"Certificate number is not recognised or is invalid.")]
    CertificateNumber,

    /// <summary>
    /// One or several settlement parties are not recognised or are invalid.
    /// Encoded/decoded by serializers as &quot;ISTP&quot;.
    /// </summary>
    [EnumMember(Value = "ISTP")]
    [IsoId("_SOEqPEpIEe2Kv_AXFg3f7A")]
    [Description(@"One or several settlement parties are not recognised or are invalid.")]
    SettlementParties,

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_SOEqZ0pIEe2Kv_AXFg3f7A")]
    [Description(@"Instruction was received after market deadline.")]
    TooLate,

    /// <summary>
    /// Instruction was received after the Receiver&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_SOEqa0pIEe2Kv_AXFg3f7A")]
    [Description(@"Instruction was received after the Receiver's deadline.")]
    AfterDeadline,

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_SOEqRkpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate,

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_SOEqXkpIEe2Kv_AXFg3f7A")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeOrCommission,

    /// <summary>
    /// Unrecognised or invalid subscriber or redeemer.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_SOEqREpIEe2Kv_AXFg3f7A")]
    [Description(@"Unrecognised or invalid subscriber or redeemer.")]
    SubscriberOrRedeemer,

    /// <summary>
    /// Unrecognised or invalid Settlement Amount Currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_SOEqeUpIEe2Kv_AXFg3f7A")]
    [Description(@"Unrecognised or invalid Settlement Amount Currency.")]
    SettlementAmountCurrency,

    /// <summary>
    /// Physical Settlement Impossible.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_SOEqdkpIEe2Kv_AXFg3f7A")]
    [Description(@"Physical Settlement Impossible.")]
    PhysicalSettlement,

    /// <summary>
    /// Unrecognised or invalid Place of Trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_SOEqTEpIEe2Kv_AXFg3f7A")]
    [Description(@"Unrecognised or invalid Place of Trade.")]
    PlaceOfTrade,

    /// <summary>
    /// Unrecognised or invalid Settlement Transaction.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_SOEqd0pIEe2Kv_AXFg3f7A")]
    [Description(@"Unrecognised or invalid Settlement Transaction.")]
    SettlementTransaction,

    /// <summary>
    /// Impossible to use RTGS System.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_SOEqckpIEe2Kv_AXFg3f7A")]
    [Description(@"Impossible to use RTGS System.")]
    RTGSSystem,

    /// <summary>
    /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_SOEqZkpIEe2Kv_AXFg3f7A")]
    [Description(
        @"The cancellation request has been rejected since more than one instruction match to the cancellation criteria."
    )]
    NoCancellationMatch,

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_SOEqM0pIEe2Kv_AXFg3f7A")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown,

    /// <summary>
    /// Investor data is insufficient. Applicable when the mandated market practice is not followed.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_SOEqbkpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Investor data is insufficient. Applicable when the mandated market practice is not followed."
    )]
    InsufficientInvestorData,

    /// <summary>
    /// Account servicer is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_SOEqWUpIEe2Kv_AXFg3f7A")]
    [Description(@"Account servicer is not recognised or is invalid.")]
    InvalidAccountServicer,

    /// <summary>
    /// Nominee account is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_SOEqW0pIEe2Kv_AXFg3f7A")]
    [Description(@"Nominee account is not recognised or is invalid.")]
    InvalidNomineeAccount,

    /// <summary>
    /// New plan manager is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INPM&quot;.
    /// </summary>
    [EnumMember(Value = "INPM")]
    [IsoId("_SOEqYkpIEe2Kv_AXFg3f7A")]
    [Description(@"New plan manager is not recognised or is invalid.")]
    InvalidNewPlanManager,

    /// <summary>
    /// Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year.
    /// Encoded/decoded by serializers as &quot;CYPA&quot;.
    /// </summary>
    [EnumMember(Value = "CYPA")]
    [IsoId("_SOEqP0pIEe2Kv_AXFg3f7A")]
    [Description(
        @"Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year."
    )]
    CurrentYearPartial,

    /// <summary>
    /// Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well.
    /// Encoded/decoded by serializers as &quot;PTNS&quot;.
    /// </summary>
    [EnumMember(Value = "PTNS")]
    [IsoId("_SOEqaEpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well."
    )]
    PartialNotSupported,

    /// <summary>
    /// Financial instrument is not valid for the requested tax year.
    /// Encoded/decoded by serializers as &quot;FTAX&quot;.
    /// </summary>
    [EnumMember(Value = "FTAX")]
    [IsoId("_SOEqQ0pIEe2Kv_AXFg3f7A")]
    [Description(@"Financial instrument is not valid for the requested tax year.")]
    FinancialInstrumentTaxYear,

    /// <summary>
    /// ISA type is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;ISAT&quot;.
    /// </summary>
    [EnumMember(Value = "ISAT")]
    [IsoId("_SOEqb0pIEe2Kv_AXFg3f7A")]
    [Description(@"ISA type is not recognised or invalid.")]
    InvalidISAType,

    /// <summary>
    /// Cash account is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_SOEqbUpIEe2Kv_AXFg3f7A")]
    [Description(@"Cash account is not recognised or invalid.")]
    InvalidCashAccount,

    /// <summary>
    /// Transfer reference is a duplicate of a previously received transfer.
    /// Encoded/decoded by serializers as &quot;TREF&quot;.
    /// </summary>
    [EnumMember(Value = "TREF")]
    [IsoId("_SOEqUUpIEe2Kv_AXFg3f7A")]
    [Description(@"Transfer reference is a duplicate of a previously received transfer.")]
    DuplicateTransferReference,

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_SOEqbEpIEe2Kv_AXFg3f7A")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    InvalidSettlementAmount,

    /// <summary>
    /// Unrecognised or invalid ordered amount.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_SOEqe0pIEe2Kv_AXFg3f7A")]
    [Description(@"Unrecognised or invalid ordered amount.")]
    InvalidOrderedAmount,

    /// <summary>
    /// Amount of subscription is below the minimum initial investment amount.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_SOEqVUpIEe2Kv_AXFg3f7A")]
    [Description(@"Amount of subscription is below the minimum initial investment amount.")]
    BelowMinimumInitialInvestmentAmount,

    /// <summary>
    /// Amount of subscription is below the minimum top-up investment.
    /// Encoded/decoded by serializers as &quot;BMTO&quot;.
    /// </summary>
    [EnumMember(Value = "BMTO")]
    [IsoId("_SOEqUkpIEe2Kv_AXFg3f7A")]
    [Description(@"Amount of subscription is below the minimum top-up investment.")]
    BelowMinimumTopUpAmount,

    /// <summary>
    /// Insufficient capacity.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_SOEqXUpIEe2Kv_AXFg3f7A")]
    [Description(@"Insufficient capacity.")]
    InsufficientCapacity,

    /// <summary>
    /// Percentage holding breach, for example, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_SOEqTUpIEe2Kv_AXFg3f7A")]
    [Description(@"Percentage holding breach, for example, PPM rules; taxation rules (ERISA).")]
    PercentageHoldingBreach,

    /// <summary>
    /// Amount is below the minimum redemption amount.
    /// Encoded/decoded by serializers as &quot;BMRA&quot;.
    /// </summary>
    [EnumMember(Value = "BMRA")]
    [IsoId("_SOEqMEpIEe2Kv_AXFg3f7A")]
    [Description(@"Amount is below the minimum redemption amount.")]
    BelowMinimumRedemptionAmount,

    /// <summary>
    /// Holding will be below the minimum retained value.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("_SOEqR0pIEe2Kv_AXFg3f7A")]
    [Description(@"Holding will be below the minimum retained value.")]
    BelowMinimumRetainedAmount,

    /// <summary>
    /// Lock-up period is in place.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_SOEqSUpIEe2Kv_AXFg3f7A")]
    [Description(@"Lock-up period is in place.")]
    LockUp,

    /// <summary>
    /// Assets are illiquid.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("_SOEqNUpIEe2Kv_AXFg3f7A")]
    [Description(@"Assets are illiquid.")]
    AssetsIlliquid,

    /// <summary>
    /// Data in the order or transfer instruction is invalid.
    /// Encoded/decoded by serializers as &quot;DINV&quot;.
    /// </summary>
    [EnumMember(Value = "DINV")]
    [IsoId("_SOEqK0pIEe2Kv_AXFg3f7A")]
    [Description(@"Data in the order or transfer instruction is invalid.")]
    DataInvalid,

    /// <summary>
    /// Fund is closed and will not take in any more investments.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_SOEqdUpIEe2Kv_AXFg3f7A")]
    [Description(@"Fund is closed and will not take in any more investments.")]
    FundClosed,

    /// <summary>
    /// Instruction specifies an unacceptable combination for the financial instruments in the switch order.
    /// Encoded/decoded by serializers as &quot;UNSC&quot;.
    /// </summary>
    [EnumMember(Value = "UNSC")]
    [IsoId("_SOEqQUpIEe2Kv_AXFg3f7A")]
    [Description(
        @"Instruction specifies an unacceptable combination for the financial instruments in the switch order."
    )]
    UnacceptableSwitchCombination,

    /// <summary>
    /// The two share classes are not part of the same fund.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_SOEqYEpIEe2Kv_AXFg3f7A")]
    [Description(@"The two share classes are not part of the same fund.")]
    NotConvertable,

    /// <summary>
    /// Asset instructed for transfer is closed.
    /// Encoded/decoded by serializers as &quot;ACLO&quot;.
    /// </summary>
    [EnumMember(Value = "ACLO")]
    [IsoId("_SOEqWkpIEe2Kv_AXFg3f7A")]
    [Description(@"Asset instructed for transfer is closed.")]
    AssetClosed,

    /// <summary>
    /// Transfer quantity is too small.
    /// Encoded/decoded by serializers as &quot;NQTY&quot;.
    /// </summary>
    [EnumMember(Value = "NQTY")]
    [IsoId("_SOEqakpIEe2Kv_AXFg3f7A")]
    [Description(@"Transfer quantity is too small.")]
    QuantityBelowMinimum,

    /// <summary>
    /// Asset does not support reregistration.
    /// Encoded/decoded by serializers as &quot;NASS&quot;.
    /// </summary>
    [EnumMember(Value = "NASS")]
    [IsoId("_SOEqSkpIEe2Kv_AXFg3f7A")]
    [Description(@"Asset does not support reregistration.")]
    AssetNotSupported,

    /// <summary>
    /// Instruction is not compliant with the relevant market practice.
    /// Encoded/decoded by serializers as &quot;NCMP&quot;.
    /// </summary>
    [EnumMember(Value = "NCMP")]
    [IsoId("_SOEqMUpIEe2Kv_AXFg3f7A")]
    [Description(@"Instruction is not compliant with the relevant market practice.")]
    NotCompliantWithMarketPractice,
}
