// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuYqcdp-Ed-ak6NoX_4Aeg_451159608")]
[Description(@"Specifies the type of transaction.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
public enum TransactionType1Code
{
    /// <summary>
    /// Transaction is a redemption of an investment fund.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_YuYqctp-Ed-ak6NoX_4Aeg_-726363086")]
    [Description(@"Transaction is a redemption of an investment fund.")]
    Redemption = InvestmentFundTransactionTypeCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_YuYqc9p-Ed-ak6NoX_4Aeg_-693115460")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    Subscription = InvestmentFundTransactionTypeCode.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement.
    /// Encoded/decoded by serializers as &quot;SSPL&quot;.
    /// </summary>
    [EnumMember(Value = "SSPL")]
    [IsoId("_YuYqdNp-Ed-ak6NoX_4Aeg_-800826197")]
    [Description(
        @"Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement."
    )]
    SubscriptionSavingsPlan = InvestmentFundTransactionTypeCode.SubscriptionSavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past.
    /// Encoded/decoded by serializers as &quot;RWPL&quot;.
    /// </summary>
    [EnumMember(Value = "RWPL")]
    [IsoId("_YuYqddp-Ed-ak6NoX_4Aeg_-800826188")]
    [Description(
        @"Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past."
    )]
    RedemptionWithdrawingPlan = InvestmentFundTransactionTypeCode.RedemptionWithdrawingPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a change between investment funds (usually of the same family) with or without cash in/out, at more interesting conditions than a separate redemption or a separate subscription.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_YuYqdtp-Ed-ak6NoX_4Aeg_-800826187")]
    [Description(
        @"Transaction is a change between investment funds (usually of the same family) with or without cash in/out, at more interesting conditions than a separate redemption or a separate subscription."
    )]
    Switch = InvestmentFundTransactionTypeCode.Switch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the result of a corporate action.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_YuYqd9p-Ed-ak6NoX_4Aeg_-1401028450")]
    [Description(@"Transaction is the result of a corporate action.")]
    CorporationActionEvent = InvestmentFundTransactionTypeCode.CorporationActionEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TRIN&quot;.
    /// </summary>
    [EnumMember(Value = "TRIN")]
    [IsoId("_YuYqeNp-Ed-ak6NoX_4Aeg_-1401028449")]
    [Description(
        @"Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management."
    )]
    TransferIn = InvestmentFundTransactionTypeCode.TransferIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TOUT&quot;.
    /// </summary>
    [EnumMember(Value = "TOUT")]
    [IsoId("_Yuh0YNp-Ed-ak6NoX_4Aeg_-1401028448")]
    [Description(
        @"Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management."
    )]
    TransferOut = InvestmentFundTransactionTypeCode.TransferOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWII&quot;.
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_Yuh0Ydp-Ed-ak6NoX_4Aeg_-1833292534")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchIn = InvestmentFundTransactionTypeCode.SwitchIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWIO&quot;.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_Yuh0Ytp-Ed-ak6NoX_4Aeg_-1833292464")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchOut = InvestmentFundTransactionTypeCode.SwitchOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;SUAA&quot;.
    /// </summary>
    [EnumMember(Value = "SUAA")]
    [IsoId("_Yuh0Y9p-Ed-ak6NoX_4Aeg_-1833292404")]
    [Description(
        @"Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure."
    )]
    SubscriptionAssetAllocation = InvestmentFundTransactionTypeCode.SubscriptionAssetAllocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;REAA&quot;.
    /// </summary>
    [EnumMember(Value = "REAA")]
    [IsoId("_Yuh0ZNp-Ed-ak6NoX_4Aeg_-1833292344")]
    [Description(
        @"Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure."
    )]
    RedemptionAssetAllocation = InvestmentFundTransactionTypeCode.RedemptionAssetAllocation, // same ordinal as derivation source for type conversions
}
