// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cash settlement date is not recognised or is invalid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZfQtyNp-Ed-ak6NoX_4Aeg_99789863")]
[Description(@"Cash settlement date is not recognised or is invalid.")]
[Derivations(
    typeof(RejectedStatusReason5Code),
    typeof(RejectedStatusReason6Code),
    typeof(RejectedStatusReason11Code),
    typeof(RejectedStatusReason13Code),
    typeof(TransferRejectedStatusReason2Code),
    typeof(MessageRejectedReason1Code),
    typeof(CancellationRejectedReason1Code),
    typeof(RejectedCancellationStatusReason1Code),
    typeof(RejectedStatusReason7Code),
    typeof(TransferRejectedStatusReason1Code),
    typeof(RejectedStatusReason9Code),
    typeof(RejectedStatusReason8Code),
    typeof(RejectedStatusReason10Code),
    typeof(RejectedStatusReason12Code),
    typeof(RejectedStatusReason4Code)
)]
public enum RejectedStatusReasonCode
{
    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZfQtydp-Ed-ak6NoX_4Aeg_1637617751")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate,

    /// <summary>
    /// Acquisition date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IAQD&quot;.
    /// </summary>
    [EnumMember(Value = "IAQD")]
    [IsoId("_ZfZ3sNp-Ed-ak6NoX_4Aeg_1637618189")]
    [Description(@"Acquisition date is not recognised or is invalid.")]
    AcquisitionDate,

    /// <summary>
    /// Order contains funds that have different valuation points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_ZfZ3sdp-Ed-ak6NoX_4Aeg_258633656")]
    [Description(@"Order contains funds that have different valuation points.")]
    DifferentValuationPoints,

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZfZ3stp-Ed-ak6NoX_4Aeg_258633674")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent,

    /// <summary>
    /// Direct debit account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDDB&quot;.
    /// </summary>
    [EnumMember(Value = "IDDB")]
    [IsoId("_ZfZ3s9p-Ed-ak6NoX_4Aeg_258633691")]
    [Description(@"Direct debit account identification is not recognised or is invalid.")]
    DirectDebit,

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ZfZ3tNp-Ed-ak6NoX_4Aeg_258633951")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary,

    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZfZ3tdp-Ed-ak6NoX_4Aeg_258633986")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount,

    /// <summary>
    /// Payment card details are incorrect.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_ZfZ3ttp-Ed-ak6NoX_4Aeg_258634011")]
    [Description(@"Payment card details are incorrect.")]
    PaymentCard,

    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("_ZfZ3t9p-Ed-ak6NoX_4Aeg_258634046")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer,

    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZfZ3uNp-Ed-ak6NoX_4Aeg_258634063")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace,

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_ZfZ3udp-Ed-ak6NoX_4Aeg_258634354")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent,

    /// <summary>
    /// Safekeeping place is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ISAF&quot;.
    /// </summary>
    [EnumMember(Value = "ISAF")]
    [IsoId("_ZfjosNp-Ed-ak6NoX_4Aeg_258634431")]
    [Description(@"Safekeeping place is not recognised or is invalid.")]
    SafekeepingPlace,

    /// <summary>
    /// Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_Zfjosdp-Ed-ak6NoX_4Aeg_258634449")]
    [Description(
        @"Form of the security is wrong, eg, the form of security is registered not bearer or vice versa."
    )]
    InvalidSecurityForm,

    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Zfjostp-Ed-ak6NoX_4Aeg_258634484")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification,

    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_Zfjos9p-Ed-ak6NoX_4Aeg_258634527")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction,

    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("_ZfjotNp-Ed-ak6NoX_4Aeg_258634570")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer,

    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_Zfjotdp-Ed-ak6NoX_4Aeg_258634630")]
    [Description(
        @"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy."
    )]
    AccountBlockedMissingDocuments,

    /// <summary>
    /// There is not enough cash in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_Zfjottp-Ed-ak6NoX_4Aeg_258634942")]
    [Description(@"There is not enough cash in the account to process the instruction.")]
    NotEnoughCash,

    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_Zfjot9p-Ed-ak6NoX_4Aeg_258634977")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument,

    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_ZfjouNp-Ed-ak6NoX_4Aeg_258635037")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName,

