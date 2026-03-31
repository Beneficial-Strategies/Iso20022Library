// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUJuZ9p-Ed-ak6NoX_4Aeg_1950929666")]
[Description(@"Specifies the type of margin.")]
[Derivations(typeof(RemarketingMarginType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RemarketingMarginTypeCode>))]
#endif
public enum RemarketingMarginTypeCode
{
    /// <summary>
    /// Agreed margin.
    /// Encoded/decoded by serializers as &quot;AGRE&quot;.
    /// </summary>
    [EnumMember(Value = "AGRE")]
    [IsoId("_aUJuaNp-Ed-ak6NoX_4Aeg_2083917829")]
    [Description(@"Agreed margin.")]
    Agreed,

    /// <summary>
    /// Alternative margin.
    /// Encoded/decoded by serializers as &quot;ALTE&quot;.
    /// </summary>
    [EnumMember(Value = "ALTE")]
    [IsoId("_aUTfYNp-Ed-ak6NoX_4Aeg_2083917830")]
    [Description(@"Alternative margin.")]
    Alternative,
}
