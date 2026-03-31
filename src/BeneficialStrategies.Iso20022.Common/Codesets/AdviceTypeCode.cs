// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of advice to provide back in the report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AuwW8NomEembTrt_WixjyQ")]
[Description(@"Specifies the type of advice to provide back in the report.")]
[Derivations(typeof(AdviceType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdviceTypeCode>))]
#endif
public enum AdviceTypeCode
{
    /// <summary>
    /// Advice with transaction details is requested.
    /// Encoded/decoded by serializers as &quot;ADWD&quot;.
    /// </summary>
    [EnumMember(Value = "ADWD")]
    [IsoId("_FeuGANomEembTrt_WixjyQ")]
    [Description(@"Advice with transaction details is requested.")]
    AdviceWithDetails,

    /// <summary>
    /// Advice without  transaction details is requested.
    /// Encoded/decoded by serializers as &quot;ADND&quot;.
    /// </summary>
    [EnumMember(Value = "ADND")]
    [IsoId("_F4QAUNomEembTrt_WixjyQ")]
    [Description(@"Advice without  transaction details is requested.")]
    AdviceWithoutDetails,
}