    /// <summary>
    /// Percentage of commission waiving exceeds the commission percentage or commission amount.
    /// Encoded/decoded by serializers as &quot;UWAI&quot;.
    /// </summary>
    [EnumMember(Value = "UWAI")]
    [IsoId("_Zfjoudp-Ed-ak6NoX_4Aeg_258635320")]
    [Description(
        @"Percentage of commission waiving exceeds the commission percentage or commission amount."
    )]
    UnacceptedCommissionWaiving,

    /// <summary>
    /// Deal currency is not supported.
    /// Encoded/decoded by serializers as &quot;UDCY&quot;.
    /// </summary>
    [EnumMember(Value = "UDCY")]
    [IsoId("_Zfjoutp-Ed-ak6NoX_4Aeg_258635362")]
    [Description(@"Deal currency is not supported.")]
    UnacceptedDealCurrency,

    /// <summary>
    /// Net asset value currency is not supported.
    /// Encoded/decoded by serializers as &quot;UNAV&quot;.
    /// </summary>
    [EnumMember(Value = "UNAV")]
    [IsoId("_ZfsyoNp-Ed-ak6NoX_4Aeg_258635440")]
    [Description(@"Net asset value currency is not supported.")]
    UnacceptedNAVCurrency,

    /// <summary>
    /// Payment method, for example, cheque or payment card, is not accepted.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_Zfsyodp-Ed-ak6NoX_4Aeg_258635475")]
    [Description(@"Payment method, for example, cheque or payment card, is not accepted.")]
    UnacceptedPaymentMethod,

    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("_Zfsyotp-Ed-ak6NoX_4Aeg_258635517")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency,

    /// <summary>
    /// Quantity of units or amount of money in the order is too high for a subscription.
    /// Encoded/decoded by serializers as &quot;SHIG&quot;.
    /// </summary>
    [EnumMember(Value = "SHIG")]
    [IsoId("_Zfsyo9p-Ed-ak6NoX_4Aeg_258635560")]
    [Description(
        @"Quantity of units or amount of money in the order is too high for a subscription."
    )]
    TooHighUnitsOrAmountToSubscribe,

    /// <summary>
    /// Quantity of units or amount of money in the order is too low for a subscription.
    /// Encoded/decoded by serializers as &quot;SLOW&quot;.
    /// </summary>
    [EnumMember(Value = "SLOW")]
    [IsoId("_ZfsypNp-Ed-ak6NoX_4Aeg_258635847")]
    [Description(
        @"Quantity of units or amount of money in the order is too low for a subscription."
    )]
    TooLowUnitsOrAmountToSubscribe,

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zfsypdp-Ed-ak6NoX_4Aeg_258635907")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference,

    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_Zfsyptp-Ed-ak6NoX_4Aeg_258635949")]
    [Description(
        @"Order contains physical delivery details but the fund can not be physically delivered."
    )]
    PhysicalDeliveryImpossible,

    /// <summary>
    /// Order reference is a duplicate of a previously received order.
    /// Encoded/decoded by serializers as &quot;ORRF&quot;.
    /// </summary>
    [EnumMember(Value = "ORRF")]
    [IsoId("_Zfsyp9p-Ed-ak6NoX_4Aeg_495977332")]
    [Description(@"Order reference is a duplicate of a previously received order.")]
    DuplicateOrderReference,

    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("_ZfsyqNp-Ed-ak6NoX_4Aeg_495977392")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount,

    /// <summary>
    /// Order type is invalid.
    /// Encoded/decoded by serializers as &quot;IOTP&quot;.
    /// </summary>
    [EnumMember(Value = "IOTP")]
    [IsoId("_Zfsyqdp-Ed-ak6NoX_4Aeg_495977427")]
    [Description(@"Order type is invalid.")]
    InvalidOrderType,

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_Zf2joNp-Ed-ak6NoX_4Aeg_495977884")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA,

    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_Zf2jodp-Ed-ak6NoX_4Aeg_495977936")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime,

    /// <summary>
    /// Request contains an invalid or unrecognised business reference.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_Zf2jotp-Ed-ak6NoX_4Aeg_-1778567558")]
    [Description(@"Request contains an invalid or unrecognised business reference.")]
    InvalidOrUnrecognisedReference,

    /// <summary>
    /// Instructing party is not allowed to ask for a status for that specific order.
    /// Encoded/decoded by serializers as &quot;NALO&quot;.
    /// </summary>
    [EnumMember(Value = "NALO")]
    [IsoId("_Zf2jo9p-Ed-ak6NoX_4Aeg_-1778567523")]
    [Description(@"Instructing party is not allowed to ask for a status for that specific order.")]
    NotAllowedRequest,

