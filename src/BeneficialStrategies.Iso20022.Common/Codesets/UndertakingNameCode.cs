// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the named type of the undertaking.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIyKoHyjEeGWJuGCfvwOsQ")]
[Description(@"Specifies the named type of the undertaking.")]
[Derivations(typeof(UndertakingName1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UndertakingNameCode>))]
#endif
public enum UndertakingNameCode
{
    /// <summary>
    /// Undertaking is a demand guarantee.
    /// Encoded/decoded by serializers as &quot;DGAR&quot;.
    /// </summary>
    [EnumMember(Value = "DGAR")]
    [IsoId("_nL0jIHyjEeGWJuGCfvwOsQ")]
    [Description(@"Undertaking is a demand guarantee.")]
    DemandGuarantee,

    /// <summary>
    /// Undertaking is a standby letter of credit.
    /// Encoded/decoded by serializers as &quot;STBY&quot;.
    /// </summary>
    [EnumMember(Value = "STBY")]
    [IsoId("_tZls8HyjEeGWJuGCfvwOsQ")]
    [Description(@"Undertaking is a standby letter of credit.")]
    StandbyLetterOfCredit,
}
