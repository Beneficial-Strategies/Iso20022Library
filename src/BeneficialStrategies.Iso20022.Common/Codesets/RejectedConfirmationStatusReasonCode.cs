// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a confirmation rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZcH6ONp-Ed-ak6NoX_4Aeg_2113248200")]
[Description(@"Specifies the reason for a confirmation rejected status.")]
[Derivations(typeof(RejectedConfirmationStatusReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectedConfirmationStatusReasonCode>))]
#endif
public enum RejectedConfirmationStatusReasonCode
{
    /// <summary>
    /// Investment account information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSAF&quot;.
    /// </summary>
    [EnumMember(Value = "DSAF")]
    [IsoId("_ZcRrMNp-Ed-ak6NoX_4Aeg_-1704775209")]
    [Description(@"Investment account information not the same as instructed.")]
    DifferentInvestmentAccountDetails,

    /// <summary>
    /// Financial instrument information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DFIN&quot;.
    /// </summary>
    [EnumMember(Value = "DFIN")]
    [IsoId("_ZcRrMdp-Ed-ak6NoX_4Aeg_-1470199278")]
    [Description(@"Financial instrument information not the same as instructed.")]
    DifferentFinancialInstrumentDetails,

    /// <summary>
    /// Beneficiary details is not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DBEN&quot;.
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_ZcRrMtp-Ed-ak6NoX_4Aeg_-1447112316")]
    [Description(@"Beneficiary details is not the same as instructed.")]
    DifferentBeneficiaryDetails,

    /// <summary>
    /// Place of trade not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPTD&quot;.
    /// </summary>
    [EnumMember(Value = "DPTD")]
    [IsoId("_ZcRrM9p-Ed-ak6NoX_4Aeg_-1037990127")]
    [Description(@"Place of trade not the same as instructed.")]
    DifferentPlaceOfTrade,

    /// <summary>
    /// Order date time not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_ZcRrNNp-Ed-ak6NoX_4Aeg_-1009361819")]
    [Description(@"Order date time not the same as instructed.")]
    DifferentOrderDateTime,

    /// <summary>
    /// Cancellation right not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DCXR&quot;.
    /// </summary>
    [EnumMember(Value = "DCXR")]
    [IsoId("_ZcRrNdp-Ed-ak6NoX_4Aeg_-982579260")]
    [Description(@"Cancellation right not the same as instructed.")]
    DifferentCancellationRight,

    /// <summary>
    /// Units number information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DUNB&quot;.
    /// </summary>
    [EnumMember(Value = "DUNB")]
    [IsoId("_ZcRrNtp-Ed-ak6NoX_4Aeg_-968727883")]
    [Description(@"Units number information not the same as instructed.")]
    DifferentUnitsNumber,

    /// <summary>
    /// Order type information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DORT&quot;.
    /// </summary>
    [EnumMember(Value = "DORT")]
    [IsoId("_ZcRrN9p-Ed-ak6NoX_4Aeg_-940096394")]
    [Description(@"Order type information not the same as instructed.")]
    DifferentOrderType,

    /// <summary>
    /// Rounding information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DROU&quot;.
    /// </summary>
    [EnumMember(Value = "DROU")]
    [IsoId("_ZcRrONp-Ed-ak6NoX_4Aeg_-924397559")]
    [Description(@"Rounding information not the same as instructed.")]
    DifferentRounding,

    /// <summary>
    /// Net amount information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DNAM&quot;.
    /// </summary>
    [EnumMember(Value = "DNAM")]
    [IsoId("_ZcRrOdp-Ed-ak6NoX_4Aeg_-844974273")]
    [Description(@"Net amount information not the same as instructed.")]
    DifferentNetAmount,

    /// <summary>
    /// Gross amount information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DGAM&quot;.
    /// </summary>
    [EnumMember(Value = "DGAM")]
    [IsoId("_ZcRrOtp-Ed-ak6NoX_4Aeg_-837588505")]
    [Description(@"Gross amount information not the same as instructed.")]
    DifferentGrossAmount,

    /// <summary>
    /// Holdings redemption rate not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DHRR&quot;.
    /// </summary>
    [EnumMember(Value = "DHRR")]
    [IsoId("_ZcbcMNp-Ed-ak6NoX_4Aeg_-813576507")]
    [Description(@"Holdings redemption rate not the same as instructed.")]
    DifferentHoldingsRedemptionRate,

    /// <summary>
    /// Group 1 or 2 units not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DGRP&quot;.
    /// </summary>
    [EnumMember(Value = "DGRP")]
    [IsoId("_ZcbcMdp-Ed-ak6NoX_4Aeg_-584544029")]
    [Description(@"Group 1 or 2 units not the same as instructed.")]
    DifferentGroup1Or2Units,

