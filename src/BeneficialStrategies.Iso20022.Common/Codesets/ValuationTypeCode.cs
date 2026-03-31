// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type used for the calculation of the valuation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YQhLUPP4EeS_qLctCs2aRQ")]
[Description(@"Specifies the type used for the calculation of the valuation.")]
[Derivations(typeof(ValuationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValuationTypeCode>))]
#endif
public enum ValuationTypeCode
{
    /// <summary>
    /// Mark to market valuation.
    /// Encoded/decoded by serializers as &quot;MTMA&quot;.
    /// </summary>
    [EnumMember(Value = "MTMA")]
    [IsoId("_dEVfoPP4EeS_qLctCs2aRQ")]
    [Description(@"Mark to market valuation.||")]
    MarkToMarket,

    /// <summary>
    /// Mark to model valuation.
    /// Encoded/decoded by serializers as &quot;MTMO&quot;.
    /// </summary>
    [EnumMember(Value = "MTMO")]
    [IsoId("_dKIloPP4EeS_qLctCs2aRQ")]
    [Description(@"Mark to model valuation.|")]
    MarkToModel,

    /// <summary>
    /// Central counterparty (CCP) valuation.
    /// Encoded/decoded by serializers as &quot;CCPV&quot;.
    /// </summary>
    [EnumMember(Value = "CCPV")]
    [IsoId("_db2AsPP4EeS_qLctCs2aRQ")]
    [Description(@"Central counterparty (CCP) valuation.")]
    CCPValuation,

    /// <summary>
    /// Amortised cost valuation.
    /// Encoded/decoded by serializers as &quot;AMCS&quot;.
    /// </summary>
    [EnumMember(Value = "AMCS")]
    [IsoId("_BQ7LEOZeEeiwYuOX3XC2zQ")]
    [Description(@"Amortised cost valuation.")]
    AmortisedCost,
}