    /// <summary>
    /// Order or transfer has already been executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_Zf2jpNp-Ed-ak6NoX_4Aeg_-1778567246")]
    [Description(@"Order or transfer has already been executed and confirmation has been sent.")]
    AlreadyExecuted,

    /// <summary>
    /// Instructing party is not allowed to request a cancellation.
    /// Encoded/decoded by serializers as &quot;NALC&quot;.
    /// </summary>
    [EnumMember(Value = "NALC")]
    [IsoId("_Zf2jpdp-Ed-ak6NoX_4Aeg_-1471036160")]
    [Description(@"Instructing party is not allowed to request a cancellation.")]
    NotAllowedToCancel,

    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_Zf2jptp-Ed-ak6NoX_4Aeg_-1471036005")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible,

    /// <summary>
    /// Another reason for the status rejected.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Zf2jp9p-Ed-ak6NoX_4Aeg_-731419930")]
    [Description(@"Another reason for the status rejected.")]
    Other,

    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Zf2jqNp-Ed-ak6NoX_4Aeg_1637617786")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity,

    /// <summary>
    /// Certificate number is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICTN&quot;.
    /// </summary>
    [EnumMember(Value = "ICTN")]
    [IsoId("_Zf2jqdp-Ed-ak6NoX_4Aeg_1637618154")]
    [Description(@"Certificate number is not recognised or is invalid.")]
    CertificateNumber,

    /// <summary>
    /// One or several settlement parties are not recognised or are invalid.
    /// Encoded/decoded by serializers as &quot;ISTP&quot;.
    /// </summary>
    [EnumMember(Value = "ISTP")]
    [IsoId("_ZgAUoNp-Ed-ak6NoX_4Aeg_-1964708823")]
    [Description(@"One or several settlement parties are not recognised or are invalid.")]
    SettlementParties,

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZgAUodp-Ed-ak6NoX_4Aeg_-1772368761")]
    [Description(@"Instruction was received after market deadline.")]
    TooLate,

    /// <summary>
    /// Instruction was received after the Receiver&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZgAUotp-Ed-ak6NoX_4Aeg_-1771448420")]
    [Description(@"Instruction was received after the Receiver's deadline.")]
    AfterDeadline,

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZgAUo9p-Ed-ak6NoX_4Aeg_-1771447645")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate,

    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as &quot;FEEE&quot;.
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_ZgAUpNp-Ed-ak6NoX_4Aeg_-1771447100")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeOrCommission,

    /// <summary>
    /// Unrecognised or invalid subscriber or redeemer.
    /// Encoded/decoded by serializers as &quot;IEXE&quot;.
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZgAUpdp-Ed-ak6NoX_4Aeg_-1771446524")]
    [Description(@"Unrecognised or invalid subscriber or redeemer.")]
    SubscriberOrRedeemer,

    /// <summary>
    /// Unrecognised or invalid Settlement Amount Currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZgAUptp-Ed-ak6NoX_4Aeg_-1771445706")]
    [Description(@"Unrecognised or invalid Settlement Amount Currency.")]
    SettlementAmountCurrency,

    /// <summary>
    /// Physical Settlement Impossible.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZgAUp9p-Ed-ak6NoX_4Aeg_-1771445204")]
    [Description(@"Physical Settlement Impossible.")]
    PhysicalSettlement,

    /// <summary>
    /// Unrecognised or invalid Place of Trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZgAUqNp-Ed-ak6NoX_4Aeg_-1770524915")]
    [Description(@"Unrecognised or invalid Place of Trade.")]
    PlaceOfTrade,

    /// <summary>
    /// Unrecognised or invalid Settlement Transaction.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZgAUqdp-Ed-ak6NoX_4Aeg_-1770524140")]
    [Description(@"Unrecognised or invalid Settlement Transaction.")]
    SettlementTransaction,

    /// <summary>
    /// Impossible to use RTGS System.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZgAUqtp-Ed-ak6NoX_4Aeg_-1770523612")]
    [Description(@"Impossible to use RTGS System.")]
    RTGSSystem,

    /// <summary>
    /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZgJekNp-Ed-ak6NoX_4Aeg_-1770523037")]
    [Description(
        @"The cancellation request has been rejected since more than one instruction match to the cancellation criteria."
    )]
    NoCancellationMatch,

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_ZgJekdp-Ed-ak6NoX_4Aeg_-1770522244")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown,

