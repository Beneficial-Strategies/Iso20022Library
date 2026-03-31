// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the issued undertaking name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-IZCEXltEeG7BsjMvd1mEw_1477926493")]
[Description(@"Specifies the issued undertaking name.")]
[Derivations(typeof(UndertakingIssuanceName1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UndertakingIssuanceNameCode>))]
#endif
public enum UndertakingIssuanceNameCode
{
    /// <summary>
    /// Demand guarantee.
    /// Encoded/decoded by serializers as &quot;DGAR&quot;.
    /// </summary>
    [EnumMember(Value = "DGAR")]
    [IsoId("_-IZCEnltEeG7BsjMvd1mEw_443560113")]
    [Description(@"Demand guarantee.")]
    Guarantee,

    /// <summary>
    /// Standby letter of credit.
    /// Encoded/decoded by serializers as &quot;STBY&quot;.
    /// </summary>
    [EnumMember(Value = "STBY")]
    [IsoId("_-IZCE3ltEeG7BsjMvd1mEw_621678785")]
    [Description(@"Standby letter of credit.")]
    Standby,
}
