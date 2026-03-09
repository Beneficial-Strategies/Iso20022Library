// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Determines how the variation margin requirement will be calculated, either net or gross.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YczLMNp-Ed-ak6NoX_4Aeg_945714582")]
[Description(@"Determines how the variation margin requirement will be calculated, either net or gross.")]
[DerivedFrom(typeof(ExposureConventionTypeCode))]
public enum ExposureConventionType1Code
{
    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_YczLMdp-Ed-ak6NoX_4Aeg_-886123604")]
    [Description(@"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined.")]
    Gross = ExposureConventionTypeCode.Gross, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation.
    /// Encoded/decoded by serializers as &quot;NET1&quot;.
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("_YczLMtp-Ed-ak6NoX_4Aeg_528113018")]
    [Description(@"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation.")]
    Net = ExposureConventionTypeCode.Net, // same ordinal as derivation source for type conversions
    
}
