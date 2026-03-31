// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yuh0Zdp-Ed-ak6NoX_4Aeg_-872010891")]
[Description(@"Specifies the type of transaction.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionType2Code>))]
#endif
public enum TransactionType2Code
{
    /// <summary>
    /// Transaction is a redemption of an investment fund.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_Yuh0Ztp-Ed-ak6NoX_4Aeg_-756571607")]
    [Description(@"Transaction is a redemption of an investment fund.")]
    Redemption = InvestmentFundTransactionTypeCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_Yuh0Z9p-Ed-ak6NoX_4Aeg_-754722916")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    Subscription = InvestmentFundTransactionTypeCode.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement.
    /// Encoded/decoded by serializers as &quot;SSPL&quot;.
    /// </summary>
    [EnumMember(Value = "SSPL")]
    [IsoId("_Yuh0aNp-Ed-ak6NoX_4Aeg_-746412148")]
    [Description(
        @"Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement."
    )]
    SubscriptionSavingsPlan = InvestmentFundTransactionTypeCode.SubscriptionSavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past.
    /// Encoded/decoded by serializers as &quot;RWPL&quot;.
    /// </summary>
    [EnumMember(Value = "RWPL")]
    [IsoId("_YurlYNp-Ed-ak6NoX_4Aeg_-745487445")]
    [Description(
        @"Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past."
    )]
    RedemptionWithdrawingPlan = InvestmentFundTransactionTypeCode.RedemptionWithdrawingPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TRIN&quot;.
    /// </summary>
    [EnumMember(Value = "TRIN")]
    [IsoId("_YurlYdp-Ed-ak6NoX_4Aeg_-732559796")]
    [Description(
        @"Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management."
    )]
    TransferIn = InvestmentFundTransactionTypeCode.TransferIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TOUT&quot;.
    /// </summary>
    [EnumMember(Value = "TOUT")]
    [IsoId("_YurlYtp-Ed-ak6NoX_4Aeg_-731634274")]
    [Description(
        @"Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management."
    )]
    TransferOut = InvestmentFundTransactionTypeCode.TransferOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWII&quot;.
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_YurlY9p-Ed-ak6NoX_4Aeg_-384390981")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchIn = InvestmentFundTransactionTypeCode.SwitchIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWIO&quot;.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_YurlZNp-Ed-ak6NoX_4Aeg_-372387112")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchOut = InvestmentFundTransactionTypeCode.SwitchOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;SUAA&quot;.
    /// </summary>
    [EnumMember(Value = "SUAA")]
    [IsoId("_YurlZdp-Ed-ak6NoX_4Aeg_-690818303")]
    [Description(
        @"Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure."
    )]
    SubscriptionAssetAllocation = InvestmentFundTransactionTypeCode.SubscriptionAssetAllocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;REAA&quot;.
    /// </summary>
    [EnumMember(Value = "REAA")]
    [IsoId("_YurlZtp-Ed-ak6NoX_4Aeg_-690817720")]
    [Description(
        @"Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure."
    )]
    RedemptionAssetAllocation = InvestmentFundTransactionTypeCode.RedemptionAssetAllocation, // same ordinal as derivation source for type conversions
}
