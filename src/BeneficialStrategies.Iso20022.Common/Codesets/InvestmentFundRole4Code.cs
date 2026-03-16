// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role played by an actor in an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_acfyEdp-Ed-ak6NoX_4Aeg_2104979731")]
[Description(@"Specifies the role played by an actor in an investment fund transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole4Code
{
    /// <summary>
    /// Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.
    /// Encoded/decoded by serializers as &quot;FMCO&quot;.
    /// </summary>
    [EnumMember(Value = "FMCO")]
    [IsoId("_acfyEtp-Ed-ak6NoX_4Aeg_-1943406499")]
    [Description(
        @"Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund."
    )]
    FundManagementCompany = PartyRoleCode.FundManagementCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_acfyE9p-Ed-ak6NoX_4Aeg_-1943406468")]
    [Description(
        @"Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company."
    )]
    Registrar = PartyRoleCode.Registrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_acfyFNp-Ed-ak6NoX_4Aeg_-1943406437")]
    [Description(
        @"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution."
    )]
    TransferAgent = PartyRoleCode.TransferAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_acfyFdp-Ed-ak6NoX_4Aeg_-1943406436")]
    [Description(
        @"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor."
    )]
    Intermediary = PartyRoleCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_acfyFtp-Ed-ak6NoX_4Aeg_-1943406407")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor = PartyRoleCode.Distributor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that acts as an aggregator of funds, also called a funds hub.
    /// Encoded/decoded by serializers as &quot;CONC&quot;.
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_acfyF9p-Ed-ak6NoX_4Aeg_-1942486405")]
    [Description(@"Party that acts as an aggregator of funds, also called a funds hub.")]
    Concentrator = PartyRoleCode.Concentrator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying client of the intermediary.
    /// Encoded/decoded by serializers as &quot;UCL1&quot;.
    /// </summary>
    [EnumMember(Value = "UCL1")]
    [IsoId("_acfyGNp-Ed-ak6NoX_4Aeg_-1942486375")]
    [Description(@"Underlying client of the intermediary.")]
    UnderlyingClient1 = PartyRoleCode.UnderlyingClient1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying client of underlying client 1.
    /// Encoded/decoded by serializers as &quot;UCL2&quot;.
    /// </summary>
    [EnumMember(Value = "UCL2")]
    [IsoId("_acfyGdp-Ed-ak6NoX_4Aeg_-1942486344")]
    [Description(@"Underlying client of underlying client 1.")]
    UnderlyingClient2 = PartyRoleCode.UnderlyingClient2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that transmits the instruction, advice, notification or report.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_acpjENp-Ed-ak6NoX_4Aeg_-1942486290")]
    [Description(@"Party that transmits the instruction, advice, notification or report.")]
    TransmittingAgent = PartyRoleCode.TransmittingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as the contact person at the instructing party institution.
    /// Encoded/decoded by serializers as &quot;CONI&quot;.
    /// </summary>
    [EnumMember(Value = "CONI")]
    [IsoId("_acpjEdp-Ed-ak6NoX_4Aeg_-1685745025")]
    [Description(@"Party acting as the contact person at the instructing party institution.")]
    ContactPersonAtInstructingPartyInstitution =
        PartyRoleCode.ContactPersonAtInstructingPartyInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as the contact person at the executing party institution.
    /// Encoded/decoded by serializers as &quot;CONE&quot;.
    /// </summary>
    [EnumMember(Value = "CONE")]
    [IsoId("_acpjEtp-Ed-ak6NoX_4Aeg_-1634030236")]
    [Description(@"Party acting as the contact person at the executing party institution.")]
    ContactPersonAtExecutingPartyInstitution =
        PartyRoleCode.ContactPersonAtExecutingPartyInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Name of Agent to the order, if different from the instructing party.
    /// Encoded/decoded by serializers as &quot;CONA&quot;.
    /// </summary>
    [EnumMember(Value = "CONA")]
    [IsoId("_acpjE9p-Ed-ak6NoX_4Aeg_-1588776728")]
    [Description(@"Name of Agent to the order, if different from the instructing party.")]
    NameOfAgentToOrder = PartyRoleCode.NameOfAgentToOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_acpjFNp-Ed-ak6NoX_4Aeg_-1837683040")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian = PartyRoleCode.Custodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as an intermediary agent between an investor and a transfer agent for the subscription or redemption to a fund.
    /// Encoded/decoded by serializers as &quot;FNBR&quot;.
    /// </summary>
    [EnumMember(Value = "FNBR")]
    [IsoId("_acpjFdp-Ed-ak6NoX_4Aeg_-191046399")]
    [Description(
        @"Party acting as an intermediary agent between an investor and a transfer agent for the subscription or redemption to a fund."
    )]
    FundBroker = PartyRoleCode.FundBroker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as settlement agent, provides custody for assets, provides financing for leverage, and prepares daily account statements for its clients, who are money managers, hedge funds, market makers, arbitrageurs, specialists and other professional investors.
    /// Encoded/decoded by serializers as &quot;PRBR&quot;.
    /// </summary>
    [EnumMember(Value = "PRBR")]
    [IsoId("_acpjFtp-Ed-ak6NoX_4Aeg_-1321106680")]
    [Description(
        @"Party acting as settlement agent, provides custody for assets, provides financing for leverage, and prepares daily account statements for its clients, who are money managers, hedge funds, market makers, arbitrageurs, specialists and other professional investors."
    )]
    PrimeBroker = PartyRoleCode.PrimeBroker, // same ordinal as derivation source for type conversions
}
