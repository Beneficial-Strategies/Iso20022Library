// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account ownership.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jlHYMJNhEem9mu_a5rvrBw")]
[Description(@"Specifies the type of account ownership.")]
[DerivedFrom(typeof(AccountOwnershipTypeCode))]
public enum AccountOwnershipType5Code
{
    /// <summary>
    /// The person is ...
    /// Encoded/decoded by serializers as &quot;USUF&quot;.
    /// </summary>
    [EnumMember(Value = "USUF")]
    [IsoId("_WUASAZNiEem9mu_a5rvrBw")]
    [Description(@"The person is ...")]
    Usufructuary = AccountOwnershipTypeCode.Usufructuary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A person has full ownership on the asset.
    /// Encoded/decoded by serializers as &quot;OWNR&quot;.
    /// </summary>
    [EnumMember(Value = "OWNR")]
    [IsoId("_YKOz0ZNiEem9mu_a5rvrBw")]
    [Description(@"A person has full ownership on the asset. ")]
    Owner = AccountOwnershipTypeCode.Owner, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A person has bare ownership on the asset.
    /// Encoded/decoded by serializers as &quot;BOWN&quot;.
    /// </summary>
    [EnumMember(Value = "BOWN")]
    [IsoId("_Yr5WcZNiEem9mu_a5rvrBw")]
    [Description(@"A person has bare ownership on the asset.")]
    BareOwner = AccountOwnershipTypeCode.BareOwner, // same ordinal as derivation source for type conversions
}
