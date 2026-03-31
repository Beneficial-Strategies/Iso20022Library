// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the oversubscription type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pktlTL3EeKU9IrkkToqcw_-2000683477")]
[Description(@"Specifies the oversubscription type.")]
[Derivations(typeof(OversubscriptionType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OversubscriptionTypeCode>))]
#endif
public enum OversubscriptionTypeCode
{
    /// <summary>
    /// Unlimited oversubscription.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_1puekDL3EeKU9IrkkToqcw_2035989338")]
    [Description(@"Unlimited oversubscription.")]
    Unlimited,

    /// <summary>
    /// The subscription is limited by quantity or percentage.
    /// Encoded/decoded by serializers as &quot;LTDB&quot;.
    /// </summary>
    [EnumMember(Value = "LTDB")]
    [IsoId("_1puekTL3EeKU9IrkkToqcw_684397253")]
    [Description(@"The subscription is limited by quantity or percentage.")]
    LimitedByQuantityOrPercentage,

    /// <summary>
    /// No oversubscription is allowed.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_1puekjL3EeKU9IrkkToqcw_613549737")]
    [Description(@"No oversubscription is allowed.")]
    NoOversubscription,
}
