// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a fee is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("98d73747-a658-4807-96a7-26dc66736303")]
[Description(@"Specifies the type of service for which a fee e is asked or paid.")]
[DerivedFrom(typeof(InvestmentFundFeeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InvestmentFundFee3Code>))]
public enum InvestmentFundFee3Code
{
    /// <summary>
    /// Additional fee not covered by another fee type.
    /// Encoded/decoded by serializers as &quot;ADDF&quot;.
    /// </summary>
    [EnumMember(Value = "ADDF")]
    [IsoId("468ea6e1-9b21-407f-a408-fd42c1fa7821")]
    [Description(@"Additional fee not covered by another fee type.")]
    AdditionalFee = InvestmentFundFeeCode.AdditionalFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when redeeming.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("25ecf329-688a-41a2-ac62-8494f8df15b5")]
    [Description(@"Fee paid by the investor to the fund or fund management company when redeeming.")]
    BackEndLoad = InvestmentFundFeeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("454cbda9-3065-40d8-ae65-e5fa9406c4f2")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee = InvestmentFundFeeCode.BrokerageFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as &quot;CBCH&quot;.
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("babe60e6-f8d9-4a9b-905b-c8a12635cbf4")]
    [Description(@"In investment funds, the charge of the correspondent bank for transferring money.")]
    CorrespondentBankCharge = InvestmentFundFeeCode.CorrespondentBankCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as &quot;CDPL&quot;.
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("503273ff-8451-491a-a8a0-8badd25d1516")]
    [Description(@"Amount of cash due to an intermediary for selling a product, or services, to a third party.")]
    CommissionDePlacement = InvestmentFundFeeCode.CommissionDePlacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as &quot;CDSC&quot;.
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("7f3cfd9e-3c4a-4fdd-9618-defa18c25cca")]
    [Description(@"Deferred sales charge.")]
    ContingentDeferredSalesCharge = InvestmentFundFeeCode.ContingentDeferredSalesCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("3bf7e5d7-dd0e-4139-add8-9fe0d927a6a9")]
    [Description(@"Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services.")]
    ServiceProvisionFee = InvestmentFundFeeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount paid out by the fund to a third party.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("64a81e8a-d318-4a4a-b575-afd90aae83ee")]
    [Description(@"Amount paid out by the fund to a third party.")]
    Commission = InvestmentFundFeeCode.Commission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments.
    /// Encoded/decoded by serializers as &quot;DLEV&quot;.
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("447b1f8e-c9e7-4f28-b44f-e90c3c8fd40c")]
    [Description(@"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.")]
    DilutionLevy = InvestmentFundFeeCode.DilutionLevy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when subscribing.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("41cb7b27-eb4d-45c3-bcb0-1eab16199a16")]
    [Description(@"Fee paid by the investor to the fund or fund management company when subscribing.")]
    FrontEndLoad = InvestmentFundFeeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("32b58043-866f-4445-af66-7173b6ec3437")]
    [Description(@"Charge paid at the time of the first subscription.")]
    InitialCharge = InvestmentFundFeeCode.InitialCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Network fee assigned to a transaction on a DLT network.
    /// Encoded/decoded by serializers as &quot;NTWK&quot;.
    /// </summary>
    [EnumMember(Value = "NTWK")]
    [IsoId("5e813292-611a-477a-ae08-d681737d1834")]
    [Description(@"Network fee assigned to a transaction on a DLT network.")]
    NetworkFee = InvestmentFundFeeCode.NetworkFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("df57fd19-4a75-46d5-9c4c-b32711961275")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty = InvestmentFundFeeCode.Penalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("3e8bc21e-704a-4423-ab10-2e545b22c674")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = InvestmentFundFeeCode.PostageCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("7107d47e-cbef-449f-b783-1e74966f2c03")]
    [Description(@"In investment funds, pre-arranged addition to the trade amount based on the published net asset value.")]
    Premium = InvestmentFundFeeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged by a regulatory authority, for example, securities and exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("46b8b4b7-8fc3-4103-a16c-8a6218a9a963")]
    [Description(@"Fee charged by a regulatory authority, for example, securities and exchange fees.")]
    RegulatoryFee = InvestmentFundFeeCode.RegulatoryFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("17d74ca2-9ad6-47de-bfe9-9dc3014fd076")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = InvestmentFundFeeCode.ShippingCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("d427c231-a9a1-4989-8b17-29adc930a454")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch = InvestmentFundFeeCode.Switch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges paid by the investor to the fund company for subscription and redemption orders.
    /// Encoded/decoded by serializers as &quot;UCIC&quot;.
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("0e8c737a-41e4-4be7-8fb0-5f64f12b83bb")]
    [Description(@"Charges paid by the investor to the fund company for subscription and redemption orders.")]
    UCITSCommission = InvestmentFundFeeCode.UCITSCommission, // same ordinal as derivation source for type conversions
}