    /// <summary>
    /// Income preference information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DINP&quot;.
    /// </summary>
    [EnumMember(Value = "DINP")]
    [IsoId("_ZcbcMtp-Ed-ak6NoX_4Aeg_-570689327")]
    [Description(@"Income preference information not the same as instructed.")]
    DifferentIncomePreference,

    /// <summary>
    /// Letter Intent reference information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DLIR&quot;.
    /// </summary>
    [EnumMember(Value = "DLIR")]
    [IsoId("_ZcbcM9p-Ed-ak6NoX_4Aeg_-539289250")]
    [Description(@"Letter Intent reference information not the same as instructed.")]
    DifferentLetterIntentReference,

    /// <summary>
    /// Accumulation right reference information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DARR&quot;.
    /// </summary>
    [EnumMember(Value = "DARR")]
    [IsoId("_ZcbcNNp-Ed-ak6NoX_4Aeg_-512506653")]
    [Description(@"Accumulation right reference information not the same as instructed.")]
    DifferentAccumulationRightReference,

    /// <summary>
    /// Physical delivery indicator information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPDI&quot;.
    /// </summary>
    [EnumMember(Value = "DPDI")]
    [IsoId("_ZcbcNdp-Ed-ak6NoX_4Aeg_-494959628")]
    [Description(@"Physical delivery indicator information not the same as instructed.")]
    DifferentPhysicalDeliveryIndicator,

    /// <summary>
    /// Requested settlement currency information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DRSC&quot;.
    /// </summary>
    [EnumMember(Value = "DRSC")]
    [IsoId("_ZcbcNtp-Ed-ak6NoX_4Aeg_-470024511")]
    [Description(@"Requested settlement currency information not the same as instructed.")]
    DifferentRequestedSettlementCurrency,

    /// <summary>
    /// Requested NAV currency information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DNAV&quot;.
    /// </summary>
    [EnumMember(Value = "DNAV")]
    [IsoId("_ZcbcN9p-Ed-ak6NoX_4Aeg_-454326701")]
    [Description(@"Requested NAV currency information not the same as instructed.")]
    DifferentRequestedNAVCurrency,

    /// <summary>
    /// Foreign exchange details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DFXD&quot;.
    /// </summary>
    [EnumMember(Value = "DFXD")]
    [IsoId("_ZcbcONp-Ed-ak6NoX_4Aeg_-439548555")]
    [Description(@"Foreign exchange details information not the same as instructed.")]
    DifferentForeignExchangeDetails,

    /// <summary>
    /// Charge details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DCHD&quot;.
    /// </summary>
    [EnumMember(Value = "DCHD")]
    [IsoId("_ZcbcOdp-Ed-ak6NoX_4Aeg_-187430203")]
    [Description(@"Charge details information not the same as instructed.")]
    DifferentChargeDetails,

    /// <summary>
    /// Commission details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DXOD&quot;.
    /// </summary>
    [EnumMember(Value = "DXOD")]
    [IsoId("_ZckmINp-Ed-ak6NoX_4Aeg_-181888516")]
    [Description(@"Commission details information not the same as instructed.")]
    DifferentCommissionDetails,

    /// <summary>
    /// Tax details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DTAD&quot;.
    /// </summary>
    [EnumMember(Value = "DTAD")]
    [IsoId("_ZckmIdp-Ed-ak6NoX_4Aeg_-168959552")]
    [Description(@"Tax details information not the same as instructed.")]
    DifferentTaxDetails,

    /// <summary>
    /// Physical delivery details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPDD&quot;.
    /// </summary>
    [EnumMember(Value = "DPDD")]
    [IsoId("_ZckmItp-Ed-ak6NoX_4Aeg_-154181972")]
    [Description(@"Physical delivery details information not the same as instructed.")]
    DifferentPhysicalDeliveryDetails,

    /// <summary>
    /// Settlement and custody details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSCA&quot;.
    /// </summary>
    [EnumMember(Value = "DSCA")]
    [IsoId("_ZckmI9p-Ed-ak6NoX_4Aeg_-139404972")]
    [Description(@"Settlement and custody details information not the same as instructed.")]
    DifferentSettlementAndCustodyDetails,

    /// <summary>
    /// Payment Instrument details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPID&quot;.
    /// </summary>
    [EnumMember(Value = "DPID")]
    [IsoId("_ZckmJNp-Ed-ak6NoX_4Aeg_-124630805")]
    [Description(@"Payment Instrument details information not the same as instructed.")]
    DifferentPaymentInstrumentDetails,

