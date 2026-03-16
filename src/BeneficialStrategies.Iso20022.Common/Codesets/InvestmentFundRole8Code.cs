// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nVhNgNyREeqKxsvOxFQHKA")]
[Description(@"Specifies the role of the party.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole8Code
{
    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_REphkdyTEeqzDbuoooxhdw")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian = PartyRoleCode.Custodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_RUab4dyTEeqzDbuoooxhdw")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor = PartyRoleCode.Distributor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.
    /// Encoded/decoded by serializers as &quot;FMCO&quot;.
    /// </summary>
    [EnumMember(Value = "FMCO")]
    [IsoId("_R02PcdyTEeqzDbuoooxhdw")]
    [Description(
        @"Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund."
    )]
    FundManagementCompany = PartyRoleCode.FundManagementCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_R_G-sdyTEeqzDbuoooxhdw")]
    [Description(
        @"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor."
    )]
    Intermediary = PartyRoleCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund&apos;s prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_SIe9IdyTEeqzDbuoooxhdw")]
    [Description(
        @"Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund."
    )]
    InvestmentManager = PartyRoleCode.InvestmentManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_SSTngdyTEeqzDbuoooxhdw")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor = PartyRoleCode.Investor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_TMLOwdyTEeqzDbuoooxhdw")]
    [Description(
        @"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution."
    )]
    TransferAgent = PartyRoleCode.TransferAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that transmits the instruction, advice, notification or report.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_TZ3FcdyTEeqzDbuoooxhdw")]
    [Description(@"Party that transmits the instruction, advice, notification or report.")]
    TransmittingAgent = PartyRoleCode.TransmittingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying client of the intermediary.
    /// Encoded/decoded by serializers as &quot;UCL1&quot;.
    /// </summary>
    [EnumMember(Value = "UCL1")]
    [IsoId("_TfhBgdyTEeqzDbuoooxhdw")]
    [Description(@"Underlying client of the intermediary.")]
    UnderlyingClient1 = PartyRoleCode.UnderlyingClient1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying client of underlying client 1.
    /// Encoded/decoded by serializers as &quot;UCL2&quot;.
    /// </summary>
    [EnumMember(Value = "UCL2")]
    [IsoId("_TkbWsdyTEeqzDbuoooxhdw")]
    [Description(@"Underlying client of underlying client 1.")]
    UnderlyingClient2 = PartyRoleCode.UnderlyingClient2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_AQgqcdydEeqzDbuoooxhdw")]
    [Description(
        @"Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company."
    )]
    Registrar = PartyRoleCode.Registrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial institution that executes cash transfers on behalf of its clients.
    /// Encoded/decoded by serializers as &quot;CACO&quot;.
    /// </summary>
    [EnumMember(Value = "CACO")]
    [IsoId("_CoZu4dydEeqzDbuoooxhdw")]
    [Description(@"Financial institution that executes cash transfers on behalf of its clients.")]
    CashCorrespondent = PartyRoleCode.CashCorrespondent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that acts as an aggregator of funds, also called a funds hub.
    /// Encoded/decoded by serializers as &quot;CONC&quot;.
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_Ctm_AdydEeqzDbuoooxhdw")]
    [Description(@"Party that acts as an aggregator of funds, also called a funds hub.")]
    Concentrator = PartyRoleCode.Concentrator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines.
    /// Encoded/decoded by serializers as &quot;DATP&quot;.
    /// </summary>
    [EnumMember(Value = "DATP")]
    [IsoId("_ErUo4dydEeqzDbuoooxhdw")]
    [Description(
        @"Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines."
    )]
    DataProvider = PartyRoleCode.DataProvider, // same ordinal as derivation source for type conversions
}
