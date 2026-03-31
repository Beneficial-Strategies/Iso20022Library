// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the investor was referred.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZaoseNp-Ed-ak6NoX_4Aeg_-1818846482")]
[Description(@"Indicates if the investor was referred.")]
[Derivations(typeof(Referred1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReferredCode>))]
#endif
public enum ReferredCode
{
    /// <summary>
    /// The investor was referred to the fund by a placement agent.
    /// Encoded/decoded by serializers as &quot;REFR&quot;.
    /// </summary>
    [EnumMember(Value = "REFR")]
    [IsoId("_ZaydcNp-Ed-ak6NoX_4Aeg_-1409726701")]
    [Description(@"The investor was referred to the fund by a placement agent.")]
    Referred,

    /// <summary>
    /// The investor was not referred to the fund by a placement agent.
    /// Encoded/decoded by serializers as &quot;NRFR&quot;.
    /// </summary>
    [EnumMember(Value = "NRFR")]
    [IsoId("_Zaydcdp-Ed-ak6NoX_4Aeg_-1401417523")]
    [Description(@"The investor was not referred to the fund by a placement agent.")]
    NotReferred,

    /// <summary>
    /// It is not known whether the investor was referred to the fund by a placement agent.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_Zaydctp-Ed-ak6NoX_4Aeg_-1400492958")]
    [Description(
        @"It is not known whether the investor was referred to the fund by a placement agent."
    )]
    NotKnown,
}
