// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__vrhg9ojEeC60axPepSq7g_1563954315")]
[Description(@"Specifies the type of repurchase transaction.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
public enum RepurchaseType7Code
{
    /// <summary>
    /// Relates to a Swap/Substitution.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("__vrhhNojEeC60axPepSq7g_-2098807040")]
    [Description(@"Relates to a Swap/Substitution.")]
    Swap = RepurchaseTypeCode.Swap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("__vrhhdojEeC60axPepSq7g_-1838435152")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall = RepurchaseTypeCode.RepurchaseCall, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("__v1SgNojEeC60axPepSq7g_-371286389")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    Pairoff = RepurchaseTypeCode.Pairoff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("__v1SgdojEeC60axPepSq7g_1146352751")]
    [Description(@"Is part of a pair-off.")]
    RepoRate = RepurchaseTypeCode.RepoRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("__v1SgtojEeC60axPepSq7g_511320905")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    Rollover = RepurchaseTypeCode.Rollover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("__v1Sg9ojEeC60axPepSq7g_1978469668")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    TopUp = RepurchaseTypeCode.TopUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("__v1ShNojEeC60axPepSq7g_-2108580250")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    Withdrawal = RepurchaseTypeCode.Withdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("__v1ShdojEeC60axPepSq7g_342518057")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment = RepurchaseTypeCode.PrincipalExposureAdjustment, // same ordinal as derivation source for type conversions
    
}
