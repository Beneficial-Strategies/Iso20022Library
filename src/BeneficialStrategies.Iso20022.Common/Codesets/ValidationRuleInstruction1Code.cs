// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the instruction for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cCdYNCAZEeuxStysDTgLiw")]
[Description(@"Specifies the instruction for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleInstruction1Code
{
    /// <summary>
    /// Hold cash for creditor.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_sgJgYSAeEeuSiN6KdHu9iw")]
    [Description(@"Hold cash for creditor.")]
    HoldCashForCreditor = ValidationRuleCode.HoldCashForCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Phone beneficiary.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_sgJgYyAeEeuSiN6KdHu9iw")]
    [Description(@"Phone beneficiary.")]
    PhoneBeneficiary = ValidationRuleCode.PhoneBeneficiary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Telecom beneficiary.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_sgJgZSAeEeuSiN6KdHu9iw")]
    [Description(@"Telecom beneficiary.")]
    Telecom = ValidationRuleCode.Telecom, // same ordinal as derivation source for type conversions
    
}
