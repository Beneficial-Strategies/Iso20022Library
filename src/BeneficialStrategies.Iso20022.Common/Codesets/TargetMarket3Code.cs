// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial product is in scope of a target market parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UHnL0LVNEeqkjqDuFVh1-A")]
[Description(@"Specifies whether a financial product is in scope of a target market parameter.")]
[DerivedFrom(typeof(TargetMarketCode))]
public enum TargetMarket3Code
{
    /// <summary>
    /// Yes, is applicable.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("_W8tJobVNEeqkjqDuFVh1-A")]
    [Description(@"Yes, is applicable.")]
    InScope = TargetMarketCode.InScope, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No, is not applicable.
    /// Encoded/decoded by serializers as &quot;NSCO&quot;.
    /// </summary>
    [EnumMember(Value = "NSCO")]
    [IsoId("_XqxwkbVNEeqkjqDuFVh1-A")]
    [Description(@"No, is not applicable.")]
    NotInScope = TargetMarketCode.NotInScope, // same ordinal as derivation source for type conversions
}