    /// <summary>
    /// Investor data is insufficient. Applicable when the mandated market practice is not followed.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_ZgJektp-Ed-ak6NoX_4Aeg_-1770521692")]
    [Description(
        @"Investor data is insufficient. Applicable when the mandated market practice is not followed."
    )]
    InsufficientInvestorData,

    /// <summary>
    /// Account servicer is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_ZgJek9p-Ed-ak6NoX_4Aeg_-1769601417")]
    [Description(@"Account servicer is not recognised or is invalid.")]
    InvalidAccountServicer,

    /// <summary>
    /// Nominee account is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_ZgJelNp-Ed-ak6NoX_4Aeg_-1769600642")]
    [Description(@"Nominee account is not recognised or is invalid.")]
    InvalidNomineeAccount,

    /// <summary>
    /// New plan manager is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INPM&quot;.
    /// </summary>
    [EnumMember(Value = "INPM")]
    [IsoId("_ZgJeldp-Ed-ak6NoX_4Aeg_-1769600055")]
    [Description(@"New plan manager is not recognised or is invalid.")]
    InvalidNewPlanManager,

    /// <summary>
    /// Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year.
    /// Encoded/decoded by serializers as &quot;CYPA&quot;.
    /// </summary>
    [EnumMember(Value = "CYPA")]
    [IsoId("_ZgJeltp-Ed-ak6NoX_4Aeg_-1769599455")]
    [Description(
        @"Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year."
    )]
    CurrentYearPartial,

    /// <summary>
    /// Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well.
    /// Encoded/decoded by serializers as &quot;PTNS&quot;.
    /// </summary>
    [EnumMember(Value = "PTNS")]
    [IsoId("_ZgJel9p-Ed-ak6NoX_4Aeg_-1769598636")]
    [Description(
        @"Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well."
    )]
    PartialNotSupported,

    /// <summary>
    /// Financial instrument is not valid for the requested tax year.
    /// Encoded/decoded by serializers as &quot;FTAX&quot;.
    /// </summary>
    [EnumMember(Value = "FTAX")]
    [IsoId("_ZgJemNp-Ed-ak6NoX_4Aeg_-1769598074")]
    [Description(@"Financial instrument is not valid for the requested tax year.")]
    FinancialInstrumentTaxYear,

    /// <summary>
    /// ISA type is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;ISAT&quot;.
    /// </summary>
    [EnumMember(Value = "ISAT")]
    [IsoId("_ZgJemdp-Ed-ak6NoX_4Aeg_-1768677810")]
    [Description(@"ISA type is not recognised or invalid.")]
    InvalidISAType,

    /// <summary>
    /// Cash account is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZgTPkNp-Ed-ak6NoX_4Aeg_-1768677000")]
    [Description(@"Cash account is not recognised or invalid.")]
    InvalidCashAccount,

    /// <summary>
    /// Transfer reference is a duplicate of a previously received transfer.
    /// Encoded/decoded by serializers as &quot;TREF&quot;.
    /// </summary>
    [EnumMember(Value = "TREF")]
    [IsoId("_ZgTPkdp-Ed-ak6NoX_4Aeg_-1768676164")]
    [Description(@"Transfer reference is a duplicate of a previously received transfer.")]
    DuplicateTransferReference,

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZgTPktp-Ed-ak6NoX_4Aeg_95305416")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    InvalidSettlementAmount,

    /// <summary>
    /// Unrecognised or invalid ordered amount.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_ZgTPk9p-Ed-ak6NoX_4Aeg_-1167804216")]
    [Description(@"Unrecognised or invalid ordered amount.")]
    InvalidOrderedAmount,

    /// <summary>
    /// Amount of subscription is below the minimum initial investment amount.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_ZgTPlNp-Ed-ak6NoX_4Aeg_-1167802313")]
    [Description(@"Amount of subscription is below the minimum initial investment amount.")]
    BelowMinimumInitialInvestmentAmount,

    /// <summary>
    /// Amount of subscription is below the minimum top-up investment.
    /// Encoded/decoded by serializers as &quot;BMTO&quot;.
    /// </summary>
    [EnumMember(Value = "BMTO")]
    [IsoId("_ZgTPldp-Ed-ak6NoX_4Aeg_-1166880747")]
    [Description(@"Amount of subscription is below the minimum top-up investment.")]
    BelowMinimumTopUpAmount,