    /// <summary>
    /// Settlement amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSAM&quot;.
    /// </summary>
    [EnumMember(Value = "DSAM")]
    [IsoId("_ZckmJdp-Ed-ak6NoX_4Aeg_-111698385")]
    [Description(@"Settlement amount not the same as instructed.")]
    DifferentSettlementAmount,

    /// <summary>
    /// Settlement date not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSDT&quot;.
    /// </summary>
    [EnumMember(Value = "DSDT")]
    [IsoId("_ZckmJtp-Ed-ak6NoX_4Aeg_-93228070")]
    [Description(@"Settlement date not the same as instructed.")]
    DifferentSettlementDate,

    /// <summary>
    /// Extension information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DEXD&quot;.
    /// </summary>
    [EnumMember(Value = "DEXD")]
    [IsoId("_ZckmJ9p-Ed-ak6NoX_4Aeg_-81222744")]
    [Description(@"Extension information not the same as instructed.")]
    DifferentExtensionDetails,

    /// <summary>
    /// Intermediary information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DIMD&quot;.
    /// </summary>
    [EnumMember(Value = "DIMD")]
    [IsoId("_ZckmKNp-Ed-ak6NoX_4Aeg_-66447822")]
    [Description(@"Intermediary information not the same as instructed.")]
    DifferentIntermediaryDetails,

    /// <summary>
    /// Total redemption amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DTRA&quot;.
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_ZckmKdp-Ed-ak6NoX_4Aeg_-55363287")]
    [Description(@"Total redemption amount not the same as instructed.")]
    DifferentTotalRedemptionAmount,

    /// <summary>
    /// Total subscription amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DTSA&quot;.
    /// </summary>
    [EnumMember(Value = "DTSA")]
    [IsoId("_ZcuXINp-Ed-ak6NoX_4Aeg_-42437390")]
    [Description(@"Total subscription amount not the same as instructed.")]
    DifferentTotalSubscriptionAmount,

    /// <summary>
    /// Additional cash in not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DACI&quot;.
    /// </summary>
    [EnumMember(Value = "DACI")]
    [IsoId("_ZcuXIdp-Ed-ak6NoX_4Aeg_-28584376")]
    [Description(@"Additional cash in not the same as instructed.")]
    DifferentAdditionalCashIn,

    /// <summary>
    /// Resulting cash out not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DACO&quot;.
    /// </summary>
    [EnumMember(Value = "DACO")]
    [IsoId("_ZcuXItp-Ed-ak6NoX_4Aeg_-23964007")]
    [Description(@"Resulting cash out not the same as instructed.")]
    DifferentResultingCashOut,

    /// <summary>
    /// Percentage of total subscription amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPSA&quot;.
    /// </summary>
    [EnumMember(Value = "DPSA")]
    [IsoId("_ZcuXI9p-Ed-ak6NoX_4Aeg_-10114216")]
    [Description(@"Percentage of total subscription amount not the same as instructed.")]
    DifferentPercentageOfTotalSubscriptionAmount,

    /// <summary>
    /// Percentage of total redemption amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPRA&quot;.
    /// </summary>
    [EnumMember(Value = "DPRA")]
    [IsoId("_ZcuXJNp-Ed-ak6NoX_4Aeg_2817621")]
    [Description(@"Percentage of total redemption amount not the same as instructed.")]
    DifferentPercentageOfTotalRedemptionAmount,

    /// <summary>
    /// Leg Identification not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DLID&quot;.
    /// </summary>
    [EnumMember(Value = "DLID")]
    [IsoId("_ZcuXJdp-Ed-ak6NoX_4Aeg_17594932")]
    [Description(@"Leg Identification not the same as instructed.")]
    DifferentLegIdentification,

    /// <summary>
    /// Confirmation is recognised by the Receiver because the message reference is identified, but the order reference is not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DORF&quot;.
    /// </summary>
    [EnumMember(Value = "DORF")]
    [IsoId("_ZcuXJtp-Ed-ak6NoX_4Aeg_30521778")]
    [Description(
        @"Confirmation is recognised by the Receiver because the message reference is identified, but the order reference is not the same as instructed."
    )]
    DifferentOrderReference,

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ZcuXJ9p-Ed-ak6NoX_4Aeg_44373585")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference,

    /// <summary>
    /// Deal reference is a duplicate of a previously received deal reference.
    /// Encoded/decoded by serializers as &quot;DREF&quot;.
    /// </summary>
    [EnumMember(Value = "DREF")]
    [IsoId("_ZcuXKNp-Ed-ak6NoX_4Aeg_71157658")]
    [Description(@"Deal reference is a duplicate of a previously received deal reference.")]
    DuplicateDealReference,

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_ZcuXKdp-Ed-ak6NoX_4Aeg_348211990")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent,

