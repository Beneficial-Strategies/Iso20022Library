// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Trading Date Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__zj79dojEeC60axPepSq7g_1662306334")]
[Description(@"Trading Date Code.")]
[DerivedFrom(typeof(TradingDateCode))]
public enum TradingDate1Code
{
    /// <summary>
    /// Partial trades have occurred over a period of two or more days.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("__ztF4NojEeC60axPepSq7g_2007838442")]
    [Description(@"Partial trades have occurred over a period of two or more days.")]
    Various = TradingDateCode.Various, // same ordinal as derivation source for type conversions
}
