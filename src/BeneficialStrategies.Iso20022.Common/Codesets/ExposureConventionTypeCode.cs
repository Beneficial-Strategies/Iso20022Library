// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Determines how the variation margin requirement will be calculated, either net or gross.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YczLM9p-Ed-ak6NoX_4Aeg_-483728852")]
[Description(
    @"Determines how the variation margin requirement will be calculated, either net or gross."
)]
[Derivations(typeof(ExposureConventionType1Code))]
public enum ExposureConventionTypeCode
{
    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_YczLNNp-Ed-ak6NoX_4Aeg_1466690893")]
    [Description(
        @"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined."
    )]
    Gross,

    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation.
    /// Encoded/decoded by serializers as &quot;NET1&quot;.
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("_YczLNdp-Ed-ak6NoX_4Aeg_1963652229")]
    [Description(
        @"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation."
    )]
    Net,
}
