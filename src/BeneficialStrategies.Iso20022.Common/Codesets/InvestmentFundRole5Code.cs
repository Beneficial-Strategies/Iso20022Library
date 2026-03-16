// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role played by an actor in an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOC0p9p-Ed-ak6NoX_4Aeg_-878907454")]
[Description(@"Specifies the role played by an actor in an investment fund transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InvestmentFundRole5Code
{
    /// <summary>
    /// Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_WOMloNp-Ed-ak6NoX_4Aeg_-878907424")]
    [Description(
        @"Party appointed by the fund management company. This party updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution."
    )]
    TransferAgent = PartyRoleCode.TransferAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_WOMlodp-Ed-ak6NoX_4Aeg_-878907423")]
    [Description(
        @"Party that provides services to investors relating to financial products. These services may include some, or all of, provision of information and advice on products, placement of investment orders, transmission of payment, custody of assets, and the administration of rights and benefits. In the specific framework of investment funds industry, an intermediary may present information about funds to potential investors, and solicit orders for the fund. This intermediary may facilitate the transmission of the orders and information from/to the investors and/or other intermediaries. The intermediary receives commission from the Fund and/or fees from the investor."
    )]
    Intermediary = PartyRoleCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_WOMlotp-Ed-ak6NoX_4Aeg_1633754476")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor = PartyRoleCode.Distributor, // same ordinal as derivation source for type conversions
}
