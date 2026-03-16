// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if a charge or cost is intended (ex ante) or actual (post ante).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lko5sDcjEeidBoT_PugKiA")]
[Description(@"Specifies if a charge or cost is intended (ex ante) or actual (post ante).")]
[Derivations(typeof(IntendedOrActual2Code))]
public enum IntendedOrActualCode
{
    /// <summary>
    /// Ex ante (intended).
    /// Encoded/decoded by serializers as &quot;ANTE&quot;.
    /// </summary>
    [EnumMember(Value = "ANTE")]
    [IsoId("_nCEhADcjEeidBoT_PugKiA")]
    [Description(@"Ex ante (intended).")]
    ExAnte,

    /// <summary>
    /// Ex post (actual).
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_tNzqgDcjEeidBoT_PugKiA")]
    [Description(@"Ex post (actual).")]
    ExPost,
}
