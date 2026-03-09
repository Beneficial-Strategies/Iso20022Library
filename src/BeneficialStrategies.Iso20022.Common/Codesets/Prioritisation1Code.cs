// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if one side or the other of a cross order should be prioritized.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKBiANp-Ed-ak6NoX_4Aeg_1567908558")]
[Description(@"Indicates if one side or the other of a cross order should be prioritized.")]
[DerivedFrom(typeof(PrioritisationCode))]
public enum Prioritisation1Code
{
    /// <summary>
    /// None of the sides should be prioritised.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_aKBiAdp-Ed-ak6NoX_4Aeg_1628857705")]
    [Description(@"None of the sides should be prioritised.")]
    None = PrioritisationCode.None, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buy side is prioritized.
    /// Encoded/decoded by serializers as &quot;BSPR&quot;.
    /// </summary>
    [EnumMember(Value = "BSPR")]
    [IsoId("_aKBiAtp-Ed-ak6NoX_4Aeg_1628857765")]
    [Description(@"Buy side is prioritized.")]
    BuySide = PrioritisationCode.BuySide, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sell side is prioritised.
    /// Encoded/decoded by serializers as &quot;SSPR&quot;.
    /// </summary>
    [EnumMember(Value = "SSPR")]
    [IsoId("_aKBiA9p-Ed-ak6NoX_4Aeg_1628858017")]
    [Description(@"Sell side is prioritised.")]
    SellSide = PrioritisationCode.SellSide, // same ordinal as derivation source for type conversions
    
}
