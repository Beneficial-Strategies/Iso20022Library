// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the collateral type against which all repurchase agreements are conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q4dpgJf_EeSfnc-VXAEapg")]
[Description(@"Specifies the collateral type against which all repurchase agreements are conducted.")]
[Derivations(typeof(SpecialCollateral1Code),typeof(SpecialCollateral2Code))]
public enum SpecialCollateralCode
{
    /// <summary>
    /// Identifies that all repurchase agreements are conducted against general collateral.
    /// Encoded/decoded by serializers as &quot;GENE&quot;.
    /// </summary>
    [EnumMember(Value = "GENE")]
    [IsoId("_TACaAJf_EeSfnc-VXAEapg")]
    [Description(@"Identifies that all repurchase agreements are conducted against general collateral.")]
    GeneralCollateral,
    
    /// <summary>
    /// Identifies that all repurchase agreements are conducted against special collateral.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_Tb3aYJf_EeSfnc-VXAEapg")]
    [Description(@"Identifies that all repurchase agreements are conducted against special collateral.")]
    SpecialCollateral,
    
    /// <summary>
    /// Identifies that this is a securities lending transaction, made of repurchase agreements and reverse repurchase agreements versus cash.
    /// Encoded/decoded by serializers as &quot;MRRP&quot;.
    /// </summary>
    [EnumMember(Value = "MRRP")]
    [IsoId("_UKZfkMEaEea7jLfvGi1PDw")]
    [Description(@"Identifies that this is a securities lending transaction, made of repurchase agreements and reverse repurchase agreements versus cash.")]
    MatchedAndReverseRepurchaseAgreement,
    
}
