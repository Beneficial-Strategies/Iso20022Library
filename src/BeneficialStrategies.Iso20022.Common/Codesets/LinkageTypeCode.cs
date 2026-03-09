// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of linkage requested.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afCIsNp-Ed-ak6NoX_4Aeg_1075790667")]
[Description(@"Type of linkage requested.")]
[Derivations(typeof(LinkageType1Code))]
public enum LinkageTypeCode
{
    /// <summary>
    /// Request is to link the referenced transactions.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_afCIsdp-Ed-ak6NoX_4Aeg_1642832919")]
    [Description(@"Request is to link the referenced transactions.")]
    Link,
    
    /// <summary>
    /// Request is to unlink the referenced transactions.
    /// Encoded/decoded by serializers as &quot;UNLK&quot;.
    /// </summary>
    [EnumMember(Value = "UNLK")]
    [IsoId("_afCIstp-Ed-ak6NoX_4Aeg_1965142157")]
    [Description(@"Request is to unlink the referenced transactions.")]
    Unlink,
    
    /// <summary>
    /// Request is to soft link the referenced transactions.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_afCIs9p-Ed-ak6NoX_4Aeg_2015936781")]
    [Description(@"Request is to soft link the referenced transactions.")]
    Soft,
    
}
