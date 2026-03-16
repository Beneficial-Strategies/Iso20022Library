// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a9lF6dp-Ed-ak6NoX_4Aeg_1571365550")]
[Description(@"Type of service for which a charge is asked or paid.")]
[Derivations(
    typeof(ChargeType8Code),
    typeof(ChargeType14Code),
    typeof(ChargeType4Code),
    typeof(ChargeType1Code),
    typeof(ChargeType10Code),
    typeof(ChargeType11Code),
    typeof(ChargeType15Code),
    typeof(ChargeType17Code),
    typeof(ChargeType13Code),
    typeof(ChargeType6Code),
    typeof(ChargeType16Code),
    typeof(ChargeType12Code),
    typeof(ChargeType7Code),
    typeof(ChargeType9Code)
)]
public enum ChargeTypeCode
{
    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_a9u24Np-Ed-ak6NoX_4Aeg_1216745738")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee,

    /// <summary>
    /// Fee paid for services provided.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_a9u24dp-Ed-ak6NoX_4Aeg_-1939920132")]
    [Description(@"Fee paid for services provided.")]
    Commission,

    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a9u24tp-Ed-ak6NoX_4Aeg_-1943223710")]
    [Description(
        @"Sales charge paid by the investor when redeeming an investment such as an investment fund."
    )]
    BackEndLoad,

    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a9u249p-Ed-ak6NoX_4Aeg_-1943223709")]
    [Description(
        @"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund."
    )]
    FrontEndLoad,

    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_a9u25Np-Ed-ak6NoX_4Aeg_-1943223708")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch,

    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.
    /// Encoded/decoded by serializers as &quot;DLEV&quot;.
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("_a9u25dp-Ed-ak6NoX_4Aeg_-329415246")]
    [Description(
        @"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders."
    )]
    DilutionLevy,

    /// <summary>
    /// Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_a9u25tp-Ed-ak6NoX_4Aeg_-329415245")]
    [Description(
        @"Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker."
    )]
    Discount,

    /// <summary>
    /// Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management.
    /// Encoded/decoded by serializers as &quot;MANF&quot;.
    /// </summary>
    [EnumMember(Value = "MANF")]
    [IsoId("_a9u259p-Ed-ak6NoX_4Aeg_729082922")]
    [Description(
        @"Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management."
    )]
    ManagementFee,

    /// <summary>
    /// In investment funds, a fee charged for the transfer of ownership of an investment fund.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_a94A0Np-Ed-ak6NoX_4Aeg_729082931")]
    [Description(
        @"In investment funds, a fee charged for the transfer of ownership of an investment fund."
    )]
    TransferFee,

    /// <summary>
    /// Fee charged for matching and/or confirmation.
    /// Encoded/decoded by serializers as &quot;MACO&quot;.
    /// </summary>
    [EnumMember(Value = "MACO")]
    [IsoId("_a94A0dp-Ed-ak6NoX_4Aeg_21503873")]
    [Description(@"Fee charged for matching and/or confirmation.")]
    MatchingFees,

    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_a94A0tp-Ed-ak6NoX_4Aeg_21504150")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge,

    /// <summary>
    /// Fee charged by a regulatory authority, eg, Securities and Exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_a94A09p-Ed-ak6NoX_4Aeg_21504185")]
    [Description(@"Fee charged by a regulatory authority, eg, Securities and Exchange fees.")]
    RegulatoryFee,

    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_a94A1Np-Ed-ak6NoX_4Aeg_21504245")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge,

    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a94A1dp-Ed-ak6NoX_4Aeg_21504553")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee,

    /// <summary>
    /// Charges, drawdown, or other reduction from or in addition to the deal price.
    /// Encoded/decoded by serializers as &quot;SPCN&quot;.
    /// </summary>
    [EnumMember(Value = "SPCN")]
    [IsoId("_a94A1tp-Ed-ak6NoX_4Aeg_21504606")]
    [Description(@"Charges, drawdown, or other reduction from or in addition to the deal price.")]
    SpecialConcessions,

    /// <summary>
    /// Portion of charge that the fund is entitled to receive, that cannot be reduced by an intermediary.
    /// Encoded/decoded by serializers as &quot;PACQ&quot;.
    /// </summary>
    [EnumMember(Value = "PACQ")]
    [IsoId("_a94A19p-Ed-ak6NoX_4Aeg_-1068334940")]
    [Description(
        @"Portion of charge that the fund is entitled to receive, that cannot be reduced by an intermediary."
    )]
    PartAcquis,

    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_a94A2Np-Ed-ak6NoX_4Aeg_-2055235441")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty,

    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as &quot;CDSC&quot;.
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("_a94A2dp-Ed-ak6NoX_4Aeg_-2055235424")]
    [Description(@"Deferred sales charge.")]
    ContingencyDeferredSalesCharge,

    /// <summary>
    /// Another type of charge.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a-Bx0Np-Ed-ak6NoX_4Aeg_-1628569358")]
    [Description(@"Another type of charge.")]
    Other,

    /// <summary>
    /// The part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_a-Bx0dp-Ed-ak6NoX_4Aeg_-575593958")]
    [Description(
        @"The part of an investor's subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year."
    )]
    Equalisation,

    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as &quot;CBCH&quot;.
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_a-Bx0tp-Ed-ak6NoX_4Aeg_-609044555")]
    [Description(
        @"In investment funds, the charge of the correspondent bank for transferring money."
    )]
    CorrespondentBankCharge,

    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_a-Bx09p-Ed-ak6NoX_4Aeg_1033900373")]
    [Description(
        @"In investment funds, pre-arranged addition to the trade amount based on the published net asset value."
    )]
    Premium,

    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_a-Bx1Np-Ed-ak6NoX_4Aeg_-1896103317")]
    [Description(@"Charge paid at the time of the first subscription.")]
    Initial,

    /// <summary>
    /// Fee paid for advisory services rendered.
    /// Encoded/decoded by serializers as &quot;ADVI&quot;.
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_a-Bx1dp-Ed-ak6NoX_4Aeg_1192404257")]
    [Description(@"Fee paid for advisory services rendered.")]
    AdvisoryFee,

    /// <summary>
    /// Fee paid to a custodian in respect of custodial services.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_a-Bx1tp-Ed-ak6NoX_4Aeg_1192404317")]
    [Description(@"Fee paid to a custodian in respect of custodial services.")]
    CustodyFee,

    /// <summary>
    /// Fee paid in respect of publications made.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_a-Bx19p-Ed-ak6NoX_4Aeg_1192404342")]
    [Description(@"Fee paid in respect of publications made.")]
    PublicationFee,

    /// <summary>
    /// Fee paid for accounting services rendered.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_a-Bx2Np-Ed-ak6NoX_4Aeg_1192404594")]
    [Description(@"Fee paid for accounting services rendered.")]
    AccountingFee,

    /// <summary>
    /// Charge is for signature services.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_a-Bx2dp-Ed-ak6NoX_4Aeg_1274994337")]
    [Description(@"Charge is for signature services.")]
    SignatureService,

    /// <summary>
    /// Charge is for storage of goods at destination.
    /// Encoded/decoded by serializers as &quot;STDE&quot;.
    /// </summary>
    [EnumMember(Value = "STDE")]
    [IsoId("_a-Li0Np-Ed-ak6NoX_4Aeg_1274995439")]
    [Description(@"Charge is for storage of goods at destination.")]
    StorageAtDestination,

    /// <summary>
    /// Charge is for storage of goods at origin.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_a-Li0dp-Ed-ak6NoX_4Aeg_1274995734")]
    [Description(@"Charge is for storage of goods at origin.")]
    StorageAtOrigin,

    /// <summary>
    /// Charge is for packaging of goods.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_a-Li0tp-Ed-ak6NoX_4Aeg_1274995829")]
    [Description(@"Charge is for packaging of goods.")]
    Packaging,

    /// <summary>
    /// Charge is for pick-up of goods.
    /// Encoded/decoded by serializers as &quot;PICK&quot;.
    /// </summary>
    [EnumMember(Value = "PICK")]
    [IsoId("_a-Li09p-Ed-ak6NoX_4Aeg_1274996154")]
    [Description(@"Charge is for pick-up of goods.")]
    PickUp,

    /// <summary>
    /// Charge is for dangerous goods.
    /// Encoded/decoded by serializers as &quot;DNGR&quot;.
    /// </summary>
    [EnumMember(Value = "DNGR")]
    [IsoId("_a-Li1Np-Ed-ak6NoX_4Aeg_1274996327")]
    [Description(@"Charge is for dangerous goods.")]
    DangerousGoodsFee,

    /// <summary>
    /// Charge is for security.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_a-Li1dp-Ed-ak6NoX_4Aeg_1274996412")]
    [Description(@"Charge is for security.")]
    SecurityCharge,

    /// <summary>
    /// Charge is a premium for insurance.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_a-Li1tp-Ed-ak6NoX_4Aeg_1274996760")]
    [Description(@"Charge is a premium for insurance.")]
    InsurancePremium,

    /// <summary>
    /// Charge is for the collection of the freight.
    /// Encoded/decoded by serializers as &quot;COLF&quot;.
    /// </summary>
    [EnumMember(Value = "COLF")]
    [IsoId("_a-Li19p-Ed-ak6NoX_4Aeg_1274997093")]
    [Description(@"Charge is for the collection of the freight.")]
    CollectFreight,

    /// <summary>
    /// Charge is for clearance and handling of goods at origin.
    /// Encoded/decoded by serializers as &quot;CHOR&quot;.
    /// </summary>
    [EnumMember(Value = "CHOR")]
    [IsoId("_a-Li2Np-Ed-ak6NoX_4Aeg_1274997163")]
    [Description(@"Charge is for clearance and handling of goods at origin.")]
    ClearanceAndHandlingAtOrigin,

    /// <summary>
    /// Charge is for clearance and handling of goods at destination.
    /// Encoded/decoded by serializers as &quot;CHDE&quot;.
    /// </summary>
    [EnumMember(Value = "CHDE")]
    [IsoId("_a-Li2dp-Ed-ak6NoX_4Aeg_1274997265")]
    [Description(@"Charge is for clearance and handling of goods at destination.")]
    ClearanceAndHandlingAtDestination,

    /// <summary>
    /// Charge is an airway bill fee.
    /// Encoded/decoded by serializers as &quot;AIRF&quot;.
    /// </summary>
    [EnumMember(Value = "AIRF")]
    [IsoId("_a-Li2tp-Ed-ak6NoX_4Aeg_1274997620")]
    [Description(@"Charge is an airway bill fee.")]
    AirWayBillFee,

    /// <summary>
    /// Charge is for transport.
    /// Encoded/decoded by serializers as &quot;TRPT&quot;.
    /// </summary>
    [EnumMember(Value = "TRPT")]
    [IsoId("_a-UswNp-Ed-ak6NoX_4Aeg_1274997690")]
    [Description(@"Charge is for transport.")]
    TransportCharges,

    /// <summary>
    /// Charges paid by the investor to the Fund Company for subscription and redemption orders.
    /// Encoded/decoded by serializers as &quot;UCIC&quot;.
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_a-Uswdp-Ed-ak6NoX_4Aeg_-1007099196")]
    [Description(
        @"Charges paid by the investor to the Fund Company for subscription and redemption orders."
    )]
    UCITSCommission,

    /// <summary>
    /// Specially agreed front-end load.
    /// Encoded/decoded by serializers as &quot;SFEN&quot;.
    /// </summary>
    [EnumMember(Value = "SFEN")]
    [IsoId("_a-Uswtp-Ed-ak6NoX_4Aeg_-373701440")]
    [Description(@"Specially agreed front-end load.")]
    SpeciallyAgreedFrontEndLoad,

    /// <summary>
    /// Charge linked to an ADR (American Depositary Receipt).
    /// Encoded/decoded by serializers as &quot;ADRF&quot;.
    /// </summary>
    [EnumMember(Value = "ADRF")]
    [IsoId("_a-Usw9p-Ed-ak6NoX_4Aeg_-555458219")]
    [Description(@"Charge linked to an ADR (American Depositary Receipt).")]
    ADRFee,

    /// <summary>
    /// Fee linked to the cancellation of an issuance.
    /// Encoded/decoded by serializers as &quot;ISSC&quot;.
    /// </summary>
    [EnumMember(Value = "ISSC")]
    [IsoId("_a-UsxNp-Ed-ak6NoX_4Aeg_-555458188")]
    [Description(@"Fee linked to the cancellation of an issuance.")]
    IssuanceCancellationFee,

    /// <summary>
    /// Miscellaneous fee.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_a-Usxdp-Ed-ak6NoX_4Aeg_-555458157")]
    [Description(@"Miscellaneous fee.")]
    MiscellaneousFee,

    /// <summary>
    /// Charge linked to the issuance of security.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_a-Usxtp-Ed-ak6NoX_4Aeg_-555458127")]
    [Description(@"Charge linked to the issuance of security.")]
    IssuanceFee,
}
