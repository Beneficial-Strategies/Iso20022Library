// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the transaction is collateralised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9l5ZMC48EeK7-OZOLIksSw")]
[Description(@"Specifies whether the transaction is collateralised.")]
[Derivations(typeof(CollateralisationIndicator1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralisationIndicatorCode>))]
#endif
public enum CollateralisationIndicatorCode
{
    /// <summary>
    /// Transaction is fully collateralised.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_Ze1M8C5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is fully collateralised.")]
    FullyCollateralised,

    /// <summary>
    /// Transaction is one-way collateralised.
    /// Encoded/decoded by serializers as &quot;ONEW&quot;.
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_hq8SwC5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is one-way collateralised.")]
    OneWayCollateralised,

    /// <summary>
    /// Transaction is partially collateralised.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_k7rDsC5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is partially collateralised.")]
    PartiallyCollateralised,

    /// <summary>
    /// Transaction is uncollateralised.
    /// Encoded/decoded by serializers as &quot;UNCO&quot;.
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_oNARkC5TEeK7-OZOLIksSw")]
    [Description(@"Transaction is uncollateralised.")]
    Uncollateralised,
}
