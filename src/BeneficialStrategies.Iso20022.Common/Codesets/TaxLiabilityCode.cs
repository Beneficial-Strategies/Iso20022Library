// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tax role capacity of the instructing party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YiBCZNp-Ed-ak6NoX_4Aeg_14926888")]
[Description(@"Specifies the tax role capacity of the instructing party.")]
[Derivations(typeof(TaxLiability1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxLiabilityCode>))]
#endif
public enum TaxLiabilityCode
{
    /// <summary>
    /// Settlement party is acting as a principal for tax liability.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_YiBCZdp-Ed-ak6NoX_4Aeg_-98912178")]
    [Description(@"Settlement party is acting as a principal for tax liability.")]
    TaxPrincipal,

    /// <summary>
    /// Settlement party is acting as an agent for tax liability.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_YiBCZtp-Ed-ak6NoX_4Aeg_-1274103203")]
    [Description(@"Settlement party is acting as an agent for tax liability.")]
    TaxAgent,
}
