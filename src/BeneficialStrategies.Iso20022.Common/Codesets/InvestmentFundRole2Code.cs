// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role played by an actor in an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_acDtMNp-Ed-ak6NoX_4Aeg_1035600722")]
[Description(@"Specifies the role played by an actor in an investment fund transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole2Code
{
    /// <summary>
    /// Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.
    /// Encoded/decoded by serializers as &quot;FMCO&quot;.
    /// </summary>
    [EnumMember(Value = "FMCO")]
    [IsoId("_acDtMdp-Ed-ak6NoX_4Aeg_-1672757374")]
    [Description(@"Party that sets up a fund, decides upon the investment strategy, appoints agents, and is responsible for the promotion and the marketing of the fund. This party makes all the strategic decisions related to a fund.")]
    FundManagementCompany = PartyRoleCode.FundManagementCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_acDtMtp-Ed-ak6NoX_4Aeg_-1672756984")]
    [Description(@"Party responsible for keeping track of the owners of securities. In the investment fund business, this party keeps the investor registry of the fund, and administers investor accounts and related records. It is appointed by the fund management company.")]
    Registrar = PartyRoleCode.Registrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_acDtM9p-Ed-ak6NoX_4Aeg_-1672756949")]
    [Description(@"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransferAgent = PartyRoleCode.TransferAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_acDtNNp-Ed-ak6NoX_4Aeg_-1672756931")]
    [Description(@"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.")]
    Intermediary = PartyRoleCode.Intermediary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_acDtNdp-Ed-ak6NoX_4Aeg_-1672756906")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor = PartyRoleCode.Distributor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that acts as an aggregator of funds, also called a funds hub.
    /// Encoded/decoded by serializers as &quot;CONC&quot;.
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_acDtNtp-Ed-ak6NoX_4Aeg_-1672756846")]
    [Description(@"Party that acts as an aggregator of funds, also called a funds hub.")]
    Concentrator = PartyRoleCode.Concentrator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying client of the intermediary.
    /// Encoded/decoded by serializers as &quot;UCL1&quot;.
    /// </summary>
    [EnumMember(Value = "UCL1")]
    [IsoId("_acDtN9p-Ed-ak6NoX_4Aeg_-712294595")]
    [Description(@"Underlying client of the intermediary.")]
    UnderlyingClient1 = PartyRoleCode.UnderlyingClient1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying client of underlying client 1.
    /// Encoded/decoded by serializers as &quot;UCL2&quot;.
    /// </summary>
    [EnumMember(Value = "UCL2")]
    [IsoId("_acDtONp-Ed-ak6NoX_4Aeg_-712294458")]
    [Description(@"Underlying client of underlying client 1.")]
    UnderlyingClient2 = PartyRoleCode.UnderlyingClient2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that transmits the instruction, advice, notification or report.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_acDtOdp-Ed-ak6NoX_4Aeg_-712294198")]
    [Description(@"Party that transmits the instruction, advice, notification or report.")]
    TransmittingAgent = PartyRoleCode.TransmittingAgent, // same ordinal as derivation source for type conversions
    
}
