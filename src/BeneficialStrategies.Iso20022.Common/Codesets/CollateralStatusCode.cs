// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_itEK0MUZEeiF-qqyf1JQhg")]
[Description(
    @"Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message."
)]
[Derivations(typeof(CollateralStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralStatusCode>))]
#endif
public enum CollateralStatusCode
{
    /// <summary>
    /// Shortage of collateral.
    /// Encoded/decoded by serializers as &quot;DEFI&quot;.
    /// </summary>
    [EnumMember(Value = "DEFI")]
    [IsoId("_HnIp4MUaEeiF-qqyf1JQhg")]
    [Description(@"Shortage of collateral.")]
    CollateralShortage,

    /// <summary>
    /// Excess of collateral.
    /// Encoded/decoded by serializers as &quot;EXCS&quot;.
    /// </summary>
    [EnumMember(Value = "EXCS")]
    [IsoId("_KxXKMMUaEeiF-qqyf1JQhg")]
    [Description(@"Excess of collateral.")]
    CollateralExcess,

    /// <summary>
    /// Collateral covers the exposure and there is no excess.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_UvIa4MUaEeiF-qqyf1JQhg")]
    [Description(@"Collateral covers the exposure and there is no excess.")]
    NoExcessCollateral,
}
