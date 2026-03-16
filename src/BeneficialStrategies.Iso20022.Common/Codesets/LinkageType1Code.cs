// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of linkage requested.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ae4Xttp-Ed-ak6NoX_4Aeg_-2003821143")]
[Description(@"Type of linkage requested.")]
[DerivedFrom(typeof(LinkageTypeCode))]
public enum LinkageType1Code
{
    /// <summary>
    /// Request is to link the referenced transactions.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_ae4Xt9p-Ed-ak6NoX_4Aeg_-2003821118")]
    [Description(@"Request is to link the referenced transactions.")]
    Link = LinkageTypeCode.Link, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request is to unlink the referenced transactions.
    /// Encoded/decoded by serializers as &quot;UNLK&quot;.
    /// </summary>
    [EnumMember(Value = "UNLK")]
    [IsoId("_ae4XuNp-Ed-ak6NoX_4Aeg_-2003821117")]
    [Description(@"Request is to unlink the referenced transactions.")]
    Unlink = LinkageTypeCode.Unlink, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request is to soft link the referenced transactions.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_ae4Xudp-Ed-ak6NoX_4Aeg_-2003821101")]
    [Description(@"Request is to soft link the referenced transactions.")]
    Soft = LinkageTypeCode.Soft, // same ordinal as derivation source for type conversions
}