    /// <summary>
    /// Insufficient capacity.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_ZgTPltp-Ed-ak6NoX_4Aeg_-1166878928")]
    [Description(@"Insufficient capacity.")]
    InsufficientCapacity,

    /// <summary>
    /// Percentage holding breach, for example, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_ZgTPl9p-Ed-ak6NoX_4Aeg_-1165957284")]
    [Description(@"Percentage holding breach, for example, PPM rules; taxation rules (ERISA).")]
    PercentageHoldingBreach,

    /// <summary>
    /// Amount is below the minimum redemption amount.
    /// Encoded/decoded by serializers as &quot;BMRA&quot;.
    /// </summary>
    [EnumMember(Value = "BMRA")]
    [IsoId("_ZgTPmNp-Ed-ak6NoX_4Aeg_-1165955381")]
    [Description(@"Amount is below the minimum redemption amount.")]
    BelowMinimumRedemptionAmount,

    /// <summary>
    /// Holding will be below the minimum retained value.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("_ZgTPmdp-Ed-ak6NoX_4Aeg_-1165033762")]
    [Description(@"Holding will be below the minimum retained value.")]
    BelowMinimumRetainedAmount,

    /// <summary>
    /// Lock-up period is in place.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_ZgdAkNp-Ed-ak6NoX_4Aeg_-1165031798")]
    [Description(@"Lock-up period is in place.")]
    LockUp,

    /// <summary>
    /// Assets are illiquid.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("_ZgdAkdp-Ed-ak6NoX_4Aeg_-1164110119")]
    [Description(@"Assets are illiquid.")]
    AssetsIlliquid,

    /// <summary>
    /// Data in the order or transfer instruction is invalid.
    /// Encoded/decoded by serializers as &quot;DINV&quot;.
    /// </summary>
    [EnumMember(Value = "DINV")]
    [IsoId("_ZgdAktp-Ed-ak6NoX_4Aeg_-1164108155")]
    [Description(@"Data in the order or transfer instruction is invalid.")]
    DataInvalid,

    /// <summary>
    /// Fund is closed and will not take in any more investments.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_ZgdAk9p-Ed-ak6NoX_4Aeg_-1163186260")]
    [Description(@"Fund is closed and will not take in any more investments.")]
    FundClosed,

    /// <summary>
    /// Instruction specifies an unacceptable combination for the financial instruments in the switch order.
    /// Encoded/decoded by serializers as &quot;UNSC&quot;.
    /// </summary>
    [EnumMember(Value = "UNSC")]
    [IsoId("_JF3hgFNFEeaOrcVOcDJQkA")]
    [Description(
        @"Instruction specifies an unacceptable combination for the financial instruments in the switch order."
    )]
    UnacceptableSwitchCombination,

    /// <summary>
    /// The two share classes are not part of the same fund.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_cG_fMBaGEeqoX-WM86RAxQ")]
    [Description(@"The two share classes are not part of the same fund.")]
    NotConvertable,

    /// <summary>
    /// Asset instructed for transfer is closed.
    /// Encoded/decoded by serializers as &quot;ACLO&quot;.
    /// </summary>
    [EnumMember(Value = "ACLO")]
    [IsoId("_csL28BaGEeqoX-WM86RAxQ")]
    [Description(@"Asset instructed for transfer is closed.")]
    AssetClosed,

    /// <summary>
    /// Transfer quantity is too small.
    /// Encoded/decoded by serializers as &quot;NQTY&quot;.
    /// </summary>
    [EnumMember(Value = "NQTY")]
    [IsoId("_dIKBQBaGEeqoX-WM86RAxQ")]
    [Description(@"Transfer quantity is too small.")]
    QuantityBelowMinimum,

    /// <summary>
    /// Asset does not support reregistration.
    /// Encoded/decoded by serializers as &quot;NASS&quot;.
    /// </summary>
    [EnumMember(Value = "NASS")]
    [IsoId("_dh5W8BaGEeqoX-WM86RAxQ")]
    [Description(@"Asset does not support reregistration.")]
    AssetNotSupported,

    /// <summary>
    /// Instruction is not compliant with the relevant market practice.
    /// Encoded/decoded by serializers as &quot;NCMP&quot;.
    /// </summary>
    [EnumMember(Value = "NCMP")]
    [IsoId("_L74qsOiiEeuLe8v4JEtDDg")]
    [Description(@"Instruction is not compliant with the relevant market practice.")]
    NotCompliantWithMarketPractice,
}
