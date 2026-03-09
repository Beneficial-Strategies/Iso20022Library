// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VfjYECF1EeW9XJWqfgXIIA")]
[Description(@"Specifies the status of an account.")]
[DerivedFrom(typeof(AccountStatusCode))]
public enum AccountStatus4Code
{
    /// <summary>
    /// Account can be used for its intended purpose.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_ZRLPkSF1EeW9XJWqfgXIIA")]
    [Description(@"Account can be used for its intended purpose.")]
    Enabled = AccountStatusCode.Enabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account cannot be used for its intended purpose, either temporarily or permanently.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_Z6_BkSF1EeW9XJWqfgXIIA")]
    [Description(@"Account cannot be used for its intended purpose, either temporarily or permanently.")]
    Disabled = AccountStatusCode.Disabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account change is pending approval.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_aHU0cSF1EeW9XJWqfgXIIA")]
    [Description(@"Account change is pending approval.")]
    Pending = AccountStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.
    /// Encoded/decoded by serializers as &quot;FORM&quot;.
    /// </summary>
    [EnumMember(Value = "FORM")]
    [IsoId("_aXZQwSF1EeW9XJWqfgXIIA")]
    [Description(@"Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.")]
    ProForma = AccountStatusCode.ProForma, // same ordinal as derivation source for type conversions
    
}
