// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies charges linked to the type of service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a81fBdp-Ed-ak6NoX_4Aeg_724898334")]
[Description(@"Identifies charges linked to the type of service.")]
[DerivedFrom(typeof(ChargeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChargeType13Code>))]
#endif
public enum ChargeType13Code
{
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a81fBtp-Ed-ak6NoX_4Aeg_1141407780")]
    [Description(
        @"Sales charge paid by the investor when redeeming an investment such as an investment fund."
    )]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a81fB9p-Ed-ak6NoX_4Aeg_1141407788")]
    [Description(
        @"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund."
    )]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_a81fCNp-Ed-ak6NoX_4Aeg_1141407811")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch = ChargeTypeCode.Switch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.
    /// Encoded/decoded by serializers as &quot;DLEV&quot;.
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("_a8_QANp-Ed-ak6NoX_4Aeg_1141407841")]
    [Description(
        @"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders."
    )]
    DilutionLevy = ChargeTypeCode.DilutionLevy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_a8_QAdp-Ed-ak6NoX_4Aeg_1141407872")]
    [Description(
        @"Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker."
    )]
    Discount = ChargeTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_a8_QAtp-Ed-ak6NoX_4Aeg_1141407873")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty = ChargeTypeCode.Penalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_a8_QA9p-Ed-ak6NoX_4Aeg_1141407903")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = ChargeTypeCode.PostageCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged by a regulatory authority, eg, Securities and Exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_a8_QBNp-Ed-ak6NoX_4Aeg_1141407933")]
    [Description(@"Fee charged by a regulatory authority, eg, Securities and Exchange fees.")]
    RegulatoryFee = ChargeTypeCode.RegulatoryFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_a8_QBdp-Ed-ak6NoX_4Aeg_1141408212")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = ChargeTypeCode.ShippingCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a8_QBtp-Ed-ak6NoX_4Aeg_1141408242")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee = ChargeTypeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as &quot;CDSC&quot;.
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("_a8_QB9p-Ed-ak6NoX_4Aeg_1141408273")]
    [Description(@"Deferred sales charge.")]
    ContingencyDeferredSalesCharge = ChargeTypeCode.ContingencyDeferredSalesCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as &quot;CBCH&quot;.
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_a8_QCNp-Ed-ak6NoX_4Aeg_1141408304")]
    [Description(
        @"In investment funds, the charge of the correspondent bank for transferring money."
    )]
    CorrespondentBankCharge = ChargeTypeCode.CorrespondentBankCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_a8_QCdp-Ed-ak6NoX_4Aeg_1141408334")]
    [Description(
        @"In investment funds, pre-arranged addition to the trade amount based on the published net asset value."
    )]
    Premium = ChargeTypeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_a8_QCtp-Ed-ak6NoX_4Aeg_1141408365")]
    [Description(@"Charge paid at the time of the first subscription.")]
    Initial = ChargeTypeCode.Initial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_a9IZ8Np-Ed-ak6NoX_4Aeg_1141408366")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee = ChargeTypeCode.BrokerageFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges paid by the investor to the Fund Company for subscription and redemption orders.
    /// Encoded/decoded by serializers as &quot;UCIC&quot;.
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_a9IZ8dp-Ed-ak6NoX_4Aeg_1141408396")]
    [Description(
        @"Charges paid by the investor to the Fund Company for subscription and redemption orders."
    )]
    UCITSCommission = ChargeTypeCode.UCITSCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specially agreed front-end load.
    /// Encoded/decoded by serializers as &quot;SFEN&quot;.
    /// </summary>
    [EnumMember(Value = "SFEN")]
    [IsoId("_a9IZ8tp-Ed-ak6NoX_4Aeg_1182043721")]
    [Description(@"Specially agreed front-end load.")]
    SpeciallyAgreedFrontEndLoad = ChargeTypeCode.SpeciallyAgreedFrontEndLoad, // same ordinal as derivation source for type conversions
}
