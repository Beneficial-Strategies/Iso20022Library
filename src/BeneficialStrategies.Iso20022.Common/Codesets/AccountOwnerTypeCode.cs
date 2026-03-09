// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account owner.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r1Jf8I8mEeeBmcwCTnMfBg")]
[Description(@"Specifies the type of account owner.")]
[Derivations(typeof(AccountOwnerType1Code))]
public enum AccountOwnerTypeCode
{
    /// <summary>
    /// Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.
    /// Encoded/decoded by serializers as &quot;POWN&quot;.
    /// </summary>
    [EnumMember(Value = "POWN")]
    [IsoId("_u0xSwY8mEeeBmcwCTnMfBg")]
    [Description(@"Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.")]
    PrimaryOwner,
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// Encoded/decoded by serializers as &quot;TRUS&quot;.
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_u_et8Y8mEeeBmcwCTnMfBg")]
    [Description(@"Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.")]
    Trustee,
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_up6GkY8mEeeBmcwCTnMfBg")]
    [Description(@"Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.")]
    CustodianForMinor,
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_uv29kY8mEeeBmcwCTnMfBg")]
    [Description(@"Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.")]
    Nominee,
    
    /// <summary>
    /// One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_u6IT4Y8mEeeBmcwCTnMfBg")]
    [Description(@"One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.")]
    SecondaryOwner,
    
}
