// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a fee is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GX-V4DiAEeaH-93K5JKmzw")]
[Description(@"Specifies the type of service for which a fee is asked or paid.")]
[Derivations(typeof(InvestmentFundFee1Code), typeof(InvestmentFundFee2Code))]
public enum InvestmentFundFeeCode
{
    /// <summary>
    /// Fee paid for accounting services rendered.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_SutpUziAEeaH-93K5JKmzw")]
    [Description(@"Fee paid for accounting services rendered.")]
    AccountingFee,

    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when redeeming.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_SutpVziAEeaH-93K5JKmzw")]
    [Description(
        @"Fee paid by the investor to the fund or fund management company when redeeming."
    )]
    BackEndLoad,

    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_SutpWDiAEeaH-93K5JKmzw")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee,

    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as &quot;CDSC&quot;.
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("_SutpXTiAEeaH-93K5JKmzw")]
    [Description(@"Deferred sales charge.")]
    ContingentDeferredSalesCharge,

    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as &quot;CBCH&quot;.
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_SutpXjiAEeaH-93K5JKmzw")]
    [Description(
        @"In investment funds, the charge of the correspondent bank for transferring money."
    )]
    CorrespondentBankCharge,

    /// <summary>
    /// Fee paid to a custodian in respect of custodial services.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_SutpXziAEeaH-93K5JKmzw")]
    [Description(@"Fee paid to a custodian in respect of custodial services.")]
    CustodyFee,

    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.
    /// Encoded/decoded by serializers as &quot;DLEV&quot;.
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("_SutpYTiAEeaH-93K5JKmzw")]
    [Description(
        @"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders."
    )]
    DilutionLevy,

    /// <summary>
    /// Charge that has been reduced by a fund.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_SutpYjiAEeaH-93K5JKmzw")]
    [Description(@"Charge that has been reduced by a fund.")]
    Discount,

    /// <summary>
    /// The part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_SutpYziAEeaH-93K5JKmzw")]
    [Description(
        @"The part of an investor's subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year."
    )]
    Equalisation,

    /// <summary>
    /// Fee paid by the investor to the fund or fund management company when subscribing.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_SutpZDiAEeaH-93K5JKmzw")]
    [Description(
        @"Fee paid by the investor to the fund or fund management company when subscribing."
    )]
    FrontEndLoad,

    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_SutpZTiAEeaH-93K5JKmzw")]
    [Description(@"Charge paid at the time of the first subscription.")]
    InitialCharge,

    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_SutpeziAEeaH-93K5JKmzw")]
    [Description(
        @"In investment funds, pre-arranged addition to the trade amount based on the published net asset value."
    )]
    Premium,

    /// <summary>
    /// Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_SutpgjiAEeaH-93K5JKmzw")]
    [Description(
        @"Fee paid by the investor to a distributor/intermediary or other service provider for the provision of financial services."
    )]
    ServiceProvisionFee,

    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_Su3aFDiAEeaH-93K5JKmzw")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch,

    /// <summary>
    /// In investment funds, a fee charged for the transfer of ownership of an investment fund.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_Su3aFTiAEeaH-93K5JKmzw")]
    [Description(
        @"In investment funds, a fee charged for the transfer of ownership of an investment fund."
    )]
    TransferFee,

    /// <summary>
    /// Charges paid by the investor to the fund company for subscription and redemption orders.
    /// Encoded/decoded by serializers as &quot;UCIC&quot;.
    /// </summary>
    [EnumMember(Value = "UCIC")]
    [IsoId("_Su3aFziAEeaH-93K5JKmzw")]
    [Description(
        @"Charges paid by the investor to the fund company for subscription and redemption orders."
    )]
    UCITSCommission,

    /// <summary>
    /// Amount paid out by the fund to a third party.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_rJJXoTiAEeaH-93K5JKmzw")]
    [Description(@"Amount paid out by the fund to a third party.")]
    Commission,

    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_hFpc9DiBEeaH-93K5JKmzw")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge,

    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_kMSdxDiBEeaH-93K5JKmzw")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge,

    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as &quot;CDPL&quot;.
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_sOW2wTiBEeaH-93K5JKmzw")]
    [Description(
        @"Amount of cash due to an intermediary for selling a product, or services, to a third party."
    )]
    CommissionDePlacement,

    /// <summary>
    /// Additional fee not covered by another fee type.
    /// Encoded/decoded by serializers as &quot;ADDF&quot;.
    /// </summary>
    [EnumMember(Value = "ADDF")]
    [IsoId("_De2hwDiCEeaH-93K5JKmzw")]
    [Description(@"Additional fee not covered by another fee type.")]
    AdditionalFee,

    /// <summary>
    /// Fee charged by a regulatory authority, for example, securities and exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_8FyIlDkoEeapUO0vUIo9Xw")]
    [Description(
        @"Fee charged by a regulatory authority, for example, securities and exchange fees."
    )]
    RegulatoryFee,

    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_VnICoa2aEea0Qtj9EW8okQ")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty,

    /// <summary>
    /// Fees, drawdown, or other reduction from or in addition to the deal price.
    /// Encoded/decoded by serializers as &quot;SPCN&quot;.
    /// </summary>
    [EnumMember(Value = "SPCN")]
    [IsoId("_nL7QlK27EeerDLLe8bZJCA")]
    [Description(@"Fees, drawdown, or other reduction from or in addition to the deal price.")]
    SpecialConcessions,
}
