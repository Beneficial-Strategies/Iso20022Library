// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of payout that will result from an in-the-money option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_El9IgKbFEeSxuMLA5o46jQ")]
[Description(@"Indicates the type of payout that will result from an in-the-money option.")]
[DerivedFrom(typeof(OptionPayoutTypeCode))]
public enum OptionPayoutType1Code
{
    /// <summary>
    /// Indicates the type of binaryoption.
    /// Encoded/decoded by serializers as &quot;BINA&quot;.
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_ImTYgabFEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of binaryoption.")]
    Binary = OptionPayoutTypeCode.Binary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the type of capped option.
    /// Encoded/decoded by serializers as &quot;CAPP&quot;.
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_IsFQYabFEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of capped option.")]
    Capped = OptionPayoutTypeCode.Capped, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the type of vanilla option.
    /// Encoded/decoded by serializers as &quot;VANI&quot;.
    /// </summary>
    [EnumMember(Value = "VANI")]
    [IsoId("_IuUsEabFEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of vanilla option.")]
    Vanilla = OptionPayoutTypeCode.Vanilla, // same ordinal as derivation source for type conversions
    
}
