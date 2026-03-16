// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aczUGNp-Ed-ak6NoX_4Aeg_-1474043592")]
[Description(@"Specifies the type of transaction.")]
[Derivations(
    typeof(InvestmentFundTransactionOutType1Code),
    typeof(InvestmentFundTransactionOutType4Code),
    typeof(TransactionType1Code),
    typeof(TransactionType2Code),
    typeof(InvestmentFundTransactionType1Code),
    typeof(InvestmentFundTransactionInType3Code),
    typeof(InvestmentFundTransactionInType1Code)
)]
public enum InvestmentFundTransactionTypeCode
{
    /// <summary>
    /// Transaction is a redemption of an investment fund.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ac8eANp-Ed-ak6NoX_4Aeg_-1414014899")]
    [Description(@"Transaction is a redemption of an investment fund.")]
    Redemption,

    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ac8eAdp-Ed-ak6NoX_4Aeg_-1414014882")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    Subscription,

    /// <summary>
    /// Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement.
    /// Encoded/decoded by serializers as &quot;SSPL&quot;.
    /// </summary>
    [EnumMember(Value = "SSPL")]
    [IsoId("_ac8eAtp-Ed-ak6NoX_4Aeg_-1414014864")]
    [Description(
        @"Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement."
    )]
    SubscriptionSavingsPlan,

    /// <summary>
    /// Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past.
    /// Encoded/decoded by serializers as &quot;RWPL&quot;.
    /// </summary>
    [EnumMember(Value = "RWPL")]
    [IsoId("_ac8eA9p-Ed-ak6NoX_4Aeg_-1414014829")]
    [Description(
        @"Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past."
    )]
    RedemptionWithdrawingPlan,

    /// <summary>
    /// Transaction is a change between investment funds (usually of the same family) with or without cash in/out, at more interesting conditions than a separate redemption or a separate subscription.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_ac8eBNp-Ed-ak6NoX_4Aeg_-1414014804")]
    [Description(
        @"Transaction is a change between investment funds (usually of the same family) with or without cash in/out, at more interesting conditions than a separate redemption or a separate subscription."
    )]
    Switch,

    /// <summary>
    /// Transaction is the result of a corporate action.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ac8eBdp-Ed-ak6NoX_4Aeg_-1414014787")]
    [Description(@"Transaction is the result of a corporate action.")]
    CorporationActionEvent,

    /// <summary>
    /// Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TRIN&quot;.
    /// </summary>
    [EnumMember(Value = "TRIN")]
    [IsoId("_ac8eBtp-Ed-ak6NoX_4Aeg_-1414014744")]
    [Description(
        @"Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management."
    )]
    TransferIn,

    /// <summary>
    /// Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TOUT&quot;.
    /// </summary>
    [EnumMember(Value = "TOUT")]
    [IsoId("_ac8eB9p-Ed-ak6NoX_4Aeg_-1414014726")]
    [Description(
        @"Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management."
    )]
    TransferOut,

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWII&quot;.
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_ac8eCNp-Ed-ak6NoX_4Aeg_-1414014708")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchIn,

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWIO&quot;.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_ac8eCdp-Ed-ak6NoX_4Aeg_-1414014673")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchOut,

    /// <summary>
    /// Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;SUAA&quot;.
    /// </summary>
    [EnumMember(Value = "SUAA")]
    [IsoId("_adGPANp-Ed-ak6NoX_4Aeg_-1414014431")]
    [Description(
        @"Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure."
    )]
    SubscriptionAssetAllocation,

    /// <summary>
    /// Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;REAA&quot;.
    /// </summary>
    [EnumMember(Value = "REAA")]
    [IsoId("_adGPAdp-Ed-ak6NoX_4Aeg_-1414014396")]
    [Description(
        @"Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure."
    )]
    RedemptionAssetAllocation,

    /// <summary>
    /// Transaction is a cross-in.
    /// Encoded/decoded by serializers as &quot;CROI&quot;.
    /// </summary>
    [EnumMember(Value = "CROI")]
    [IsoId("_adGPAtp-Ed-ak6NoX_4Aeg_1958826424")]
    [Description(@"Transaction is a cross-in.")]
    CrossIn,

    /// <summary>
    /// Transaction is a cross out.
    /// Encoded/decoded by serializers as &quot;CROO&quot;.
    /// </summary>
    [EnumMember(Value = "CROO")]
    [IsoId("_adGPA9p-Ed-ak6NoX_4Aeg_-679609394")]
    [Description(@"Transaction is a cross out.")]
    CrossOut,

    /// <summary>
    /// Transaction is an InSpecie.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_adGPBNp-Ed-ak6NoX_4Aeg_1557156653")]
    [Description(@"Transaction is an InSpecie.")]
    InSpecie,

    /// <summary>
    /// Transaction is a dividend.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_adGPBdp-Ed-ak6NoX_4Aeg_2067863197")]
    [Description(@"Transaction is a dividend.")]
    Dividend,

    /// <summary>
    /// Transaction is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_adGPBtp-Ed-ak6NoX_4Aeg_-1667450763")]
    [Description(@"Transaction is another type of transaction.")]
    Other,

    /// <summary>
    /// Transaction is a reinvestment of dividend.
    /// Encoded/decoded by serializers as &quot;RDIV&quot;.
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_adGPB9p-Ed-ak6NoX_4Aeg_1449121174")]
    [Description(@"Transaction is a reinvestment of dividend.")]
    ReinvestmentOfDividend,

    /// <summary>
    /// All types of transactions.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_QzUggFsIEea4y99eritluQ")]
    [Description(@"All types of transactions.")]
    All,

    /// <summary>
    /// Purchase of securities.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_X5-aIFsIEea4y99eritluQ")]
    [Description(@"Purchase of securities.")]
    SecuritiesPurchase,

    /// <summary>
    /// Sale of securities.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_b2vxsFsIEea4y99eritluQ")]
    [Description(@"Sale of securities.")]
    SecuritiesSale,

    /// <summary>
    /// Transaction is a cash withdrawal.
    /// Encoded/decoded by serializers as &quot;CWIT&quot;.
    /// </summary>
    [EnumMember(Value = "CWIT")]
    [IsoId("_ENCgAFsJEea4y99eritluQ")]
    [Description(@"Transaction is a cash withdrawal.")]
    CashWithdrawal,

    /// <summary>
    /// Transaction is a cash deposit.
    /// Encoded/decoded by serializers as &quot;CDEP&quot;.
    /// </summary>
    [EnumMember(Value = "CDEP")]
    [IsoId("_I4hXsFsJEea4y99eritluQ")]
    [Description(@"Transaction is a cash deposit.")]
    CashDeposit,

    /// <summary>
    /// Transaction is the payment of dividends and other proceeds.
    /// Encoded/decoded by serializers as &quot;DIVP&quot;.
    /// </summary>
    [EnumMember(Value = "DIVP")]
    [IsoId("_PSGI4FsJEea4y99eritluQ")]
    [Description(@"Transaction is the payment of dividends and other proceeds.")]
    DividendPayment,
}
