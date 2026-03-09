// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rank of an element (party, market) in a specific environment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6S0e4JNgEeWSf8tCOKY7Ug")]
[Description(@"Specifies the rank of an element (party, market) in a specific environment.")]
[DerivedFrom(typeof(RankCode))]
public enum Rank1Code
{
    /// <summary>
    /// Element is the primary one.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_8Vcd8ZNgEeWSf8tCOKY7Ug")]
    [Description(@"Element is the primary one.")]
    Primary = RankCode.Primary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Element is the primary one.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_8dx6kZNgEeWSf8tCOKY7Ug")]
    [Description(@"Element is the primary one.")]
    Secondary = RankCode.Secondary, // same ordinal as derivation source for type conversions
    
}
