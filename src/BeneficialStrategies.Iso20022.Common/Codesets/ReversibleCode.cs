// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the possibility to terminate the securities lending contract either by the borrower or lender before the expiration date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__v_Dg9ojEeC60axPepSq7g_-2080569702")]
[Description(@"Indicates the possibility to terminate the securities lending contract either by the borrower or lender before the expiration date.")]
[Derivations(typeof(Reversible1Code))]
public enum ReversibleCode
{
    /// <summary>
    /// Securities lending contract can be ended by the borrower before the expiration date.
    /// Encoded/decoded by serializers as &quot;REVL&quot;.
    /// </summary>
    [EnumMember(Value = "REVL")]
    [IsoId("__v_DhNojEeC60axPepSq7g_-999316932")]
    [Description(@"Securities lending contract can be ended by the borrower before the expiration date.")]
    Reversible,
    
    /// <summary>
    /// Securities lending contract can not be ended by the borrower before the expiration date.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("__v_DhdojEeC60axPepSq7g_-1276803682")]
    [Description(@"Securities lending contract can not be ended by the borrower before the expiration date.")]
    Fixed,
    
    /// <summary>
    /// Securities lending contract can be ended by the lender before the expiration date.
    /// Encoded/decoded by serializers as &quot;CABK&quot;.
    /// </summary>
    [EnumMember(Value = "CABK")]
    [IsoId("__wINcNojEeC60axPepSq7g_-1931814150")]
    [Description(@"Securities lending contract can be ended by the lender before the expiration date.")]
    CallBack,
    
}
