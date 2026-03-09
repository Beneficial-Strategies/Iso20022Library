// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account owner.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VreTFtp-Ed-ak6NoX_4Aeg_-894819562")]
[Description(@"Specifies the type of account owner.")]
[DerivedFrom(typeof(AccountOwnerTypeCode))]
public enum AccountOwnerType1Code
{
    /// <summary>
    /// Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.
    /// Encoded/decoded by serializers as &quot;POWN&quot;.
    /// </summary>
    [EnumMember(Value = "POWN")]
    [IsoId("_VreTF9p-Ed-ak6NoX_4Aeg_-894819554")]
    [Description(@"Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.")]
    PrimaryOwner = AccountOwnerTypeCode.PrimaryOwner, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// Encoded/decoded by serializers as &quot;TRUS&quot;.
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_VreTGNp-Ed-ak6NoX_4Aeg_-894819553")]
    [Description(@"Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.")]
    Trustee = AccountOwnerTypeCode.Trustee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_VreTGdp-Ed-ak6NoX_4Aeg_-894819552")]
    [Description(@"Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.")]
    CustodianForMinor = AccountOwnerTypeCode.CustodianForMinor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_VroEENp-Ed-ak6NoX_4Aeg_-894819551")]
    [Description(@"Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.")]
    Nominee = AccountOwnerTypeCode.Nominee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_VroEEdp-Ed-ak6NoX_4Aeg_-894819550")]
    [Description(@"One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.")]
    SecondaryOwner = AccountOwnerTypeCode.SecondaryOwner, // same ordinal as derivation source for type conversions
    
}
