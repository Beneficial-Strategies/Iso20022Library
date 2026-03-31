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
[IsoId("_ZbYTUdp-Ed-ak6NoX_4Aeg_2141876808")]
[Description(@"Specifies the reason for a confirmation rejected status.")]
[DerivedFrom(typeof(RejectedConfirmationStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectedConfirmationStatusReason1Code>))]
#endif
public enum RejectedConfirmationStatusReason1Code
{
    /// <summary>
    /// Investment account information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSAF&quot;.
    /// </summary>
    [EnumMember(Value = "DSAF")]
    [IsoId("_ZbYTUtp-Ed-ak6NoX_4Aeg_-695958995")]
    [Description(@"Investment account information not the same as instructed.")]
    DifferentInvestmentAccountDetails =
        RejectedConfirmationStatusReasonCode.DifferentInvestmentAccountDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DFIN&quot;.
    /// </summary>
    [EnumMember(Value = "DFIN")]
    [IsoId("_ZbYTU9p-Ed-ak6NoX_4Aeg_-695958376")]
    [Description(@"Financial instrument information not the same as instructed.")]
    DifferentFinancialInstrumentDetails =
        RejectedConfirmationStatusReasonCode.DifferentFinancialInstrumentDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Beneficiary details is not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DBEN&quot;.
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_ZbYTVNp-Ed-ak6NoX_4Aeg_-695037937")]
    [Description(@"Beneficiary details is not the same as instructed.")]
    DifferentBeneficiaryDetails = RejectedConfirmationStatusReasonCode.DifferentBeneficiaryDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of trade not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPTD&quot;.
    /// </summary>
    [EnumMember(Value = "DPTD")]
    [IsoId("_ZbYTVdp-Ed-ak6NoX_4Aeg_-695037912")]
    [Description(@"Place of trade not the same as instructed.")]
    DifferentPlaceOfTrade = RejectedConfirmationStatusReasonCode.DifferentPlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order date time not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DORD&quot;.
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_ZbYTVtp-Ed-ak6NoX_4Aeg_-695037410")]
    [Description(@"Order date time not the same as instructed.")]
    DifferentOrderDateTime = RejectedConfirmationStatusReasonCode.DifferentOrderDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation right not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DCXR&quot;.
    /// </summary>
    [EnumMember(Value = "DCXR")]
    [IsoId("_ZbYTV9p-Ed-ak6NoX_4Aeg_-695036887")]
    [Description(@"Cancellation right not the same as instructed.")]
    DifferentCancellationRight = RejectedConfirmationStatusReasonCode.DifferentCancellationRight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Units number information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DUNB&quot;.
    /// </summary>
    [EnumMember(Value = "DUNB")]
    [IsoId("_ZbYTWNp-Ed-ak6NoX_4Aeg_-695036697")]
    [Description(@"Units number information not the same as instructed.")]
    DifferentUnitsNumber = RejectedConfirmationStatusReasonCode.DifferentUnitsNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order type information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DORT&quot;.
    /// </summary>
    [EnumMember(Value = "DORT")]
    [IsoId("_ZbYTWdp-Ed-ak6NoX_4Aeg_-695035896")]
    [Description(@"Order type information not the same as instructed.")]
    DifferentOrderType = RejectedConfirmationStatusReasonCode.DifferentOrderType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rounding information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DROU&quot;.
    /// </summary>
    [EnumMember(Value = "DROU")]
    [IsoId("_ZbiEUNp-Ed-ak6NoX_4Aeg_-695035334")]
    [Description(@"Rounding information not the same as instructed.")]
    DifferentRounding = RejectedConfirmationStatusReasonCode.DifferentRounding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net amount information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DNAM&quot;.
    /// </summary>
    [EnumMember(Value = "DNAM")]
    [IsoId("_ZbiEUdp-Ed-ak6NoX_4Aeg_-695034499")]
    [Description(@"Net amount information not the same as instructed.")]
    DifferentNetAmount = RejectedConfirmationStatusReasonCode.DifferentNetAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross amount information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DGAM&quot;.
    /// </summary>
    [EnumMember(Value = "DGAM")]
    [IsoId("_ZbiEUtp-Ed-ak6NoX_4Aeg_-687649588")]
    [Description(@"Gross amount information not the same as instructed.")]
    DifferentGrossAmount = RejectedConfirmationStatusReasonCode.DifferentGrossAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holdings redemption rate not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DHRR&quot;.
    /// </summary>
    [EnumMember(Value = "DHRR")]
    [IsoId("_ZbiEU9p-Ed-ak6NoX_4Aeg_-687648777")]
    [Description(@"Holdings redemption rate not the same as instructed.")]
    DifferentHoldingsRedemptionRate =
        RejectedConfirmationStatusReasonCode.DifferentHoldingsRedemptionRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Group 1 or 2 units not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DGRP&quot;.
    /// </summary>
    [EnumMember(Value = "DGRP")]
    [IsoId("_ZbiEVNp-Ed-ak6NoX_4Aeg_-687648250")]
    [Description(@"Group 1 or 2 units not the same as instructed.")]
    DifferentGroup1Or2Units = RejectedConfirmationStatusReasonCode.DifferentGroup1Or2Units, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income preference information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DINP&quot;.
    /// </summary>
    [EnumMember(Value = "DINP")]
    [IsoId("_ZbiEVdp-Ed-ak6NoX_4Aeg_-687647770")]
    [Description(@"Income preference information not the same as instructed.")]
    DifferentIncomePreference = RejectedConfirmationStatusReasonCode.DifferentIncomePreference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Letter Intent reference information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DLIR&quot;.
    /// </summary>
    [EnumMember(Value = "DLIR")]
    [IsoId("_ZbiEVtp-Ed-ak6NoX_4Aeg_-687647572")]
    [Description(@"Letter Intent reference information not the same as instructed.")]
    DifferentLetterIntentReference =
        RejectedConfirmationStatusReasonCode.DifferentLetterIntentReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accumulation right reference information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DARR&quot;.
    /// </summary>
    [EnumMember(Value = "DARR")]
    [IsoId("_ZbiEV9p-Ed-ak6NoX_4Aeg_-687647165")]
    [Description(@"Accumulation right reference information not the same as instructed.")]
    DifferentAccumulationRightReference =
        RejectedConfirmationStatusReasonCode.DifferentAccumulationRightReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical delivery indicator information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPDI&quot;.
    /// </summary>
    [EnumMember(Value = "DPDI")]
    [IsoId("_ZbiEWNp-Ed-ak6NoX_4Aeg_-687646892")]
    [Description(@"Physical delivery indicator information not the same as instructed.")]
    DifferentPhysicalDeliveryIndicator =
        RejectedConfirmationStatusReasonCode.DifferentPhysicalDeliveryIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested settlement currency information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DRSC&quot;.
    /// </summary>
    [EnumMember(Value = "DRSC")]
    [IsoId("_ZbiEWdp-Ed-ak6NoX_4Aeg_-687646624")]
    [Description(@"Requested settlement currency information not the same as instructed.")]
    DifferentRequestedSettlementCurrency =
        RejectedConfirmationStatusReasonCode.DifferentRequestedSettlementCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested NAV currency information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DNAV&quot;.
    /// </summary>
    [EnumMember(Value = "DNAV")]
    [IsoId("_ZbiEWtp-Ed-ak6NoX_4Aeg_-686726255")]
    [Description(@"Requested NAV currency information not the same as instructed.")]
    DifferentRequestedNAVCurrency =
        RejectedConfirmationStatusReasonCode.DifferentRequestedNAVCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Foreign exchange details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DFXD&quot;.
    /// </summary>
    [EnumMember(Value = "DFXD")]
    [IsoId("_Zbr1UNp-Ed-ak6NoX_4Aeg_-686726238")]
    [Description(@"Foreign exchange details information not the same as instructed.")]
    DifferentForeignExchangeDetails =
        RejectedConfirmationStatusReasonCode.DifferentForeignExchangeDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DCHD&quot;.
    /// </summary>
    [EnumMember(Value = "DCHD")]
    [IsoId("_Zbr1Udp-Ed-ak6NoX_4Aeg_-686726220")]
    [Description(@"Charge details information not the same as instructed.")]
    DifferentChargeDetails = RejectedConfirmationStatusReasonCode.DifferentChargeDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DXOD&quot;.
    /// </summary>
    [EnumMember(Value = "DXOD")]
    [IsoId("_Zbr1Utp-Ed-ak6NoX_4Aeg_-686726203")]
    [Description(@"Commission details information not the same as instructed.")]
    DifferentCommissionDetails = RejectedConfirmationStatusReasonCode.DifferentCommissionDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DTAD&quot;.
    /// </summary>
    [EnumMember(Value = "DTAD")]
    [IsoId("_Zbr1U9p-Ed-ak6NoX_4Aeg_-686725676")]
    [Description(@"Tax details information not the same as instructed.")]
    DifferentTaxDetails = RejectedConfirmationStatusReasonCode.DifferentTaxDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical delivery details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPDD&quot;.
    /// </summary>
    [EnumMember(Value = "DPDD")]
    [IsoId("_Zbr1VNp-Ed-ak6NoX_4Aeg_-686725195")]
    [Description(@"Physical delivery details information not the same as instructed.")]
    DifferentPhysicalDeliveryDetails =
        RejectedConfirmationStatusReasonCode.DifferentPhysicalDeliveryDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement and custody details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSCA&quot;.
    /// </summary>
    [EnumMember(Value = "DSCA")]
    [IsoId("_Zbr1Vdp-Ed-ak6NoX_4Aeg_-686724668")]
    [Description(@"Settlement and custody details information not the same as instructed.")]
    DifferentSettlementAndCustodyDetails =
        RejectedConfirmationStatusReasonCode.DifferentSettlementAndCustodyDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment Instrument details information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPID&quot;.
    /// </summary>
    [EnumMember(Value = "DPID")]
    [IsoId("_Zbr1Vtp-Ed-ak6NoX_4Aeg_-686724222")]
    [Description(@"Payment Instrument details information not the same as instructed.")]
    DifferentPaymentInstrumentDetails =
        RejectedConfirmationStatusReasonCode.DifferentPaymentInstrumentDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSAM&quot;.
    /// </summary>
    [EnumMember(Value = "DSAM")]
    [IsoId("_Zbr1V9p-Ed-ak6NoX_4Aeg_-686723369")]
    [Description(@"Settlement amount not the same as instructed.")]
    DifferentSettlementAmount = RejectedConfirmationStatusReasonCode.DifferentSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DSDT&quot;.
    /// </summary>
    [EnumMember(Value = "DSDT")]
    [IsoId("_Zbr1WNp-Ed-ak6NoX_4Aeg_-686723197")]
    [Description(@"Settlement date not the same as instructed.")]
    DifferentSettlementDate = RejectedConfirmationStatusReasonCode.DifferentSettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extension information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DEXD&quot;.
    /// </summary>
    [EnumMember(Value = "DEXD")]
    [IsoId("_Zbr1Wdp-Ed-ak6NoX_4Aeg_-685802681")]
    [Description(@"Extension information not the same as instructed.")]
    DifferentExtensionDetails = RejectedConfirmationStatusReasonCode.DifferentExtensionDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary information not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DIMD&quot;.
    /// </summary>
    [EnumMember(Value = "DIMD")]
    [IsoId("_Zb0_QNp-Ed-ak6NoX_4Aeg_-685802206")]
    [Description(@"Intermediary information not the same as instructed.")]
    DifferentIntermediaryDetails =
        RejectedConfirmationStatusReasonCode.DifferentIntermediaryDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total redemption amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DTRA&quot;.
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_Zb0_Qdp-Ed-ak6NoX_4Aeg_-685801492")]
    [Description(@"Total redemption amount not the same as instructed.")]
    DifferentTotalRedemptionAmount =
        RejectedConfirmationStatusReasonCode.DifferentTotalRedemptionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total subscription amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DTSA&quot;.
    /// </summary>
    [EnumMember(Value = "DTSA")]
    [IsoId("_Zb0_Qtp-Ed-ak6NoX_4Aeg_-685800812")]
    [Description(@"Total subscription amount not the same as instructed.")]
    DifferentTotalSubscriptionAmount =
        RejectedConfirmationStatusReasonCode.DifferentTotalSubscriptionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional cash in not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DACI&quot;.
    /// </summary>
    [EnumMember(Value = "DACI")]
    [IsoId("_Zb0_Q9p-Ed-ak6NoX_4Aeg_-685800545")]
    [Description(@"Additional cash in not the same as instructed.")]
    DifferentAdditionalCashIn = RejectedConfirmationStatusReasonCode.DifferentAdditionalCashIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting cash out not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DACO&quot;.
    /// </summary>
    [EnumMember(Value = "DACO")]
    [IsoId("_Zb0_RNp-Ed-ak6NoX_4Aeg_-685800113")]
    [Description(@"Resulting cash out not the same as instructed.")]
    DifferentResultingCashOut = RejectedConfirmationStatusReasonCode.DifferentResultingCashOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage of total subscription amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPSA&quot;.
    /// </summary>
    [EnumMember(Value = "DPSA")]
    [IsoId("_Zb0_Rdp-Ed-ak6NoX_4Aeg_-685799319")]
    [Description(@"Percentage of total subscription amount not the same as instructed.")]
    DifferentPercentageOfTotalSubscriptionAmount =
        RejectedConfirmationStatusReasonCode.DifferentPercentageOfTotalSubscriptionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage of total redemption amount not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DPRA&quot;.
    /// </summary>
    [EnumMember(Value = "DPRA")]
    [IsoId("_Zb0_Rtp-Ed-ak6NoX_4Aeg_-684879098")]
    [Description(@"Percentage of total redemption amount not the same as instructed.")]
    DifferentPercentageOfTotalRedemptionAmount =
        RejectedConfirmationStatusReasonCode.DifferentPercentageOfTotalRedemptionAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Leg Identification not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DLID&quot;.
    /// </summary>
    [EnumMember(Value = "DLID")]
    [IsoId("_Zb0_R9p-Ed-ak6NoX_4Aeg_-684878588")]
    [Description(@"Leg Identification not the same as instructed.")]
    DifferentLegIdentification = RejectedConfirmationStatusReasonCode.DifferentLegIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is recognised by the Receiver because the message reference is identified, but the order reference is not the same as instructed.
    /// Encoded/decoded by serializers as &quot;DORF&quot;.
    /// </summary>
    [EnumMember(Value = "DORF")]
    [IsoId("_Zb-wQNp-Ed-ak6NoX_4Aeg_-684878065")]
    [Description(
        @"Confirmation is recognised by the Receiver because the message reference is identified, but the order reference is not the same as instructed."
    )]
    DifferentOrderReference = RejectedConfirmationStatusReasonCode.DifferentOrderReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zb-wQdp-Ed-ak6NoX_4Aeg_-684877623")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference = RejectedConfirmationStatusReasonCode.UnknownLinkagesReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deal reference is a duplicate of a previously received deal reference.
    /// Encoded/decoded by serializers as &quot;DREF&quot;.
    /// </summary>
    [EnumMember(Value = "DREF")]
    [IsoId("_Zb-wQtp-Ed-ak6NoX_4Aeg_-684876727")]
    [Description(@"Deal reference is a duplicate of a previously received deal reference.")]
    DuplicateDealReference = RejectedConfirmationStatusReasonCode.DuplicateDealReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_Zb-wQ9p-Ed-ak6NoX_4Aeg_-684876702")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectedConfirmationStatusReasonCode.ReceivingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver&apos;s Custodian is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IRCU&quot;.
    /// </summary>
    [EnumMember(Value = "IRCU")]
    [IsoId("_Zb-wRNp-Ed-ak6NoX_4Aeg_-684876685")]
    [Description(@"Receiver's Custodian is not recognised or is invalid.")]
    ReceiversCustodian = RejectedConfirmationStatusReasonCode.ReceiversCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver&apos;s Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IRIN&quot;.
    /// </summary>
    [EnumMember(Value = "IRIN")]
    [IsoId("_Zb-wRdp-Ed-ak6NoX_4Aeg_-684876667")]
    [Description(@"Receiver's Intermediary is not recognised or is invalid.")]
    ReceiversIntermediary = RejectedConfirmationStatusReasonCode.ReceiversIntermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Zb-wRtp-Ed-ak6NoX_4Aeg_-684876049")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectedConfirmationStatusReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deliverer&apos;s Custodian is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDCU&quot;.
    /// </summary>
    [EnumMember(Value = "IDCU")]
    [IsoId("_Zb-wR9p-Ed-ak6NoX_4Aeg_-683955551")]
    [Description(@"Deliverer's Custodian is not recognised or is invalid.")]
    DeliverersCustodian = RejectedConfirmationStatusReasonCode.DeliverersCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deliverer&apos;s Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IDIN&quot;.
    /// </summary>
    [EnumMember(Value = "IDIN")]
    [IsoId("_Zb-wSNp-Ed-ak6NoX_4Aeg_-683955533")]
    [Description(@"Deliverer's Intermediary is not recognised or is invalid.")]
    DeliverersIntermediary = RejectedConfirmationStatusReasonCode.DeliverersIntermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit transfer details are incorrect.
    /// Encoded/decoded by serializers as &quot;ICTR&quot;.
    /// </summary>
    [EnumMember(Value = "ICTR")]
    [IsoId("_Zb-wSdp-Ed-ak6NoX_4Aeg_-683955006")]
    [Description(@"Credit transfer details are incorrect.")]
    InvalidCreditTransfer = RejectedConfirmationStatusReasonCode.InvalidCreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement Amount is invalid.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Zb-wStp-Ed-ak6NoX_4Aeg_-683954465")]
    [Description(@"Settlement Amount is invalid.")]
    SettlementAmount = RejectedConfirmationStatusReasonCode.SettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date or transfer date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZcH6MNp-Ed-ak6NoX_4Aeg_-683953707")]
    [Description(@"Settlement date or transfer date is not recognised or is invalid.")]
    SettlementDate = RejectedConfirmationStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_ZcH6Mdp-Ed-ak6NoX_4Aeg_-683953223")]
    [Description(@"Confirmation is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedConfirmationStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EU tax information is missing.
    /// Encoded/decoded by serializers as &quot;MEUT&quot;.
    /// </summary>
    [EnumMember(Value = "MEUT")]
    [IsoId("_ZcH6Mtp-Ed-ak6NoX_4Aeg_-683952682")]
    [Description(@"EU tax information is missing.")]
    MissingEUTaxInformation = RejectedConfirmationStatusReasonCode.MissingEUTaxInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission information is missing.
    /// Encoded/decoded by serializers as &quot;MCOM&quot;.
    /// </summary>
    [EnumMember(Value = "MCOM")]
    [IsoId("_ZcH6M9p-Ed-ak6NoX_4Aeg_-683031210")]
    [Description(@"Commission information is missing.")]
    MissingCommission = RejectedConfirmationStatusReasonCode.MissingCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge information is missing.
    /// Encoded/decoded by serializers as &quot;MCHA&quot;.
    /// </summary>
    [EnumMember(Value = "MCHA")]
    [IsoId("_ZcH6NNp-Ed-ak6NoX_4Aeg_-674719853")]
    [Description(@"Charge information is missing.")]
    MissingCharge = RejectedConfirmationStatusReasonCode.MissingCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax information is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_ZcH6Ndp-Ed-ak6NoX_4Aeg_-674719348")]
    [Description(@"Tax information is missing.")]
    MissingTaxInformation = RejectedConfirmationStatusReasonCode.MissingTaxInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amendment of order confirmation not allowed.
    /// Encoded/decoded by serializers as &quot;NATA&quot;.
    /// </summary>
    [EnumMember(Value = "NATA")]
    [IsoId("_ZcH6Ntp-Ed-ak6NoX_4Aeg_-674718837")]
    [Description(@"Amendment of order confirmation not allowed.")]
    NotAllowedtoAmend = RejectedConfirmationStatusReasonCode.NotAllowedtoAmend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amendment of order confirmation too late.
    /// Encoded/decoded by serializers as &quot;ALAT&quot;.
    /// </summary>
    [EnumMember(Value = "ALAT")]
    [IsoId("_ZcH6N9p-Ed-ak6NoX_4Aeg_-674718357")]
    [Description(@"Amendment of order confirmation too late.")]
    AmendmentTooLate = RejectedConfirmationStatusReasonCode.AmendmentTooLate, // same ordinal as derivation source for type conversions
}
