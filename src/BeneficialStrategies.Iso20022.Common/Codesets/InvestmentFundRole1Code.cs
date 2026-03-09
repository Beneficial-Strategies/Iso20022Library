// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role played by the actors in the investment funds industry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vi-eZtp-Ed-ak6NoX_4Aeg_1660914600")]
[Description(@"Specifies the role played by the actors in the investment funds industry.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole1Code
{
    /// <summary>
    /// Financial institution that executes cash transfers on behalf of its clients.
    /// Encoded/decoded by serializers as &quot;CACO&quot;.
    /// </summary>
    [EnumMember(Value = "CACO")]
    [IsoId("_Vi-eZ9p-Ed-ak6NoX_4Aeg_325528926")]
    [Description(@"Financial institution that executes cash transfers on behalf of its clients.")]
    CashCorrespondent = PartyRoleCode.CashCorrespondent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Vi-eaNp-Ed-ak6NoX_4Aeg_477910264")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian = PartyRoleCode.Custodian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines.
    /// Encoded/decoded by serializers as &quot;DATP&quot;.
    /// </summary>
    [EnumMember(Value = "DATP")]
    [IsoId("_Vi-eadp-Ed-ak6NoX_4Aeg_436349307")]
    [Description(@"Source of financial information. Provides financial news and data (for example, facts, statistics and analysis), for professional and individual investors through various media, for example, the Internet, magazines.")]
    DataProvider = PartyRoleCode.DataProvider, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// Encoded/decoded by serializers as &quot;FIAG&quot;.
    /// </summary>
    [EnumMember(Value = "FIAG")]
    [IsoId("_VjIPYNp-Ed-ak6NoX_4Aeg_-1199469611")]
    [Description(@"Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.")]
    FinalAgent = PartyRoleCode.FinalAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.
    /// Encoded/decoded by serializers as &quot;FMCO&quot;.
    /// </summary>
    [EnumMember(Value = "FMCO")]
    [IsoId("_VjIPYdp-Ed-ak6NoX_4Aeg_508386038")]
    [Description(@"Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.")]
    FundManagementCompany = PartyRoleCode.FundManagementCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.
    /// Encoded/decoded by serializers as &quot;FACT&quot;.
    /// </summary>
    [EnumMember(Value = "FACT")]
    [IsoId("_VjIPYtp-Ed-ak6NoX_4Aeg_778054036")]
    [Description(@"Party that keeps accounting records of the available assets and liabilities of the fund. This party calculates deal prices, the Net Asset Value (NAV) of the fund, and may provide fund performance and tax data.")]
    FundAccountant = PartyRoleCode.FundAccountant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_VjIPY9p-Ed-ak6NoX_4Aeg_-1128358093")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor = PartyRoleCode.Investor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund&apos;s prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_VjIPZNp-Ed-ak6NoX_4Aeg_1757620779")]
    [Description(@"Party that implements the investment strategy, that is, selects portfolio investments in accordance with the objectives and strategy in the fund's prospectus, and places orders to effect or liquidate selected investments in accordance with net flow of capital into or out of the fund.")]
    InvestmentManager = PartyRoleCode.InvestmentManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.
    /// Encoded/decoded by serializers as &quot;PAYI&quot;.
    /// </summary>
    [EnumMember(Value = "PAYI")]
    [IsoId("_VjIPZdp-Ed-ak6NoX_4Aeg_379093110")]
    [Description(@"Agent that executes the payment. In the context of the investment fund industry, the paying agent is the local legal representative of the fund. It may pay out dividends, and collects money for the purchase of funds when a client deals directly with the fund and/or when a client deals with bearer shares. It pays out the redemption of the fund, may distribute information about the fund, and provides legal information about the fund.")]
    PayingAgent = PartyRoleCode.PayingAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_VjIPZtp-Ed-ak6NoX_4Aeg_1801946302")]
    [Description(@"Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.")]
    Registrar = PartyRoleCode.Registrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_VjIPZ9p-Ed-ak6NoX_4Aeg_833466392")]
    [Description(@"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransferAgent = PartyRoleCode.TransferAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_VjIPaNp-Ed-ak6NoX_4Aeg_-1699296722")]
    [Description(@"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.")]
    Intermediary = PartyRoleCode.Intermediary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// Encoded/decoded by serializers as &quot;FTAG&quot;.
    /// </summary>
    [EnumMember(Value = "FTAG")]
    [IsoId("_VjIPadp-Ed-ak6NoX_4Aeg_486082931")]
    [Description(@"Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.")]
    FirstAgent = PartyRoleCode.FirstAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_VjIPatp-Ed-ak6NoX_4Aeg_-285619")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor = PartyRoleCode.Distributor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that acts as an aggregator of funds, also called a funds hub.
    /// Encoded/decoded by serializers as &quot;CONC&quot;.
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_VjSAYNp-Ed-ak6NoX_4Aeg_5257662")]
    [Description(@"Party that acts as an aggregator of funds, also called a funds hub.")]
    Concentrator = PartyRoleCode.Concentrator, // same ordinal as derivation source for type conversions
    
}
