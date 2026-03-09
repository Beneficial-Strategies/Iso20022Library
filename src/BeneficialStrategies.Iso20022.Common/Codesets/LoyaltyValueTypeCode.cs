// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of value used for the loyalty programme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ln1yYF_BEee_oqB7UglxLw")]
[Description(@"Type of value used for the loyalty programme.")]
[Derivations(typeof(LoyaltyValueType1Code))]
public enum LoyaltyValueTypeCode
{
    /// <summary>
    /// Value expressed in points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_xDNpgF_BEee_oqB7UglxLw")]
    [Description(@"Value expressed in points.")]
    Points,
    
    /// <summary>
    /// Value expressed in miles.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_0JFOQF_BEee_oqB7UglxLw")]
    [Description(@"Value expressed in miles.")]
    Miles,
    
    /// <summary>
    /// Value expressed in monetary units.
    /// Encoded/decoded by serializers as &quot;MONE&quot;.
    /// </summary>
    [EnumMember(Value = "MONE")]
    [IsoId("_3WrysF_BEee_oqB7UglxLw")]
    [Description(@"Value expressed in monetary units.")]
    Monetary,
    
    /// <summary>
    /// Value expressed in a private currency.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_8cf18F_BEee_oqB7UglxLw")]
    [Description(@"Value expressed in a private currency.")]
    PrivateCurrency,
    
    /// <summary>
    /// Value expressed in any other type of loyalty value.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_BI4FgF_CEee_oqB7UglxLw")]
    [Description(@"Value expressed in any other type of loyalty value.")]
    Other,
    
}
