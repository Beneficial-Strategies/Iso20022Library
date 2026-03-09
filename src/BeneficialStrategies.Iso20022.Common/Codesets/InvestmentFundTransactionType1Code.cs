// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nj6G8FsJEea4y99eritluQ")]
[Description(@"Specifies the type of transaction.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
public enum InvestmentFundTransactionType1Code
{
    /// <summary>
    /// All types of transactions.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_6nRqMVsJEea4y99eritluQ")]
    [Description(@"All types of transactions.")]
    All = InvestmentFundTransactionTypeCode.All, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sale of securities.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_9GhT0VsJEea4y99eritluQ")]
    [Description(@"Sale of securities.")]
    SecuritiesSale = InvestmentFundTransactionTypeCode.SecuritiesSale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchase of securities.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_9MVA4VsJEea4y99eritluQ")]
    [Description(@"Purchase of securities.")]
    SecuritiesPurchase = InvestmentFundTransactionTypeCode.SecuritiesPurchase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWIO&quot;.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_-p81cVsJEea4y99eritluQ")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchOut = InvestmentFundTransactionTypeCode.SwitchOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TRIN&quot;.
    /// </summary>
    [EnumMember(Value = "TRIN")]
    [IsoId("_AJptoVsKEea4y99eritluQ")]
    [Description(@"Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.")]
    TransferIn = InvestmentFundTransactionTypeCode.TransferIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TOUT&quot;.
    /// </summary>
    [EnumMember(Value = "TOUT")]
    [IsoId("_APvukVsKEea4y99eritluQ")]
    [Description(@"Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.")]
    TransferOut = InvestmentFundTransactionTypeCode.TransferOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_BTnmYVsKEea4y99eritluQ")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    Subscription = InvestmentFundTransactionTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a redemption of an investment fund.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_CCzAkVsKEea4y99eritluQ")]
    [Description(@"Transaction is a redemption of an investment fund.")]
    Redemption = InvestmentFundTransactionTypeCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a cash deposit.
    /// Encoded/decoded by serializers as &quot;CDEP&quot;.
    /// </summary>
    [EnumMember(Value = "CDEP")]
    [IsoId("_ngYcYVsKEea4y99eritluQ")]
    [Description(@"Transaction is a cash deposit.")]
    CashDeposit = InvestmentFundTransactionTypeCode.CashDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a cash withdrawal.
    /// Encoded/decoded by serializers as &quot;CWIT&quot;.
    /// </summary>
    [EnumMember(Value = "CWIT")]
    [IsoId("_npTu4VsKEea4y99eritluQ")]
    [Description(@"Transaction is a cash withdrawal.")]
    CashWithdrawal = InvestmentFundTransactionTypeCode.CashWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of dividends and other proceeds.
    /// Encoded/decoded by serializers as &quot;DIVP&quot;.
    /// </summary>
    [EnumMember(Value = "DIVP")]
    [IsoId("_2rbqQVsKEea4y99eritluQ")]
    [Description(@"Transaction is the payment of dividends and other proceeds.")]
    DividendPayment = InvestmentFundTransactionTypeCode.DividendPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the result of a corporate action.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_L1LrMVsLEea4y99eritluQ")]
    [Description(@"Transaction is the result of a corporate action.")]
    CorporationActionEvent = InvestmentFundTransactionTypeCode.CorporationActionEvent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a cross-in.
    /// Encoded/decoded by serializers as &quot;CROI&quot;.
    /// </summary>
    [EnumMember(Value = "CROI")]
    [IsoId("_L-jpoVsLEea4y99eritluQ")]
    [Description(@"Transaction is a cross-in.")]
    CrossIn = InvestmentFundTransactionTypeCode.CrossIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a cross out.
    /// Encoded/decoded by serializers as &quot;CROO&quot;.
    /// </summary>
    [EnumMember(Value = "CROO")]
    [IsoId("_MEqRoVsLEea4y99eritluQ")]
    [Description(@"Transaction is a cross out.")]
    CrossOut = InvestmentFundTransactionTypeCode.CrossOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a dividend.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_MI-J4VsLEea4y99eritluQ")]
    [Description(@"Transaction is a dividend.")]
    Dividend = InvestmentFundTransactionTypeCode.Dividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an InSpecie.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_MQHTsVsLEea4y99eritluQ")]
    [Description(@"Transaction is an InSpecie.")]
    InSpecie = InvestmentFundTransactionTypeCode.InSpecie, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_MVBo4VsLEea4y99eritluQ")]
    [Description(@"Transaction is another type of transaction.")]
    Other = InvestmentFundTransactionTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;REAA&quot;.
    /// </summary>
    [EnumMember(Value = "REAA")]
    [IsoId("_MaO5AVsLEea4y99eritluQ")]
    [Description(@"Transaction is a redemption in an asset allocation plan which enables investors to withdraw, by percentage a certain amount of cash from several sub-funds of a same umbrella structure.")]
    RedemptionAssetAllocation = InvestmentFundTransactionTypeCode.RedemptionAssetAllocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past.
    /// Encoded/decoded by serializers as &quot;RWPL&quot;.
    /// </summary>
    [EnumMember(Value = "RWPL")]
    [IsoId("_Mgob8VsLEea4y99eritluQ")]
    [Description(@"Transaction is a withdrawal by individuals in the framework of a structured plan for investments made in the past.")]
    RedemptionWithdrawingPlan = InvestmentFundTransactionTypeCode.RedemptionWithdrawingPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a reinvestment of dividend.
    /// Encoded/decoded by serializers as &quot;RDIV&quot;.
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_MlP2MVsLEea4y99eritluQ")]
    [Description(@"Transaction is a reinvestment of dividend.")]
    ReinvestmentOfDividend = InvestmentFundTransactionTypeCode.ReinvestmentOfDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement.
    /// Encoded/decoded by serializers as &quot;SSPL&quot;.
    /// </summary>
    [EnumMember(Value = "SSPL")]
    [IsoId("_MyV3AVsLEea4y99eritluQ")]
    [Description(@"Transaction is a subscription for a savings plan, that is, money set aside by individuals in the framework of a structured plan for a special purpose, for example, retirement.")]
    SubscriptionSavingsPlan = InvestmentFundTransactionTypeCode.SubscriptionSavingsPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure.
    /// Encoded/decoded by serializers as &quot;SUAA&quot;.
    /// </summary>
    [EnumMember(Value = "SUAA")]
    [IsoId("_M4I9AVsLEea4y99eritluQ")]
    [Description(@"Transaction is a subscription in an asset allocation plan that enables investors to allocate, by percentage a certain amount of cash into several sub-funds of a same umbrella structure.")]
    SubscriptionAssetAllocation = InvestmentFundTransactionTypeCode.SubscriptionAssetAllocation, // same ordinal as derivation source for type conversions
    
}
