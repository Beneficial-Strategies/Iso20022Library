// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the redemption is partly or fully.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bo8XEdp-Ed-ak6NoX_4Aeg_-793137810")]
[Description(@"Specifies if the redemption is partly or fully.")]
public enum AmountFullfilTypeCode
{
    /// <summary>
    /// Full redemption.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bo8XEtp-Ed-ak6NoX_4Aeg_-525318706")]
    [Description(@"Full redemption.")]
    Completely,

    /// <summary>
    /// Partial redemption.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_bo8XE9p-Ed-ak6NoX_4Aeg_-525315741")]
    [Description(@"Partial redemption.")]
    Partial,

    /// <summary>
    /// Full or partial redemption.
    /// Encoded/decoded by serializers as &quot;TOPA&quot;.
    /// </summary>
    [EnumMember(Value = "TOPA")]
    [IsoId("_bo8XFNp-Ed-ak6NoX_4Aeg_-524392767")]
    [Description(@"Full or partial redemption.")]
    TotalOrPartial,
}
