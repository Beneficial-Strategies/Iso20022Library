// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hNwd8CCsEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of transaction.")]
[Derivations(typeof(SettlementInstructionReason1Code))]
public enum SettlementInstructionReasonCode
{
    /// <summary>
    /// Settlement of subscriptions or subscription legs of a switch transaction.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_qkmRgCCsEeWJd9HF2tO7BA")]
    [Description(@"Settlement of subscriptions or subscription legs of a switch transaction.")]
    Subscription,

    /// <summary>
    /// Settlement of investments to a savings plan.
    /// Encoded/decoded by serializers as &quot;SAVP&quot;.
    /// </summary>
    [EnumMember(Value = "SAVP")]
    [IsoId("_wVIFsCCsEeWJd9HF2tO7BA")]
    [Description(@"Settlement of investments to a savings plan.")]
    InvestmentSavingsPlan,

    /// <summary>
    /// Settlement of withdrawals from a savings plan.
    /// Encoded/decoded by serializers as &quot;WTHP&quot;.
    /// </summary>
    [EnumMember(Value = "WTHP")]
    [IsoId("_8heGwCCsEeWJd9HF2tO7BA")]
    [Description(@"Settlement of withdrawals from a savings plan.")]
    WithdrawalSavingsPlan,

    /// <summary>
    /// Settlement of investments to a savings plan and withdrawals from a savings plan.
    /// Encoded/decoded by serializers as &quot;SAVE&quot;.
    /// </summary>
    [EnumMember(Value = "SAVE")]
    [IsoId("_FjoDwCCtEeWJd9HF2tO7BA")]
    [Description(
        @"Settlement of investments to a savings plan and withdrawals from a savings plan."
    )]
    SavingsPlan,

    /// <summary>
    /// Settlement of securities purchases.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_MUt9ECCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of securities purchases.")]
    SecuritiesPurchase,

    /// <summary>
    /// Settlement of charges.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_PfzZACCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of charges.")]
    Charges,

    /// <summary>
    /// Settlement of all debit amounts.
    /// Encoded/decoded by serializers as &quot;CSHO&quot;.
    /// </summary>
    [EnumMember(Value = "CSHO")]
    [IsoId("_TlzlECCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of all debit amounts.")]
    AllDebits,

    /// <summary>
    /// Settlement of redemptions or redemption legs of a switch transaction.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_W0wNUCCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of redemptions or redemption legs of a switch transaction.")]
    Redemption,

    /// <summary>
    /// Settlement of securities sales.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_gGFOwCCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of securities sales.")]
    SecuritiesSale,

    /// <summary>
    /// Settlement of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_l2nC8CCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of interest.")]
    Interest,

    /// <summary>
    /// Settlement of dividends.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_n4yWECCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of dividends.")]
    Dividend,

    /// <summary>
    /// Settlement of all credit amounts.
    /// Encoded/decoded by serializers as &quot;CSHI&quot;.
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_qgA3ACCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of all credit amounts.")]
    AllCredits,

    /// <summary>
    /// Settlement of all credit and debit amounts.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_t5X_gCCtEeWJd9HF2tO7BA")]
    [Description(@"Settlement of all credit and debit amounts.")]
    AllCreditsAndDebits,

    /// <summary>
    /// Settlement of corporate actions.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_52lTgFxlEeW0RaYpOo325g")]
    [Description(@"Settlement of corporate actions.")]
    CorporateAction,
}
