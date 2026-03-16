// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTosldp-Ed-ak6NoX_4Aeg_561015299")]
[Description(@"Specifies the type of repurchase transaction.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
public enum RepurchaseType3Code
{
    /// <summary>
    /// Relates to a Swap/Substitution.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_ZTosltp-Ed-ak6NoX_4Aeg_561015301")]
    [Description(@"Relates to a Swap/Substitution.")]
    Swap = RepurchaseTypeCode.Swap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_ZTosl9p-Ed-ak6NoX_4Aeg_561015330")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall = RepurchaseTypeCode.RepurchaseCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZTosmNp-Ed-ak6NoX_4Aeg_561015331")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    Pairoff = RepurchaseTypeCode.Pairoff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_ZTosmdp-Ed-ak6NoX_4Aeg_561015360")]
    [Description(@"Is part of a pair-off.")]
    RepoRate = RepurchaseTypeCode.RepoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_ZTx2gNp-Ed-ak6NoX_4Aeg_561015361")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Rollover = RepurchaseTypeCode.Rollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_ZTx2gdp-Ed-ak6NoX_4Aeg_561015362")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    TopUp = RepurchaseTypeCode.TopUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_ZTx2gtp-Ed-ak6NoX_4Aeg_561015608")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Withdrawal = RepurchaseTypeCode.Withdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_ZTx2g9p-Ed-ak6NoX_4Aeg_777121086")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment = RepurchaseTypeCode.PrincipalExposureAdjustment, // same ordinal as derivation source for type conversions
}
