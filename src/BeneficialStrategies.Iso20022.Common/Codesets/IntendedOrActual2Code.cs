// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if a charge or cost is intended (ex ante) or actual (post ante).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZfakIppEeidFfW6ExBZOw")]
[Description(@"Specifies if a charge or cost is intended (ex ante) or actual (post ante).")]
[DerivedFrom(typeof(IntendedOrActualCode))]
public enum IntendedOrActual2Code
{
    /// <summary>
    /// Ex ante (intended).
    /// Encoded/decoded by serializers as &quot;ANTE&quot;.
    /// </summary>
    [EnumMember(Value = "ANTE")]
    [IsoId("_bTCWIYppEeidFfW6ExBZOw")]
    [Description(@"Ex ante (intended).")]
    ExAnte = IntendedOrActualCode.ExAnte, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ex post (actual).
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_bYjIQYppEeidFfW6ExBZOw")]
    [Description(@"Ex post (actual).")]
    ExPost = IntendedOrActualCode.ExPost, // same ordinal as derivation source for type conversions
    
}