    /// <summary>
    /// Receiver&apos;s Custodian is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IRCU&quot;.
    /// </summary>
    [EnumMember(Value = "IRCU")]
    [IsoId("_ZcuXKtp-Ed-ak6NoX_4Aeg_372225025")]
    [Description(@"Receiver's Custodian is not recognised or is invalid.")]
    ReceiversCustodian,

    /// <summary>
    /// Receiver&apos;s Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IRIN&quot;.
    /// </summary>
    [EnumMember(Value = "IRIN")]
    [IsoId("_Zc4IINp-Ed-ak6NoX_4Aeg_385154371")]
    [Description(@"Receiver's Intermediary is not recognised or is invalid.")]
    ReceiversIntermediary,

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Zc4IIdp-Ed-ak6NoX_4Aeg_402702197")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent,

    /// <summary>
    /// Deliverer&apos;s Custodian is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDCU&quot;.
    /// </summary>
    [EnumMember(Value = "IDCU")]
    [IsoId("_Zc4IItp-Ed-ak6NoX_4Aeg_873698375")]
    [Description(@"Deliverer's Custodian is not recognised or is invalid.")]
    DeliverersCustodian,

    /// <summary>
    /// Deliverer&apos;s Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDIN&quot;.
    /// </summary>
    [EnumMember(Value = "IDIN")]
    [IsoId("_Zc4II9p-Ed-ak6NoX_4Aeg_-1818037850")]
    [Description(@"Deliverer's Intermediary is not recognised or is invalid.")]
    DeliverersIntermediary,

    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("_Zc4IJNp-Ed-ak6NoX_4Aeg_-1811574797")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer,

    /// <summary>
    /// Settlement Amount is invalid.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Zc4IJdp-Ed-ak6NoX_4Aeg_-1788484295")]
    [Description(@"Settlement Amount is invalid.")]
    SettlementAmount,

    /// <summary>
    /// Settlement date or transfer date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Zc4IJtp-Ed-ak6NoX_4Aeg_-1782945488")]
    [Description(@"Settlement date or transfer date is not recognised or is invalid.")]
    SettlementDate,

    /// <summary>
    /// Confirmation is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_Zc4IJ9p-Ed-ak6NoX_4Aeg_-1761704089")]
    [Description(@"Confirmation is not compliant with the service level agreement.")]
    NotCompliantWithSLA,

    /// <summary>
    /// EU tax information is missing.
    /// Encoded/decoded by serializers as &quot;MEUT&quot;.
    /// </summary>
    [EnumMember(Value = "MEUT")]
    [IsoId("_Zc4IKNp-Ed-ak6NoX_4Aeg_-1303636761")]
    [Description(@"EU tax information is missing.")]
    MissingEUTaxInformation,

    /// <summary>
    /// Commission information is missing.
    /// Encoded/decoded by serializers as &quot;MCOM&quot;.
    /// </summary>
    [EnumMember(Value = "MCOM")]
    [IsoId("_Zc4IKdp-Ed-ak6NoX_4Aeg_-1287012362")]
    [Description(@"Commission information is missing.")]
    MissingCommission,

    /// <summary>
    /// Charge information is missing.
    /// Encoded/decoded by serializers as &quot;MCHA&quot;.
    /// </summary>
    [EnumMember(Value = "MCHA")]
    [IsoId("_ZdBSENp-Ed-ak6NoX_4Aeg_-1273161408")]
    [Description(@"Charge information is missing.")]
    MissingCharge,

    /// <summary>
    /// Tax information is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_ZdBSEdp-Ed-ak6NoX_4Aeg_-1267619317")]
    [Description(@"Tax information is missing.")]
    MissingTaxInformation,

    /// <summary>
    /// Amendment of order confirmation not allowed.
    /// Encoded/decoded by serializers as &quot;NATA&quot;.
    /// </summary>
    [EnumMember(Value = "NATA")]
    [IsoId("_ZdBSEtp-Ed-ak6NoX_4Aeg_-1246378920")]
    [Description(@"Amendment of order confirmation not allowed.")]
    NotAllowedtoAmend,

    /// <summary>
    /// Amendment of order confirmation too late.
    /// Encoded/decoded by serializers as &quot;ALAT&quot;.
    /// </summary>
    [EnumMember(Value = "ALAT")]
    [IsoId("_ZdBSE9p-Ed-ak6NoX_4Aeg_-1239914291")]
    [Description(@"Amendment of order confirmation too late.")]
    AmendmentTooLate,
}
