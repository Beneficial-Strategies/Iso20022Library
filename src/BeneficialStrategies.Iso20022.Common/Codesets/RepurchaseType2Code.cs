// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTe7ltp-Ed-ak6NoX_4Aeg_212758394")]
[Description(@"Specifies the type of repurchase transaction.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepurchaseType2Code>))]
#endif
public enum RepurchaseType2Code
{
    /// <summary>
    /// Relates to a Swap/Substitution.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_ZTe7l9p-Ed-ak6NoX_4Aeg_473191454")]
    [Description(@"Relates to a Swap/Substitution.")]
    Swap = RepurchaseTypeCode.Swap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_ZTe7mNp-Ed-ak6NoX_4Aeg_489815295")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall = RepurchaseTypeCode.RepurchaseCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZToskNp-Ed-ak6NoX_4Aeg_501821642")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    Pairoff = RepurchaseTypeCode.Pairoff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_ZToskdp-Ed-ak6NoX_4Aeg_529525655")]
    [Description(@"Is part of a pair-off.")]
    RepoRate = RepurchaseTypeCode.RepoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_ZTosktp-Ed-ak6NoX_4Aeg_560001854")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Rollover = RepurchaseTypeCode.Rollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_ZTosk9p-Ed-ak6NoX_4Aeg_572932121")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    TopUp = RepurchaseTypeCode.TopUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_ZToslNp-Ed-ak6NoX_4Aeg_573855643")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Withdrawal = RepurchaseTypeCode.Withdrawal, // same ordinal as derivation source for type conversions
}
