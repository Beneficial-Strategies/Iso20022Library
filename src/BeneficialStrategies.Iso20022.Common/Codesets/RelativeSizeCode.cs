// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A type of quantity of financial instrument expressed in a relative size.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZsOLstp-Ed-ak6NoX_4Aeg_336258693")]
[Description(@"A type of quantity of financial instrument expressed in a relative size.")]
[Derivations(typeof(RelativeSize1Code))]
public enum RelativeSizeCode
{
    /// <summary>
    /// Indicates that the relative size is small.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_ZsOLs9p-Ed-ak6NoX_4Aeg_336258694")]
    [Description(@"Indicates that the relative size is small.")]
    Small,

    /// <summary>
    /// Indicates that the relative size is medium.
    /// Encoded/decoded by serializers as &quot;MEDI&quot;.
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_ZsOLtNp-Ed-ak6NoX_4Aeg_336258695")]
    [Description(@"Indicates that the relative size is medium.")]
    Medium,

    /// <summary>
    /// Indicates that the relative size is large.
    /// Encoded/decoded by serializers as &quot;LARG&quot;.
    /// </summary>
    [EnumMember(Value = "LARG")]
    [IsoId("_ZsOLtdp-Ed-ak6NoX_4Aeg_336258696")]
    [Description(@"Indicates that the relative size is large.")]
    Large,

    /// <summary>
    /// Indicates that the quantity is undisclosed.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_ZsOLttp-Ed-ak6NoX_4Aeg_1323051777")]
    [Description(@"Indicates that the quantity is undisclosed.")]
    Undisclosed,
}
