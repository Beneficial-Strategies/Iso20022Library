// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_76NdACCtEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of transaction.")]
[DerivedFrom(typeof(SettlementInstructionReasonCode))]
public enum SettlementInstructionReason1Code
{
    /// <summary>
    /// Settlement of all credit amounts.
    /// Encoded/decoded by serializers as &quot;CSHI&quot;.
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_-R0NkSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of all credit amounts.")]
    AllCredits = SettlementInstructionReasonCode.AllCredits, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of all credit and debit amounts.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_-ZjNQSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of all credit and debit amounts.")]
    AllCreditsAndDebits = SettlementInstructionReasonCode.AllCreditsAndDebits, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of all debit amounts.
    /// Encoded/decoded by serializers as &quot;CSHO&quot;.
    /// </summary>
    [EnumMember(Value = "CSHO")]
    [IsoId("_-hlu8SCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of all debit amounts.")]
    AllDebits = SettlementInstructionReasonCode.AllDebits, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of charges.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_-pnpkSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of charges.")]
    Charges = SettlementInstructionReasonCode.Charges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of dividends.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_-xDuUSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of dividends.")]
    Dividend = SettlementInstructionReasonCode.Dividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_-5PZ8SCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of interest.")]
    Interest = SettlementInstructionReasonCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of investments to a savings plan.
    /// Encoded/decoded by serializers as &quot;SAVP&quot;.
    /// </summary>
    [EnumMember(Value = "SAVP")]
    [IsoId("__A1PsSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of investments to a savings plan.")]
    InvestmentSavingsPlan = SettlementInstructionReasonCode.InvestmentSavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of redemptions or redemption legs of a switch transaction.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("__IaeYSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of redemptions or redemption legs of a switch transaction.")]
    Redemption = SettlementInstructionReasonCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of investments to a savings plan and withdrawals from a savings plan.
    /// Encoded/decoded by serializers as &quot;SAVE&quot;.
    /// </summary>
    [EnumMember(Value = "SAVE")]
    [IsoId("__P2jISCtEeWJd9HF2tO7BA")]
    [Description(
        @"Settlement of investments to a savings plan and withdrawals from a savings plan."
    )]
    SavingsPlan = SettlementInstructionReasonCode.SavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of securities purchases.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("__XcY4SCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of securities purchases.")]
    SecuritiesPurchase = SettlementInstructionReasonCode.SecuritiesPurchase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of securities sales.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("__fVJkSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of securities sales.")]
    SecuritiesSale = SettlementInstructionReasonCode.SecuritiesSale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of subscriptions or subscription legs of a switch transaction.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("__mxOUSCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of subscriptions or subscription legs of a switch transaction.")]
    Subscription = SettlementInstructionReasonCode.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of withdrawals from a savings plan.
    /// Encoded/decoded by serializers as &quot;WTHP&quot;.
    /// </summary>
    [EnumMember(Value = "WTHP")]
    [IsoId("__up_ASCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of withdrawals from a savings plan.")]
    WithdrawalSavingsPlan = SettlementInstructionReasonCode.WithdrawalSavingsPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of corporate actions.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_AuSyMVxmEeW0RaYpOo325g")]
    [Description(@"Settlement of corporate actions.")]
    CorporateAction = SettlementInstructionReasonCode.CorporateAction, // same ordinal as derivation source for type conversions
}
