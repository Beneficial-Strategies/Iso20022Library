// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the SSI update effective date is to be applied.
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e41SoDcfEeOA3chqL9a4Rw")]
[Description(
    @"Specifies how the SSI update effective date is to be applied.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalEffectiveDateParameter1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalEffectiveDateParameterCode>))]
#endif
public enum ExternalEffectiveDateParameterCode
{
    /// <summary>
    /// Relates to the settlement date.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_uU8YQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Relates to the settlement date.")]
    SettlementDate,

    /// <summary>
    /// Relates to the trade date.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_uU8YRvRYEeuLhpyIdtJzwg")]
    [Description(@"Relates to the trade date.")]
    TradeDate,
}
