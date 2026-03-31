// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a fee e is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YL5_oDiCEeaH-93K5JKmzw")]
[Description(@"Specifies the type of service for which a fee e is asked or paid.")]
[DerivedFrom(typeof(InvestmentFundFeeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestmentFundFee1Code>))]
#endif
public enum InvestmentFundFee1Code
{
    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when redeeming.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_cAfrkTiCEeaH-93K5JKmzw")]
    [Description(
        @"Fee paid by the investor to the fund or fund management company when redeeming."
    )]
    BackEndLoad = InvestmentFundFeeCode.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_cKKk8TiCEeaH-93K5JKmzw")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee = InvestmentFundFeeCode.BrokerageFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount paid out by the fund to a third party.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_cT1eUTiCEeaH-93K5JKmzw")]
    [Description(@"Amount paid out by the fund to a third party.")]
    Commission = InvestmentFundFeeCode.Commission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as &quot;CDPL&quot;.
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_cdqIsTiCEeaH-93K5JKmzw")]
    [Description(
        @"Amount of cash due to an intermediary for selling a product, or services, to a third party."
    )]
    CommissionDePlacement = InvestmentFundFeeCode.CommissionDePlacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as &quot;CDSC&quot;.
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("_cnL4ITiCEeaH-93K5JKmzw")]
    [Description(@"Deferred sales charge.")]
    ContingentDeferredSalesCharge = InvestmentFundFeeCode.ContingentDeferredSalesCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as &quot;CBCH&quot;.
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_cxmYYTiCEeaH-93K5JKmzw")]
    [Description(
        @"In investment funds, the charge of the correspondent bank for transferring money."
    )]
    CorrespondentBankCharge = InvestmentFundFeeCode.CorrespondentBankCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.
    /// Encoded/decoded by serializers as &quot;DLEV&quot;.
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("_dFFVETiCEeaH-93K5JKmzw")]
    [Description(
        @"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders."
    )]
    DilutionLevy = InvestmentFundFeeCode.DilutionLevy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when subscribing.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_dkB64TiCEeaH-93K5JKmzw")]
    [Description(
        @"Fee paid by the investor to the fund or fund management company when subscribing."
    )]
    FrontEndLoad = InvestmentFundFeeCode.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_dx3ikTiCEeaH-93K5JKmzw")]
    [Description(@"Charge paid at the time of the first subscription.")]
    InitialCharge = InvestmentFundFeeCode.InitialCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional fee not covered by another fee type.
    /// Encoded/decoded by serializers as &quot;ADDF&quot;.
    /// </summary>
    [EnumMember(Value = "ADDF")]
    [IsoId("_d-N8gTiCEeaH-93K5JKmzw")]
    [Description(@"Additional fee not covered by another fee type.")]
    AdditionalFee = InvestmentFundFeeCode.AdditionalFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_eLBCYTiCEeaH-93K5JKmzw")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = InvestmentFundFeeCode.PostageCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_eU1FsTiCEeaH-93K5JKmzw")]
    [Description(
        @"In investment funds, pre-arranged addition to the trade amount based on the published net asset value."
    )]
    Premium = InvestmentFundFeeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_eezhETiCEeaH-93K5JKmzw")]
    [Description(
        @"Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services."
    )]
    ServiceProvisionFee = InvestmentFundFeeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_eoeacTiCEeaH-93K5JKmzw")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = InvestmentFundFeeCode.ShippingCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_ex_i0TiCEeaH-93K5JKmzw")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch = InvestmentFundFeeCode.Switch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges paid by the investor to the fund company for subscription and redemption orders.
    /// Encoded/decoded by serializers as &quot;UCIC&quot;.
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_fU9F8TiCEeaH-93K5JKmzw")]
    [Description(
        @"Charges paid by the investor to the fund company for subscription and redemption orders."
    )]
    UCITSCommission = InvestmentFundFeeCode.UCITSCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged by a regulatory authority, for example, securities and exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_EtSw8TkpEeapUO0vUIo9Xw")]
    [Description(
        @"Fee charged by a regulatory authority, for example, securities and exchange fees."
    )]
    RegulatoryFee = InvestmentFundFeeCode.RegulatoryFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_Z5oZoa2aEea0Qtj9EW8okQ")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty = InvestmentFundFeeCode.Penalty, // same ordinal as derivation source for type conversions
}
