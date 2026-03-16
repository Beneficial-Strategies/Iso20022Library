// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkeTNNp-Ed-ak6NoX_4Aeg_-866982753")]
[Description(@"Specifies the reason for a rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum RejectedStatusReason5Code
{
    /// <summary>
    /// Order contains funds that have different valuation points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_VkeTNdp-Ed-ak6NoX_4Aeg_-512347283")]
    [Description(@"Order contains funds that have different valuation points.")]
    DifferentValuationPoints = RejectedStatusReasonCode.DifferentValuationPoints, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_VkeTNtp-Ed-ak6NoX_4Aeg_-511427251")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectedStatusReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDDB&quot;.
    /// </summary>
    [EnumMember(Value = "IDDB")]
    [IsoId("_VkeTN9p-Ed-ak6NoX_4Aeg_-511427234")]
    [Description(@"Direct debit account identification is not recognised or is invalid.")]
    DirectDebit = RejectedStatusReasonCode.DirectDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_VkeTONp-Ed-ak6NoX_4Aeg_-511427216")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectedStatusReasonCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_VkeTOdp-Ed-ak6NoX_4Aeg_-511427199")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment card details are incorrect.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_VkndINp-Ed-ak6NoX_4Aeg_-511427181")]
    [Description(@"Payment card details are incorrect.")]
    PaymentCard = RejectedStatusReasonCode.PaymentCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("_VkndIdp-Ed-ak6NoX_4Aeg_-511427156")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer = RejectedStatusReasonCode.InvalidCreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_VkndItp-Ed-ak6NoX_4Aeg_-511427139")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace = RejectedStatusReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_VkndI9p-Ed-ak6NoX_4Aeg_-511427121")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectedStatusReasonCode.ReceivingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping place is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ISAF&quot;.
    /// </summary>
    [EnumMember(Value = "ISAF")]
    [IsoId("_VkndJNp-Ed-ak6NoX_4Aeg_-511427096")]
    [Description(@"Safekeeping place is not recognised or is invalid.")]
    SafekeepingPlace = RejectedStatusReasonCode.SafekeepingPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_VkndJdp-Ed-ak6NoX_4Aeg_-511427079")]
    [Description(
        @"Form of the security is wrong, eg, the form of security is registered not bearer or vice versa."
    )]
    InvalidSecurityForm = RejectedStatusReasonCode.InvalidSecurityForm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_VkndJtp-Ed-ak6NoX_4Aeg_-793166376")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_VkndJ9p-Ed-ak6NoX_4Aeg_-511427044")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction = RejectedStatusReasonCode.AccountBlockedForCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("_VkxOINp-Ed-ak6NoX_4Aeg_-511427026")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer = RejectedStatusReasonCode.AccountBlockedForTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_VkxOIdp-Ed-ak6NoX_4Aeg_-511427001")]
    [Description(
        @"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy."
    )]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is not enough cash in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_VkxOItp-Ed-ak6NoX_4Aeg_-511426966")]
    [Description(@"There is not enough cash in the account to process the instruction.")]
    NotEnoughCash = RejectedStatusReasonCode.NotEnoughCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_VkxOI9p-Ed-ak6NoX_4Aeg_-323094095")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_VkxOJNp-Ed-ak6NoX_4Aeg_90644619")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName =
        RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage of commission waiving exceeds the commission percentage or commission amount.
    /// Encoded/decoded by serializers as &quot;UWAI&quot;.
    /// </summary>
    [EnumMember(Value = "UWAI")]
    [IsoId("_VkxOJdp-Ed-ak6NoX_4Aeg_-511426672")]
    [Description(
        @"Percentage of commission waiving exceeds the commission percentage or commission amount."
    )]
    UnacceptedCommissionWaiving = RejectedStatusReasonCode.UnacceptedCommissionWaiving, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal currency is not supported.
    /// Encoded/decoded by serializers as &quot;UDCY&quot;.
    /// </summary>
    [EnumMember(Value = "UDCY")]
    [IsoId("_VkxOJtp-Ed-ak6NoX_4Aeg_-511426654")]
    [Description(@"Deal currency is not supported.")]
    UnacceptedDealCurrency = RejectedStatusReasonCode.UnacceptedDealCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net asset value currency is not supported.
    /// Encoded/decoded by serializers as &quot;UNAV&quot;.
    /// </summary>
    [EnumMember(Value = "UNAV")]
    [IsoId("_VkxOJ9p-Ed-ak6NoX_4Aeg_-511426612")]
    [Description(@"Net asset value currency is not supported.")]
    UnacceptedNAVCurrency = RejectedStatusReasonCode.UnacceptedNAVCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment method, for example, cheque or payment card, is not accepted.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_VkxOKNp-Ed-ak6NoX_4Aeg_-511426594")]
    [Description(@"Payment method, for example, cheque or payment card, is not accepted.")]
    UnacceptedPaymentMethod = RejectedStatusReasonCode.UnacceptedPaymentMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("_VkxOKdp-Ed-ak6NoX_4Aeg_-511426569")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency =
        RejectedStatusReasonCode.UnacceptedRequestedSettlementCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of units or amount of money in the order is too high for a subscription.
    /// Encoded/decoded by serializers as &quot;SHIG&quot;.
    /// </summary>
    [EnumMember(Value = "SHIG")]
    [IsoId("_Vk6_INp-Ed-ak6NoX_4Aeg_-511426551")]
    [Description(
        @"Quantity of units or amount of money in the order is too high for a subscription."
    )]
    TooHighUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooHighUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of units or amount of money in the order is too low for a subscription.
    /// Encoded/decoded by serializers as &quot;SLOW&quot;.
    /// </summary>
    [EnumMember(Value = "SLOW")]
    [IsoId("_Vk6_Idp-Ed-ak6NoX_4Aeg_-511426268")]
    [Description(
        @"Quantity of units or amount of money in the order is too low for a subscription."
    )]
    TooLowUnitsOrAmountToSubscribe = RejectedStatusReasonCode.TooLowUnitsOrAmountToSubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Vk6_Itp-Ed-ak6NoX_4Aeg_-511426250")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference = RejectedStatusReasonCode.UnknownLinkagesReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_Vk6_I9p-Ed-ak6NoX_4Aeg_-511426225")]
    [Description(
        @"Order contains physical delivery details but the fund can not be physically delivered."
    )]
    PhysicalDeliveryImpossible = RejectedStatusReasonCode.PhysicalDeliveryImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order reference is a duplicate of a previously received order.
    /// Encoded/decoded by serializers as &quot;ORRF&quot;.
    /// </summary>
    [EnumMember(Value = "ORRF")]
    [IsoId("_Vk6_JNp-Ed-ak6NoX_4Aeg_-511426190")]
    [Description(@"Order reference is a duplicate of a previously received order.")]
    DuplicateOrderReference = RejectedStatusReasonCode.DuplicateOrderReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("_Vk6_Jdp-Ed-ak6NoX_4Aeg_-511426165")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount =
        RejectedStatusReasonCode.InstructingPartyNotAllowedForAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order type is invalid.
    /// Encoded/decoded by serializers as &quot;IOTP&quot;.
    /// </summary>
    [EnumMember(Value = "IOTP")]
    [IsoId("_Vk6_Jtp-Ed-ak6NoX_4Aeg_-511426148")]
    [Description(@"Order type is invalid.")]
    InvalidOrderType = RejectedStatusReasonCode.InvalidOrderType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_Vk6_J9p-Ed-ak6NoX_4Aeg_-511426113")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_Vk6_KNp-Ed-ak6NoX_4Aeg_-511426095")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another reason for the status rejected.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vk6_Kdp-Ed-ak6NoX_4Aeg_-511426070")]
    [Description(@"Another reason for the status rejected.")]
    Other = RejectedStatusReasonCode.Other, // same ordinal as derivation source for type conversions
}
