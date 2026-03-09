// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the order is sell or buy driven.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aRBh4dp-Ed-ak6NoX_4Aeg_-127818682")]
[Description(@"Specifies if the order is sell or buy driven.")]
[DerivedFrom(typeof(SideCode))]
public enum OrderDriverCode
{
    /// <summary>
    /// Order is buy driven.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_aRBh4tp-Ed-ak6NoX_4Aeg_1502724820")]
    [Description(@"Order is buy driven.")]
    Buy = SideCode.Buy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is sell driven.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_aRBh49p-Ed-ak6NoX_4Aeg_1502725190")]
    [Description(@"Order is sell driven.")]
    Sell = SideCode.Sell, // same ordinal as derivation source for type conversions
    
}
