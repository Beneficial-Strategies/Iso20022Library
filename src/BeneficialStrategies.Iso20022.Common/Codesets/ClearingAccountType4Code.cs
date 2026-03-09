// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CGl4YIJLEeuDe9SyRl5qeg")]
[Description(@"Specifies the clearing account type.")]
[DerivedFrom(typeof(ClearingAccountTypeCode))]
public enum ClearingAccountType4Code
{
    /// <summary>
    /// Specifies that the account is used to register trades executed for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_Gbdm4YJLEeuDe9SyRl5qeg")]
    [Description(@"Specifies that the account is used to register trades executed for the clearing member's customers.")]
    Client = ClearingAccountTypeCode.Client, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.
    /// Encoded/decoded by serializers as &quot;HOUS&quot;.
    /// </summary>
    [EnumMember(Value = "HOUS")]
    [IsoId("_GmBREYJLEeuDe9SyRl5qeg")]
    [Description(@"Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.")]
    House = ClearingAccountTypeCode.House, // same ordinal as derivation source for type conversions
    
}
